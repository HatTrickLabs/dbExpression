using v2019DbEx.DataService;
using v2019DbEx.secDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Configuration;
using HatTrick.DbEx.Sql.Assembler;
using HatTrick.DbEx.Sql.Builder;
using HatTrick.DbEx.Sql.Expression;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Unit.Assembler
{
    [Trait("Statement", "SELECT")]
    [Trait("Clause", "WHERE")]
    public class WhereClauseAssemblerTests : TestBase
    {
        [Fact]
        public void Does_a_single_where_predicate_result_in_valid_clause()
        {
            //given
            var (db, serviceProvider) = Configure<v2019MsSqlDb>();

            ITerminationExpressionBuilder<v2019MsSqlDb> exp = 

                db.SelectOne(sec.Person.Id)
                    .From(sec.Person.As("p"))
                    .Where(sec.Person.As("p").Id > 0);

            SelectQueryExpression queryExpression = ((exp as IQueryExpressionProvider)!.Expression as SelectQueryExpression)!;
            ISqlStatementBuilder builder = serviceProvider.GetServiceProviderFor<v2019MsSqlDb>().GetRequiredService<ISqlStatementBuilder>();
            AssemblyContext context = serviceProvider.GetServiceProviderFor<v2019MsSqlDb>().GetRequiredService<AssemblyContext>();
            string whereClause;

            //when
            builder.AppendElement(queryExpression.Where!, context);
            whereClause = builder.Appender.ToString()!;

            //then
            whereClause.Should().NotBeNullOrWhiteSpace();
            whereClause.Should().Be($"[p].[Id] > @P1");

            builder.Parameters.Parameters.Should().ContainSingle()
                .Which.Parameter.ParameterName.Should().Be("@P1");
        }
    }
}
