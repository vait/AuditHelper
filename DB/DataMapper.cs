using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AuditHelper.Classes;

namespace AuditHelper.DB
{
    internal interface IDataMapper<T> where T : Entity
    {
        T GetByID(int aId);
        int Insert(T aEntity);
        bool Delete(T aEntity);
        bool Update(T aEntity);
    }

    internal interface IDataMapperDictionary<T> : IDataMapper<T> where T : SimpleEntity
    {
        List<int> GetAllIDs();
    }

    static class ApplicationDataMappers
    {
        public static readonly LevelOfRiskDM LevelsOfRiskDM = new LevelOfRiskDM();
        public static readonly OutsideOrgDM OutsideOrgDM = new OutsideOrgDM();
        public static readonly OutsideEmpDM OutsideEmpDM = new OutsideEmpDM();
        public static readonly ContentStatusDM ContentStatusDM = new ContentStatusDM();
        public static readonly PlanDM PlanDM = new PlanDM();
        public static readonly PlanContentDM PlanContentDM = new PlanContentDM();
    }


}
