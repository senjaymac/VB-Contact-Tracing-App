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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtboxFirstName = New System.Windows.Forms.TextBox()
        Me.txtbxLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtbxAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtbxAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxTitle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(53, 182)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name:"
        '
        'txtboxFirstName
        '
        Me.txtboxFirstName.Location = New System.Drawing.Point(119, 179)
        Me.txtboxFirstName.Name = "txtboxFirstName"
        Me.txtboxFirstName.Size = New System.Drawing.Size(170, 20)
        Me.txtboxFirstName.TabIndex = 4
        '
        'txtbxLastName
        '
        Me.txtbxLastName.Location = New System.Drawing.Point(361, 179)
        Me.txtbxLastName.Name = "txtbxLastName"
        Me.txtbxLastName.Size = New System.Drawing.Size(170, 20)
        Me.txtbxLastName.TabIndex = 6
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(295, 182)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name:"
        '
        'txtbxAddress
        '
        Me.txtbxAddress.Location = New System.Drawing.Point(152, 210)
        Me.txtbxAddress.Name = "txtbxAddress"
        Me.txtbxAddress.Size = New System.Drawing.Size(275, 20)
        Me.txtbxAddress.TabIndex = 8
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(53, 213)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(95, 13)
        Me.lblAddress.TabIndex = 7
        Me.lblAddress.Text = "Complete Address:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(449, 213)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age:"
        '
        'txtbxAge
        '
        Me.txtbxAge.Location = New System.Drawing.Point(484, 210)
        Me.txtbxAge.Name = "txtbxAge"
        Me.txtbxAge.Size = New System.Drawing.Size(47, 20)
        Me.txtbxAge.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Gender:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(54, 14)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(96, 14)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 42)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(304, 249)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 16
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(217, 252)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblPhoneNumber.TabIndex = 15
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(484, 249)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(47, 20)
        Me.TextBox2.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Temperature:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 471)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtbxAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtbxAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtbxLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtboxFirstName)
        Me.Controls.Add(Me.lblFirstName)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpbxTitle As GroupBox
    Friend WithEvents lblPleaseFillUp As Label
    Friend WithEvents lblContactTraceForm As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtboxFirstName As TextBox
    Friend WithEvents txtbxLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtbxAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtbxAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
End Class
