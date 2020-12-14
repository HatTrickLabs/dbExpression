﻿using System.Collections.Generic;

namespace HatTrick.DbEx.Sql
{
#pragma warning disable IDE1006 // Naming Styles
    public interface SelectEntitiesContinuation<TEntity> : SelectEntitiesTermination<TEntity>
#pragma warning restore IDE1006 // Naming Styles
        where TEntity : class, IDbEntity
    {
        /// <summary>
        /// Construct the WHERE clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/t-sql/queries/where-transact-sql">Microsoft docs on WHERE</see>
        /// </para>
        /// </summary>
        /// <param name="where">Any filter predicate of type <see cref="AnyWhereClause"/>.</param>
        /// <returns><see cref="SelectEntitiesContinuation{TEntity}"/>, a fluent continuation for the construction of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        SelectEntitiesContinuation<TEntity> Where(AnyWhereClause where);

        /// <summary>
        /// Construct the ORDER BY clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/t-sql/queries/select-order-by-clause-transact-sql">Microsoft docs on ORDER BY</see>
        /// </para>
        /// </summary>
        /// <param name="orderBy">A list of expressions of type <see cref="AnyOrderByClause"/> indicating the order and direction for sorting.</param>
        /// <returns><see cref="SelectEntitiesContinuation{TEntity}"/>, a fluent continuation for the construction of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        SelectEntitiesOrderByContinuation<TEntity> OrderBy(params AnyOrderByClause[] orderBy);

        /// <summary>
        /// Construct the ORDER BY clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/t-sql/queries/select-order-by-clause-transact-sql">Microsoft docs on ORDER BY</see>
        /// </para>
        /// </summary>
        /// <param name="orderBy">A list of expressions of type <see cref="AnyOrderByClause"/> specifying the order and direction for sorting.</param>
        /// <returns><see cref="SelectEntitiesContinuation{TEntity}"/>, a fluent continuation for the construction of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        SelectEntitiesOrderByContinuation<TEntity> OrderBy(IEnumerable<AnyOrderByClause> orderBy);

        /// <summary>
        /// Construct the GROUP BY clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/t-sql/queries/select-group-by-transact-sql">Microsoft docs on GROUP BY</see>
        /// </para>
        /// </summary>
        /// <param name="groupBy">A list of expressions of type <see cref="AnyGroupByClause"/> specifying how to group the selected results.</param>
        /// <returns><see cref="SelectEntitiesContinuation{TEntity}"/>, a fluent continuation for the construction of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        SelectEntitiesContinuation<TEntity> GroupBy(params AnyGroupByClause[] groupBy);

        /// <summary>
        /// Construct the GROUP BY clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/t-sql/queries/select-group-by-transact-sql">Microsoft docs on GROUP BY</see>
        /// </para>
        /// </summary>
        /// <param name="groupBy">A list of expressions of type <see cref="AnyGroupByClause"/> specifying how to group the selected results.</param>
        /// <returns><see cref="SelectEntitiesContinuation{TEntity}"/>, a fluent continuation for the construction of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        SelectEntitiesContinuation<TEntity> GroupBy(IEnumerable<AnyGroupByClause> groupBy);

        /// <summary>
        /// Construct the HAVING clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/t-sql/queries/select-having-transact-sql">Microsoft docs on HAVING</see>
        /// </para>
        /// </summary>
        /// <param name="having\">A list of expressions of type <see cref="AnyHavingClause"/> specifying conditions on the grouping or aggregation of selected results.</param>
        /// <returns><see cref="SelectEntitiesContinuation{TEntity}"/>, a fluent continuation for the construction of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        SelectEntitiesContinuation<TEntity> Having(AnyHavingClause having);

        /// <summary>
        /// Construct an INNER JOIN clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/relational-databases/performance/joins">Microsoft docs on JOINS</see>
        /// </para>
        /// </summary>
        /// <param name="entity">Any expression of type <see cref="AnyEntity"/> specifying the database entity to join to.</param>
        /// <returns><see cref="JoinOn{SelectEntitiesContinuation{TEntity}}"/>, a fluent continuation for the construction of a sql JOIN expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        JoinOn<SelectEntitiesContinuation<TEntity>> InnerJoin(AnyEntity entity);

        /// <summary>
        /// Construct an INNER JOIN clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/relational-databases/performance/joins">Microsoft docs on JOINS</see>
        /// </para>
        /// </summary>
        /// <param name="subquery">Any expression of type <see cref="AnySelectSubquery"/> specifying a SELECT query expression to join to.</param>
        /// <returns><see cref="JoinOnWithAlias{SelectEntitiesContinuation{TEntity}}"/>, a fluent continuation for the construction of a sql JOIN expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        JoinOnWithAlias<SelectEntitiesContinuation<TEntity>> InnerJoin(AnySelectSubquery subquery);

        /// <summary>
        /// Construct an LEFT JOIN clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/relational-databases/performance/joins">Microsoft docs on JOINS</see>
        /// </para>
        /// </summary>
        /// <param name="entity">Any expression of type <see cref="AnyEntity"/> specifying the database entity to join to.</param>
        /// <returns><see cref="JoinOn{SelectEntitiesContinuation{TEntity}}"/>, a fluent continuation for the construction of a sql JOIN expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        JoinOn<SelectEntitiesContinuation<TEntity>> LeftJoin(AnyEntity entity);

        /// <summary>
        /// Construct an LEFT JOIN clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/relational-databases/performance/joins">Microsoft docs on JOINS</see>
        /// </para>
        /// </summary>
        /// <param name="subquery">Any expression of type <see cref="AnySelectSubquery"/> specifying a SELECT query expression to join to.</param>
        /// <returns><see cref="JoinOnWithAlias{SelectEntitiesContinuation{TEntity}}"/>, a fluent continuation for the construction of a sql JOIN expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        JoinOnWithAlias<SelectEntitiesContinuation<TEntity>> LeftJoin(AnySelectSubquery subquery);

        /// <summary>
        /// Construct an RIGHT JOIN clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/relational-databases/performance/joins">Microsoft docs on JOINS</see>
        /// </para>
        /// </summary>
        /// <param name="entity">Any expression of type <see cref="AnyEntity"/> specifying the database entity to join to.</param>
        /// <returns><see cref="JoinOn{SelectEntitiesContinuation{TEntity}}"/>, a fluent continuation for the construction of a sql JOIN expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        JoinOn<SelectEntitiesContinuation<TEntity>> RightJoin(AnyEntity entity);

        /// <summary>
        /// Construct an RIGHT JOIN clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/relational-databases/performance/joins">Microsoft docs on JOINS</see>
        /// </para>
        /// </summary>
        /// <param name="subquery">Any expression of type <see cref="AnySelectSubquery"/> specifying a SELECT query expression to join to.</param>
        /// <returns><see cref="JoinOnWithAlias{SelectEntitiesContinuation{TEntity}}"/>, a fluent continuation for the construction of a sql JOIN expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        JoinOnWithAlias<SelectEntitiesContinuation<TEntity>> RightJoin(AnySelectSubquery subquery);

        /// <summary>
        /// Construct an FULL JOIN clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/relational-databases/performance/joins">Microsoft docs on JOINS</see>
        /// </para>
        /// </summary>
        /// <param name="entity">Any expression of type <see cref="AnyEntity"/> specifying the database entity to join to.</param>
        /// <returns><see cref="JoinOn{SelectEntitiesContinuation{TEntity}}"/>, a fluent continuation for the construction of a sql JOIN expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        JoinOn<SelectEntitiesContinuation<TEntity>> FullJoin(AnyEntity entity);

        /// <summary>
        /// Construct an FULL JOIN clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/relational-databases/performance/joins">Microsoft docs on JOINS</see>
        /// </para>
        /// </summary>
        /// <param name="subquery">Any expression of type <see cref="AnySelectSubquery"/> specifying a SELECT query expression to join to.</param>
        /// <returns><see cref="JoinOnWithAlias{SelectEntitiesContinuation{TEntity}}"/>, a fluent continuation for the construction of a sql JOIN expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        JoinOnWithAlias<SelectEntitiesContinuation<TEntity>> FullJoin(AnySelectSubquery subquery);

        /// <summary>
        /// Construct an CROSS JOIN clause of a sql SELECT query expression for a list of <typeparamref name="TEntity"/> entities.
        /// <para>
        /// <see href="https://docs.microsoft.com/en-us/sql/relational-databases/performance/joins">Microsoft docs on JOINS</see>
        /// </para>
        /// </summary>
        /// <param name="entity">Any expression of type <see cref="AnyEntity"/> specifying the database entity to join to.</param>
        /// <returns><see cref="JoinOn{SelectEntitiesContinuation{TEntity}}"/>, a fluent continuation for the construction of a sql JOIN expression for a list of <typeparamref name="TEntity"/> entities.</returns>
        JoinOn<SelectEntitiesContinuation<TEntity>> CrossJoin(AnyEntity entity);
    }
}