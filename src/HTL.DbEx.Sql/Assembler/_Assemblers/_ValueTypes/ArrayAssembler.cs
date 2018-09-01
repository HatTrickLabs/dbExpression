﻿using System;
using System.Collections.Generic;

namespace HTL.DbEx.Sql.Assembler
{
    public class ArrayAssembler : ISqlPartAssembler<Array>
    {
        public string Assemble(object expressionPart, ISqlStatementBuilder builder, AssemblerOverrides overrides)
            => Assemble(expressionPart as Array, builder, overrides);

        public string Assemble(Array expressionPart, ISqlStatementBuilder builder, AssemblerOverrides overrides)
        {
            if (!(expressionPart is Array arry) || arry.Length == 0)
                return string.Empty;

            var parameterNames = new List<string>();
            foreach (var item in arry)
            {
                string s = item as string;
                parameterNames.Add(builder.Parameters.Add(item, item.GetType(), s?.Length).ParameterName);
            }
            return $"{string.Join(", ", parameterNames)}";
        }
    }
}