﻿namespace HTL.DbEx.Sql.Expression
{
    public class DBJoinDirective<T> where T : class, new()
    {
        #region internals
        private readonly SqlExpressionBuilder<T> _dbQuery;
        private readonly DBExpressionEntity<T> _joinEntity;
        private readonly DBExpressionJoinType _joinType;
        #endregion

        #region constructors
        public DBJoinDirective(SqlExpressionBuilder<T> dbQuery, DBExpressionEntity<T> joinEntity, DBExpressionJoinType joinType)
        {
            _dbQuery = dbQuery;
            _joinEntity = joinEntity;
            _joinType = joinType;
        }
        #endregion

        #region methods
        public SqlExpressionBuilder<T> On(DBFilterExpression filter)
        {
            _dbQuery.Expression &= _joinEntity.Join(_joinType, filter);
            return _dbQuery;
        }
        #endregion
    }
}
