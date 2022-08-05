using DbEx.DataService;
using DbEx.dboData;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Builder.Alias;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Integration
{
    [Trait("Statement", "SELECT")]
    [Trait("Function", "MAX")]
    public partial class MaximumTests : ExecutorTestBase
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_maximum_total_purchase_amount_succeed(int version, double expected = 55.96)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Max(dbo.Purchase.TotalPurchaseAmount).As("max_amount")
                ).From(dbo.Purchase);

            //when               
            double result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_maximum_distinct_total_purchase_amount_succeed(int version, double expected = 55.96)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Max(dbo.Purchase.TotalPurchaseAmount).Distinct().As("max_amount")
                ).From(dbo.Purchase);

            //when               
            double result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        [Trait("Operation", "ORDER BY")]
        public void Can_order_by_maximum_of_total_purchase_amount_ascending_succeed(int version, double expected = 55.96)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Max(dbo.Purchase.TotalPurchaseAmount).As("avg_amount")
                ).From(dbo.Purchase)
                .OrderBy(db.fx.Max(dbo.Purchase.TotalPurchaseAmount));

            //when               
            double result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        [Trait("Operation", "ORDER BY")]
        public void Can_order_by_maximum_of_total_purchase_amount_descending_succeed(int version, double expected = 55.96)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Max(dbo.Purchase.TotalPurchaseAmount)
                ).From(dbo.Purchase)
                .OrderBy(db.fx.Max(dbo.Purchase.TotalPurchaseAmount).Desc);

            //when               
            double result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        [Trait("Operation", "ORDER BY")]
        public void Can_order_by_maximum_of_total_purchase_amount_ascending_and_aliasing_succeed(int version, double expected = 55.96)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Max(dbo.Purchase.TotalPurchaseAmount).As("alias")
                ).From(dbo.Purchase)
                .OrderBy(db.fx.Max(dbo.Purchase.TotalPurchaseAmount));

            //when               
            double result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        [Trait("Operation", "ORDER BY")]
        public void Can_order_by_maximum_of_total_purchase_amount_descending_and_aliasing_succeed(int version, double expected = 55.96)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Max(dbo.Purchase.TotalPurchaseAmount).As("alias")
                ).From(dbo.Purchase)
                .OrderBy(db.fx.Max(dbo.Purchase.TotalPurchaseAmount).Desc);

            //when               
            double result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        [Trait("Operation", "SUBQUERY")]
        public void Does_maximum_of_aliased_field_succeed(int version, decimal expected = 30.00m)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Max(("lines", "PurchasePrice")).As("alias")
                ).From(dbo.Purchase)
                .InnerJoin(
                    db.SelectMany<PurchaseLine>()
                    .From(dbo.PurchaseLine)
                ).As("lines").On(dbo.Purchase.Id == ("lines", "PurchaseId"));

            //when               
            object? result = exp.Execute();

            //then
            result.Should().BeOfType<decimal>().Which.Should().BeApproximately(expected, 0.001m, "Rounding errors in ceiling");
        }
    }
}