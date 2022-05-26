Imports System.IO
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim flag As Integer = 0
        Dim mypath As String = Environ$("Userprofile") & "\MyDairy\"
        Dim d As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim filenames = My.Computer.FileSystem.GetFiles(mypath, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
        For Each filename As String In filenames
            If d = Path.GetFileNameWithoutExtension(filename) Then
                RichTextBox1.Show()
                Button4.Show()
                Label1.Hide()
                Label2.Show()
                DateTimePicker1.Hide()
                Button1.Hide()
                RichTextBox1.Show()
                Label2.Text = d
                flag = 1
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(mypath + d + ".txt")
            End If
        Next
        If flag = 0 Then
            MessageBox.Show("Page is not written")
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.Hide()
        Label1.Show()
        Label2.Hide()
        DateTimePicker1.Show()
        Button1.Show()
        Button2.Show()
        RichTextBox1.Hide()
        Button4.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Hide()
        Label1.Show()
        Label2.Hide()
        DateTimePicker1.Show()
        Button1.Show()
        Button2.Show()
        RichTextBox1.Hide()
        Button4.Hide()
    End Sub
End Class