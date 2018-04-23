using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.XtraReports.UserDesigner;

namespace XPOReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnOpenEud_Click(object sender, EventArgs e)
        {
            DevExpress.XtraReports.UserDesigner.XRDesignFormEx designer = new DevExpress.XtraReports.UserDesigner.XRDesignFormEx();
            designer.DesignPanel.Activated += new EventHandler(DesignPanel_Activated);
            designer.Show();
        }

        void DesignPanel_Activated(object sender, EventArgs e) {
            XtraReport report = ((XRDesignPanel)sender).Report;
            if(report is XpoBaseReport) {
                ((XpoBaseReport)report).XpoSession = new UnitOfWork();
            }
        }

        private void btnNewXpoReport_Click(object sender, EventArgs e) {
            XpoBaseReport report = new XpoBaseReport(new UnitOfWork());
            report.XpoClassName = "XPOReport.Customer";
            report.ShowDesignerDialog();
        }
    }
}