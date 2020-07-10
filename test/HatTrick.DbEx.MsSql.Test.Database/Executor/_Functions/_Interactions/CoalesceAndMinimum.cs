﻿using DbEx.DataService;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql;
using System.Collections.Generic;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Database.Executor
{
    [Trait("Function", "COALESECE")]
    [Trait("Function", "MIN")]
    public partial class CoalesceAndMinimum : ExecutorTestBase
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_coalesce_of_min_of_credit_limit_and_static_value_succeed(int version, int expected = 10000)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Coalesce(db.fx.Min(dbo.Person.CreditLimit), 1)
                ).From(dbo.Person);

            //when               
            int result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        [Trait("Operation", "GROUP BY")]
        public void Does_selecting_coalesce_of_min_of_credit_limit_and_person_id_succeed(int version, int expected = 50)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectMany(
                    db.fx.Coalesce(db.fx.Min(dbo.Person.CreditLimit), dbo.Person.Id)
                ).From(dbo.Person)
                .GroupBy(dbo.Person.Id);

            //when               
            IList<int> result = exp.Execute();

            //then
            result.Should().HaveCount(expected);
        }


        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_min_of_coalesce_of_credit_limit_and_static_value_succeed(int version, int expected = 1)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Min(db.fx.Coalesce(dbo.Person.CreditLimit, 1))
                ).From(dbo.Person);

            //when               
            int result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_min_of_coalesce_of_credit_limit_and_person_id_succeed(int version, int expected = 42)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Min(db.fx.Coalesce(dbo.Person.CreditLimit, dbo.Person.Id))
                ).From(dbo.Person);
            //when               
            int result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_min_of_coalesce_of_quantity_and_year_of_last_credit_limit_review_succeed(int version, int expected = 10000)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Min(db.fx.Coalesce(dbo.Person.CreditLimit, dbo.Person.YearOfLastCreditLimitReview))
                ).From(dbo.Person);

            //when               
            int? result = exp.Execute();

            //then
            result.Should().Be(expected);
        }
    }
}
