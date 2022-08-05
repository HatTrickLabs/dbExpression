﻿using DbEx.DataService;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Connection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Unit.Configuration
{
    public class ConnectionStringConfigurationTests : TestBase
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_setting_connection_string_to_null_throw_correct_exception_when_resolved(int version)
        {
            //given, when & then
            var ex = Assert.Throws<DbExpressionConfigurationException>(() => ConfigureForMsSqlVersion(version, c => c.ConnectionString.Use((string?)null!)));
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_configuration_using_null_delegate_throw_expected_exception(int version)
        {
            //given & when & then
            Assert.Throws<DbExpressionConfigurationException>(() => ConfigureForMsSqlVersion(version, builder => builder.ConnectionString.Use((Func<string>)null!)));
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_configuration_using_delegate_returning_null_throw_expected_exception(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, builder => builder.ConnectionString.Use<NoOpConnectionStringFactory>());

            //when & then
            Assert.Throws<NotImplementedException>(() => provider.GetRequiredService<IConnectionStringFactory<MsSqlDb>>().GetConnectionString());
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_configuration_of_a_connection_string_factory_using_generic_rsolve_correctly(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, builder => builder.ConnectionString.Use<NoOpConnectionStringFactory>());

            //when
            var resolved = provider.GetRequiredService<IConnectionStringFactory<MsSqlDb>>();

            //then
            resolved.Should().BeOfType<NoOpConnectionStringFactory>();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_configuration_of_a_connection_string_factory_using_instance_resolve_correctly(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, builder => builder.ConnectionString.Use("abc"));

            //when
            var resolved = provider.GetRequiredService<IConnectionStringFactory<MsSqlDb>>().GetConnectionString();

            //then
            resolved.Should().Be("abc");
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_configuration_of_a_connection_string_factory_using_instance_resolve_transients(int version)
        {
            //given
            var values = Enumerable.Range(0, 5);
            var factory = new ConnectionStringFactory(values.ToList());
            var provider = ConfigureForMsSqlVersion(version, builder => builder.ConnectionString.Use(sp => factory));
            var resolvedFactory = provider.GetRequiredService<IConnectionStringFactory<MsSqlDb>>();

            //when
            var resolved = new List<string>();
            for (var i = 0; i < values.Count(); i++)
                resolved.Add(resolvedFactory.GetConnectionString());

            //then
            resolved.Should().OnlyHaveUniqueItems().And.BeInAscendingOrder();
        }

        public class NoOpConnectionStringFactory : IConnectionStringFactory<MsSqlDb>
        {
            public string GetConnectionString()
            {
                throw new NotImplementedException();
            }
        }

        public class ConnectionStringFactory : IConnectionStringFactory<MsSqlDb>
        {
            private List<int> values;
            private int currentIndex = -1;

            public ConnectionStringFactory(List<int> values)
            {
                this.values = values;
            }

            public string GetConnectionString()
            {
                currentIndex++;
                return values[currentIndex].ToString();
            }
        }
    }
}