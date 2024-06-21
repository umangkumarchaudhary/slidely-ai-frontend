<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissions
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPrevClick = New System.Windows.Forms.Button()
        Me.btnNextClick = New System.Windows.Forms.Button()
        Me.txtStopwatch_Time = New System.Windows.Forms.TextBox()
        Me.txtGithub_Link = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bhavesh Joshi, Slidely Task 2 - View Submissions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone Num"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 48)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Github Link for Task 2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(26, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 51)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Stopwatch Time"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrevClick
        '
        Me.btnPrevClick.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrevClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevClick.Location = New System.Drawing.Point(12, 347)
        Me.btnPrevClick.Name = "btnPrevClick"
        Me.btnPrevClick.Size = New System.Drawing.Size(200, 40)
        Me.btnPrevClick.TabIndex = 9
        Me.btnPrevClick.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevClick.UseVisualStyleBackColor = False
        '
        'btnNextClick
        '
        Me.btnNextClick.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNextClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextClick.Location = New System.Drawing.Point(218, 347)
        Me.btnNextClick.Name = "btnNextClick"
        Me.btnNextClick.Size = New System.Drawing.Size(200, 40)
        Me.btnNextClick.TabIndex = 10
        Me.btnNextClick.Text = "NEXT ( CTRL + N)"
        Me.btnNextClick.UseVisualStyleBackColor = False
        '
        'txtStopwatch_Time
        '
        Me.txtStopwatch_Time.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtStopwatch_Time.Location = New System.Drawing.Point(148, 269)
        Me.txtStopwatch_Time.Multiline = True
        Me.txtStopwatch_Time.Name = "txtStopwatch_Time"
        Me.txtStopwatch_Time.ReadOnly = True
        Me.txtStopwatch_Time.Size = New System.Drawing.Size(267, 26)
        Me.txtStopwatch_Time.TabIndex = 15
        Me.txtStopwatch_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGithub_Link
        '
        Me.txtGithub_Link.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGithub_Link.Location = New System.Drawing.Point(148, 222)
        Me.txtGithub_Link.Multiline = True
        Me.txtGithub_Link.Name = "txtGithub_Link"
        Me.txtGithub_Link.ReadOnly = True
        Me.txtGithub_Link.Size = New System.Drawing.Size(267, 26)
        Me.txtGithub_Link.TabIndex = 16
        Me.txtGithub_Link.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtphone.Location = New System.Drawing.Point(148, 176)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.ReadOnly = True
        Me.txtphone.Size = New System.Drawing.Size(267, 26)
        Me.txtphone.TabIndex = 17
        Me.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(148, 137)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(267, 26)
        Me.txtEmail.TabIndex = 18
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(148, 96)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(267, 26)
        Me.txtName.TabIndex = 19
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ViewSubmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 424)
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
        Me.KeyPreview = True
        Me.Name = "ViewSubmissions"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrevClick As Button
    Friend WithEvents btnNextClick As Button
    Friend WithEvents txtStopwatch_Time As TextBox
    Friend WithEvents txtGithub_Link As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
End Class
