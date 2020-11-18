using System;
using System.Collections.Generic;

namespace HatTrick.DbEx.Sql.Expression
{
    public partial class StringConcatFunctionExpression :
        ConcatFunctionExpression<string>,
        StringElement,
        AnyStringElement,
        IEquatable<StringConcatFunctionExpression>
    {
        #region constructors
        public StringConcatFunctionExpression(IList<AnyStringElement> expressions) : base(expressions)
        {

        }

        protected StringConcatFunctionExpression(IList<AnyStringElement> expressions, string alias) : base(expressions, alias)
        {

        }
        #endregion

        #region as
        public StringElement As(string alias)
            => new StringConcatFunctionExpression(base.Expression, alias);
        #endregion

        #region equals
        public bool Equals(StringConcatFunctionExpression obj)
            => obj is StringConcatFunctionExpression && base.Equals(obj);

        public override bool Equals(object obj)
            => obj is StringConcatFunctionExpression exp && base.Equals(exp);

        public override int GetHashCode()
            => base.GetHashCode();
        #endregion
    }
}
