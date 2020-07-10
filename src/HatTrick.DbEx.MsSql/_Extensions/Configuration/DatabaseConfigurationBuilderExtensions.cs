﻿using HatTrick.DbEx.Sql.Configuration;
using System.Linq;

namespace HatTrick.DbEx.MsSql.Configuration
{
    public static class DatabaseConfigurationBuilderExtensions
    {
        public static void UseIdentityInsertStrategy(this DatabaseConfigurationBuilder config)
        {
            config.BeforeInsertingEntity(inserting =>
            {
                var identity = inserting.AllFields.Fields.SingleOrDefault(e => e.Metadata.IsIdentity);
                if (identity == null)
                    return;

                inserting.CommandTextWriter
                    .Write(";SELECT ")
                    .Write(inserting.ParameterBuilder.AddOutput(identity.Field).Parameter.ParameterName)
                    .Write(" = SCOPE_IDENTITY()");
            });

            config.AfterInsertingEntity(inserted =>
            {
                var identity = inserted.AllFields.Fields.SingleOrDefault(e => e.Metadata.IsIdentity);
                if (identity == null)
                    return;

                inserted.Entity.SetPropertyValue<int>(identity.Field, inserted.Parameters.Single(p => p.Field == identity.Field).Parameter.Value);
            });
        }
    }
}