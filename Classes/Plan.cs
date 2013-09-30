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
        public List<int> Content
        {
            get
            {
                return this._content;
            }
        }

        public PlanContent this[int index]
        {
            get
            {
                if (_content.Contains(index) )
                {
                    return ApplicationMap.PlanContent[index];
                }

                return null;
            }
            set
            {
                ApplicationMap.PlanContent[index] = value;
                if (value.Id == -1)
                    //Загружаем индексы 
                    this._content = ApplicationDataMappers.PlanContentDM.GetAllIDs(this.Id);

                this.Update(value);
            }
        }
        /// <summary>
        /// Remove Content by ID
        /// </summary>
        /// <param name="index">if -1 then remove all content</param>
        public void DeleteContent(int index)
        {
            //Удаляем сам план
            if (_content.Contains(index))
            {
                ApplicationMap.PlanContent.Delete(ApplicationMap.PlanContent[index]);
                _content.Remove(index);
            }

            if (index == -1)
            {
                foreach(int i in this._content)
                    ApplicationMap.PlanContent.Delete(ApplicationMap.PlanContent[i]);

                _content.Clear();
            }
        }

        private void Update(PlanContent aContent)
        {
            //Проверяем дату окончания (EndDate)
            if (aContent.Expired > this.EndDate)
                this._endDate = aContent.Expired;

            //Проверяем даты завершения
            if (aContent.StatusId == -1)
                if (aContent.Expired < this.NearestDate)
                    this._nearestDate = aContent.Expired;
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

            //Загружаем индексы 
            this._content = ApplicationDataMappers.PlanContentDM.GetAllIDs(this.Id);
        }

    }
}
