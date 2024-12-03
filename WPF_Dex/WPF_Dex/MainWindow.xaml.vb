Class MainWindow
    Private Sub Nighthawk_Click(sender As Object, e As RoutedEventArgs)
        PictureBox1.Visibility = Visibility.Visible
        F15Egale.Visibility = Visibility.Hidden
        B2Bomber.Visibility = Visibility.Hidden
        Rec.Visibility = Visibility.Hidden
        Label1.Content = "B-2 Bomber"
        TextBox1.Text = ""
    End Sub

    Private Sub Bomber_Click(sender As Object, e As RoutedEventArgs)
        PictureBox1.Visibility = Visibility.Hidden
        F15Egale.Visibility = Visibility.Visible
        B2Bomber.Visibility = Visibility.Hidden
        Rec.Visibility = Visibility.Hidden
        Label1.Content = "F-15 Eagle"
        TextBox1.Text = ""
    End Sub

    Private Sub Eagle_Click(sender As Object, e As RoutedEventArgs)
        PictureBox1.Visibility = Visibility.Hidden
        F15Egale.Visibility = Visibility.Hidden
        B2Bomber.Visibility = Visibility.Visible
        Rec.Visibility = Visibility.Hidden
        Label1.Content = "F-117 NightHawk"
        TextBox1.Text = ""
    End Sub
End Class
