using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AuditHelper.Classes;

namespace AuditHelper.DB
{
    internal class PlanDM : IDataMapperDictionary<Plan>
    {
        private auditHelperDataSetTableAdapters.tbl_PlanTableAdapter _adapter = new auditHelperDataSetTableAdapters.tbl_PlanTableAdapter();
        private auditHelperDataSetTableAdapters.tbl_PlanCoordinateTableAdapter _adapterPC = new auditHelperDataSetTableAdapters.tbl_PlanCoordinateTableAdapter();

        public Plan GetByID(int aId)
        {
            Plan tmp = null;
            auditHelperDataSet.tbl_PlanDataTable _tbl = null;
            auditHelperDataSet.tbl_PlanCoordinateDataTable _tblPC = null;

            _tbl = _adapter.GetDataByID(aId);
            _tblPC = _adapterPC.GetDataByID(aId);
            if (_tbl.Rows.Count == 1 && _tblPC.Rows.Count > 0)
            {
                tmp = new Plan(_tbl[0].vch_name,
                    _tblPC[0].employee_ID,
                    _tblPC.Rows.Count > 1 ? _tblPC[1].employee_ID : -1,
                    _tblPC.Rows.Count > 2 ? _tblPC[2].employee_ID : -1, 
                    _tbl[0].org_id);
            }

            return tmp;
        }

       /* public List<int> GetSomeIDs(int aStart, int aCount)
        {
            List<int> _tmp = new List<int>();
            auditHelperDataSet.tbl_PlanDataTable _tbl = null;

            if (aCount < 1)
                _tbl = _adapter.GetSomeIDs(aStart, aCount);
            else
                _tbl = _adapter.GetAllIDs();

            foreach (auditHelperDataSet.tbl_PlanRow rw in _tbl)
            {
                _tmp.Add(rw.org_id);
            }

            return _tmp;
        }*/

        public List<int> GetAllIDs()
        {
            List<int> _tmp = new List<int>();
            auditHelperDataSet.tbl_PlanDataTable _tbl = null;

            _tbl = _adapter.GetAllIDs();

            foreach (auditHelperDataSet.tbl_PlanRow rw in _tbl)
            {
                _tmp.Add(rw.plan_id);
            }

            return _tmp;
        }

        public int Insert(Plan aEntity)
        {

            if (_adapter.Insert(aEntity.Name, aEntity.Org) != 1)
                return -1;

            _adapterPC.Insert(aEntity.Employee1ID, aEntity.Id);
            if (aEntity.Employee2ID != -1)
                _adapterPC.Insert(aEntity.Employee2ID, aEntity.Id);
            if (aEntity.Employee3ID != -1)
                _adapterPC.Insert(aEntity.Employee3ID, aEntity.Id);

            return (int)_adapter.GetLastID();
        }

        public bool Delete(Plan aEntity)
        {
            if (aEntity == null)
                return false;

            if (_adapterPC.Delete(aEntity.Id) < 1)
                return false;

            if (_adapter.Delete(aEntity.Id) >= 1)
                return true;

            return false;
        }


    }
}
