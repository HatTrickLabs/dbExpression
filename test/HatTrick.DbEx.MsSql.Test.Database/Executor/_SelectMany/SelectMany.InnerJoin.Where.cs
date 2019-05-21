﻿using Data;
using DataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql.Extensions.Builder;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Database.Executor
{
    [Trait("Statement", "SELECT")]
    public partial class SelectMany
    {
        [Trait("Operation", "INNER JOIN")]
        public partial class InnerJoin
        {
            [Trait("Clause", "WHERE")]
            public partial class Where : ExecutorTestBase
            {
                [Theory]
                [MsSqlVersions.AllVersions]
                public void Does_filtering_by_billing_addresstype_equal_to_billing_have_35_records(int version, int expectedCount = 35)
                {
                    //given
                    ConfigureForMsSqlVersion(version);

                    var exp = db.SelectMany<int>(dbo.Person.Id)
                        .From(dbo.Person)
                        .InnerJoin(dbo.Person_Address).On(dbo.Person.Id == dbo.Person_Address.PersonId)
                        .InnerJoin(dbo.Address).On(dbo.Person_Address.AddressId == dbo.Address.Id)
                        .Where(dbo.Address.AddressType == AddressType.Billing);

                    //when               
                    var persons = exp.Execute();

                    //then
                    persons.Should().HaveCount(expectedCount);
                }

                [Theory]
                [MsSqlVersions.AllVersions]
                public void Does_filtering_by_address_id_equal_to_1_have_14_records(int version, int expectedCount = 14)
                {
                    //given
                    ConfigureForMsSqlVersion(version);

                    var exp = db.SelectMany<int>(dbo.Person.Id)
                        .From(dbo.Person)
                        .InnerJoin(dbo.Person_Address).On(dbo.Person.Id == dbo.Person_Address.PersonId)
                        .InnerJoin(dbo.Address).On(dbo.Person_Address.AddressId == dbo.Address.Id)
                        .Where(dbo.Address.Id == 1);

                    //when               
                    var persons = exp.Execute();

                    //then
                    persons.Should().HaveCount(expectedCount);
                }

                [Theory]
                [MsSqlVersions.AllVersions]
                public void Does_filtering_by_addresstype_equal_to_billing_and_address_id_not_equal_to_1_have_35_records(int version, int expectedCount = 35)
                {
                    //given
                    ConfigureForMsSqlVersion(version);

                    var exp = db.SelectMany<int>(dbo.Person.Id)
                        .From(dbo.Person)
                        .InnerJoin(dbo.Person_Address).On(dbo.Person.Id == dbo.Person_Address.PersonId)
                        .InnerJoin(dbo.Address).On(dbo.Person_Address.AddressId == dbo.Address.Id)
                        .Where(dbo.Address.AddressType == AddressType.Billing & dbo.Address.Id != 1);

                    //when               
                    var persons = exp.Execute();

                    //then
                    persons.Should().HaveCount(expectedCount);
                }
            }
        }
    }
}