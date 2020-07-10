﻿namespace HatTrick.DbEx.Sql.Assembler
{
    public class NullableValueTypePartAppender<T> : IAssemblyPartAppender<T>
    {
        public virtual void AppendPart(object value, ISqlStatementBuilder builder, AssemblyContext context)
            => AppendPart((T)value, builder, context);

        public virtual void AppendPart(T value, ISqlStatementBuilder builder, AssemblyContext context)
        {
            if (context?.Field != null)
                builder.Appender.Write(builder.Parameters.Add(value, context.Field).Parameter.ParameterName);
            else
                builder.Appender.Write(builder.Parameters.Add<T>(value).ParameterName);
        }
    }
}