<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " Hours of labor:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Cost of parts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   and supplies:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(123, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(216, 20)
        Me.txtName.TabIndex = 2
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(132, 51)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(84, 20)
        Me.txtLabor.TabIndex = 3
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(132, 77)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(84, 20)
        Me.txtParts.TabIndex = 4
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(264, 52)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 45)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bill"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(39, 114)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(300, 134)
        Me.lstDisplay.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 261)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.txtLabor)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Auto Repair                                           "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lstDisplay As ListBox
End Class
