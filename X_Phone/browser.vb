Public Class browser
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim f2 As Main = New Main
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.Show()
        Me.Close()
    End Sub

    Private Sub browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Try
            Dim MyWeb As Object
            MyWeb = WebBrowser1.ActiveXInstance
            MyWeb.ExecWB(63, 2, Convert.ToInt32(50), "NULL")
            TextBox1.Text = WebBrowser1.Document.Domain.ToString
        Catch
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Try
            WebBrowser1.Navigate("https://www.google.com/")
            Do Until WebBrowser1.ReadyState = WebBrowserReadyState.Complete
                Application.DoEvents()
            Loop
            If TextBox1.Text <> "" And TextBox1.Text.IndexOf(".com") = -1 Then
                WebBrowser1.Document.GetElementById("q").SetAttribute("value", TextBox1.Text)
                WebBrowser1.Document.GetElementById("btnK").InvokeMember("click")
                Do Until WebBrowser1.ReadyState = WebBrowserReadyState.Complete
                    Application.DoEvents()
                Loop
            End If
            TextBox1.Text = WebBrowser1.Url.ToString
        Catch
        End Try
    End Sub
End Class