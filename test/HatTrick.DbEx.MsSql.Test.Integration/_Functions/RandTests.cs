using DbEx.DataService;
using DbEx.dboData;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Builder.Alias;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Builder.Alias;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Integration
{
    [Trait("Statement", "SELECT")]
    [Trait("Function", "RAND")]
    public partial class RandTests : ResetDatabaseNotRequired
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_rand_with_seed_using_field_expression_succeed(int version, float expected = 0.714f)
        {
            //given
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Rand(dbo.PurchaseLine.Id)
                ).From(dbo.PurchaseLine)
                .Where(dbo.PurchaseLine.Id == 1);

            //when               
            float result = exp.Execute();

            //then
            result.Should().BeApproximately(expected, 0.001f, "Rounding error in random value.");
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_rand_succeed(int version)
        {
            //given
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Rand().As("value")
                ).From(dbo.Purchase);

            //when               
            float result = exp.Execute();

            //then
            result.Should().BeGreaterThan(0);
        }
        
        [Theory]
        [MsSqlVersions.AllVersions]
        [Trait("Operation", "SUBQUERY")]
        public void Does_rand_of_aliased_field_succeed(int version, float expected = 0.714f)
        {
            //given
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Rand(("lines", "Id")).As("alias")
                ).From(dbo.Purchase)
                .InnerJoin(
                    db.SelectOne<PurchaseLine>()
                    .From(dbo.PurchaseLine)
                    .Where(dbo.PurchaseLine.Id == 2)
                ).As("lines").On(dbo.Purchase.Id == ("lines", "PurchaseId"));

            //when               
            float? result = exp.Execute();

            //then
            result.Should().BeApproximately(expected, 0.001f, "Rounding error in random value.");
        }
    }
}