using System;
using System.Collections.Generic;

namespace clothes_site_sample.scripts.Bases
{
    public interface IRepository<TEntity> where TEntity : class
    {
        int Count();
        int CountBy(Predicate<TEntity> match);
        bool IsNullOrEmpty();
        bool IsNullOrEmptyBy(Predicate<TEntity> match);
        bool IsNotEmpty();
        bool IsNotEmptyBy(Predicate<TEntity> match);
        void Add(TEntity entity);
        void Add(EntityBase entityBase);
        void AddAll(IEnumerable<Dictionary<string, object>> list);
        TEntity GetByOrDefault(Predicate<TEntity> match, TEntity defaultEntity);
        TEntity GetByIndexOrDefault(int index, TEntity defaultEntity);
        TEntity GetFirstOrDefault(TEntity defaultEntity);
        TEntity GetLastOrDefault(TEntity defaultEntity);
        bool TryFindBy(Predicate<TEntity> match, out TEntity entity);
        bool TryFindByIndex(int index, out TEntity entity);
        bool TryGetFirst(out TEntity entity);
        bool TryGetLast(out TEntity entity);
        List<TEntity> FindAll();
        List<TEntity> FindAllBy(Predicate<TEntity> match);
        void ClearBy(Predicate<TEntity> match);
        void ClearAll();
        void ClearAllBy(Predicate<TEntity> match);
    }
}