﻿using System;
using System.Configuration;

namespace HTL.DbEx.Sql.Connection
{
    public abstract class SqlConnectionFactory : ISqlConnectionFactory
    {
        public virtual SqlConnection CreateSqlConnection(ConnectionStringSettings connectionStringSettings) => throw new NotImplementedException("Connection factory requires database platform specific implementation");
    }
}