﻿using HatTrick.DbEx.CodeTemplating.Builder;
using HatTrick.DbEx.CodeTemplating.Model;
using System.Linq;

namespace HatTrick.DbEx.CodeTemplating.CodeGenerator
{
    public class LeftFunctionExpressionCodeGenerator : CodeGenerator<FunctionTemplateModel>
    {
        private const string functionName = "Left";

        protected override void PopulateModel(FunctionTemplateModel model, string @namespace, TypeModel typeModel)
        {
            base.PopulateModel(model, @namespace, typeModel);
            model.FunctionName = functionName;
            model.ArithmeticOperations = TypeBuilder.CreateBuilder().AddNumericTypes().ToList().Select(@type => new ArithmeticOperationsTemplateModel
            {
                OperationType = @type,
                ReturnType = ArithmeticBuilder.InferReturnTypeByPrecedence(typeModel, @type),
                Operations = ArithmeticBuilder.CreateBuilder().InferArithmeticOperations(typeModel, @type).ToList()
            }).ToList();
        }

        public override void Generate(string templatePath, string outputSubdirectory)
        {
            foreach (var @type in TypeBuilder.CreateBuilder().Add<string>().Add<object>().ToList())
                Generate(templatePath, outputSubdirectory, $"{@type.Name}{functionName}FunctionExpression.generated.cs", CreateModel("HatTrick.DbEx.Sql.Expression", @type));
        }
    }
}