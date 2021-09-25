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
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OutputTxt = New System.Windows.Forms.TextBox()
        Me.GradeInt = New System.Windows.Forms.TextBox()
        Me.YearInt = New System.Windows.Forms.TextBox()
        Me.CheckBtn = New System.Windows.Forms.Button()
        Me.LoanList = New System.Windows.Forms.ListBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(107, 70)
        Me.NameTxt.Multiline = True
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(341, 34)
        Me.NameTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 51)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOAN SCHEME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(8, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "GradeLevel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(8, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(8, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Type Of Loan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(8, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "No of Years"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(199, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ANALYSIS"
        '
        'OutputTxt
        '
        Me.OutputTxt.Location = New System.Drawing.Point(13, 310)
        Me.OutputTxt.Multiline = True
        Me.OutputTxt.Name = "OutputTxt"
        Me.OutputTxt.Size = New System.Drawing.Size(453, 160)
        Me.OutputTxt.TabIndex = 9
        '
        'GradeInt
        '
        Me.GradeInt.Location = New System.Drawing.Point(107, 110)
        Me.GradeInt.Multiline = True
        Me.GradeInt.Name = "GradeInt"
        Me.GradeInt.Size = New System.Drawing.Size(341, 34)
        Me.GradeInt.TabIndex = 10
        '
        'YearInt
        '
        Me.YearInt.Location = New System.Drawing.Point(107, 150)
        Me.YearInt.Multiline = True
        Me.YearInt.Name = "YearInt"
        Me.YearInt.Size = New System.Drawing.Size(341, 34)
        Me.YearInt.TabIndex = 11
        '
        'CheckBtn
        '
        Me.CheckBtn.Location = New System.Drawing.Point(157, 239)
        Me.CheckBtn.Name = "CheckBtn"
        Me.CheckBtn.Size = New System.Drawing.Size(204, 34)
        Me.CheckBtn.TabIndex = 13
        Me.CheckBtn.Text = "CHECK"
        Me.CheckBtn.UseVisualStyleBackColor = True
        '
        'LoanList
        '
        Me.LoanList.FormattingEnabled = True
        Me.LoanList.ItemHeight = 15
        Me.LoanList.Items.AddRange(New Object() {"CAR", "MOTOCYCLE"})
        Me.LoanList.Location = New System.Drawing.Point(107, 191)
        Me.LoanList.Name = "LoanList"
        Me.LoanList.Size = New System.Drawing.Size(341, 34)
        Me.LoanList.TabIndex = 14
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Location = New System.Drawing.Point(30, 476)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(204, 34)
        Me.SubmitBtn.TabIndex = 15
        Me.SubmitBtn.Text = "SUBMIT"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(261, 476)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(204, 34)
        Me.ExitBtn.TabIndex = 16
        Me.ExitBtn.Text = "EXIT"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 514)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.LoanList)
        Me.Controls.Add(Me.CheckBtn)
        Me.Controls.Add(Me.YearInt)
        Me.Controls.Add(Me.GradeInt)
        Me.Controls.Add(Me.OutputTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameTxt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents OutputTxt As TextBox
    Friend WithEvents GradeInt As TextBox
    Friend WithEvents YearInt As TextBox
    Friend WithEvents CheckBtn As Button
    Friend WithEvents LoanList As ListBox
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
