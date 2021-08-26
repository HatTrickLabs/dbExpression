﻿using DbEx.DataService;
using DbEx.dboData;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Database.Executor
{
    [Trait("Statement", "SELECT")]
    [Trait("Function", "ABS")]
    public partial class Abs : ExecutorTestBase
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_abs_of_total_purchase_quantity_succeed(int version, int expected = 1)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Abs(dbo.PurchaseLine.Quantity)
                ).From(dbo.PurchaseLine)
                .Where(dbo.PurchaseLine.Id == 1);

            //when               
            int result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_abs_of_total_purchase_amount_succeed(int version, double expected = 27.98)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Abs(dbo.Purchase.TotalPurchaseAmount).As("amount")
                ).From(dbo.Purchase)
                .Where(dbo.Purchase.Id == 2);

            //when               
            double result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_abs_of_purchase_price_succeed(int version, decimal expected = 7.81m)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Abs(dbo.PurchaseLine.PurchasePrice)
                ).From(dbo.PurchaseLine)
                .Where(dbo.PurchaseLine.Id == 1);

            //when               
            decimal result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        [Trait("Operation", "SUBQUERY")]
        public void Does_abs_of_aliased_field_succeed(int version, decimal expected = 7.81m)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Abs(dbex.Alias("lines", "PurchasePrice")).As("alias")
                ).From(dbo.Purchase)
                .InnerJoin(
                    db.SelectOne<PurchaseLine>()
                    .From(dbo.PurchaseLine)
                    .Where(dbo.PurchaseLine.Id == 1)
                ).As("lines").On(dbo.Purchase.Id == dbex.Alias("lines", "PurchaseId"));

            //when               
            object result = exp.Execute();

            //then
            result.Should().BeOfType<decimal>().Which.Should().Be(expected);
        }
    }
}