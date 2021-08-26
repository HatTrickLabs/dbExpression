﻿using DbEx.DataService;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql;
using System.Collections.Generic;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Database.Executor
{
    [Trait("Statement", "SELECT")]
    [Trait("Function", "CAST")]
    [Trait("Function", "LIKE")]
    public partial class CastAndLike : ExecutorTestBase
    {
        [Theory]
        [Trait("Operation", "LIKE")]
        [MsSqlVersions.AllVersions]
        public void Does_where_clause_using_cast_of_decimal_and_like_succeed(int version, int expected = 1)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectMany(
                    dbo.Product.Id
                ).From(dbo.Product)
                .Where(db.fx.Cast(dbo.Product.Price).AsVarChar(12).Like("7.8%"));

            //when               
            IList<int> results = exp.Execute();

            //then
            results.Should().HaveCount(expected);
        }

        [Theory]
        [Trait("Operation", "LIKE")]
        [MsSqlVersions.AllVersions]
        public void Does_where_clause_using_cast_of_nullable_decimal_and_like_succeed(int version, int expected = 2)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectMany(
                    dbo.Product.Id
                ).From(dbo.Product)
                .Where(db.fx.Cast(dbo.Product.Height).AsVarChar(12).Like("12.%"));

            //when               
            IList<int> results = exp.Execute();

            //then
            results.Should().HaveCount(expected);
        }
    }
}