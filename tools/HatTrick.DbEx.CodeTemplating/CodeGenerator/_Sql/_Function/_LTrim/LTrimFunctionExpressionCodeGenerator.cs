﻿using HatTrick.DbEx.CodeTemplating.Builder;
using HatTrick.DbEx.CodeTemplating.Model;
using System.Linq;

namespace HatTrick.DbEx.CodeTemplating.CodeGenerator
{
    public class LTrimFunctionExpressionCodeGenerator : CodeGenerator<FunctionTemplateModel>
    {
        private const string functionName = "LTrim";

        protected override void PopulateModel(FunctionTemplateModel model, string @namespace, TypeModel typeModel)
        {
            base.PopulateModel(model, @namespace, typeModel);
            model.FunctionName = functionName;
            model.ArithmeticOperations = TypeBuilder.CreateBuilder().Add<string>().ToList().Select(@type => new ArithmeticOperationsTemplateModel
            {
                OperationType = @type,
                ReturnType = typeModel,
                Operations = ArithmeticBuilder.CreateBuilder().AddArithmeticAdd().ToList()
            }).ToList();
        }

        public override void Generate(string templatePath, string outputSubdirectory)
            => Generate(templatePath, outputSubdirectory, $"{TypeBuilder.Get<string>().Name}{functionName}FunctionExpression.generated.cs", CreateModel("HatTrick.DbEx.Sql.Expression", TypeBuilder.Get<string>()));
    }
}