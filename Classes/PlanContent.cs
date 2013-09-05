using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuditHelper.Classes
{
    public class PlanContent : SimpleEntity
    {
        public PlanContent(string aName, int aId = -1)
            : base(aName, aId) { }
    }
}
