Public Class frmInvestment

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        If IsValidData() Then
            If rdoFutureValue.Checked Then
                Me.CalculateFutureValue()
                txtMonthlyInvestment.Select()
            Else
                Me.CalculateMonthlyInvestment()
                txtInterestRate.Select()
            End If
        End If

    End Sub

    Private Function IsValidData() As Boolean
        If rdoFutureValue.Checked Then
            Return _
                Validator.IsPresent(txtMonthlyInvestment) AndAlso
                Validator.IsNumeric(txtMonthlyInvestment) AndAlso
                Validator.IsWithinRange(txtMonthlyInvestment, 100, 1000) AndAlso
                Validator.IsPresent(txtInterestRate) AndAlso
                Validator.IsNumeric(txtInterestRate) AndAlso
                Validator.IsWithinRange(txtInterestRate, 0, 24) AndAlso
                Validator.IsPresent(txtYears) AndAlso
                Validator.IsInteger(txtYears) AndAlso
                Validator.IsWithinRange(txtYears, 1, 65)
        Else
            Return _
                Validator.IsPresent(txtInterestRate) AndAlso
                Validator.IsNumeric(txtInterestRate) AndAlso
                Validator.IsWithinRange(txtInterestRate, 0, 24) AndAlso
                Validator.IsPresent(txtYears) AndAlso
                Validator.IsInteger(txtYears) AndAlso
                Validator.IsWithinRange(txtYears, 1, 65) AndAlso
                Validator.IsPresent(txtFutureValue) AndAlso
                Validator.IsNumeric(txtFutureValue) AndAlso
                Validator.IsWithinRange(txtFutureValue, 1000, 1000000)
        End If
    End Function

    Private Sub CalculateFutureValue()
        Dim iMonths As Integer = txtYears.Text * 12
        Dim dInterestRate As Decimal = txtInterestRate.Text / 12 / 100
        Dim dFutureValue As Decimal =
            FV(dInterestRate, iMonths, -txtMonthlyInvestment.Text, 0,
            DueDate.BegOfPeriod)
        txtFutureValue.Text = FormatCurrency(dFutureValue)
    End Sub

    Private Sub CalculateMonthlyInvestment()
        Dim iMonths As Integer = txtYears.Text * 12
        Dim dInterestRate As Decimal = txtInterestRate.Text / 12 / 100
        Dim dMonthlyInvestment =
            Pmt(dInterestRate, iMonths, 0, -txtFutureValue.Text, DueDate.BegOfPeriod)
        txtMonthlyInvestment.Text = FormatCurrency(dMonthlyInvestment)
    End Sub

    Private Sub rdoFutureValue_CheckedChanged(sender As Object,
            e As EventArgs) Handles rdoFutureValue.CheckedChanged
        txtFutureValue.ReadOnly = True
        txtFutureValue.TabStop = False
        txtMonthlyInvestment.ReadOnly = False
        txtMonthlyInvestment.TabStop = True
        Me.ClearControls()
        txtMonthlyInvestment.Select()
    End Sub

    Private Sub rdoMonthlyInvestment_CheckedChanged(sender As Object,
            e As EventArgs) Handles rdoMonthlyInvestment.CheckedChanged
        txtFutureValue.ReadOnly = False
        txtFutureValue.TabStop = True
        txtMonthlyInvestment.ReadOnly = True
        txtMonthlyInvestment.TabStop = False
        Me.ClearControls()
        txtInterestRate.Select()
    End Sub

    Private Sub ClearControls()
        txtMonthlyInvestment.Text = ""
        txtInterestRate.Text = ""
        txtYears.Text = ""
        txtFutureValue.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object,
            e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
