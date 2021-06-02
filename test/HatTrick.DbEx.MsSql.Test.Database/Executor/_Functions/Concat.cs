﻿using DbEx.DataService;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Database.Executor
{
    [Trait("Statement", "SELECT")]
    [Trait("Function", "CONCAT")]
    public partial class Concat : ExecutorTestBase
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_concat_of_person_first_and_last_name_succeed(int version, int expected = 50)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectMany(
                    db.fx.Concat(dbo.Person.FirstName, dbo.Person.LastName)
                ).From(dbo.Person);

            //when               
            var names = exp.Execute();

            //then
            names.Should().HaveCount(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_concat_of_person_first_and_last_name_with_literal_succeed(int version, int expected = 50)
        {
            //given
            ConfigureForMsSqlVersion(version);

            var exp = db.SelectMany(
                    db.fx.Concat(dbo.Person.FirstName, " ", dbo.Person.LastName)
                ).From(dbo.Person);

            //when               
            var names = exp.Execute();

            //then
            names.Should().HaveCount(expected);
        }
    }
}