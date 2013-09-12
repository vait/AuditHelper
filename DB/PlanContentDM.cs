using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AuditHelper.Classes;

namespace AuditHelper.DB
{
    internal class PlanContentDM : IDataMapperDictionary<PlanContent>
    {
        private auditHelperDataSetTableAdapters.tbl_Plan_ContentTableAdapter _adapter = new auditHelperDataSetTableAdapters.tbl_Plan_ContentTableAdapter();

        public PlanContent GetByID(int aId)
        {
            PlanContent tmp = null;
            auditHelperDataSet.tbl_Plan_ContentDataTable _tbl = null;

            _tbl = _adapter.GetDataByID(aId);

            if (_tbl.Rows.Count == 1)
            {
                tmp = new PlanContent(_tbl[0].Isparent_idNull() ? -1 : _tbl[0].parent_id, 
                    _tbl[0].vch_recomendation,
                    _tbl[0].vch_correct_actions, _tbl[0].employee_ID,
                    _tbl[0].dtm_expired, _tbl[0].vch_comments, _tbl[0].risk_id, 
                    _tbl[0].Isstatus_idNull() ? -1 :_tbl[0].status_id, 
                    _tbl[0].vch_number, _tbl[0].content_id);
            }

            return tmp;
        }

        public List<int> GetAllIDs() { return null; }

        public List<int> GetAllIDs(int aPlanID)
        {
            List<int> _tmp = new List<int>();
            auditHelperDataSet.tbl_Plan_ContentDataTable _tbl = null;

            _tbl = _adapter.GetAllIDs(aPlanID);
            foreach (auditHelperDataSet.tbl_Plan_ContentRow rw in _tbl)
            {
                _tmp.Add(rw.content_id);
            }

            return _tmp;
        }

        public int Insert(PlanContent aEntity)
        {

            if (_adapter.Insert(
                aEntity.PlanId, aEntity.ParentId == -1?null:(int?)aEntity.ParentId, aEntity.Name,
                aEntity.Recomendation, aEntity.CorrectActions, aEntity.EmployeeId,
                aEntity.Expired, aEntity.Comments, aEntity.RiskId,
                aEntity.StatusId == -1 ? null : (int?)aEntity.StatusId) != 1)
                return -1;

            return (int)_adapter.GetLastID();
        }

        public bool Delete(PlanContent aEntity)
        {
            if (aEntity == null)
                return false;

            if (_adapter.Delete(aEntity.Id) >= 1)
                return true;

            return false;
        }

        public bool Update(PlanContent aEntity)
        {
            if (aEntity == null)
                return false;

            PlanContent tmp = aEntity;

            if (_adapter.Update(aEntity.PlanId, aEntity.ParentId == -1 ? null : (int?)aEntity.ParentId, aEntity.Name,
                aEntity.Recomendation, aEntity.CorrectActions, aEntity.EmployeeId,
                aEntity.Expired, aEntity.Comments, aEntity.RiskId,
                aEntity.StatusId == -1 ? null : (int?)aEntity.StatusId, aEntity.Id) > 1)
                return true;

            return false;
        }

    }
}
