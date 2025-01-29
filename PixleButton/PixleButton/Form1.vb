Imports System.IO
Imports System.Xml

Public Class Form1
    Private Sub TestBtn_Click(sender As Object, e As EventArgs) Handles TestBtn.Click
        'For index = 0 To 99
        '    Controls("B" & index).BackColor = Color_Btn.BackColor
        '    Controls("B" & index).Text = index
        'Next
        Dim a() As String = TextBox2.Text.Split(",")
        Dim t As Integer = 0
        Dim c As Integer = a(0)

        For index = t To c - 1
            Controls("B" & index).BackColor = Color.AntiqueWhite
        Next
        For index = CInt(a(0)) To CInt(a(0)) + CInt(a(1)) - 1
            Controls("B" & index).BackColor = Color.SteelBlue
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For index = 0 To 99
            Controls("B" & index).BackColor = Color.White
            Controls("B" & index).Text = ""
        Next
    End Sub

    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click, B1.Click, B10.Click, B11.Click, B92.Click, B93.Click, B94.Click, B95.Click, B96.Click, B97.Click, B98.Click, B99.Click, B82.Click, B83.Click, B84.Click, B85.Click, B86.Click, B87.Click, B88.Click, B89.Click, B72.Click, B73.Click, B74.Click, B75.Click, B76.Click, B77.Click, B78.Click, B79.Click, B62.Click, B63.Click, B64.Click, B65.Click, B66.Click, B67.Click, B68.Click, B69.Click, B52.Click, B53.Click, B54.Click, B55.Click, B56.Click, B57.Click, B58.Click, B59.Click, B42.Click, B43.Click, B44.Click, B45.Click, B46.Click, B47.Click, B48.Click, B49.Click, B32.Click, B33.Click, B34.Click, B35.Click, B36.Click, B37.Click, B38.Click, B39.Click, B22.Click, B23.Click, B24.Click, B25.Click, B26.Click, B27.Click, B28.Click, B29.Click, B19.Click, B18.Click, B17.Click, B13.Click, B14.Click, B15.Click, B16.Click, B12.Click, B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click, B90.Click, B91.Click, B80.Click, B81.Click, B70.Click, B71.Click, B60.Click, B61.Click, B50.Click, B51.Click, B40.Click, B41.Click, B30.Click, B31.Click, B20.Click, B21.Click
        If sender.backcolor = Color.White Then
            sender.backcolor = Color_Btn.BackColor
        Else
            sender.backcolor = Color.White
        End If
        WriteText(1, TextBox1)
        WriteText(2, TextBox2)
        WriteText(3, TextBox3)
        WriteText(4, TextBox4)
        WriteText(5, TextBox5)
        WriteText(6, TextBox6)
        WriteText(7, TextBox7)
        WriteText(8, TextBox8)
        WriteText(9, TextBox9)
        WriteText(10, TextBox10)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Color_Btn.Click
        ColorDialog1.ShowDialog()
        sender.backcolor = ColorDialog1.Color
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Dim fOutput As New IO.StreamWriter(SaveFileDialog1.FileName)
        fOutput.WriteLine(TextBox1.Text)
        fOutput.WriteLine(TextBox2.Text)
        fOutput.WriteLine(TextBox3.Text)
        fOutput.WriteLine(TextBox4.Text)
        fOutput.WriteLine(TextBox5.Text)
        fOutput.WriteLine(TextBox6.Text)
        fOutput.WriteLine(TextBox7.Text)
        fOutput.WriteLine(TextBox8.Text)
        fOutput.WriteLine(TextBox9.Text)
        fOutput.WriteLine(TextBox10.Text)
        fOutput.Close()
        DrawLine(1, TextBox1.Text)
        DrawLine(2, TextBox2.Text)
        DrawLine(3, TextBox3.Text)
        DrawLine(4, TextBox4.Text)
        DrawLine(5, TextBox5.Text)
        DrawLine(6, TextBox6.Text)
        DrawLine(7, TextBox7.Text)
        DrawLine(8, TextBox8.Text)
        DrawLine(9, TextBox9.Text)
        DrawLine(10, TextBox10.Text)
        fOutput.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        Dim fInput As New IO.StreamReader(OpenFileDialog1.FileName)
        TextBox1.Text = fInput.ReadLine
        TextBox2.Text = fInput.ReadLine
        TextBox3.Text = fInput.ReadLine
        TextBox4.Text = fInput.ReadLine
        TextBox5.Text = fInput.ReadLine
        TextBox6.Text = fInput.ReadLine
        TextBox7.Text = fInput.ReadLine
        TextBox8.Text = fInput.ReadLine
        TextBox9.Text = fInput.ReadLine
        TextBox10.Text = fInput.ReadLine
        fInput.Close()
        DrawLine(1, TextBox1.Text)
        DrawLine(2, TextBox2.Text)
        DrawLine(3, TextBox3.Text)
        DrawLine(4, TextBox4.Text)
        DrawLine(5, TextBox5.Text)
        DrawLine(6, TextBox6.Text)
        DrawLine(7, TextBox7.Text)
        DrawLine(8, TextBox8.Text)
        DrawLine(9, TextBox9.Text)
        DrawLine(10, TextBox10.Text)
        fInput.Close()
    End Sub
    Sub DrawLine(r As Integer, l As String)

        Dim nums() As String
        nums = l.Split(",")
        Dim c As Color

        Dim col As Color = Color.White
        Dim count As Integer = (r - 1) * 10
        For Each n As Integer In nums
            For i = 0 To n - 1
                Controls("B" & count).BackColor = col
                count = count + 1
            Next
            If col = Color.White Then
                col = Color.Black
            Else
                col = Color.White
            End If
        Next
    End Sub

    Sub WriteText(row As Integer, t As TextBox)
        Dim Count As Integer
        Dim col As Color = Color.White
        t.Clear()

        For i = (row - 1) * 10 To row * 10 - 1
            If Controls("b" & i).BackColor = col Then
                Count = Count + 1
            Else
                t.Text += Count & ","
                Count = 1
                col = Controls("b" & i).BackColor
            End If

        Next
        t.Text += Count.ToString
    End Sub

    Private Sub ReadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadToolStripMenuItem.Click
        For Each textbox As System.Windows.Forms.Control In Me.Controls
            textbox.Text = ""
        Next
        For index = 0 To 99
            Controls("B" & index).BackColor = Color.White
            Controls("B" & index).Text = ""
        Next
    End Sub
End Class
