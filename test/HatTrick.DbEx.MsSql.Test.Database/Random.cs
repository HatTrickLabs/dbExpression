﻿using Data.dbo;
using DataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Database.Executor;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql.Extensions.Builder;
using System.Linq;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Database
{
    public class Random : ExecutorTestBase
    {
        [Theory]
        [Trait("Operation", "GROUP BY")]
        [Trait("Operation", "HAVING")]
        [Trait("Operation", "ORDER BY")]
        [Trait("Operation", "DISTINCT")]
        [MsSqlVersions.AllVersions]
        public void Does_select_many_result_in_valid_expression(int version, int expectedCount = 17)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when
            var persons = db.SelectMany(
                    dbo.Person.Id.As("foo"),
                    dbo.Person.FirstName,
                    dbo.Person.LastName,
                    db.Count(dbo.Person_Address.Id).As("person_count")
                ).Distinct()
                .From(dbo.Person)
                .InnerJoin(dbo.Person_Address).On(dbo.Person.Id == dbo.Person_Address.PersonId)
                .GroupBy(
                    dbo.Person.Id,
                    dbo.Person.FirstName,
                    dbo.Person.LastName
                )
                .Having(
                    db.Count(dbo.Person_Address.Id) > 1
                )
                .OrderBy(
                    dbo.Person.LastName,
                    dbo.Person.FirstName.Desc
                )
                .Execute();

            //then
            persons.Count().Should().Be(expectedCount);
        }
    }
}
