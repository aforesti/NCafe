﻿using NCafe.Abstractions.ReadModels;
using System.Collections.Concurrent;

namespace NCafe.Infrastructure.ReadModels;

public class InMemoryReadModelRepository<T> : IReadModelRepository<T> where T : ReadModel
{
    private static readonly ConcurrentDictionary<Guid, T> items = new();

    public void Add(T model)
    {
        items.TryAdd(model.Id, model);
    }

    public T GetById(Guid id)
    {
        return items.TryGetValue(id, out T result) ? result : null;
    }
}