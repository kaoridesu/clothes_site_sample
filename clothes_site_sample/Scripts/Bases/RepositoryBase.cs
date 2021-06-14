using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace clothes_site_sample.scripts.Bases
{
    public abstract class RepositoryBase<TEntity, KRepository> : IRepository<TEntity> where TEntity : EntityBase, new()
        where KRepository : IRepository<TEntity>, new()
    {
        private static readonly object LockObject = new object();
        protected abstract List<TEntity> EntityList { get; }
        private static KRepository instance;
        public static KRepository Me => instance ??= new KRepository();
        public virtual string TableName => typeof(KRepository).Name;
        public virtual string PhysicalName => typeof(KRepository).Name;

        public int Count() => EntityList.Count;
        public int CountBy(Predicate<TEntity> match) => FindAllBy(match).Count;
        public bool IsNullOrEmpty() => true;
        public bool IsNullOrEmptyBy(Predicate<TEntity> match) => true;
        public bool IsNotEmpty() => true;
        public bool IsNotEmptyBy(Predicate<TEntity> match) => true;

        public void Add(TEntity entity)
        {
            if (entity == null)
            {
                return;
            }

            lock (LockObject)
            {
                EntityList.Add(entity);
            }
        }

        public void Add(EntityBase entityBase)
        {
            if (entityBase == null)
            {
                return;
            }

            TEntity entity = entityBase as TEntity;
            lock (LockObject)
            {
                EntityList.Add(entity);
            }
        }

        public void AddAll(params EntityBase[] entityBases)
        {
            ClearAll();
            foreach (var entityBase in entityBases)
            {
                Add(entityBase);
            }
        }

        public void AddAll(IEnumerable<Dictionary<string, object>> list)
        {
            ClearAll();
            foreach (var values in list)
            {
                TEntity entity = new TEntity();
                entity.SetField(values);
                Add(entity);
            }
        }

        public TEntity GetBy(Predicate<TEntity> match)
        {
            return GetByOrDefault(match, null);
        }

        public TEntity GetFirst()
        {
            return GetFirstOrDefault(null);
        }

        public TEntity GetLast()
        {
            return GetLastOrDefault(null);
        }

        public TEntity GetByOrDefault(Predicate<TEntity> match, TEntity defaultEntity)
        {
            TEntity result = defaultEntity;

            if (TryFindBy(match, out TEntity entity))
            {
                result = entity;
            }

            return result;
        }

        public TEntity GetByIndexOrDefault(int index, TEntity defaultEntity)
        {
            TEntity result = defaultEntity;

            if (TryFindByIndex(index, out TEntity entity))
            {
                result = entity;
            }

            return result;
        }

        public TEntity GetFirstOrDefault(TEntity defaultEntity)
        {
            TEntity result = defaultEntity;

            if (TryGetFirst(out TEntity entity))
            {
                result = entity;
            }

            return result;
        }

        public TEntity GetLastOrDefault(TEntity defaultEntity)
        {
            TEntity result = defaultEntity;

            if (TryGetLast(out TEntity entity))
            {
                result = entity;
            }

            return result;
        }

        public bool TryFindBy(Predicate<TEntity> match, out TEntity entity)
        {
            entity = EntityList.Find(match);
            return entity != null;
        }

        public bool TryFindByIndex(int index, out TEntity entity)
        {
            entity = null;

            if (index < 0 || index > Count())
            {
                return false;
            }

            entity = EntityList[index];
            return entity != null;
        }

        public bool TryGetFirst(out TEntity entity)
        {
            entity = null;
            return TryFindByIndex(0, out entity);
        }

        public bool TryGetLast(out TEntity entity)
        {
            entity = null;
            return TryFindByIndex(Count(), out entity);
        }

        public List<TEntity> FindAll() => EntityList;

        public List<TEntity> FindAllBy(Predicate<TEntity> match) => EntityList.FindAll(match);

        public void ClearBy(Predicate<TEntity> match)
        {
            if (TryFindBy(match, out TEntity e))
            {
                EntityList.Remove(e);
                return;
            }
        }

        public void ClearAll() => EntityList.Clear();

        public void ClearAllBy(Predicate<TEntity> match)
        {
            var list = FindAllBy(match);
            foreach (var entity in list)
            {
                EntityList.Remove(entity);
            }
        }
    }
}