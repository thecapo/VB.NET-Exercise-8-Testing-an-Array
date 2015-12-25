Option Strict On
Public Class Form1

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click


        'arrayRow store 10000 numbers
        Dim arrayRow As Integer = 1000
        'valueArray value is stored here
        Dim valueArray(arrayRow) As Decimal

        'getting a random number 1 to 100
        For count As Integer = 0 To arrayRow - 1
            Randomize()
            valueArray(count) = CDec((100 * Rnd()) + 1)
            txtbxData.Text += valueArray(count).ToString + vbCrLf
        Next

        'getting number of items, the minimum and maximum number
        Dim minimum As Decimal = 500
        Dim maximum As Decimal
        Dim quantity As Integer
        For count As Integer = 0 To arrayRow - 1
            If valueArray(count) < minimum Then
                minimum = valueArray(count)
            End If
            If valueArray(count) > maximum Then
                maximum = valueArray(count)
            End If

            If valueArray(arrayRow) = 0 Then
                quantity += 1
            End If
        Next

        'average in decimal 4 places
        Dim average As Decimal
        Dim ave As Decimal
        For aveCount As Integer = 0 To 499

            ave = ave + valueArray(aveCount)
            average = CDec(ave / 500)

        Next

        'displays maximum, minimum number, quantity of items displayed and average of the first 500 items
        txtbxReport.Text = minimum.ToString + vbCrLf + maximum.ToString + vbCrLf + quantity.ToString + vbCrLf + FormatNumber(average.ToString, 4)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clears both textbox for data and report 
        txtbxData.Clear()
        txtbxReport.Clear()

    End Sub
End Class
