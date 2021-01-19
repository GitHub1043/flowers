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
        Me.lblFlowers = New System.Windows.Forms.Label()
        Me.txtFlowers = New System.Windows.Forms.TextBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFlowers
        '
        Me.lblFlowers.AutoSize = True
        Me.lblFlowers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowers.Location = New System.Drawing.Point(12, 37)
        Me.lblFlowers.Name = "lblFlowers"
        Me.lblFlowers.Size = New System.Drawing.Size(107, 16)
        Me.lblFlowers.TabIndex = 0
        Me.lblFlowers.Text = "Flowers to order:"
        '
        'txtFlowers
        '
        Me.txtFlowers.Location = New System.Drawing.Point(145, 37)
        Me.txtFlowers.Name = "txtFlowers"
        Me.txtFlowers.Size = New System.Drawing.Size(100, 20)
        Me.txtFlowers.TabIndex = 1
        '
        'btnCost
        '
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(12, 99)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(75, 26)
        Me.btnCost.TabIndex = 2
        Me.btnCost.Text = "Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(12, 171)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(38, 16)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Cost:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "I Wasn't Here For This Program"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 446)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.txtFlowers)
        Me.Controls.Add(Me.lblFlowers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFlowers As System.Windows.Forms.Label
    Friend WithEvents txtFlowers As System.Windows.Forms.TextBox
    Friend WithEvents btnCost As System.Windows.Forms.Button
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
