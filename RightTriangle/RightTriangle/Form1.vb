Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim a As Double = CDbl(txtSideOne.Text)
        Dim b As Double = CDbl(txtSideTwo.Text)

        Dim result As Double
        result = CSquared(a, b)
        result = Math.Round(result, 2)
        txtHyp.Text = "If A^2 =" & a & ", and B^2 = " & b & ", then C^2 = " & CStr(result) & "!"


    End Sub
    Function CSquared(ByVal a As Double, ByVal b As Double) _
        As Double

        Dim c As Double

        c = Math.Sqrt(a ^ 2 + b ^ 2)

        Return c 'this is the outcome of the function, it says to return the outcome as variable c. This is what the "function" gives back
    End Function
End Class
