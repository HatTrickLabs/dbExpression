﻿using DbEx.DataService;
using FluentAssertions;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Assembler;
using HatTrick.DbEx.Sql.Connection;
using HatTrick.DbEx.Sql.Executor;
using HatTrick.DbEx.Sql.Expression;
using HatTrick.DbEx.Sql.Pipeline;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Unit.Configuration
{
    public class QueryExecutionPipelineConfigurationTests : TestBase
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void A_query_expression_factory_registered_via_service_provider_should_resolve_the_correct_statement_builder(int version)
        {
            //given
            var factory = Substitute.For<IQueryExecutionPipelineFactory<MsSqlDb>>();
            var provider = ConfigureForMsSqlVersion(version, configure: c => c.SqlStatements.QueryExecution.Pipeline.Use(sp => factory));

            //when
            var resolved = provider.GetService<IQueryExecutionPipelineFactory<MsSqlDb>>();

            //then
            resolved.Should().Be(factory);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void A_query_expression_factory_registered_via_generic_should_resolve_the_correct_statement_builder(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, configure: c => c.SqlStatements.QueryExecution.Pipeline.Use<NoOpQueryExecutionPipelineFactory>());

            //when
            var resolved = provider.GetService<IQueryExecutionPipelineFactory<MsSqlDb>>();

            //then
            resolved.Should().NotBeNull().And.BeOfType<NoOpQueryExecutionPipelineFactory>();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void A_query_expression_factory_registered_via_delegate_should_resolve_the_correct_statement_builder(int version)
        {
            //given
            var builder = Substitute.For<IQueryExecutionPipelineFactory<MsSqlDb>>();
            var provider = ConfigureForMsSqlVersion(version, configure: c => c.SqlStatements.QueryExecution.Pipeline.Use(() => builder));

            //when
            var resolved = provider.GetService<IQueryExecutionPipelineFactory<MsSqlDb>>();

            //then
            resolved.Should().Be(builder);
        }


        [Theory]
        [MsSqlVersions.AllVersions]
        public void Query_execution_pipeline_resolved_from_service_provider_should_be_transient(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version);

            //when
            var a1 = provider.GetService<ISelectQueryExecutionPipeline<MsSqlDb>>();
            var a2 = provider.GetService<ISelectQueryExecutionPipeline<MsSqlDb>>();

            //then
            a1.Should().NotBe(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Default_registration_of_query_execution_pipeline_should_resolve_singletons(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version);

            //when
            var a1 = provider.GetRequiredService<IQueryExecutionPipelineFactory<MsSqlDb>>();
            var a2 = provider.GetRequiredService<IQueryExecutionPipelineFactory<MsSqlDb>>();

            //then
            a1.Should().Be(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registration_of_query_execution_pipeline_via_delegate_should_resolve_singletons(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.QueryExecution.Pipeline.Use<NoOpQueryExecutionPipelineFactory>());

            //when
            var a1 = provider.GetRequiredService<IQueryExecutionPipelineFactory<MsSqlDb>>();
            var a2 = provider.GetRequiredService<IQueryExecutionPipelineFactory<MsSqlDb>>();

            //then
            a1.Should().Be(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registration_of_query_execution_pipeline_via_service_provider_should_resolve_singletons(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.QueryExecution.Pipeline.Use(sp => Substitute.For<IQueryExecutionPipelineFactory<MsSqlDb>>()));

            //when
            var a1 = provider.GetRequiredService<IQueryExecutionPipelineFactory<MsSqlDb>>();
            var a2 = provider.GetRequiredService<IQueryExecutionPipelineFactory<MsSqlDb>>();

            //then
            a1.Should().Be(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registration_of_query_execution_pipeline_via_service_provider_and_override_via_service_provider_should_resolve_singletons_and_same_instance(int version)
        {
            //given
            IServiceProvider? provider = null;
            var factory = new DelegateQueryExecutionPipelineFactory<MsSqlDb>(t => provider!.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>());
            provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.QueryExecution.Pipeline.Use(sp => factory, c => c.ForSelect().Use(sp => Substitute.For<ISelectQueryExecutionPipeline<MsSqlDb>>())));

            //when
            var a1 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();
            var a2 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();

            //then
            a1.Should().NotBe(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registration_of_query_execution_pipeline_via_service_provider_and_override_via_delegate_should_resolve_singletons_and_same_instance(int version)
        {
            //given
            IServiceProvider? provider = null;
            var factory = new DelegateQueryExecutionPipelineFactory<MsSqlDb>(t => provider!.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>());
            provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.QueryExecution.Pipeline.Use(sp => factory, c => c.ForSelect().Use(() => Substitute.For<ISelectQueryExecutionPipeline<MsSqlDb>>())));

            //when
            var a1 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();
            var a2 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();

            //then
            a1.Should().NotBe(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registration_of_query_execution_pipeline_via_service_provider_and_override_via_generic_should_resolve_singletons_and_same_instance(int version)
        {
            //given
            IServiceProvider? provider = null;
            var factory = new DelegateQueryExecutionPipelineFactory<MsSqlDb>(t => provider!.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>());
            provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.QueryExecution.Pipeline.Use(sp => factory, c => c.ForSelect().Use<SelectQueryExpressionExecutionPipeline<MsSqlDb>>()));

            //when
            var a1 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();
            var a2 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();

            //then
            a1.Should().NotBe(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registration_of_query_execution_pipeline_via_delegate_and_override_via_service_provider_should_resolve_singletons_and_same_instance(int version)
        {
            //given
            IServiceProvider? provider = null;
            var factory = new DelegateQueryExecutionPipelineFactory<MsSqlDb>(t => provider!.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>());
            provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.QueryExecution.Pipeline.Use(() => factory, c => c.ForSelect().Use(sp => Substitute.For<ISelectQueryExecutionPipeline<MsSqlDb>>())));

            //when
            var a1 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();
            var a2 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();

            //then
            a1.Should().NotBe(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registration_of_query_execution_pipeline_via_delegate_and_override_via_delegate_should_resolve_singletons_and_same_instance(int version)
        {
            //given
            IServiceProvider? provider = null;
            var factory = new DelegateQueryExecutionPipelineFactory<MsSqlDb>(t => provider!.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>());
            provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.QueryExecution.Pipeline.Use(() => factory, c => c.ForSelect().Use(() => Substitute.For<ISelectQueryExecutionPipeline<MsSqlDb>>())));

            //when
            var a1 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();
            var a2 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();

            //then
            a1.Should().NotBe(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registration_of_query_execution_pipeline_via_delegate_and_override_via_generic_should_resolve_singletons_and_same_instance(int version)
        {
            //given
            IServiceProvider? provider = null;
            var factory = new DelegateQueryExecutionPipelineFactory<MsSqlDb>(t => provider!.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>());
            provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.QueryExecution.Pipeline.Use(() => factory, c => c.ForSelect().Use<SelectQueryExpressionExecutionPipeline<MsSqlDb>>()));

            //when
            var a1 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();
            var a2 = provider.GetRequiredService<ISelectQueryExecutionPipeline<MsSqlDb>>();

            //then
            a1.Should().NotBe(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registering_statement_builders_via_a_delegate_should_resolve_singletons(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.QueryExecution.Pipeline.Use(() => Substitute.For<IQueryExecutionPipelineFactory<MsSqlDb>>()));

            //when
            var a1 = provider.GetRequiredService<IQueryExecutionPipelineFactory<MsSqlDb>>();
            var a2 = provider.GetRequiredService<IQueryExecutionPipelineFactory<MsSqlDb>>();

            //then
            a1.Should().Be(a2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Registering_statement_builders_via_instance_should_resolve_singletons(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.QueryExecution.Pipeline.Use(new NoOpQueryExecutionPipelineFactory()));

            //when
            var a1 = provider.GetRequiredService<IQueryExecutionPipelineFactory<MsSqlDb>>();
            var a2 = provider.GetRequiredService<IQueryExecutionPipelineFactory<MsSqlDb>>();

            //then
            a1.Should().Be(a2);
        }

        private class NoOpQueryExecutionPipelineFactory : IQueryExecutionPipelineFactory<MsSqlDb>
        {
            public IDeleteQueryExecutionPipeline<MsSqlDb> CreateDeleteQueryExecutionPipeline()
            {
                throw new NotImplementedException();
            }

            public IInsertQueryExecutionPipeline<MsSqlDb> CreateInsertQueryExecutionPipeline()
            {
                throw new NotImplementedException();
            }

            public ISelectQueryExecutionPipeline<MsSqlDb> CreateSelectQueryExecutionPipeline()
            {
                throw new NotImplementedException();
            }

            public ISelectSetQueryExecutionPipeline<MsSqlDb> CreateSelectSetQueryExecutionPipeline()
            {
                throw new NotImplementedException();
            }

            public IStoredProcedureExecutionPipeline<MsSqlDb> CreateStoredProcedureExecutionPipeline()
            {
                throw new NotImplementedException();
            }

            public IUpdateQueryExecutionPipeline<MsSqlDb> CreateUpdateQueryExecutionPipeline()
            {
                throw new NotImplementedException();
            }
        }
    }
}