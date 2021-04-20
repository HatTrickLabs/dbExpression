#region license
// Copyright (c) HatTrick Labs, LLC.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// The latest version of this file can be found at https://github.com/HatTrickLabs/db-ex
#endregion

﻿using System;

namespace HatTrick.DbEx.Sql.Mapper
{
    public class DelegateEntityFactory : IEntityFactory
    {
        #region internals
        private readonly Func<Type, IDbEntity> factory;
        #endregion

        #region constructors
        public DelegateEntityFactory(Func<Type, IDbEntity> factory)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }
        #endregion

        #region methods
        public virtual void RegisterFactory<TEntity>(Func<TEntity> entityFactory)
            where TEntity : class, IDbEntity
            => throw new InvalidOperationException("Entity initialization is deferred to a delegate that doesn't support registration of an entity-specific factory.");

        public TEntity CreateEntity<TEntity>()
            where TEntity : class, IDbEntity, new()
            => factory.Invoke(typeof(TEntity)) as TEntity;
        #endregion
    }
}