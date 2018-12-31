﻿using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Assembler;

namespace HatTrick.DbEx.MsSql.Assembler
{
    public class MsSqlStatementBuilderFactory : SqlStatementBuilderFactory
    {
        #region methods
        public override void RegisterDefaultAssemblers()
        {
            base.RegisterDefaultAssemblers();
            base.RegisterAssembler(SqlStatementExecutionType.GetList, new SelectAllMsSqlAssembler());
            base.RegisterAssembler(SqlStatementExecutionType.GetDynamicList, new SelectAllMsSqlAssembler());
            base.RegisterAssembler(SqlStatementExecutionType.GetValueList, new SelectAllMsSqlAssembler());
        }

        public override void RegisterDefaultValueFormatters()
        {
            base.RegisterDefaultValueFormatters();
            base.RegisterValueFormatter<string,StringValueTypeFormatter>();
        }
        #endregion
    }
}
