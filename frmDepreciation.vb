Public Class frmDepreciation

    Private Sub frmDepreciation_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 40
            cboLife.Items.Add(i)
        Next
    End Sub

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        If IsValidData() Then
            lstDepreciation.Items.Clear()
            For i As Integer = 1 To cboLife.Text
                lstDepreciation.Items.Add("Year " & i & ":   " &
                    FormatCurrency(SYD(txtInitialCost.Text,
                    txtFinalValue.Text, cboLife.Text, i)))
            Next
            txtInitialCost.Select()
        End If
    End Sub

    Private Function IsValidData() As Boolean
        If Validator.IsPresent(txtInitialCost) AndAlso
                Validator.IsNumeric(txtInitialCost) AndAlso
                Validator.IsWithinRange(txtInitialCost, 500, 1000000) Then
            Dim dMaximum As Decimal = txtInitialCost.Text
            If Validator.IsPresent(txtFinalValue) AndAlso
                    Validator.IsNumeric(txtFinalValue) AndAlso
                    Validator.IsWithinRange(txtFinalValue, 0, dMaximum) AndAlso
                    Validator.IsSelected(cboLife) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub btnClose_Click(sender As Object,
            e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class