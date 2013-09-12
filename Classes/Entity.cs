using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuditHelper.Classes
{
    public abstract class Entity
    {
        private readonly int _id = -1;

        public int Id
        {
            get { return _id; }
        }

        internal Entity(int id = -1)
        {
            _id = id;
        }

        public override bool Equals(object obj)
        {
            return obj is Entity ? this._id.Equals((obj as Entity).Id) : false;
        }

        public override int GetHashCode()
        {
            return this._id.GetHashCode();
        }
    }

    public class SimpleEntity : Entity
    {
        private string _name = "";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        internal SimpleEntity(string aName, int aId = -1)
            : base(aId)
        {
            _name = aName.Trim();
        }

        public override string ToString()
        {
            return this._name;
        }

        public static int CompareSimpleEntities(SimpleEntity x, SimpleEntity y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
