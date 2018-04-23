Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo
Imports DevExpress.XtraReports.UserDesigner

Namespace XPOReport
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnOpenEud_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpenEud.Click
            Dim designer As New DevExpress.XtraReports.UserDesigner.XRDesignFormEx()
            AddHandler designer.DesignPanel.Activated, AddressOf DesignPanel_Activated
            designer.Show()
        End Sub

        Private Sub DesignPanel_Activated(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport = DirectCast(sender, XRDesignPanel).Report
            If TypeOf report Is XpoBaseReport Then
                DirectCast(report, XpoBaseReport).XpoSession = New UnitOfWork()
            End If
        End Sub

        Private Sub btnNewXpoReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewXpoReport.Click
            Dim report As New XpoBaseReport(New UnitOfWork())
            report.XpoClassName = "XPOReport.Customer"
            report.ShowDesignerDialog()
        End Sub
    End Class
End Namespace