Public Class Form1

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim intFlowers As Integer
        Dim sngCost As Single
        Const TAX As Single = 0.11
        ' Three prices
        Const SMALL As Single = 1.32 '1-11
        Const MEDIUM As Single = 1.24 ' 12+
        Const LARGE As Single = 1.07 ' 50+

        ' set value
        intFlowers = Val(txtFlowers.Text)

        ' calculate
        If (intFlowers < 12) Then
            sngCost = intFlowers * SMALL
        ElseIf (intFlowers >= 12) Then
            sngCost = intFlowers * MEDIUM
        ElseIf (intFlowers >= 50) Then
            sngCost = intFlowers * LARGE
        End If

        'display
        lblCost.Text = "Cost: " & sngCost

    End Sub
End Class
