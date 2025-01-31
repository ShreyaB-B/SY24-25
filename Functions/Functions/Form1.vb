Imports System.Security.Cryptography

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearALL()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetALL(Label2.Text)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = Add(TextBox1.Text, TextBox2.Text)
    End Sub
    Sub ClearALL()
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label2.Text = ""
    End Sub
    Sub SetALL(s As String)
        Label1.Text = s
    End Sub
    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click
        Sqr_AreaTB.Text = sqrArea(SideTB.Text)
        Sqr_PerTB.Text = squrmeter(SideTB.Text)
    End Sub

    Private Sub CalcButn_Click(sender As Object, e As EventArgs) Handles CalcButn.Click
        Rect_AreaTB.Text = rectArea(TextBox5.Text, TextBox6.Text)
        Rect_PerTB.Text = rectPer(TextBox5.Text, TextBox6.Text)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Crl_AreaTB.Text = CrlArea(Crl_RadiusTB.Text)
        Crl_CirTB.Text = CrlCir(Crl_RadiusTB.Text)
    End Sub
    Function Add(n1 As Integer, n2 As Integer) As Integer
        Return n1 + n2
    End Function


    Function sqrArea(side As Integer) As Integer
        Return side * side
    End Function

    Function squrmeter(side As Integer) As Integer
        Return side * 4
    End Function

    Function rectArea(sideA As Integer, sideB As Integer) As Integer
        Return sideA * sideB
    End Function

    Function rectPer(sideA As Integer, sideB As Integer) As Integer
        Return sideA * 2 + sideB * 2
    End Function

    Function CrlArea(r As Integer) As Integer
        Return r * r * Math.PI
    End Function
    Function CrlCir(r As Integer) As Integer
        Return 2 * r * Math.PI
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TriAreaTB.Text = triarea(BSide.Text, CSide.Text)
        TriPerTB.Text = triPer(CSide.Text)
    End Sub
    Function triarea(h As Integer, b As Integer) As Integer
        Return (h * b) / 2
    End Function
    Function triPer(b As Integer) As Integer
        Return b + b + b
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TriAreaTB.Text = triarea(BSide.Text, CSide.Text)
        TriPerTB.Text = triPer(CSide.Text)
    End Sub

    Function SurfaceArea(l As Integer, h As Integer) As Integer
        Return
    End Function
    Function volume(l As Integer, h As Integer) As Integer
        Return
    End Function
End Class
