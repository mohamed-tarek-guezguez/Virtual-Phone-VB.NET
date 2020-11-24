Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = BackColor
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://www.google.com/")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://www.google.com/")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://www.messenger.com/")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://www.m.facebook.com/")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://www.youtube.com/?hl=fr")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://mail.google.com/mail/u/0/?tab=wm&ogbl")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://www.google.com/maps")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://www.dropbox.com/")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://twitter.com/")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1575551817&rver=7.1.6819.0&wp=MBI_SSL&wreply=https%3A%2F%2Flw.skype.com%2Flogin%2Foauth%2Fproxy%3Fclient_id%3D360605%26redirect_uri%3Dhttps%253A%252F%252Fsecure.skype.com%252Fportal%252Flogin%253Freturn_url%253Dhttps%25253A%25252F%25252Fsecure.skype.com%25252Fportal%25252Foverview%26response_type%3Dpostgrant%26state%3D7e5ac768845c4ccb7be80f3f%26site_name%3Dlw.skype.com&lc=1033&id=293290&mkt=en-US&psi=skype&lw=1&cobrandid=2befc4b5-19e3-46e8-8347-77317a16a5a5&client_flight=ReservedFlight33%2CReservedFlight67")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://maktoob.yahoo.com/?p=us")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://soundcloud.com/")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim f2 As browser = New browser
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.WebBrowser1.Navigate("https://www.instagram.com/")
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f2 As Calc = New Calc
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay.TimeOfDay.ToString
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim f2 As note = New note
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click

    End Sub
End Class
