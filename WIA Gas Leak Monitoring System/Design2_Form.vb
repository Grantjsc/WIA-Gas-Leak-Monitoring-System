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
        PassChanges_Form.ShowDialog()
        'Load_Settings()
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

    Private Sub TimerMessages_Tick(sender As Object, e As EventArgs) Handles TimerMessages.Tick

        Get_Message_Delay()

        TimerMessages.Interval = Mes_Del

        If Not (GT01_Alarm Or GT02_Alarm Or GT03_Alarm Or GT04_Alarm Or GT05_Alarm Or
        GT06_Alarm Or GT07_Alarm Or GT08_Alarm Or GT09_Alarm Or GT10_Alarm Or
        GT11_Alarm Or GT12_Alarm Or GT13_Alarm Or GT14_Alarm Or GT15_Alarm Or
        GT16_Alarm Or GT17_Alarm Or GT18_Alarm Or GT19_Alarm Or GT20_Alarm Or
        GT21_Alarm Or GT22_Alarm Or GT23_Alarm Or GT24_Alarm Or GT25_Alarm Or
        GT26_Alarm Or GT27_Alarm Or GT28_Alarm Or GT29_Alarm Or GT30_Alarm Or
        GT31_Alarm Or GT32_Alarm Or GT33_Alarm Or GT34_Alarm Or GT35_Alarm Or
        GT36_Alarm Or GT37_Alarm Or GT38_Alarm Or GT39_Alarm Or GT40_Alarm Or
        GT41_Alarm Or GT42_Alarm Or GT43_Alarm Or GT44_Alarm Or GT45_Alarm Or
        GT46_Alarm Or GT47_Alarm Or GT48_Alarm Or GT49_Alarm Or GT50_Alarm Or
        GT51_Alarm Or GT52_Alarm Or GT53_Alarm Or GT54_Alarm Or GT55_Alarm Or
        GT56_Alarm Or GT57_Alarm Or GT58_Alarm Or GT59_Alarm Or GT60_Alarm Or
        GT61_Alarm) Then

            TimerMessages.Enabled = False

            'Console.WriteLine("All alarms are False.")
            'send SMS and email (All GT in WIA are good)
            'Array.Clear(GasLeak_Loc, 0, GasLeak_Loc.Length)

            If GasLeak_Loc.Count > 0 Then
                'Console.WriteLine("The ArrayList has values.")
                TimerMessages.Enabled = False
                'SMS_NoLeak()
                'Send_Email_NoLeak()

                GasLeak_Loc.Clear()

                TimerMessages.Enabled = False
            Else
                'Console.WriteLine("The ArrayList is empty.")
            End If

        Else
            'Get_Details()

            SMS_Warning()
            Send_Email()
            'Console.WriteLine("At least one alarm is True.")
        End If
    End Sub

    Private Sub MessageRecipientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessageRecipientToolStripMenuItem.Click
        Update_MessAndDelay = True
        PassChanges_Form.ShowDialog()
    End Sub

    Sub Send_One()
        Get_Message_Delay()

        TimerMessages.Interval = Mes_Del

        If GT01_Alarm And GT02_Alarm And GT03_Alarm And GT04_Alarm And GT05_Alarm And
     GT06_Alarm And GT07_Alarm And GT08_Alarm And GT09_Alarm And GT10_Alarm And
     GT11_Alarm And GT12_Alarm And GT13_Alarm And GT14_Alarm And GT15_Alarm And
     GT16_Alarm And GT17_Alarm And GT18_Alarm And GT19_Alarm And GT20_Alarm And
     GT21_Alarm And GT22_Alarm And GT23_Alarm And GT24_Alarm And GT25_Alarm And
     GT26_Alarm And GT27_Alarm And GT28_Alarm And GT29_Alarm And GT30_Alarm And
     GT31_Alarm And GT32_Alarm And GT33_Alarm And GT34_Alarm And GT35_Alarm And
     GT36_Alarm And GT37_Alarm And GT38_Alarm And GT39_Alarm And GT40_Alarm And
     GT41_Alarm And GT42_Alarm And GT43_Alarm And GT44_Alarm And GT45_Alarm And
     GT46_Alarm And GT47_Alarm And GT48_Alarm And GT49_Alarm And GT50_Alarm And
     GT51_Alarm And GT52_Alarm And GT53_Alarm And GT54_Alarm And GT55_Alarm And
     GT56_Alarm And GT57_Alarm And GT58_Alarm And GT59_Alarm And GT60_Alarm And
     GT61_Alarm Then

            TimerMessages.Enabled = False

            'Console.WriteLine("All alarms are False.")
            'send SMS and email (All GT in WIA are good)
            'Array.Clear(GasLeak_Loc, 0, GasLeak_Loc.Length)

            If GasLeak_Loc.Count > 0 Then
                'Console.WriteLine("The ArrayList has values.")
                SMS_NoLeak()
                Send_Email_NoLeak()

                GasLeak_Loc.Clear()

                TimerMessages.Enabled = False
            Else
                'Console.WriteLine("The ArrayList is empty.")
            End If

        Else
            'Get_Details()

            SMS_Warning()
            Send_Email()
            'Console.WriteLine("At least one alarm is True.")
        End If
    End Sub


End Class