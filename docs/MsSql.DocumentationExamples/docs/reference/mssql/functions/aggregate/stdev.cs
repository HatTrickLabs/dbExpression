using DbEx.DataService;
using DbEx.dboData;
using DbEx.dboDataService;
using DbEx.secDataService;
using HatTrick.DbEx.MsSql.Expression;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Builder.Alias;
using Microsoft.Extensions.Logging;

namespace MsSql.DocumentationExamples.Reference.Mssql.Functions.Aggregate
{
    ///<summary>Code examples from https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdev</summary>
    public class StDev : IDocumentationExamples
    {
        private readonly ILogger<StDev> logger;

        public StDev(ILogger<StDev> logger)
        {
            this.logger = logger;
        }

        public void ExecuteExamples()
        {
            StDev_line_no_46();
            StDev_line_no_64();
            StDev_line_no_86();
        }

        ///<summary>https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdev at line 46</summary>
        private void StDev_line_no_46()
        {
            logger.LogDebug("https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdev at line 46");

            float result = db.SelectOne(
                    db.fx.StDev(dbo.Product.ShippingWeight)
                )
                .From(dbo.Product)
                .Execute();

            /*
            SELECT TOP(1)
                STDEV([_t0].[ShippingWeight])
            FROM
                [dbo].[Product] AS [_t0];
            */
        }

        ///<summary>https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdev at line 64</summary>
        private void StDev_line_no_64()
        {
            logger.LogDebug("https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdev at line 64");

            float result = db.SelectOne(
                    db.fx.StDev(dbo.Product.ShippingWeight)
                )
                .From(dbo.Product)
                .OrderBy(db.fx.StDev(dbo.Product.ShippingWeight).Desc())
                .Execute();

            /*
            SELECT TOP(1)
                STDEV([_t0].[ShippingWeight])
            FROM
                [dbo].[Product] AS [_t0]
            ORDER BY
                STDEV([_t0].[ShippingWeight]) DESC;
            */
        }

        ///<summary>https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdev at line 86</summary>
        private void StDev_line_no_86()
        {
            logger.LogDebug("https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdev at line 86");

            IEnumerable<ProductCategoryType?> results = db.SelectMany(
                    dbo.Product.ProductCategoryType
                )
                .From(dbo.Product)
                .GroupBy(dbo.Product.ProductCategoryType)
                .Having(db.fx.StDev(dbo.Product.ShippingWeight) > 1)
                .Execute();

            /*
            exec sp_executesql N'SELECT
                [_t0].[ProductCategoryType]
            FROM
                [dbo].[Product] AS [_t0]
            GROUP BY
                [_t0].[ProductCategoryType]
            HAVING
                STDEV([_t0].[ShippingWeight]) > @P1;',N'@P1 real',@P1=1
            */
        }

    }
}
