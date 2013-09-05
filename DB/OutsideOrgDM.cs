using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AuditHelper.Classes;

namespace AuditHelper.DB
{
    internal class OutsideOrgDM : IDataMapperDictionary<OutsideOrg>
    {
        private auditHelperDataSetTableAdapters.tbl_OutsideOrgTableAdapter _adapter = new auditHelperDataSetTableAdapters.tbl_OutsideOrgTableAdapter();

        public OutsideOrg GetByID(int aId)
        {
            OutsideOrg tmp = null;
            auditHelperDataSet.tbl_OutsideOrgDataTable _tbl = null;

            _tbl = _adapter.GetDataByID(aId);
            if (_tbl.Rows.Count == 1)
            {
                tmp = new OutsideOrg(_tbl[0].vch_full_name, _tbl[0].vch_short_name, _tbl[0].org_id);
            }

            return tmp;
        }

        public List<int> GetAllIDs()
        {
            List<int> _tmp = new List<int>();
            auditHelperDataSet.tbl_OutsideOrgDataTable _tbl = null;

            _tbl = _adapter.GetAllIDs();
            foreach (auditHelperDataSet.tbl_OutsideOrgRow rw in _tbl)
            {
                _tmp.Add(rw.org_id);
            }

            return _tmp;
        }

        public int Insert(OutsideOrg aEntity)
        {

            if (_adapter.Insert(aEntity.FullName, aEntity.Name) != 1)
                return -1;

            return (int)_adapter.GetLastID();
        }

        public bool Delete(OutsideOrg aEntity)
        {
            if (aEntity == null)
                return false;

            if (_adapter.Delete(aEntity.Id) >= 1)
                return true;

            return false;
        }

        public bool Update(OutsideOrg aEntity)
        {
            if (aEntity == null)
                return false;

            OutsideOrg tmp = aEntity;

            if (_adapter.Update(tmp.FullName, tmp.Name, tmp.Id) > 1)
                return true;
            return false;
        }

    }
}
