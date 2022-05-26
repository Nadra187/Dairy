Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mydate As Date
        mydate = Today
        Label1.Text = mydate
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d As String = Date.Now.ToString("yyyy-MM-dd")
        Dim path As String = Environ$("Userprofile") & "\MyDairy\"
        '"C:\Users\nadraibrahim\MyDairy\"
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
        My.Computer.FileSystem.WriteAllText(path + d + ".txt", RichTextBox1.Text, True)
        Dim ToHideDir As New DirectoryInfo(path)
        ToHideDir.Attributes = FileAttributes.Hidden
        Label2.Visible = True
        Label2.Text = "saved"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
        Label2.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Form2.Show()
    End Sub

End Class
