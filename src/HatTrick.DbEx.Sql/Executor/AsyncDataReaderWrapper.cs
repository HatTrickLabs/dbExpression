﻿using HatTrick.DbEx.Sql.Connection;
using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace HatTrick.DbEx.Sql.Executor
{
    public class AsyncDataReaderWrapper : IAsyncSqlRowReader
    {
        #region internals
        private bool disposed;
        private int currentRowIndex;
        protected ISqlConnection SqlConnection { get; private set; }
        protected DbDataReader DataReader { get; private set; }
        protected CancellationToken CancellationToken { get; private set; }
        protected IValueConverterFinder Converters { get; private set; }
        #endregion

        #region constructors
        public AsyncDataReaderWrapper(ISqlConnection sqlConnection, DbDataReader dataReader, IValueConverterFinder converters) : this(sqlConnection, dataReader, converters, CancellationToken.None) { }

        public AsyncDataReaderWrapper(ISqlConnection sqlConnection, DbDataReader dataReader, IValueConverterFinder converters, CancellationToken ct)
        {
            SqlConnection = sqlConnection;
            DataReader = dataReader;
            CancellationToken = ct == null ? CancellationToken.None : ct;
            Converters = converters;
            CancellationToken.Register(() => Dispose(true));
        }
        #endregion

        #region methods
        public async Task<ISqlRow> ReadRowAsync()
        {
            CancellationToken.ThrowIfCancellationRequested();

            try
            {

                if (await DataReader.ReadAsync())
                {
                    var row = new ISqlField[DataReader.FieldCount];
                    var values = new object[DataReader.FieldCount];
                    DataReader.GetValues(values);
                    for (int i = 0; i < values.Length; i++)
                    {
                        row[i] = new Field(i, DataReader.GetName(i), DataReader.GetFieldType(i), values[i] == DBNull.Value ? null : values[i], Converters);
                    }
                    return new Row(currentRowIndex++, row);
                }
                //asking for a row and the reader has finished, proactively shut everything down.
                DataReader.Close();
                if (!SqlConnection.IsTransactional)
                    SqlConnection.Disconnect();
            }
            catch
            {
                if (DataReader is object && !DataReader.IsClosed)
                    DataReader.Close(); //redundant, but required for sqlCe before rollback...

                if (SqlConnection.IsTransactional)
                {
                    SqlConnection.RollbackTransaction();
                }
                else
                {
                    SqlConnection.Disconnect();
                }
                throw;
            }

            return null;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (DataReader is object)
                    {
                        if (!DataReader.IsClosed)
                            DataReader.Close();
                        DataReader.Dispose();
                    }
                    if (SqlConnection is object)
                    {
                        if (!SqlConnection.IsTransactional)
                            SqlConnection.Disconnect();
                    }
                }
                DataReader = null;
                SqlConnection = null;
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
