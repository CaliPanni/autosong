Imports System.Diagnostics
Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim running As Boolean = False
        Dim processes As Process() = Process.GetProcesses
        For Each process As Process In processes
            If process.ProcessName.ToLower().Contains("engine") Then
                running = True
            End If
        Next
        If running = True Then
            Label5.Visible = False
            Label4.Visible = True
            Button2.Enabled = True
            Button1.Enabled = False
        Else
            Label5.Visible = True
            Label4.Visible = False
            Button2.Enabled = False
            Button1.Enabled = True
        End If
        Dim direc As String = AppDomain.CurrentDomain.BaseDirectory
        TextBox1.Text = Path.Combine(direc, "song.txt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim proces As Process() = Process.GetProcessesByName("engine")
        For Each process As Process In proces
            process.Kill()
            Label5.Visible = True
            Label4.Visible = False
            Button2.Enabled = False
            Button1.Enabled = True
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("engine.exe")
        Label5.Visible = False
        Label4.Visible = True
        Button2.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(TextBox1.Text)
        Button3.Text = "Copiato!"
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button3.Text = "Copia"
    End Sub
End Class
