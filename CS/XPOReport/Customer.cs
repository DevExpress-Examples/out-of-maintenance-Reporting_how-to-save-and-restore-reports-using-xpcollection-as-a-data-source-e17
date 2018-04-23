using System;
using DevExpress.Xpo;

namespace XPOReport {
    public class Customer : XPObject {
        public Customer(Session session)
            : base(session) {
        }

        string _name;
        public string Name {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

        int _age;
        public int Age {
            get { return _age; }
            set { SetPropertyValue("Age", ref _age, value); }
        }
    }
}