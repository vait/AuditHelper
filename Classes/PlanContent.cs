using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuditHelper.Classes
{
    public class PlanContent : SimpleEntity
    {
        private int _parentId = -1;
        public int ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
        }

        private string _recomendation = "";
        public string Recomendation
        {
            get { return _recomendation; }
            set { _recomendation = value; }
        }

        private string _correctActions = "";
        public string CorrectActions
        {
            get { return _correctActions; }
            set { _correctActions = value; }
        }

        private int _employeeId = -1;
        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        private DateTime _expired = DateTime.MaxValue;
        public DateTime Expired
        {
            get { return _expired; }
            set { _expired = value; }
        }

        private string _comments = "";
        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        private int _riskId = -1;
        public int RiskId
        {
            get { return _riskId; }
            set { _riskId = value; }
        }

        private int _statusId = -1;
        public int StatusId
        {
            get { return _statusId; }
            set { _statusId = value; }
        }

        private int _planId = -1;
        public int PlanId
        {
            get { return _planId; }
        }

        public PlanContent(int aParentId, string aRecomendation, string aCorrectActions,
            int aEmployeeId, DateTime aExpired, string aComments, int aRiskId,
            int aStatusId, string aName, int aId = -1) : base(aName, aId) 
        {
            this._parentId = aParentId;
            this._recomendation = aRecomendation;
            this._correctActions = aCorrectActions;
            this._employeeId = aEmployeeId;
            this._expired = aExpired;
            this._comments = aComments;

        
        }
    }
}
