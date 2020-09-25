﻿using System;

namespace HatTrick.DbEx.Sql.Converter
{
    public class EnumValueConverter : IValueConverter
    {
        public virtual object ConvertFromDatabase(Type type, object value)
            => Enum.ToObject(type, value);

        public virtual T ConvertFromDatabase<T>(object value)
            => (T)Enum.ToObject(typeof(T), value);

        public virtual object ConvertToDatabase(Type type, object value)
            => Convert.ToInt32(value);
    }
}
