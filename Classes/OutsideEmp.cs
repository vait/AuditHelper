using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuditHelper.Classes
{
    public class OutsideEmp : SimpleEntity
    {
        private string _lastName = "";

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _middleName = "";

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }
        private string _postName = "";

        public string PostName
        {
            get { return _postName; }
            set { _postName = value; }
        }
        private int _orgID = -1;

        public int OrgID
        {
            get { return _orgID; }
            set { _orgID = value; }
        }

        public OutsideEmp(int aOrgID, string aPostName, string aLastName, string aName, string aMiddleName = "", int aId = -1)
            : base(aName, aId) 
        {
            if (aOrgID < 0 || String.IsNullOrEmpty(aPostName.Trim()) ||
                String.IsNullOrEmpty(aLastName.Trim()))
                throw new Exception("Передано пустое значение одного или нескольких параметров");

            this._lastName = aLastName;
            this._middleName = aMiddleName;
            this._orgID = aOrgID;
            this._postName = aPostName;        
        }

        public override string ToString()
        {
            return this.Name + (!String.IsNullOrEmpty(this.MiddleName) ? " " + this.MiddleName : "") +
                " " + this.LastName;
        }

        public string GetPostFIO()
        {
            return this.Name + (!String.IsNullOrEmpty(this.MiddleName) ? " " + this.MiddleName : "") + 
                " " + this.LastName + " [" + this.PostName + "] ";
        }

    }
}
