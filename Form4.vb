Imports System.IO
Public Class Form4


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim mypath As String = Environ$("Userprofile") & "\MyDairy\"
        Button3.Show()
        Button1.Show()
        RichTextBox1.Hide()
        Button2.Hide()
        ComboBox1.Show()
        Label1.Show()
        ComboBox1.Items.Clear()
        Label2.Hide()
        Dim filenames = My.Computer.FileSystem.GetFiles(mypath, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
        For Each filename As String In filenames
            ComboBox1.Items.Add(Path.GetFileNameWithoutExtension(filename))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = Environ$("Userprofile") & "\MyDairy\"
        Dim name As String = ComboBox1.Text
        ComboBox1.Hide()
        Label1.Hide()
        Label2.Show()
        Label2.Text = name
        RichTextBox1.Show()
        Button1.Hide()
        Button2.Show()
        Try
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(path + name + ".txt")
        Catch
            MessageBox.Show("File or path not found or invalid")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4_Load(sender, e)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class