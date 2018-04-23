Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo
Imports System.ComponentModel

Namespace XPOReport
    Friend Class XpoBaseReport
        Inherits XtraReport

        Public Sub New()
            MyBase.New()
            Bands.Add(New DevExpress.XtraReports.UI.DetailBand())
        End Sub
        Public Sub New(ByVal session As Session)
            Me.New()
            _XpoSession = session
        End Sub

        Private Sub CreateDataSource()
            If XpoSession IsNot Nothing Then
                Dim xpoType As Type = Type.GetType(XpoClassName, True)
                DataSource = New XPCollection(XpoSession, XpoSession.GetClassInfo(xpoType))
            End If
        End Sub

        Private _XpoSession As Session
        <Browsable(False)> _
        Public Property XpoSession() As Session
            Get
                Return _XpoSession
            End Get
            Set(ByVal value As Session)
                _XpoSession = value
                CreateDataSource()
            End Set
        End Property

        Private _XpoClassName As String
        Public Property XpoClassName() As String
            Get
                Return _XpoClassName
            End Get
            Set(ByVal value As String)
                If _XpoClassName <> value Then
                    _XpoClassName = value
                    CreateDataSource()
                End If
            End Set
        End Property

        Protected Overrides Sub SerializeProperties(ByVal serializer As DevExpress.XtraReports.Serialization.XRSerializer)
            MyBase.SerializeProperties(serializer)
            serializer.SerializeString("XpoClassName", XpoClassName)
        End Sub
        Protected Overrides Sub DeserializeProperties(ByVal serializer As DevExpress.XtraReports.Serialization.XRSerializer)
            MyBase.DeserializeProperties(serializer)
            XpoClassName = serializer.DeserializeString("XpoClassName", "")
        End Sub
    End Class
End Namespace
