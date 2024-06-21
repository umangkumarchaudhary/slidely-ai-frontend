<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSubmissions
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
        Me.components = New System.ComponentModel.Container()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtGithub_Link = New System.Windows.Forms.TextBox()
        Me.btnNextClick = New System.Windows.Forms.Button()
        Me.btnPrevClick = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnPauseResume = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(153, 84)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(267, 26)
        Me.txtName.TabIndex = 59
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(153, 125)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(267, 26)
        Me.txtEmail.TabIndex = 58
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtphone.Location = New System.Drawing.Point(153, 164)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(267, 26)
        Me.txtphone.TabIndex = 57
        Me.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGithub_Link
        '
        Me.txtGithub_Link.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGithub_Link.Location = New System.Drawing.Point(153, 210)
        Me.txtGithub_Link.Multiline = True
        Me.txtGithub_Link.Name = "txtGithub_Link"
        Me.txtGithub_Link.Size = New System.Drawing.Size(267, 26)
        Me.txtGithub_Link.TabIndex = 56
        Me.txtGithub_Link.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNextClick
        '
        Me.btnNextClick.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNextClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextClick.Location = New System.Drawing.Point(223, 335)
        Me.btnNextClick.Name = "btnNextClick"
        Me.btnNextClick.Size = New System.Drawing.Size(200, 40)
        Me.btnNextClick.TabIndex = 54
        Me.btnNextClick.Text = "NEXT ( CTRL + N)"
        Me.btnNextClick.UseVisualStyleBackColor = False
        '
        'btnPrevClick
        '
        Me.btnPrevClick.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrevClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevClick.Location = New System.Drawing.Point(17, 335)
        Me.btnPrevClick.Name = "btnPrevClick"
        Me.btnPrevClick.Size = New System.Drawing.Size(200, 40)
        Me.btnPrevClick.TabIndex = 53
        Me.btnPrevClick.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevClick.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(28, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 48)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Github Link for Task 2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Phone Num"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Bhavesh Joshi, Slidely Task 2 - Edit Submissions"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SeaShell
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(17, 390)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(406, 40)
        Me.btnEdit.TabIndex = 46
        Me.btnEdit.Text = "EDIT SUBMISSION (CTRL + E)"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblStopwatch
        '
        Me.lblStopwatch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopwatch.Location = New System.Drawing.Point(268, 268)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(142, 34)
        Me.lblStopwatch.TabIndex = 61
        Me.lblStopwatch.Text = "00:00:00"
        Me.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPauseResume
        '
        Me.btnPauseResume.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPauseResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseResume.Location = New System.Drawing.Point(17, 268)
        Me.btnPauseResume.Name = "btnPauseResume"
        Me.btnPauseResume.Size = New System.Drawing.Size(235, 34)
        Me.btnPauseResume.TabIndex = 60
        Me.btnPauseResume.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnPauseResume.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'EditSubmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 449)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.btnPauseResume)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtGithub_Link)
        Me.Controls.Add(Me.btnNextClick)
        Me.Controls.Add(Me.btnPrevClick)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdit)
        Me.Name = "EditSubmissions"
        Me.Text = "EditSubmissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtGithub_Link As TextBox
    Friend WithEvents btnNextClick As Button
    Friend WithEvents btnPrevClick As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnPauseResume As Button
    Friend WithEvents Timer1 As Timer
End Class
