using DbEx.DataService;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql;
using System;
using System.Collections.Generic;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Integration
{
    [Trait("Function", "COALESCE")]
    [Trait("Function", "SUM")]
    public partial class CoalesceAndSumTests : ResetDatabaseNotRequired
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_coalesce_of_sum_of_credit_limit_and_static_value_succeed(int version, int expected = 1010000)
        {
            //given
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Coalesce<float>(db.fx.Sum(dbo.Person.CreditLimit), 1)
                ).From(dbo.Person);

            //when               
            object result = exp.Execute();

            //then
            result.Should().BeOfType<float>().Which.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        [Trait("Operation", "GROUP BY")]
        public void Does_selecting_coalesce_of_sum_of_credit_limit_and_person_id_succeed(int version, int expected = 50)
        {
            //given
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version);

            var exp = db.SelectMany(
                    db.fx.Coalesce<int?>(db.fx.Sum(dbo.Person.CreditLimit), dbo.Person.Id)
                ).From(dbo.Person)
                .GroupBy(dbo.Person.Id);

            //when               
            IEnumerable<int?> results = exp.Execute();

            //then
            results.Should().HaveCount(expected);
        }

        
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_sum_of_coalesce_of_credit_limit_and_static_value_succeed(int version, int expected = 1010009)
        {
            //given
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Sum(db.fx.Coalesce<int>(dbo.Person.CreditLimit, 1))
                ).From(dbo.Person);

            //when               
            int result = exp.Execute();

            //then
            result.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_sum_of_coalesce_of_credit_limit_and_person_id_succeed(int version, int expected = 1010414)
        {
            //given
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Sum(db.fx.Coalesce<int>(dbo.Person.CreditLimit, dbo.Person.Id))
                ).From(dbo.Person);

            //when               
            int? result = exp.Execute();

            //then
            result.Should().Be(expected);
        }
    }
}
