using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AuditHelper.Classes;

namespace AuditHelper.DB
{
    internal class ContentStatusDM : IDataMapperDictionary<ContentStatus>
    {
        private auditHelperDataSetTableAdapters.tbl_Content_StatusTableAdapter _adapter = new auditHelperDataSetTableAdapters.tbl_Content_StatusTableAdapter();

        public ContentStatus GetByID(int aId)
        {
            ContentStatus tmp = null;
            auditHelperDataSet.tbl_Content_StatusDataTable _tbl = null;

            _tbl = _adapter.GetDataByID(aId);
            if (_tbl.Rows.Count == 1)
            {
                tmp = new ContentStatus(_tbl[0].vch_name, _tbl[0].status_id);
            }

            return tmp;
        }

        public List<int> GetAllIDs()
        {
            List<int> _tmp = new List<int>();
            auditHelperDataSet.tbl_Content_StatusDataTable _tbl = null;

            _tbl = _adapter.GetAllIDs();
            foreach (auditHelperDataSet.tbl_Content_StatusRow rw in _tbl)
            {
                _tmp.Add(rw.status_id);
            }

            return _tmp;
        }

        public int Insert(ContentStatus aEntity)
        {

            if (_adapter.Insert(aEntity.Name) != 1)
                return -1;

            return (int)_adapter.GetLastID();
        }

        public bool Delete(ContentStatus aEntity)
        {
            if (aEntity == null)
                return false;

            ContentStatus tmp = aEntity;

            if (_adapter.Delete(tmp.Id) >= 1)
                return true;
            return false;
        }

        public bool Update(ContentStatus aEntity)
        {
            if (aEntity == null)
                return false;

            ContentStatus tmp = aEntity;

            if (_adapter.Update(tmp.Name, tmp.Id) > 1)
                return true;
            return false;
        }
    }
}
