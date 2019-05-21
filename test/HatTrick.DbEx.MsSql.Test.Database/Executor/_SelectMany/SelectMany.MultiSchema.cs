﻿using Data;
using Data.dbo;
using DataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql.Extensions.Builder;
using System;
using System.Linq;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Database.Executor
{
    public partial class SelectMany
    {
        public class MultiSchema : ExecutorTestBase
        {
            [Theory]
            [MsSqlVersions.AllVersions]
            public void Are_there_no_records_for_persons_when_inner_joining_to_sec_schema(int version, int expectedCount = 0)
            {
                //given
                ConfigureForMsSqlVersion(version);

                var exp = db.SelectMany(dbo.Person.As("dboPerson").Id, sec.Person.Id)
                    .From(dbo.Person.As("dboPerson"))
                    .InnerJoin(sec.Person).On(dbo.Person.As("dboPerson").Id == sec.Person.Id);

                //when               
                var persons = exp.Execute();

                //then
                persons.Should().HaveCount(expectedCount);
            }

            [Theory]
            [MsSqlVersions.AllVersions]
            public void Are_there_no_records_for_persons_when_inner_joining_to_sec_schema_when_reversing_join_condition(int version, int expectedCount = 0)
            {
                //given
                ConfigureForMsSqlVersion(version);

                var exp = db.SelectMany(dbo.Person.As("dboPerson").Id, sec.Person.Id)
                    .From(dbo.Person.As("dboPerson"))
                    .InnerJoin(sec.Person).On(sec.Person.Id == dbo.Person.As("dboPerson").Id);

                //when               
                var persons = exp.Execute();

                //then
                persons.Should().HaveCount(expectedCount);
            }
        }
    }
}