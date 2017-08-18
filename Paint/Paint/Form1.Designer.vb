<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.X = New System.Windows.Forms.Label()
        Me.Y = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ColorSelect = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'X
        '
        Me.X.AutoSize = True
        Me.X.Cursor = System.Windows.Forms.Cursors.Help
        Me.X.Location = New System.Drawing.Point(3, 0)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(39, 13)
        Me.X.TabIndex = 0
        Me.X.Text = "Label1"
        '
        'Y
        '
        Me.Y.AutoSize = True
        Me.Y.Cursor = System.Windows.Forms.Cursors.Help
        Me.Y.Location = New System.Drawing.Point(3, 13)
        Me.Y.Name = "Y"
        Me.Y.Size = New System.Drawing.Size(39, 13)
        Me.Y.TabIndex = 1
        Me.Y.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.ColorSelect)
        Me.Panel1.Controls.Add(Me.X)
        Me.Panel1.Controls.Add(Me.Y)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 58)
        Me.Panel1.TabIndex = 2
        '
        'ColorSelect
        '
        Me.ColorSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColorSelect.Location = New System.Drawing.Point(65, 12)
        Me.ColorSelect.Name = "ColorSelect"
        Me.ColorSelect.Size = New System.Drawing.Size(180, 41)
        Me.ColorSelect.TabIndex = 4
        Me.ColorSelect.Text = "Select a Color..."
        Me.ColorSelect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 464)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Name = "Form1"
        Me.Text = "Paint"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents X As Label
    Friend WithEvents Y As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ColorSelect As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
