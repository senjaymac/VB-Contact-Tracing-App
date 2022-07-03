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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpbxTitle = New System.Windows.Forms.GroupBox()
        Me.lblContactTraceForm = New System.Windows.Forms.Label()
        Me.lblPleaseFillUp = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(183, 138)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(366, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 100)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'grpbxTitle
        '
        Me.grpbxTitle.Controls.Add(Me.lblPleaseFillUp)
        Me.grpbxTitle.Controls.Add(Me.lblContactTraceForm)
        Me.grpbxTitle.Controls.Add(Me.PictureBox1)
        Me.grpbxTitle.Location = New System.Drawing.Point(56, 32)
        Me.grpbxTitle.Name = "grpbxTitle"
        Me.grpbxTitle.Size = New System.Drawing.Size(483, 100)
        Me.grpbxTitle.TabIndex = 2
        Me.grpbxTitle.TabStop = False
        '
        'lblContactTraceForm
        '
        Me.lblContactTraceForm.AutoSize = True
        Me.lblContactTraceForm.Font = New System.Drawing.Font("Franklin Gothic Demi", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactTraceForm.Location = New System.Drawing.Point(29, 27)
        Me.lblContactTraceForm.Name = "lblContactTraceForm"
        Me.lblContactTraceForm.Size = New System.Drawing.Size(319, 37)
        Me.lblContactTraceForm.TabIndex = 3
        Me.lblContactTraceForm.Text = "Contact Tracing Form"
        '
        'lblPleaseFillUp
        '
        Me.lblPleaseFillUp.AutoSize = True
        Me.lblPleaseFillUp.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleaseFillUp.Location = New System.Drawing.Point(26, 64)
        Me.lblPleaseFillUp.Name = "lblPleaseFillUp"
        Me.lblPleaseFillUp.Size = New System.Drawing.Size(322, 21)
        Me.lblPleaseFillUp.TabIndex = 4
        Me.lblPleaseFillUp.Text = "* Please Fill up the informations correctly *"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 471)
        Me.Controls.Add(Me.grpbxTitle)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB - Contact Tracing App"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxTitle.ResumeLayout(False)
        Me.grpbxTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpbxTitle As GroupBox
    Friend WithEvents lblPleaseFillUp As Label
    Friend WithEvents lblContactTraceForm As Label
End Class
