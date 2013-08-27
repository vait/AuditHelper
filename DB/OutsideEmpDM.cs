using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AuditHelper.Classes;

namespace AuditHelper.DB
{
    internal class OutsideEmpDM : IDataMapperDictionary<OutsideEmp>
    {
        private auditHelperDataSetTableAdapters.tbl_OutsideEmployeeTableAdapter _adapter = new auditHelperDataSetTableAdapters.tbl_OutsideEmployeeTableAdapter();

        public OutsideEmp GetByID(int aId)
        {
            OutsideEmp tmp = null;
            auditHelperDataSet.tbl_OutsideEmployeeDataTable _tbl = null;

            _tbl = _adapter.GetDataByID(aId);
            if (_tbl.Rows.Count == 1)
            {
                tmp = new OutsideEmp(_tbl[0].org_id, _tbl[0].vch_post, _tbl[0].vch_last_name,
                    _tbl[0].vch_first_name, (_tbl[0].Isvch_middle_nameNull() ? "" : _tbl[0].vch_middle_name), _tbl[0].employee_ID);
            }

            return tmp;
        }

        public List<int> GetAllIDs()
        {
            List<int> _tmp = new List<int>();
            auditHelperDataSet.tbl_OutsideEmployeeDataTable _tbl = null;

            _tbl = _adapter.GetAllIDs();
            foreach (auditHelperDataSet.tbl_OutsideEmployeeRow rw in _tbl)
            {
                _tmp.Add(rw.employee_ID);
            }

            return _tmp;
        }

        public int Insert(OutsideEmp aEntity)
        {

            if (_adapter.Insert(aEntity.Name, aEntity.LastName, aEntity.MiddleName, aEntity.PostName, aEntity.OrgID) != 1)
                return -1;

            return (int)_adapter.GetLastID();
        }

        public bool Delete(OutsideEmp aEntity)
        {
            if (aEntity == null)
                return false;

            OutsideEmp tmp = aEntity;

            if (_adapter.Delete(tmp.Id) >= 1)
                return true;
            return false;
        }

        public bool Update(OutsideEmp aEntity)
        {
            if (aEntity == null)
                return false;

            OutsideEmp tmp = aEntity;

            if (_adapter.Update(tmp.Name, tmp.LastName, tmp.MiddleName, tmp.PostName, tmp.OrgID, tmp.Id) > 1)
                return true;
            return false;
        }
    }
}
