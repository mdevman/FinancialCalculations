<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvestment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFutureValue = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdoMonthlyInvestment = New System.Windows.Forms.RadioButton
        Me.rdoFutureValue = New System.Windows.Forms.RadioButton
        Me.txtYears = New System.Windows.Forms.TextBox
        Me.txtInterestRate = New System.Windows.Forms.TextBox
        Me.txtMonthlyInvestment = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFutureValue
        '
        Me.txtFutureValue.Location = New System.Drawing.Point(132, 139)
        Me.txtFutureValue.Name = "txtFutureValue"
        Me.txtFutureValue.ReadOnly = True
        Me.txtFutureValue.Size = New System.Drawing.Size(100, 20)
        Me.txtFutureValue.TabIndex = 25
        Me.txtFutureValue.TabStop = False
        Me.txtFutureValue.Tag = "Future Value"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoMonthlyInvestment)
        Me.GroupBox1.Controls.Add(Me.rdoFutureValue)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 48)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculate"
        '
        'rdoMonthlyInvestment
        '
        Me.rdoMonthlyInvestment.CausesValidation = False
        Me.rdoMonthlyInvestment.Location = New System.Drawing.Point(112, 16)
        Me.rdoMonthlyInvestment.Name = "rdoMonthlyInvestment"
        Me.rdoMonthlyInvestment.Size = New System.Drawing.Size(120, 24)
        Me.rdoMonthlyInvestment.TabIndex = 1
        Me.rdoMonthlyInvestment.Text = "Monthly Investment"
        '
        'rdoFutureValue
        '
        Me.rdoFutureValue.CausesValidation = False
        Me.rdoFutureValue.Checked = True
        Me.rdoFutureValue.Location = New System.Drawing.Point(8, 16)
        Me.rdoFutureValue.Name = "rdoFutureValue"
        Me.rdoFutureValue.Size = New System.Drawing.Size(104, 24)
        Me.rdoFutureValue.TabIndex = 0
        Me.rdoFutureValue.TabStop = True
        Me.rdoFutureValue.Text = "Future Value"
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(132, 115)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 20)
        Me.txtYears.TabIndex = 24
        Me.txtYears.Tag = "Number of Years"
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(132, 91)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestRate.TabIndex = 23
        Me.txtInterestRate.Tag = "Yearly Interest Rate"
        '
        'txtMonthlyInvestment
        '
        Me.txtMonthlyInvestment.Location = New System.Drawing.Point(132, 67)
        Me.txtMonthlyInvestment.Name = "txtMonthlyInvestment"
        Me.txtMonthlyInvestment.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthlyInvestment.TabIndex = 18
        Me.txtMonthlyInvestment.Tag = "Monthly Investment"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Future Value:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Number of Years:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Yearly Interest Rate:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Monthly Investment:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.CausesValidation = False
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(172, 171)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 23)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "C&lose"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(84, 171)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 23)
        Me.btnCalculate.TabIndex = 26
        Me.btnCalculate.Text = "&Calculate"
        '
        'frmInvestment
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(271, 211)
        Me.Controls.Add(Me.txtFutureValue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtMonthlyInvestment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmInvestment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculate Investment"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFutureValue As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoMonthlyInvestment As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFutureValue As System.Windows.Forms.RadioButton
    Friend WithEvents txtYears As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthlyInvestment As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
