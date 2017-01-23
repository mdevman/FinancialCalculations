Public Class frmMain

    Private Sub btnCalcInvestment_Click(sender As Object,
            e As EventArgs) Handles btnCalcInvestment.Click
        Dim investmentForm As New frmInvestment()
        investmentForm.Show()
    End Sub

    Private Sub btnCalcDepreciation_Click(sender As Object,
            e As EventArgs) Handles btnCalcDepreciation.Click
        Dim depreciationForm As New frmDepreciation()
        depreciationForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class