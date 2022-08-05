﻿using DbEx.DataService;
using FluentAssertions;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Assembler;
using HatTrick.DbEx.Sql.Expression;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Unit.Configuration
{
    public class SqlStatementBuilderConfigurationTests : TestBase
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void A_statement_builder_registered_via_service_provider_should_resolve_the_correct_statement_builder(int version)
        {
            //given
            var builder = Substitute.For<ISqlStatementBuilder<MsSqlDb>>();
            var provider = ConfigureForMsSqlVersion(version, configure: c => c.SqlStatements.Assembly.StatementBuilder.Use(sp => builder));

            //when
            var resolved = provider.GetService<ISqlStatementBuilder<MsSqlDb>>();

            //then
            resolved.Should().Be(builder);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void A_statement_builder_registered_via_generic_should_resolve_the_correct_statement_builder(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, configure: c => c.SqlStatements.Assembly.StatementBuilder.Use<NoOpSqlStatementBuilder>());

            //when
            var resolved = provider.GetService<ISqlStatementBuilder<MsSqlDb>>();

            //then
            resolved.Should().NotBeNull().And.BeOfType<NoOpSqlStatementBuilder>();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void A_statement_builder_registered_via_delegate_should_resolve_the_correct_statement_builder(int version)
        {
            //given
            var builder = Substitute.For<ISqlStatementBuilder<MsSqlDb>>();
            var provider = ConfigureForMsSqlVersion(version, configure: c => c.SqlStatements.Assembly.StatementBuilder.Use(() => builder));

            //when
            var resolved = provider.GetService<ISqlStatementBuilder<MsSqlDb>>();

            //then
            resolved.Should().Be(builder);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Statement_builder_resolved_from_service_provider_should_be_transient(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version);

            //when
            var a1 = provider.GetService<ISqlStatementBuilder<MsSqlDb>>();
            var a2 = provider.GetService<ISqlStatementBuilder<MsSqlDb>>();

            //then
            a1.Should().NotBe(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registering_statement_builders_via_service_provider_should_return_the_specified_instances(int version)
        {
            //given
            var index = -1;
            var builders = new List<ISqlStatementBuilder<MsSqlDb>>
            {
                Substitute.For<ISqlStatementBuilder<MsSqlDb>>(),
                Substitute.For<ISqlStatementBuilder<MsSqlDb>>(),
                Substitute.For<ISqlStatementBuilder<MsSqlDb>>(),
                Substitute.For<ISqlStatementBuilder<MsSqlDb>>()
            };
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.StatementBuilder.Use(sp =>
            {
                index++;
                return builders[index];
            }));

            //when
            var resolved = new List<ISqlStatementBuilder<MsSqlDb>>();
            for (var i = 0; i < builders.Count; i++)
                resolved.Add(provider.GetRequiredService<ISqlStatementBuilder<MsSqlDb>>());

            //then
            resolved.Should().Equal(builders);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registering_statement_builders_via_generic_should_return_transients(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.StatementBuilder.Use<NoOpSqlStatementBuilder>());

            //when
            var resolved = new List<ISqlStatementBuilder<MsSqlDb>>();
            for (var i = 0; i < 5; i++)
                resolved.Add(provider.GetRequiredService<ISqlStatementBuilder<MsSqlDb>>());

            //then
            resolved.Should().AllBeOfType<NoOpSqlStatementBuilder>().And.OnlyHaveUniqueItems();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registering_statement_builders_via_a_delegate_should_return_the_specified_instances(int version)
        {
            //given
            var index = -1;
            var builders = new List<ISqlStatementBuilder<MsSqlDb>>
            {
                Substitute.For<ISqlStatementBuilder<MsSqlDb>>(),
                Substitute.For<ISqlStatementBuilder<MsSqlDb>>(),
                Substitute.For<ISqlStatementBuilder<MsSqlDb>>(),
                Substitute.For<ISqlStatementBuilder<MsSqlDb>>()
            };
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.StatementBuilder.Use(() =>
            {
                index++;
                return builders[index];
            }));

            //when
            var resolved = new List<ISqlStatementBuilder<MsSqlDb>>();
            for (var i = 0; i < builders.Count; i++)
                resolved.Add(provider.GetRequiredService<ISqlStatementBuilder<MsSqlDb>>());

            //then
            resolved.Should().Equal(builders);
        }

        private class NoOpSqlStatementBuilder : ISqlStatementBuilder<MsSqlDb>
        {
            public ISqlParameterBuilder Parameters { get; }
            public IAppender Appender { get; }

            public NoOpSqlStatementBuilder()
            {
                Parameters = null!;
                Appender = null!;
            }

            public (Type ConvertedType, object? ConvertedValue) ConvertValue(object? value, Field? field)
            {
                throw new NotImplementedException();
            }

            public SqlStatement CreateSqlStatement<TQuery>(TQuery expression) where TQuery : QueryExpression
            {
                throw new NotImplementedException();
            }

            public ISqlSchemaMetadata? FindMetadata(Schema schema)
            {
                throw new NotImplementedException();
            }

            public ISqlEntityMetadata? FindMetadata(Table entity)
            {
                throw new NotImplementedException();
            }

            public ISqlFieldMetadata? FindMetadata(Field field)
            {
                throw new NotImplementedException();
            }

            public ISqlParameterMetadata? FindMetadata(QueryParameter parameter)
            {
                throw new NotImplementedException();
            }

            public string GenerateAlias()
            {
                throw new NotImplementedException();
            }

            void ISqlStatementBuilder.AppendElement<T>(T element, AssemblyContext context)
            {
                throw new NotImplementedException();
            }
        }
    }
}