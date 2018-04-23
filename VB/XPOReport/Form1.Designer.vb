Namespace XPOReport
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.btnOpenEud = New System.Windows.Forms.Button()
            Me.btnNewXpoReport = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' btnOpenEud
            ' 
            Me.btnOpenEud.Location = New System.Drawing.Point(12, 12)
            Me.btnOpenEud.Name = "btnOpenEud"
            Me.btnOpenEud.Size = New System.Drawing.Size(180, 23)
            Me.btnOpenEud.TabIndex = 1
            Me.btnOpenEud.Text = "Open End-User Report Designer..."
            Me.btnOpenEud.UseVisualStyleBackColor = True
            ' 
            ' btnNewXpoReport
            ' 
            Me.btnNewXpoReport.Location = New System.Drawing.Point(12, 41)
            Me.btnNewXpoReport.Name = "btnNewXpoReport"
            Me.btnNewXpoReport.Size = New System.Drawing.Size(180, 23)
            Me.btnNewXpoReport.TabIndex = 0
            Me.btnNewXpoReport.Text = "Design New Xpo Report..."
            Me.btnNewXpoReport.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(205, 79)
            Me.Controls.Add(Me.btnOpenEud)
            Me.Controls.Add(Me.btnNewXpoReport)
            Me.Name = "Form1"
            Me.Text = "Xpo Report Demo"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents btnOpenEud As System.Windows.Forms.Button
        Private WithEvents btnNewXpoReport As System.Windows.Forms.Button

    End Class
End Namespace

