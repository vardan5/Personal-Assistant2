<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test123xyz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.test123B = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'test123B
        '
        Me.test123B.Location = New System.Drawing.Point(269, 158)
        Me.test123B.Name = "test123B"
        Me.test123B.Size = New System.Drawing.Size(176, 76)
        Me.test123B.TabIndex = 0
        Me.test123B.Text = "Button1"
        Me.test123B.UseVisualStyleBackColor = True
        '
        'test123xyz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.test123B)
        Me.Name = "test123xyz"
        Me.Text = "test123xyz"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents test123B As Button
End Class
