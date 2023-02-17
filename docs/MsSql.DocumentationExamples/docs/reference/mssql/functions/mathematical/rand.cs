using DbEx.DataService;
using DbEx.dboData;
using DbEx.dboDataService;
using DbEx.secDataService;
using HatTrick.DbEx.MsSql.Expression;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Builder.Alias;
using Microsoft.Extensions.Logging;

namespace MsSql.DocumentationExamples.Reference.Mssql.Functions.Mathematical
{
    ///<summary>Code examples from https://dbexpression.com/docs/reference/mssql/functions/mathematical/rand</summary>
    public class Rand : IDocumentationExamples
    {
        private readonly ILogger<Rand> logger;

        public Rand(ILogger<Rand> logger)
        {
            this.logger = logger;
        }

        public void ExecuteExamples()
        {
            Rand_line_no_68();
            Rand_line_no_86();
        }

        ///<summary>https://dbexpression.com/docs/reference/mssql/functions/mathematical/rand at line 68</summary>
        private void Rand_line_no_68()
        {
            logger.LogDebug("https://dbexpression.com/docs/reference/mssql/functions/mathematical/rand at line 68");

            float? result = db.SelectOne(
                    db.fx.Rand()
                )
                .From(dbo.Product)
                .Execute();

            /*
            SELECT TOP(1)
                RAND()
            FROM
                [dbo].[Product] AS [_t0];
            */
        }

        ///<summary>https://dbexpression.com/docs/reference/mssql/functions/mathematical/rand at line 86</summary>
        private void Rand_line_no_86()
        {
            logger.LogDebug("https://dbexpression.com/docs/reference/mssql/functions/mathematical/rand at line 86");

            IEnumerable<float> results = db.SelectMany(
                    db.fx.Rand(dbo.Product.Id)
                )
                .From(dbo.Product)
                .Execute();

            /*
            SELECT
                RAND([_t0].[Id])
            FROM
                [dbo].[Product] AS [_t0]
            */
        }

    }
}
