﻿using System;
using System.Data;

namespace HatTrick.DbEx.Sql.Executor
{
    public class DataReaderWrapper : ISqlRowReader
    {
        #region internals
        private bool disposed;
        private int currentRowIndex;
        protected SqlConnection SqlConnection { get; private set; }
        protected IDataReader DataReader { get; private set; }
        #endregion

        #region constructors
        public DataReaderWrapper(SqlConnection sqlConnection, IDataReader dataReader)
        {
            SqlConnection = sqlConnection;
            DataReader = dataReader;
        }
        #endregion

        #region methods
        public ISqlRow ReadRow()
        {
            try
            {
                if (DataReader.Read())
                {
                    var row = new ISqlField[DataReader.FieldCount];
                    var values = new object[DataReader.FieldCount];
                    DataReader.GetValues(values);
                    for (int i = 0; i < values.Length; i++)
                    {
                        row[i] = new Field(i, DataReader.GetName(i), values[i] == DBNull.Value ? null : values[i]);
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
                if (DataReader != null && !DataReader.IsClosed)
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
                    if (DataReader != null)
                    {
                        if (!DataReader.IsClosed)
                            DataReader.Close();
                        DataReader.Dispose();
                    }
                    if (SqlConnection != null)
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

        public void Dispose() => Dispose(true);
        #endregion
    }
}