﻿using HTL.DbEx.ObjectMap;

namespace HTL.DbEx.Sql.ObjectMap
{
    public class SqlIndexedField : IndexedField
    {
        #region internals
        protected readonly IndexInfo _indexInfo;
        #endregion

        #region constructors
        public SqlIndexedField(IndexInfo indexInfo)
        {
            _indexInfo = indexInfo;
            this.Extract();
        }
        #endregion

        #region methods
        protected virtual void Extract()
        {
            FieldName = _indexInfo.ColumnName;
            IsDescendingKey = _indexInfo.IsDescendingKey;
            IsNonKeyInclude = _indexInfo.IsIncludeColumn;
            Ordinal = _indexInfo.ColumnOrdinal;
        }
        #endregion
    }
}