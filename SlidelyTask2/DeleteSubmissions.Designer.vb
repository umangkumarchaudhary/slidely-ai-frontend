<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteSubmissions
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtGithub_Link = New System.Windows.Forms.TextBox()
        Me.txtStopwatch_Time = New System.Windows.Forms.TextBox()
        Me.btnNextClick = New System.Windows.Forms.Button()
        Me.btnPrevClick = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(7, 401)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(406, 40)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "DELETE SUBMISSION (CTRL + D)"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(143, 95)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(267, 26)
        Me.txtName.TabIndex = 45
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(143, 136)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(267, 26)
        Me.txtEmail.TabIndex = 44
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtphone.Location = New System.Drawing.Point(143, 175)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.ReadOnly = True
        Me.txtphone.Size = New System.Drawing.Size(267, 26)
        Me.txtphone.TabIndex = 43
        Me.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGithub_Link
        '
        Me.txtGithub_Link.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGithub_Link.Location = New System.Drawing.Point(143, 221)
        Me.txtGithub_Link.Multiline = True
        Me.txtGithub_Link.Name = "txtGithub_Link"
        Me.txtGithub_Link.ReadOnly = True
        Me.txtGithub_Link.Size = New System.Drawing.Size(267, 26)
        Me.txtGithub_Link.TabIndex = 42
        Me.txtGithub_Link.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStopwatch_Time
        '
        Me.txtStopwatch_Time.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtStopwatch_Time.Location = New System.Drawing.Point(143, 268)
        Me.txtStopwatch_Time.Multiline = True
        Me.txtStopwatch_Time.Name = "txtStopwatch_Time"
        Me.txtStopwatch_Time.ReadOnly = True
        Me.txtStopwatch_Time.Size = New System.Drawing.Size(267, 26)
        Me.txtStopwatch_Time.TabIndex = 41
        Me.txtStopwatch_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNextClick
        '
        Me.btnNextClick.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNextClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextClick.Location = New System.Drawing.Point(213, 346)
        Me.btnNextClick.Name = "btnNextClick"
        Me.btnNextClick.Size = New System.Drawing.Size(200, 40)
        Me.btnNextClick.TabIndex = 40
        Me.btnNextClick.Text = "NEXT ( CTRL + N)"
        Me.btnNextClick.UseVisualStyleBackColor = False
        '
        'btnPrevClick
        '
        Me.btnPrevClick.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrevClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevClick.Location = New System.Drawing.Point(7, 346)
        Me.btnPrevClick.Name = "btnPrevClick"
        Me.btnPrevClick.Size = New System.Drawing.Size(200, 40)
        Me.btnPrevClick.TabIndex = 39
        Me.btnPrevClick.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevClick.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(21, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 51)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Stopwatch Time"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(18, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 48)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Github Link for Task 2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Phone Num"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Bhavesh Joshi, Slidely Task 2 - Delete Submissions"
        '
        'DeleteSubmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 450)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtGithub_Link)
        Me.Controls.Add(Me.txtStopwatch_Time)
        Me.Controls.Add(Me.btnNextClick)
        Me.Controls.Add(Me.btnPrevClick)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "DeleteSubmissions"
        Me.Text = "DeleteSubmissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtGithub_Link As TextBox
    Friend WithEvents txtStopwatch_Time As TextBox
    Friend WithEvents btnNextClick As Button
    Friend WithEvents btnPrevClick As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
