﻿using System;

namespace HatTrick.DbEx.Sql.Converter
{
    public class StringEnumValueConverter : IValueConverter
    {
        private static Type type = typeof(string);
        public object ConvertFromDatabase(object value)
            => value is null ? default : Enum.Parse(type, value as string, true);

        public T ConvertFromDatabase<T>(object value)
            => value is null ? default : (T)Enum.Parse(typeof(T), value as string);

        public object ConvertToDatabase(object value)
            => value is null ? null : value.ToString();
    }
}