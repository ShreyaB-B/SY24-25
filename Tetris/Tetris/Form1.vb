Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(Ghost, Pacman, 10)
        follow(Ghost2, Pacman, 10)
    End Sub
    Sub follow(g As PictureBox, a As PictureBox, s As Integer)
        If g.Location.Y > a.Location.Y Then
            move(g, 0, -s)
        Else
            move(g, 0, s)
        End If
        If g.Location.X > a.Location.X Then
            move(g, -s, 0)
        Else
            move(g, s, 0)
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Pacman, -5, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(Pacman, 5, 0)
            Pacman.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(Pacman, 0, 5)
        End If
        If e.KeyCode = Keys.Space Then
            Pacman.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
            move(Pacman, 0, -5)
            Pacman.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        Pacman.Refresh()
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
        If p.Bounds.IntersectsWith(Food.Bounds) Then
            Food.Visible = False
            Ghost.Visible = True
            Ghost2.Visible = True
        End If
        If Pacman.Bounds.IntersectsWith(Bit.Bounds) Then


        End If
        If Pacman.Bounds.IntersectsWith(Ghost.Bounds) Then
            Pacman.Visible = False
            Ghost.Visible = False
            TextBox1.Visible = True
            TextBox1.Text = "Game Over"
        End If
    End Sub

End Class
