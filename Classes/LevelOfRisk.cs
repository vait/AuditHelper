using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AuditHelper.DB.auditHelperDataSetTableAdapters;

namespace AuditHelper.Classes
{
    public class LevelOfRisk : SimpleEntity
    {
        public LevelOfRisk(string aName, int aId = -1) : base(aName, aId) { }
    }
}
