using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using System.ComponentModel;

namespace XPOReport {
    class XpoBaseReport : XtraReport {
        public XpoBaseReport()
            : base() {
            Bands.Add(new DevExpress.XtraReports.UI.DetailBand());
        }
        public XpoBaseReport(Session session)
            : this() {
            _XpoSession = session;
        }

        private void CreateDataSource() {
            if(XpoSession != null) {
                Type xpoType = Type.GetType(XpoClassName, true);
                DataSource = new XPCollection(XpoSession, XpoSession.GetClassInfo(xpoType));
            }
        }

        private Session _XpoSession;
        [Browsable(false)]
        public Session XpoSession {
            get {
                return _XpoSession;
            }
            set {
                _XpoSession = value;
                CreateDataSource();
            }
        }

        private string _XpoClassName;
        public string XpoClassName {
            get { return _XpoClassName; }
            set {
                if(_XpoClassName != value) {
                    _XpoClassName = value;
                    CreateDataSource();
                }
            }
        }

        protected override void SerializeProperties(DevExpress.XtraReports.Serialization.XRSerializer serializer) {
            base.SerializeProperties(serializer);
            serializer.SerializeString("XpoClassName", XpoClassName);
        }
        protected override void DeserializeProperties(DevExpress.XtraReports.Serialization.XRSerializer serializer) {
            base.DeserializeProperties(serializer);
            XpoClassName = serializer.DeserializeString("XpoClassName", "");
        }
    }
}
