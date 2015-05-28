Public Class frmTableOutput

    Private Sub frmTableOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvwTableOutput.Columns.Add("Value", 100, HorizontalAlignment.Left) 'Creates column in listview control to show value when the form is loaded
        lvwTableOutput.Columns.Add("Result", 100, HorizontalAlignment.Left) 'Creates column in listview control to show result when the form is loaded
    End Sub

    Private Sub btnClearResults_Click(sender As Object, e As EventArgs) Handles btnClearResults.Click
        lvwTableOutput.Items.Clear() 'When user clicks the clear button, the value and results data will be erased.
    End Sub

    Public Sub CalculationResult(ByRef prCounter As Decimal, ByRef prValue As Decimal) 'Receives counter and value parameter from 
        lvwTableOutput.Items.Add(New ListViewItem({prCounter, prValue})) 'We will add the calculation to the listview control. This includes the value that was converted and the result.
    End Sub
End Class