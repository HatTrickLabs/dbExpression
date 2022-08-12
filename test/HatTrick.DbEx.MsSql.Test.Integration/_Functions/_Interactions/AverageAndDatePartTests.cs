using DbEx.DataService;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Expression;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Integration
{
    [Trait("Function", "AVG")]
    [Trait("Function", "DATEPART")]
    public partial class AverageAndPartDiffTests : ExecutorTestBase
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Does_selecting_average_of_datedpart_of_purchasedate_and_shipdate_and_datepart_of_purchasedate_succeed(int version, int expected = 2019)
        {
            //given
            var (db, serviceProvider) = ConfigureForMsSqlVersion(version);

            var exp = db.SelectOne(
                    db.fx.Avg(db.fx.DatePart(DateParts.Year, dbo.Purchase.PurchaseDate))
                ).From(dbo.Purchase);

            //when               
            int result = exp.Execute();

            //then
            result.Should().Be(expected);
        }
    }
}
