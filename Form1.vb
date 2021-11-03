Public Class Form1
    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        Dim laborHours, partsCost, laborCost, totalPartsCost, totalCost As Double
        Dim customerName As String
        Const laborHourCost As Integer = 35
        Const tax As Double = 0.05

        lstDisplay.Items.Clear()

        If (IsNumeric(txtLabor.Text) And IsNumeric(txtParts.Text) And txtName.Text <> "") Then

            laborHours = CDbl(txtLabor.Text)
            partsCost = CDbl(txtParts.Text)
            customerName = txtName.Text

            laborCost = laborHours * laborHourCost
            totalPartsCost = partsCost + (partsCost * tax)
            totalCost = laborCost + totalPartsCost

            lstDisplay.Items.Add("Customer:            " & customerName)
            lstDisplay.Items.Add("Labor Cost:          " & FormatCurrency(laborCost))
            lstDisplay.Items.Add("Parts Cost:           " & FormatCurrency(totalPartsCost))
            lstDisplay.Items.Add("Total Cost:           " & FormatCurrency(totalCost))

        Else

            MsgBox("Please enter valid data")



        End If
    End Sub
End Class
