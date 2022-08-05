﻿using DbEx.DataService;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Assembler;
using HatTrick.DbEx.Sql.Expression;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using System;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Unit.Configuration
{
    public class ExpressionElementAppenderConfigurationTests : TestBase
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_configuration_for_element_appender_factory_using_instance_method_with_null_instance_throw_expected_exception(int version)
        {
            //given & when & then
            Assert.Throws<DbExpressionConfigurationException>(() => ConfigureForMsSqlVersion(version, builder => builder.SqlStatements.Assembly.ElementAppender.Use((IExpressionElementAppenderFactory<MsSqlDb>)null!)));
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void An_element_appender_factory_registered_as_instance_should_be_the_registered_appender_factory(int version)
        {
            //given
            var appenderFactory = Substitute.For<IExpressionElementAppenderFactory<MsSqlDb>>();
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.Use(appenderFactory));

            //when
            var factory = provider.GetService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //then
            factory.Should().Be(appenderFactory);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_configuration_of_a_default_element_appender_factory_resolve_to_the_correct_type(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version);

            //when
            var resolved = provider.GetService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //then
            resolved.Should().BeOfType<DefaultExpressionElementAppenderFactoryWithDiscovery<MsSqlDb>>();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void An_element_appender_factory_registered_via_generic_should_be_the_correct_type(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.Use<NoOpExpressionElementAppenderFactory>());

            //when
            var factory = provider.GetService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //then
            factory.Should().BeOfType<NoOpExpressionElementAppenderFactory>();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void An_element_appender_factory_registered_via_delegate_should_be_the_default_appender_factory(int version)
        {
            //given
            var factory = Substitute.For<IExpressionElementAppenderFactory<MsSqlDb>>();
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.Use(t => factory));

            //when
            var resolved = provider.GetService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //then
            resolved.Should().Be(factory);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void An_element_appender_factory_registered_via_delegate_with_element_appender_override_registered_generically_should_resolve_correctly(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.Use(sp => new DelegateExpressionElementAppenderFactory<MsSqlDb>(t => sp.GetRequiredService<FieldExpressionAppender>()), c => c.ForElementType<FieldExpression>().Use<FieldExpressionAppender>()));

            //when
            var resolved = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();
            var appender = resolved.CreateElementAppender<FieldExpression>();

            //then
            appender.Should().BeOfType<FieldExpressionAppender>().Which.Should().NotBeNull();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void The_default_factory_registration_should_discover_the_correct_appender_for_an_unregistered_appender(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version);
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var appender = factory.CreateElementAppender(dbo.Person.Id.GetType());

            //then
            appender.Should().BeOfType<FieldExpressionAppender>();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void The_default_factory_registration_with_custom_appender_registered_with_instance_should_resolve_correctly(int version)
        {
            //given
            var appender = Substitute.For<IExpressionElementAppender<SchemaExpression>>();
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.ForElementTypes(b => b.ForElementType<SchemaExpression>().Use(appender)));
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var resolved = factory.CreateElementAppender(typeof(SchemaExpression));

            //then
            factory.Should().BeOfType<DefaultExpressionElementAppenderFactoryWithDiscovery<MsSqlDb>>();
            resolved.Should().Be(appender);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void The_default_factory_registration_with_custom_appender_registered_with_delegate_should_resolve_correctly(int version)
        {
            //given
            var appender = Substitute.For<IExpressionElementAppender<SchemaExpression>>();
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.ForElementTypes(b => b.ForElementType<SchemaExpression>().Use(() => appender)));
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var resolved = factory.CreateElementAppender<SchemaExpression>();

            //then
            factory.Should().BeOfType<DefaultExpressionElementAppenderFactoryWithDiscovery<MsSqlDb>>();
            resolved.Should().Be(appender);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void The_default_factory_registration_with_custom_appender_registered_with_service_provider_should_resolve_correctly(int version)
        {
            //given
            var appender = Substitute.For<IExpressionElementAppender<SchemaExpression>>();
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.ForElementTypes(b => b.ForElementType<SchemaExpression>().Use(sp => appender)));
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var resolved = factory.CreateElementAppender(typeof(SchemaExpression));

            //then
            factory.Should().BeOfType<DefaultExpressionElementAppenderFactoryWithDiscovery<MsSqlDb>>();
            resolved.Should().Be(appender);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void The_default_factory_registration_with_custom_appender_registered_generically_should_resolve_correctly(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.ForElementTypes(b => b.ForElementType<SchemaExpression>().Use<NoOpSchemaAppender>()));
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var resolved = factory.CreateElementAppender<SchemaExpression>();

            //then
            factory.Should().BeOfType<DefaultExpressionElementAppenderFactoryWithDiscovery<MsSqlDb>>();
            resolved.Should().BeOfType<NoOpSchemaAppender>();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void An_element_appender_factory_registered_via_delegate_should_resolve_the_correct_appender(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.Use(t => new FieldExpressionAppender()));
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var appender = factory.CreateElementAppender(dbo.Person.Id.GetType());

            //then
            appender.Should().BeOfType<FieldExpressionAppender>();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void An_element_appender_factory_registered_via_delegate_using_service_provider_should_resolve_the_correct_appender(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.Use((sp, t) => new FieldExpressionAppender()));
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var appender = factory.CreateElementAppender(dbo.Person.Id.GetType());

            //then
            appender.Should().BeOfType<FieldExpressionAppender>();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void The_default_factory_registration_should_resolve_appenders_as_singletons(int version)
        {
            //given
            var provider = ConfigureForMsSqlVersion(version);
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var first = factory.CreateElementAppender(typeof(SchemaExpression));
            var second = factory.CreateElementAppender(typeof(SchemaExpression));

            //then
            first.Should().Be(second);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void The_default_factory_registration_with_custom_appender_registered_with_instance_should_resolve_singletons(int version)
        {
            //given
            var appender = Substitute.For<IExpressionElementAppender<SchemaExpression>>();
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.ForElementTypes(b => b.ForElementType<SchemaExpression>().Use(appender)));
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var a1 = factory.CreateElementAppender<SchemaExpression>();
            var a2 = factory.CreateElementAppender<SchemaExpression>();

            //then
            a1.Should().Be(a2);
            a1.Should().NotBeNull();
            a2.Should().NotBeNull();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void The_default_factory_registration_with_custom_appender_registered_with_delegate_should_resolve_singletons(int version)
        {
            //given
            var appender = Substitute.For<IExpressionElementAppender<SchemaExpression>>();
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.ForElementTypes(b => b.ForElementType<SchemaExpression>().Use(() => appender)));
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var a1 = factory.CreateElementAppender<SchemaExpression>();
            var a2 = factory.CreateElementAppender<SchemaExpression>();

            //then
            a1.Should().Be(a2);
            a1.Should().NotBeNull();
            a2.Should().NotBeNull();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void The_default_factory_registration_with_custom_appender_registered_with_service_provider_should_resolve_singletons(int version)
        {
            //given
            var appender = Substitute.For<IExpressionElementAppender<SchemaExpression>>();
            var provider = ConfigureForMsSqlVersion(version, c => c.SqlStatements.Assembly.ElementAppender.ForElementTypes(b => b.ForElementType<SchemaExpression>().Use(sp => appender)));
            var factory = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>();

            //when
            var a1 = factory.CreateElementAppender<SchemaExpression>();
            var a2 = factory.CreateElementAppender<SchemaExpression>();

            //then
            a1.Should().Be(a2);
            a1.Should().NotBeNull();
            a2.Should().NotBeNull();
        }

        public class NoOpExpressionElementAppenderFactory : IExpressionElementAppenderFactory<MsSqlDb>
        {
            public IExpressionElementAppender CreateElementAppender(Type elementType)
            {
                throw new NotImplementedException();
            }

            IExpressionElementAppender<TElement> IExpressionElementAppenderFactory<MsSqlDb>.CreateElementAppender<TElement>()
            {
                throw new NotImplementedException();
            }
        }

        public class NoOpSchemaAppender : IExpressionElementAppender<SchemaExpression>
        {
            public void AppendElement(SchemaExpression element, ISqlStatementBuilder builder, AssemblyContext context)
            {
                throw new NotImplementedException();
            }

            public void AppendElement(IExpressionElement element, ISqlStatementBuilder builder, AssemblyContext context)
            {
                throw new NotImplementedException();
            }
        }
    }
}