<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnViewSub = New System.Windows.Forms.Button()
        Me.btnCreateSub = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewSub
        '
        Me.btnViewSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnViewSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSub.Location = New System.Drawing.Point(40, 56)
        Me.btnViewSub.Name = "btnViewSub"
        Me.btnViewSub.Size = New System.Drawing.Size(340, 40)
        Me.btnViewSub.TabIndex = 0
        Me.btnViewSub.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.btnViewSub.UseVisualStyleBackColor = False
        '
        'btnCreateSub
        '
        Me.btnCreateSub.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCreateSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateSub.Location = New System.Drawing.Point(40, 108)
        Me.btnCreateSub.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCreateSub.Name = "btnCreateSub"
        Me.btnCreateSub.Size = New System.Drawing.Size(340, 40)
        Me.btnCreateSub.TabIndex = 1
        Me.btnCreateSub.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.btnCreateSub.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bhavesh Joshi, Slidely Task 2 - Slidely Forms app"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(40, 164)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(340, 40)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "DELETE SUBMISSION (CTRL + D)"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SeaShell
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(40, 219)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(340, 40)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "EDIT SUBMISSION (CTRL + E)"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Gold
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(40, 270)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(340, 40)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARCH SUBMISSION (CTRL + S)"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 331)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateSub)
        Me.Controls.Add(Me.btnViewSub)
        Me.KeyPreview = True
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewSub As Button
    Friend WithEvents btnCreateSub As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSearch As Button
End Class
