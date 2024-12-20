Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports HslCommunication.Profinet.Omron
Imports HslCommunication

Public Class Form1
    Public omronPLC As OmronFinsNet

    Private Sub StartTimer_Tick(sender As Object, e As EventArgs) Handles StartTimer.Tick
        Read_D01()
        Read_D02()
        Read_D03()
        Read_D04()
        Read_D05()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim secondaryMonitor = Screen.AllScreens.FirstOrDefault(Function(x) Not x.Primary)

        If secondaryMonitor IsNot Nothing Then
            ' Set the form's start position to manual
            Me.StartPosition = FormStartPosition.Manual
            ' Set the location of the form to the top-left corner of the secondary monitor
            Me.Location = secondaryMonitor.Bounds.Location
            Me.WindowState = FormWindowState.Maximized
            Me.Show()
        Else
            Bounds = Screen.PrimaryScreen.WorkingArea
        End If

        Connect_toPLC()

        TimerDT.Enabled = True
        StartTimer.Enabled = True

        lblGLStatus.Text = "Normal"

        'txtGT01.Text = "2.12 %"
        'txtGT01.ForeColor = Color.White
        'txtGT01.BackColor = Color.Red
        'picGT01_Alarm.Visible = True

        'txtGT17.Text = "2.12 %"
        'txtGT17.ForeColor = Color.White
        'txtGT17.BackColor = Color.Red
        'picGT17_Alarm.Visible = True

        'txtGT33.Text = "2.12 %"
        'txtGT33.ForeColor = Color.White
        'txtGT33.BackColor = Color.Red
        'picGT33_Alarm.Visible = True

        'txtGT49.Text = "2.12 %"
        'txtGT49.ForeColor = Color.White
        'txtGT49.BackColor = Color.Red
        'picGT49_Alarm.Visible = True

    End Sub

    Private Sub TimerDT_Tick(sender As Object, e As EventArgs) Handles TimerDT.Tick
        lblDateTime.Text = Date.Now.ToString("MM/dd/yyyy | hh:mm tt")
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.Control And e.KeyCode = Keys.X Then
            Me.Close()
        End If

        'If e.KeyCode = Keys.F1 Then
        '    MsgBox("F1 is pressed")
        'End If

        'Value1 = Math.Round(One_Dec, 2) ' Round to 2 decimal places
    End Sub


End Class
