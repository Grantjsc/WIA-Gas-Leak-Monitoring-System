Public Class Design2_Form
    Private Sub Design2_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim secondaryMonitor = Screen.AllScreens.FirstOrDefault(Function(x) Not x.Primary)

        If secondaryMonitor IsNot Nothing Then
            ' Set the form's start position to manual
            Me.StartPosition = FormStartPosition.Manual
            ' Set the location of the form to the top-left corner of the secondary monitor
            Me.Location = secondaryMonitor.Bounds.Location
            Me.WindowState = FormWindowState.Maximized
            Me.Show()
        Else
            Me.WindowState = FormWindowState.Maximized
            'Bounds = Screen.PrimaryScreen.WorkingArea
        End If

        Get_COM_NAME()
        Get_IP_Address()

        Connect_toPLC()
        ShowAllSensors()
        ShowLayout()

        TimerDT.Enabled = True

        'Timer_ReadOmron.Enabled = True 'Moved to the Code file Module Read_OMRON_PLC_Module (Sub Connect_toPLC())

    End Sub

    Private Sub TimerDT_Tick(sender As Object, e As EventArgs) Handles TimerDT.Tick
        lblDateTime.Text = Date.Now.ToString("MM/dd/yyyy | hh:mm tt")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer_ReadOmron_Tick(sender As Object, e As EventArgs) Handles Timer_ReadOmron.Tick
        Read_OmronPLC_Data() ' Display all data
        Read_OmronPLC_Alarm()
    End Sub

    Private Sub btnSMS_Test_Click(sender As Object, e As EventArgs) Handles btnSMS_Test.Click
        SMS_Warning()
    End Sub

    Private Sub ChangeIPAddressCOMNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeIPAddressCOMNameToolStripMenuItem.Click
        'PassChanges_Form.ShowDialog()
        Load_Settings()
    End Sub

    Private Sub AddAssociateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAssociateToolStripMenuItem.Click
        Load_AddForm()
    End Sub

    Private Sub btnEmail_Test_Click(sender As Object, e As EventArgs) Handles btnEmail_Test.Click
        Send_Email()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset_Btn()
    End Sub

    Private Sub TimerSaveDb_Tick(sender As Object, e As EventArgs) Handles TimerSaveDb.Tick
        Update_GT_ValDb()
    End Sub
End Class