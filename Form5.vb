Imports System.IO
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.ReadOnly = True
        Dim mypath As String = Environ$("Userprofile") & "\MyDairy\"
        Dim filenames = My.Computer.FileSystem.GetFiles(mypath, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
        Dim filename As String
        filename = filenames(0)
        Dim filecount As Integer = My.Computer.FileSystem.GetFiles(mypath).Count()
        If filecount = 1 Then
            Button2.Hide()
        End If
        Label1.Text = Path.GetFileNameWithoutExtension(filename)
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(filename)
    End Sub

    Private buttonclickcount As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        buttonclickcount += 1
        Dim mypath As String = Environ$("Userprofile") & "\MyDairy\"
        Dim filecount As Integer = My.Computer.FileSystem.GetFiles(mypath).Count()
        Dim filenames = My.Computer.FileSystem.GetFiles(mypath, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
        Dim filename As String
        If buttonclickcount < filecount Then
            filename = filenames(buttonclickcount)
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(filename)
            Label1.Text = Path.GetFileNameWithoutExtension(filename)
        Else
            buttonclickcount = 0
            filename = filenames(buttonclickcount)
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(filename)
            Label1.Text = Path.GetFileNameWithoutExtension(filename)
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class