using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuditHelper.Classes
{
    public class OutsideOrg : SimpleEntity
    {
        private string _fullName = "";
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }


        public OutsideOrg(string aFullName, string aName, int aId = -1)
            : base(aName, aId) 
        {
            if (String.IsNullOrEmpty(aFullName.Trim()))
                this._fullName = aName.Trim();
            else
                this._fullName = aFullName.Trim();
        
        }

        public override string ToString()
        {
            return this._fullName;
        }
    }

}
