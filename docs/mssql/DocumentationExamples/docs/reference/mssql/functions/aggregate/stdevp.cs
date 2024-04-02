using DocumentationExamples.DataService;
using DocumentationExamples.dboData;
using DocumentationExamples.dboDataService;
using DocumentationExamples.secDataService;
using DbExpression.MsSql.Expression;
using DbExpression.Sql;
using DbExpression.Sql.Builder.Alias;
using Microsoft.Extensions.Logging;

namespace DocumentationExamples.Reference.Mssql.Functions.Aggregate
{
    ///<summary>Code examples from https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdevp</summary>
    public class StDevP : IDocumentationExamples
    {
        private readonly ILogger<StDevP> logger;

        public StDevP(ILogger<StDevP> logger)
        {
            this.logger = logger;
        }

        public void ExecuteExamples()
        {
            StDevP_line_no_46();
            StDevP_line_no_64();
            StDevP_line_no_86();
        }

        ///<summary>https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdevp at line 46</summary>
        private void StDevP_line_no_46()
        {
            logger.LogDebug("https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdevp at line 46");

            float result = db.SelectOne(
                    db.fx.StDevP(dbo.Product.ShippingWeight)
                )
                .From(dbo.Product)
                .Execute();

            /*
            SELECT TOP(1)
                STDEVP([t0].[ShippingWeight])
            FROM
                [dbo].[Product] AS [t0];
            */
        }

        ///<summary>https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdevp at line 64</summary>
        private void StDevP_line_no_64()
        {
            logger.LogDebug("https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdevp at line 64");

            float result = db.SelectOne(
                    db.fx.StDevP(dbo.Product.ShippingWeight)
                )
                .From(dbo.Product)
                .OrderBy(db.fx.StDevP(dbo.Product.ShippingWeight).Desc())
                .Execute();

            /*
            SELECT TOP(1)
                STDEVP([t0].[ShippingWeight])
            FROM
                [dbo].[Product] AS [t0]
            ORDER BY
                STDEVP([t0].[ShippingWeight]) DESC;
            */
        }

        ///<summary>https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdevp at line 86</summary>
        private void StDevP_line_no_86()
        {
            logger.LogDebug("https://dbexpression.com/docs/reference/mssql/functions/aggregate/stdevp at line 86");

            IEnumerable<ProductCategoryType?> results = db.SelectMany(
                    dbo.Product.ProductCategoryType
                )
                .From(dbo.Product)
                .GroupBy(dbo.Product.ProductCategoryType)
                .Having(db.fx.StDevP(dbo.Product.ShippingWeight) > 1)
                .Execute();

            /*
            exec sp_executesql N'SELECT
                [t0].[ProductCategoryType]
            FROM
                [dbo].[Product] AS [t0]
            GROUP BY
                [t0].[ProductCategoryType]
            HAVING
                STDEVP([t0].[ShippingWeight]) > @P1;',N'@P1 real',@P1=1
            */
        }

    }
}
