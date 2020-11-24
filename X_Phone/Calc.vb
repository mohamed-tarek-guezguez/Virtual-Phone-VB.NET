Public Class Calc
    Dim ope As New Double
    Dim Sign As String

    Private Sub Calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = BackColor
    End Sub

    Private Sub b0_Click(sender As Object, e As EventArgs) Handles b0.Click
        If res.Text = "0" Then
            res.Text = 0
        Else
            res.Text += "0"
        End If
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        If res.Text = "0" Then
            res.Text = 1
        Else
            res.Text += "1"
        End If
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        If res.Text = "0" Then
            res.Text = 2
        Else
            res.Text += "2"
        End If
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If res.Text = "0" Then
            res.Text = 3
        Else
            res.Text += "3"
        End If
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        If res.Text = "0" Then
            res.Text = 4
        Else
            res.Text += "4"
        End If
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        If res.Text = "0" Then
            res.Text = 5
        else
            res.Text += "5"
        End If
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        If res.Text = "0" Then
            res.Text = 6
        Else
            res.Text += "6"
        End If
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        If res.Text = "0" Then
            res.Text = 7
        Else
            res.Text += "7"
        End If
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        If res.Text = "0" Then
            res.Text = 8
        Else
            res.Text += "8"
        End If
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        If res.Text = "0" Then
            res.Text = 9
        Else
            res.Text += "9"
        End If
    End Sub

    Private Sub bvergul_Click(sender As Object, e As EventArgs) Handles bvergul.Click
        res.Text += "."
    End Sub

    Private Sub bplus_Click(sender As Object, e As EventArgs) Handles bplus.Click
        ope = res.Text
        Label2.Text = ope
        Label3.Text = "+"
        res.Text = ""
        Sign = "+"
    End Sub

    Private Sub bC_Click(sender As Object, e As EventArgs) Handles bC.Click
        res.Text = "0"
        Label2.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub bCE_Click(sender As Object, e As EventArgs) Handles bCE.Click
        Label2.Text = ""
        Label3.Text = ""
        ope = 0
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim f2 As Main = New Main
        f2.StartPosition = FormStartPosition.Manual
        f2.Location = Me.Location
        f2.Show()
        Me.Close()
    End Sub

    Private Sub BD_Click(sender As Object, e As EventArgs) Handles BD.Click
        If res.Text.Length > 0 Then
            res.Text = res.Text.Substring(0, res.Text.Length - 1)
        End If
    End Sub

    Private Sub bmoi_Click(sender As Object, e As EventArgs) Handles bmoi.Click
        ope = res.Text
        Label2.Text = ope
        Label3.Text = "-"
        res.Text = ""
        Sign = "-"
    End Sub

    Private Sub bfoi_Click(sender As Object, e As EventArgs) Handles bfoi.Click
        ope = res.Text
        Label2.Text = ope
        Label3.Text = "*"
        res.Text = ""
        Sign = "*"
    End Sub

    Private Sub bdiv_Click(sender As Object, e As EventArgs) Handles bdiv.Click
        ope = res.Text
        Label2.Text = ope
        Label3.Text = "÷"
        res.Text = ""
        Sign = "/"
    End Sub

    Private Sub begal_Click(sender As Object, e As EventArgs) Handles begal.Click
        Label3.Text = ""
        Label2.Text = ""
        If res.Text = "" Then
            res.Text = "0"
        End If
        If Sign = "+" Then
            ope = ope + CDbl(res.Text)
        ElseIf Sign = "-" Then
            ope = ope - CDbl(res.Text)
        ElseIf Sign = "*" Then
            ope = ope * CDbl(res.Text)
        ElseIf Sign = "/" Then
            ope = ope / CDbl(res.Text)
        End If
        If Sign <> "" Then
            res.Text = ope
        End If
        Sign = ""
    End Sub

    Private Sub res_Click(sender As Object, e As EventArgs) Handles res.Click

    End Sub
End Class