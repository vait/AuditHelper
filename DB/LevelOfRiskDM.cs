using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AuditHelper.Classes;

namespace AuditHelper.DB
{
    internal class LevelOfRiskDM : IDataMapperDictionary<LevelOfRisk>
    {
        private auditHelperDataSetTableAdapters.tbl_Levels_of_RiskTableAdapter _adapter = new auditHelperDataSetTableAdapters.tbl_Levels_of_RiskTableAdapter();

        public LevelOfRisk GetByID(int aId)
        {
            LevelOfRisk tmp = null;
            auditHelperDataSet.tbl_Levels_of_RiskDataTable _tbl = null;

            _tbl = _adapter.GetDataByID(aId);
            if (_tbl.Rows.Count == 1)
            {
                tmp = new LevelOfRisk(_tbl[0].vch_name, _tbl[0].risk_id);
            }

            return tmp;
        }

        public List<int> GetAllIDs()
        {
            List<int> _tmp = new List<int>();
            auditHelperDataSet.tbl_Levels_of_RiskDataTable _tbl = null;

            _tbl = _adapter.GetAllIDs();
            foreach (auditHelperDataSet.tbl_Levels_of_RiskRow rw in _tbl)
            {
                _tmp.Add(rw.risk_id);
            }

            return _tmp;
        }

        public int Insert(LevelOfRisk aEntity)
        {

            if (_adapter.Insert(aEntity.Name) != 1)
                return -1;

            return (int)_adapter.GetLastID();
        }

        public bool Delete(LevelOfRisk aEntity)
        {
            if (aEntity == null)
                return false;

            LevelOfRisk tmp = aEntity;

            if (_adapter.Delete(tmp.Id) >= 1)
                return true;
            return false;
        }

        public bool Update(LevelOfRisk aEntity)
        {
            if (aEntity == null)
                return false;

            LevelOfRisk tmp = aEntity;

            if (_adapter.Update(tmp.Name, tmp.Id) > 1)
                return true;
            return false;
        }
    }

}
