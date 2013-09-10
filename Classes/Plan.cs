using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AuditHelper.DB;

namespace AuditHelper.Classes
{

    public class Plan : SimpleEntity
    {
        private int _employee1ID = -1;
        public int Employee1ID
        {
            get { return _employee1ID; }
            set { _employee1ID = value; }
        }

        private int _employee2ID = -1;
        public int Employee2ID
        {
            get { return _employee2ID; }
            set { _employee2ID = value; }
        }

        private int _employee3ID = -1;
        public int Employee3ID
        {
            get { return _employee3ID; }
            set { _employee3ID = value; }
        }

        private int _org = -1;
        public int OrgID
        {
            get { return _org; }
            set { _org = value; }
        }

        private DateTime _nearestDate = DateTime.MaxValue;
        public DateTime NearestDate
        {
            get { return _nearestDate; }
        }

        private DateTime _endDate = DateTime.MinValue;
        public DateTime EndDate
        {
            get { return _endDate; }
        }

        private List<int> _content = new List<int>();

        public PlanContent this[int index]
        {
            get
            {
/*                if (_content.Contains(index))
                {
                    return ApplicationMap.PlanContent[index];

                }*/
                return null;
            }
            set
            {
                this.Update();
            }
        }

        private void Update()
        {
         /*   DateTime minDate = DateTime.MaxValue;
            foreach (int id in this._content)
                if (ApplicationMap.PlanContent[index].ExpiredDate < minDate && ApplicationMap.PlanContent[index].Status == -1)
                    minDate = ApplicationMap.PlanContent[index].ExpiredDate;

            this._nearestDate = minDate;*/
        }
        
        public Plan(string aName, int aEmployee1, int aEmployee2, int aEmployee3, 
            int aOrg, DateTime aNearestDate, DateTime aEndDate, int aId = -1)
            : base(aName, aId) 
        {
            this._employee1ID = aEmployee1;
            this._employee2ID = aEmployee2;
            this._employee3ID = aEmployee3;
            this._org = aOrg;
            this._nearestDate = aNearestDate;
            this._endDate = aEndDate;
        }        
    }
}
