
Imports System.IO
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports

Public Class Form1

    Dim data1 = 0
    Dim data5 = 0
    Dim myPort As Array

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()

        For i = 0 To UBound(myPort)
            ComboBox1.Items.Add(myPort(i))
        Next
        ComboBox1.Text = ComboBox1.Items.Item(0)

        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    ' Other Subs and Functions...

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = 0
        TextBox5.Text = 0
        ' Other initialization code...
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Closing serial port and button settings...
    End Sub

    ' Other Event Handlers...

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Sending commands and enabling/disabling buttons...
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Sending commands and enabling/disabling buttons...
    End Sub

    ' SerialPort1_DataReceived and other Subs...

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        ' Handling PictureBox click event...
    End Sub

    ' Other Subs and Functions...

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Handling TextBox1's text changed event...
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ' Handling TextBox5's text changed event...
    End Sub
End Class
