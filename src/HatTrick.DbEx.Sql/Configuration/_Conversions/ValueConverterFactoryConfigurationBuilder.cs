﻿using HatTrick.DbEx.Sql.Converter;
using System;

namespace HatTrick.DbEx.Sql.Configuration
{
    public class ValueConverterFactoryConfigurationBuilder : IValueConverterFactoryConfigurationBuilder
    {
        #region internals
        private readonly RuntimeSqlDatabaseConfiguration configuration;
        private readonly ValueConverterFactoryContinuationConfigurationBuilder continuationBuilder;
        #endregion

        #region constructors
        public ValueConverterFactoryConfigurationBuilder(RuntimeSqlDatabaseConfiguration configuration)
        {
            this.configuration = configuration ?? throw new ArgumentNullException($"{nameof(configuration)} is required.");
        }

        #endregion

        #region methods
        public void Use(IValueConverterFactory factory)
            => configuration.ValueConverterFactory = factory ?? throw new ArgumentNullException($"{nameof(factory)} is required.");

        public void Use<TValueConverterFactory>()
            where TValueConverterFactory : class, IValueConverterFactory, new()
            => Use<TValueConverterFactory>(null);

        public void Use<TValueConverterFactory>(Action<TValueConverterFactory> configureFactory)
            where TValueConverterFactory : class, IValueConverterFactory, new()
        {
            if (!(configuration.ValueConverterFactory is TValueConverterFactory))
                configuration.ValueConverterFactory = new TValueConverterFactory();
            configureFactory?.Invoke(configuration.ValueConverterFactory as TValueConverterFactory);
        }

        public void Use(Func<Type, IValueConverter> factory)
        {
            if (factory is null)
                throw new ArgumentNullException($"{nameof(factory)} is required.");
            configuration.ValueConverterFactory = new DelegateValueConverterFactory(factory);
        }

        public void UseDefaultFactory()
            => UseDefaultFactory(null);

        public void UseDefaultFactory(Action<IValueConverterFactoryContinuationConfigurationBuilder> configureFactory)
        {
            if (!(configuration.ValueConverterFactory is ValueConverterFactory))
                configuration.ValueConverterFactory = new ValueConverterFactory();
            configureFactory?.Invoke(continuationBuilder ?? new ValueConverterFactoryContinuationConfigurationBuilder(configuration.ValueConverterFactory as ValueConverterFactory));
        }
        #endregion
    }
}
