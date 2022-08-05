﻿using DbEx.DataService;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.Sql.Assembler;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Unit.Assembler
{
    public class IdentifierDelimiterAssemblerTests : TestBase
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_a_non_default_delimiter_assemble_a_fieldy_expression_correctly(int version, string expected = "{dbo}.{Person}.{Id}")
        {
            //given
            var provider = ConfigureForMsSqlVersion(version);
            var field = dbo.Person.Id;
            ISqlStatementBuilder builder = provider.GetRequiredService<ISqlStatementBuilder<MsSqlDb>>();
            IExpressionElementAppender appender = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>().CreateElementAppender(field.GetType())!;

            var context = provider.GetRequiredService<AssemblyContext>();
            context.PushAppendStyles(EntityExpressionAppendStyle.Declaration, FieldExpressionAppendStyle.Declaration);
            context.IdentifierDelimiter.Begin = '{';
            context.IdentifierDelimiter.End = '}';

            appender.AppendElement(field, builder, context);

            //when
            var assembled = builder.Appender.ToString()!;

            //then
            assembled.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_a_non_default_delimiter_assemble_an_entity_expression_correctly(int version, string expected = "{dbo}.{Person}")
        {
            //given
            var provider = ConfigureForMsSqlVersion(version);
            var entity = dbo.Person;
            ISqlStatementBuilder builder = provider.GetRequiredService<ISqlStatementBuilder<MsSqlDb>>();
            IExpressionElementAppender appender = provider.GetRequiredService<IExpressionElementAppenderFactory<MsSqlDb>>().CreateElementAppender(entity.GetType())!;

            var context = provider.GetRequiredService<AssemblyContext>();
            context.PushAppendStyles(EntityExpressionAppendStyle.Declaration, FieldExpressionAppendStyle.Declaration);
            context.IdentifierDelimiter.Begin = '{';
            context.IdentifierDelimiter.End = '}';

            appender.AppendElement(entity, builder, context);

            //when
            var assembled = builder.Appender.ToString()!;

            //then
            assembled.Should().Be(expected);
        }
    }    
}