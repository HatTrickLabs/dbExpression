﻿#region license
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

using HatTrick.DbEx.Sql.Executor;
using System;

namespace HatTrick.DbEx.Sql
{
#pragma warning disable IDE1006 // Naming Styles
    public interface StoredProcedureContinuation<TDatabase,TEntity> : StoredProcedureTermination<TDatabase, TEntity>
#pragma warning restore IDE1006 // Naming Styles
        where TDatabase : class, ISqlDatabaseRuntime
        where TEntity : class, StoredProcedure
    {
        SelectValueStoredProcedureContinuation<TDatabase, TEntity, TValue> GetValue<TValue>();
        SelectValuesStoredProcedureContinuation<TDatabase, TEntity, TValue> GetValues<TValue>();
        SelectObjectStoredProcedureContinuation<TDatabase, TEntity, T> GetValue<T>(Func<ISqlFieldReader, T> map)
            where T : class;
        SelectObjectsStoredProcedureContinuation<TDatabase, TEntity, T> GetValues<T>(Func<ISqlFieldReader, T> map)
            where T : class;
        SelectDynamicStoredProcedureContinuation<TDatabase, TEntity> GetValue();
        SelectDynamicsStoredProcedureContinuation<TDatabase, TEntity> GetValues();
        MapValuesStoredProcedureContinuation<TDatabase, TEntity> MapValues(Action<ISqlFieldReader> row);
    }
}