﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AuditHelper.Classes;

namespace AuditHelper.DB
{
    public class EntityMap<T> where T : Entity
    {
        private readonly Dictionary<int, T> _entities = new Dictionary<int, T>();
        private readonly object _getLock = new object();
        private readonly Func<int, T> _entityGenerator;
        private readonly Func<T, bool> _entityUpdater;
        private readonly Func<T, int> _entityInserter;
        private readonly Func<T, bool> _entityDeleter;

        public T Get(int id)
        {
            lock (_getLock)
            {
                T entity = null;

                if (!_entities.TryGetValue(id, out entity))
                {
                    entity = _entityGenerator(id);
                    if (entity != null)
                        _entities[id] = entity;
                }

                return entity;
            }
        }

        public List<T> GetAll()
        {
            lock (_getLock)
            {
                return _entities.Values.ToList<T>();
            }
        }

        public void Set(T aEntity) 
        {
            lock (_getLock)
            {
                int newId;

                if (_entities.ContainsKey(aEntity.Id))
                {
                    if (_entityUpdater(aEntity))
                        _entities[aEntity.Id] = aEntity;
                }
                else
                {
                    newId = _entityInserter(aEntity);
                    this.Get(newId);
                }
            } 
        }

        public T this[int index]
        {
            get
            {
                return this.Get(index);
            }
            set 
            { 
                this.Set(value); 
            }
        }

        public void Delete(T aEntity)
        {
            lock (_getLock)
            {
                if (_entities.ContainsKey(aEntity.Id))
                {
                    if (_entityDeleter(aEntity))
                        _entities.Remove(aEntity.Id);
                }
            } 
        }

        internal EntityMap(Func<int, T> entityGenerator, Func<T, bool> entityUpdater,
            Func<T, int> entityInserter, Func<T, bool> entityDeleter)
        {
            _entityGenerator = entityGenerator;
            _entityUpdater = entityUpdater;
            _entityInserter = entityInserter;
            _entityDeleter = entityDeleter;
        }

        public int Count
        {
            get
            {
                lock (_getLock)
                {
                    return _entities.Count;
                }
            }
        }
    }

    public static class ApplicationMap
    {
        public static readonly EntityMap<LevelOfRisk> LevelsOfRisk =
            new EntityMap<LevelOfRisk>(id => ApplicationDataMappers.LevelsOfRiskDM.GetByID(id),
                ApplicationDataMappers.LevelsOfRiskDM.Update, 
                ApplicationDataMappers.LevelsOfRiskDM.Insert,
                ApplicationDataMappers.LevelsOfRiskDM.Delete);

        public static readonly EntityMap<OutsideOrg> OutsideOrg =
            new EntityMap<OutsideOrg>(id => ApplicationDataMappers.OutsideOrgDM.GetByID(id),
                ApplicationDataMappers.OutsideOrgDM.Update,
                ApplicationDataMappers.OutsideOrgDM.Insert,
                ApplicationDataMappers.OutsideOrgDM.Delete);

        public static readonly EntityMap<OutsideEmp> OutsideEmp =
            new EntityMap<OutsideEmp>(id => ApplicationDataMappers.OutsideEmpDM.GetByID(id),
                ApplicationDataMappers.OutsideEmpDM.Update,
                ApplicationDataMappers.OutsideEmpDM.Insert,
                ApplicationDataMappers.OutsideEmpDM.Delete);

        public static readonly EntityMap<ContentStatus> ContentStatus =
            new EntityMap<ContentStatus>(id => ApplicationDataMappers.ContentStatusDM.GetByID(id),
                ApplicationDataMappers.ContentStatusDM.Update,
                ApplicationDataMappers.ContentStatusDM.Insert,
                ApplicationDataMappers.ContentStatusDM.Delete);
      
        public static readonly EntityMap<Plan> Plan =
            new EntityMap<Plan>(id => ApplicationDataMappers.PlanDM.GetByID(id),
                ApplicationDataMappers.PlanDM.Update,
                ApplicationDataMappers.PlanDM.Insert,
                ApplicationDataMappers.PlanDM.Delete);

        public static readonly EntityMap<PlanContent> PlanContent =
            new EntityMap<PlanContent>(id => ApplicationDataMappers.PlanContentDM.GetByID(id),
                ApplicationDataMappers.PlanContentDM.Update,
                ApplicationDataMappers.PlanContentDM.Insert,
                ApplicationDataMappers.PlanContentDM.Delete);
    }
}
