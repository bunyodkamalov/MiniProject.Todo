﻿using ToDo.Domain.Common.Entities;

namespace ToDo.Domain.Common.Query;

/// <summary>
/// Represents an interface for objects that can be converted to a query specification.
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IQueryConvertible<TEntity> where TEntity : IEntity
{
    /// <summary>
    /// Converts the current object to a query specification for the specified entity type.
    /// </summary>
    /// <returns></returns>
    QuerySpecification<TEntity> ToQuerySpecification();
}

/// <summary>
/// Represents an interface for objects that can be converted to a query specification.
/// </summary>
public interface IQueryConvertible
{
    /// <summary>
    /// Converts the current object to a query specification for the specified entity type.
    /// </summary>
    /// <returns></returns>
    QuerySpecification ToQuerySpecification();
}