﻿using DbEx.DataService;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql;
using System.Collections.Generic;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Database.Executor
{
    public partial class SelectMany
    {
        public partial class InnerJoin : ExecutorTestBase
        {
            [Theory]
            [MsSqlVersions.AllVersions]
            [Trait("Operation", "INNER JOIN")]
            public void Does_persons_with_addresses_have_52_records(int version)
            {
                //given
                ConfigureForMsSqlVersion(version);

                var exp = db.SelectMany(dbo.Person.Id)
                    .From(dbo.Person)
                    .InnerJoin(dbo.PersonAddress).On(dbo.Person.Id == dbo.PersonAddress.PersonId);

                //when               
                IList<int> persons = exp.Execute();

                //then
                persons.Should().HaveCount(52);
            }
        }
    }
}