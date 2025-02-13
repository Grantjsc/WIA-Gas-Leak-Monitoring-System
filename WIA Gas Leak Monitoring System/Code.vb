Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO.Ports
Imports System.Net.Mail
Imports System.Threading
Imports System.Web
Imports System.Web.Hosting
Imports System.Xml
Imports HslCommunication.Profinet.Omron
Imports TextmagicRest
Imports TextmagicRest.Model

Module Read_OMRON_PLC_Module

    Sub Connect_toPLC()
        Form1.omronPLC = New OmronFinsNet(IP, 9600)
        Form1.omronPLC.SA1 = &H0 ' Source Node Address (PC)
        Form1.omronPLC.DA1 = &H1 ' Destination Node Address (PLC)
        Form1.omronPLC.ReceiveTimeOut = 10000 ' Increase timeout to 10 seconds
        ' Attempt to connect
        Dim connectResult = Form1.omronPLC.ConnectServer()
        If connectResult.IsSuccess Then
            Console.WriteLine("Connected to Omron NX102-9020 PLC successfully!")
            Design2_Form.Timer_ReadOmron.Enabled = True
            Design2_Form.TimerSaveDb.Enabled = True

        Else
            'MsgBox("Failed to connect to PLC: " & connectResult.Message)
            MsgBox("Failed to connect to PLC: Please check IP Address", MsgBoxStyle.Information)
            Load_Settings()
            'Console.WriteLine("Failed to connect to PLC: " & connectResult.Message)
        End If
    End Sub

    Sub Read_OmronPLC_Data()
        Read_D00()
        Read_D01()
        Read_D02()
        Read_D03()
        Read_D04()
        Read_D05()
        Read_D06()
        Read_D07()
        Read_D08()
        Read_D09()
        Read_D10()
        Read_D11()
        Read_D12()
        Read_D13()
        Read_D14()
        Read_D15()
        Read_D16()
        Read_D17()
        Read_D18()
        Read_D19()
        Read_D20()
        Read_D21()
        Read_D22()
        Read_D23()
        Read_D24()
        Read_D25()
        Read_D26()
        Read_D27()
        Read_D28()
        Read_D29()
        Read_D30()
        Read_D31()
        Read_D32()
        Read_D33()
        Read_D34()
        Read_D35()
        Read_D36()
        Read_D37()
        Read_D38()
        Read_D39()
        Read_D40()
        Read_D41()
        Read_D42()
        Read_D43()
        Read_D44()
        Read_D45()
        Read_D46()
        Read_D47()
        Read_D48()
        Read_D49()
        Read_D50()
        Read_D51()
        Read_D52()
        Read_D53()
        Read_D54()
        Read_D55()
        Read_D56()
        Read_D57()
        Read_D58()
        Read_D59()
        Read_D60()
    End Sub

    ' Selas 01 Sensors Value

    Sub Read_D00()
        Dim readResult = Form1.omronPLC.ReadInt16("D00")
        If readResult.IsSuccess Then
            'MessageBox.Show("D100 Value: " & readResult.Content.ToString())
            'Math.Round(readResult.Content, 2) & " %"
            Sensors_Form.txtSelas01_Up.Text = readResult.Content & " %"
            GT01_Val = CDec(readResult.Content)
        Else
            'MessageBox.Show("Failed to read data: " & readResult.Message)
            'Console.WriteLine("Failed to read data: " & readResult.Message)
        End If
    End Sub

    Sub Read_D01()
        Dim readResult = Form1.omronPLC.ReadInt16("D01")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas01_Mid.Text = readResult.Content & " %"
            GT02_Val = CDec(readResult.Content)
        End If
    End Sub

    Sub Read_D02()
        Dim readResult = Form1.omronPLC.ReadInt16("D02")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas01_Low.Text = readResult.Content & " %"
            GT03_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 02 Sensors Value

    Sub Read_D03()
        Dim readResult = Form1.omronPLC.ReadInt16("D03")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas02_Up.Text = readResult.Content & " %"
            GT04_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D04()
        Dim readResult = Form1.omronPLC.ReadInt16("D04")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas02_Mid.Text = readResult.Content & " %"
            GT05_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D05()
        Dim readResult = Form1.omronPLC.ReadInt16("D05")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas02_Low.Text = readResult.Content & " %"
            GT06_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 03 Sensors Value
    Sub Read_D06()
        Dim readResult = Form1.omronPLC.ReadInt16("D06")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas03_Up.Text = readResult.Content & " %"
            GT07_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D07()
        Dim readResult = Form1.omronPLC.ReadInt16("D07")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas03_Mid.Text = readResult.Content & " %"
            GT08_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D08()
        Dim readResult = Form1.omronPLC.ReadInt16("D08")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas03_Low.Text = readResult.Content & " %"
            GT09_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 04 Sensors Value

    Sub Read_D09()
        Dim readResult = Form1.omronPLC.ReadInt16("D09")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas04_Up.Text = readResult.Content & " %"
            GT10_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D10()
        Dim readResult = Form1.omronPLC.ReadInt16("D10")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas04_Mid.Text = readResult.Content & " %"
            GT11_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D11()
        Dim readResult = Form1.omronPLC.ReadInt16("D11")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas04_Low.Text = readResult.Content & " %"
            GT12_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 05 Sensors Value

    Sub Read_D12()
        Dim readResult = Form1.omronPLC.ReadInt16("D12")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas05_Up.Text = readResult.Content & " %"
            GT13_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D13()
        Dim readResult = Form1.omronPLC.ReadInt16("D13")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas05_Mid.Text = readResult.Content & " %"
            GT14_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D14()
        Dim readResult = Form1.omronPLC.ReadInt16("D14")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas05_Low.Text = readResult.Content & " %"
            GT15_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 06 Sensors Value

    Sub Read_D15()
        Dim readResult = Form1.omronPLC.ReadInt16("D15")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas06_Up.Text = readResult.Content & " %"
            GT16_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D16()
        Dim readResult = Form1.omronPLC.ReadInt16("D16")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas06_Mid.Text = readResult.Content & " %"
            GT17_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D17()
        Dim readResult = Form1.omronPLC.ReadInt16("D17")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas06_Low.Text = readResult.Content & " %"
            GT18_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 07 Sensors Value

    Sub Read_D18()
        Dim readResult = Form1.omronPLC.ReadInt16("D18")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas07_Up.Text = readResult.Content & " %"
            GT19_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D19()
        Dim readResult = Form1.omronPLC.ReadInt16("D19")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas07_Mid.Text = readResult.Content & " %"
            GT20_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D20()
        Dim readResult = Form1.omronPLC.ReadInt16("D20")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas07_Low.Text = readResult.Content & " %"
            GT21_Val = CDec(readResult.Content)
        End If
    End Sub


    ' Selas 08 Sensors Value

    Sub Read_D21()
        Dim readResult = Form1.omronPLC.ReadInt16("D21")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas08_Up.Text = readResult.Content & " %"
            GT22_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D22()
        Dim readResult = Form1.omronPLC.ReadInt16("D22")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas08_Mid.Text = readResult.Content & " %"
            GT23_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D23()
        Dim readResult = Form1.omronPLC.ReadInt16("D23")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas08_Low.Text = readResult.Content & " %"
            GT24_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 09 Sensors Value

    Sub Read_D24()
        Dim readResult = Form1.omronPLC.ReadInt16("D24")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas09_Up.Text = readResult.Content & " %"
            GT25_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D25()
        Dim readResult = Form1.omronPLC.ReadInt16("D25")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas09_Mid.Text = readResult.Content & " %"
            GT26_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D26()
        Dim readResult = Form1.omronPLC.ReadInt16("D26")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas09_Low.Text = readResult.Content & " %"
            GT27_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 10 Sensors Value

    Sub Read_D27()
        Dim readResult = Form1.omronPLC.ReadInt16("D27")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas10_Up.Text = readResult.Content & " %"
            GT28_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D28()
        Dim readResult = Form1.omronPLC.ReadInt16("D28")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas10_Mid.Text = readResult.Content & " %"
            GT29_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D29()
        Dim readResult = Form1.omronPLC.ReadInt16("D29")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas10_Low.Text = readResult.Content & " %"
            GT30_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 11 Sensors Value

    Sub Read_D30()
        Dim readResult = Form1.omronPLC.ReadInt16("D30")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas11_Up.Text = readResult.Content & " %"
            GT31_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D31()
        Dim readResult = Form1.omronPLC.ReadInt16("D31")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas11_Mid.Text = readResult.Content & " %"
            GT32_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D32()
        Dim readResult = Form1.omronPLC.ReadInt16("D32")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas11_Low.Text = readResult.Content & " %"
            GT33_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 12 Sensors Value

    Sub Read_D33()
        Dim readResult = Form1.omronPLC.ReadInt16("D33")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas12_Up.Text = readResult.Content & " %"
            GT34_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D34()
        Dim readResult = Form1.omronPLC.ReadInt16("D34")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas12_Mid.Text = readResult.Content & " %"
            GT35_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D35()
        Dim readResult = Form1.omronPLC.ReadInt16("D35")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas12_Low.Text = readResult.Content & " %"
            GT36_Val = CDec(readResult.Content)
        End If
    End Sub

    ' Selas 13 Sensors Value

    Sub Read_D36()
        Dim readResult = Form1.omronPLC.ReadInt16("D36")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas13_Up.Text = readResult.Content & " %"
            GT37_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D37()
        Dim readResult = Form1.omronPLC.ReadInt16("D37")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas13_Mid.Text = readResult.Content & " %"
            GT38_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D38()
        Dim readResult = Form1.omronPLC.ReadInt16("D38")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas13_Low.Text = readResult.Content & " %"
            GT39_Val = CDec(readResult.Content)
        End If
    End Sub

    'WAREHOUSE TRENCH SENSOR VALUE
    Sub Read_D39()
        Dim readResult = Form1.omronPLC.ReadInt16("D39")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_01.Text = readResult.Content & " %"
            GT40_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D40()
        Dim readResult = Form1.omronPLC.ReadInt16("D40")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_02.Text = readResult.Content & " %"
            GT41_Val = CDec(readResult.Content)
        End If
    End Sub

    'PICO TO NANO TRENCH SENSOR VALUE
    Sub Read_D41()
        Dim readResult = Form1.omronPLC.ReadInt16("D41")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_03.Text = readResult.Content & " %"
            GT42_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D42()
        Dim readResult = Form1.omronPLC.ReadInt16("D42")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_04.Text = readResult.Content & " %"
            GT43_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D43()
        Dim readResult = Form1.omronPLC.ReadInt16("D43")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_05.Text = readResult.Content & " %"
            GT44_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D44()
        Dim readResult = Form1.omronPLC.ReadInt16("D44")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_06.Text = readResult.Content & " %"
            GT45_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D45()
        Dim readResult = Form1.omronPLC.ReadInt16("D45")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_07.Text = readResult.Content & " %"
            GT46_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D46()
        Dim readResult = Form1.omronPLC.ReadInt16("D46")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_08.Text = readResult.Content & " %"
            GT47_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D47()
        Dim readResult = Form1.omronPLC.ReadInt16("D47")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_09.Text = readResult.Content & " %"
            GT48_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D48()
        Dim readResult = Form1.omronPLC.ReadInt16("D48")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_10.Text = readResult.Content & " %"
            GT49_Val = CDec(readResult.Content)
        End If
    End Sub

    'PICO TRENCH SENSOR VALUE
    Sub Read_D49()
        Dim readResult = Form1.omronPLC.ReadInt16("D49")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_11.Text = readResult.Content & " %"
            GT50_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D50()
        Dim readResult = Form1.omronPLC.ReadInt16("D50")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_12.Text = readResult.Content & " %"
            GT51_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D51()
        Dim readResult = Form1.omronPLC.ReadInt16("D51")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_13.Text = readResult.Content & " %"
            GT52_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D52()
        Dim readResult = Form1.omronPLC.ReadInt16("D52")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_14.Text = readResult.Content & " %"
            GT53_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D53()
        Dim readResult = Form1.omronPLC.ReadInt16("D53")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_15.Text = readResult.Content & " %"
            GT54_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D54()
        Dim readResult = Form1.omronPLC.ReadInt16("D54")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_16.Text = readResult.Content & " %"
            GT55_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D55()
        Dim readResult = Form1.omronPLC.ReadInt16("D55")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_17.Text = readResult.Content & " %"
            GT56_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D56()
        Dim readResult = Form1.omronPLC.ReadInt16("D56")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_18.Text = readResult.Content & " %"
            GT57_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D57()
        Dim readResult = Form1.omronPLC.ReadInt16("D57")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_19.Text = readResult.Content & " %"
            GT58_Val = CDec(readResult.Content)
        End If
    End Sub
    Sub Read_D58()
        Dim readResult = Form1.omronPLC.ReadInt16("D58")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_20.Text = readResult.Content & " %"
            GT59_Val = CDec(readResult.Content)
        End If
    End Sub

    '***************** GAS MIXING ************************
    Sub Read_D59()
        Dim readResult = Form1.omronPLC.ReadInt16("D59")
        If readResult.IsSuccess Then
            Sensors_Form.txtGM1.Text = readResult.Content & " %"
            GT60_Val = CDec(readResult.Content)
        End If
    End Sub

    Sub Read_D60()
        Dim readResult = Form1.omronPLC.ReadInt16("D60")
        If readResult.IsSuccess Then
            Sensors_Form.txtGM4.Text = readResult.Content & " %"
            GT61_Val = CDec(readResult.Content)
        End If
    End Sub


    Public DM_Reading1 As String
    Public DM_Reading2 As String
    Public DM_Reading3 As String

    Public Alarm_Reading1 As String
    Public Alarm_Reading2 As String
    Public Alarm_Reading3 As String
    Public ThreeVal_Read As Boolean = False


    ' ****************** READ ShowSenVal_Forn ***********************
    Sub Read_Val1()
        Dim readResult = Form1.omronPLC.ReadInt16(DM_Reading1)
        If readResult.IsSuccess Then
            ShowSenVal_Form.txtSelas_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_Val2()
        Dim readResult = Form1.omronPLC.ReadInt16(DM_Reading2)
        If readResult.IsSuccess Then
            ShowSenVal_Form.txtSelas_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_Val3()
        Dim readResult = Form1.omronPLC.ReadInt16(DM_Reading3)
        If readResult.IsSuccess Then
            ShowSenVal_Form.txtSelas_Low.Text = readResult.Content & " %"
        End If
    End Sub

    Sub Read_Val1_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool(Alarm_Reading1)
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                ShowSenVal_Form.txtSelas_Up.ForeColor = Color.Lime
                ShowSenVal_Form.txtSelas_Up.BackColor = Color.Black
                ShowSenVal_Form.picSelas_Up_Alarm.Visible = False

            Else

                ShowSenVal_Form.txtSelas_Up.ForeColor = Color.White
                ShowSenVal_Form.txtSelas_Up.BackColor = Color.Red
                ShowSenVal_Form.picSelas_Up_Alarm.Visible = True

            End If
        End If
    End Sub
    Sub Read_Val2_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool(Alarm_Reading2)
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                ShowSenVal_Form.txtSelas_Mid.ForeColor = Color.Lime
                ShowSenVal_Form.txtSelas_Mid.BackColor = Color.Black
                ShowSenVal_Form.picSelas_Mid_Alarm.Visible = False

            Else

                ShowSenVal_Form.txtSelas_Mid.ForeColor = Color.White
                ShowSenVal_Form.txtSelas_Mid.BackColor = Color.Red
                ShowSenVal_Form.picSelas_Mid_Alarm.Visible = True

            End If
        End If
    End Sub
    Sub Read_Val3_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool(Alarm_Reading3)
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                ShowSenVal_Form.txtSelas_Low.ForeColor = Color.Lime
                ShowSenVal_Form.txtSelas_Low.BackColor = Color.Black
                ShowSenVal_Form.picSelas_Low_Alarm.Visible = False

            Else

                ShowSenVal_Form.txtSelas_Low.ForeColor = Color.White
                ShowSenVal_Form.txtSelas_Low.BackColor = Color.Red
                ShowSenVal_Form.picSelas_Low_Alarm.Visible = True

            End If
        End If
    End Sub

    Sub Reset_Btn()
        Dim writeResult = Form1.omronPLC.Write("C0.03", True)
    End Sub

End Module

Module Read_Alarm_Module

    Public GasLeak_Loc As New List(Of String)()

    Public GT01_Location As String = "- Selas 01: Upper"
    Public GT02_Location As String = "- Selas 01: Middle"
    Public GT03_Location As String = "- Selas 01: Lower"

    Public GT04_Location As String = "- Selas 02: Upper"
    Public GT05_Location As String = "- Selas 02: Middle"
    Public GT06_Location As String = "- Selas 02: Lower"

    Public GT07_Location As String = "- Selas 03: Upper"
    Public GT08_Location As String = "- Selas 03: Middle"
    Public GT09_Location As String = "- Selas 03: Lower"

    Public GT10_Location As String = "- Selas 04: Upper"
    Public GT11_Location As String = "- Selas 04: Middle"
    Public GT12_Location As String = "- Selas 04: Lower"

    Public GT13_Location As String = "- Selas 05: Upper"
    Public GT14_Location As String = "- Selas 05: Middle"
    Public GT15_Location As String = "- Selas 05: Lower"

    Public GT16_Location As String = "- Selas 06: Upper"
    Public GT17_Location As String = "- Selas 06: Middle"
    Public GT18_Location As String = "- Selas 06: Lower"

    Public GT19_Location As String = "- Selas 07: Upper"
    Public GT20_Location As String = "- Selas 07: Middle"
    Public GT21_Location As String = "- Selas 07: Lower"

    Public GT22_Location As String = "- Selas 08: Upper"
    Public GT23_Location As String = "- Selas 08: Middle"
    Public GT24_Location As String = "- Selas 08: Lower"

    Public GT25_Location As String = "- Selas 09: Upper"
    Public GT26_Location As String = "- Selas 09: Middle"
    Public GT27_Location As String = "- Selas 09: Lower"

    Public GT28_Location As String = "- Selas 10: Upper"
    Public GT29_Location As String = "- Selas 10: Middle"
    Public GT30_Location As String = "- Selas 10: Lower"

    Public GT31_Location As String = "- Selas 11: Upper"
    Public GT32_Location As String = "- Selas 11: Middle"
    Public GT33_Location As String = "- Selas 11: Lower"

    Public GT34_Location As String = "- Selas 12: Upper"
    Public GT35_Location As String = "- Selas 12: Middle"
    Public GT36_Location As String = "- Selas 12: Lower"

    Public GT37_Location As String = "- Selas 13: Upper"
    Public GT38_Location As String = "- Selas 13: Middle"
    Public GT39_Location As String = "- Selas 13: Lower"

    Public GT40_Location As String = "- Warehouse: Trench 01"
    Public GT41_Location As String = "- Warehouse: Trench 02"

    Public GT42_Location As String = "- PICO to NANO: Trench 03"
    Public GT43_Location As String = "- PICO to NANO: Trench 04"
    Public GT44_Location As String = "- PICO to NANO: Trench 05"
    Public GT45_Location As String = "- PICO to NANO: Trench 06"
    Public GT46_Location As String = "- PICO to NANO: Trench 07"
    Public GT47_Location As String = "- PICO to NANO: Trench 08"
    Public GT48_Location As String = "- PICO to NANO: Trench 09"
    Public GT49_Location As String = "- PICO to NANO: Trench 10"

    Public GT50_Location As String = "- PICO: Trench 11"
    Public GT51_Location As String = "- PICO: Trench 12"
    Public GT52_Location As String = "- PICO: Trench 13"
    Public GT53_Location As String = "- PICO: Trench 14"
    Public GT54_Location As String = "- PICO: Trench 15"
    Public GT55_Location As String = "- PICO: Trench 16"
    Public GT56_Location As String = "- PICO: Trench 17"
    Public GT57_Location As String = "- PICO: Trench 18"
    Public GT58_Location As String = "- PICO: Trench 19"
    Public GT59_Location As String = "- PICO: Trench 20"

    Public GT60_Location As String = "- Gas Mixing: 1"
    Public GT61_Location As String = "- Gas Mixing: 4"

    Public GT01_Alarm As Boolean = False
    Public GT02_Alarm As Boolean = False
    Public GT03_Alarm As Boolean = False
    Public GT04_Alarm As Boolean = False
    Public GT05_Alarm As Boolean = False
    Public GT06_Alarm As Boolean = False
    Public GT07_Alarm As Boolean = False
    Public GT08_Alarm As Boolean = False
    Public GT09_Alarm As Boolean = False
    Public GT10_Alarm As Boolean = False
    Public GT11_Alarm As Boolean = False
    Public GT12_Alarm As Boolean = False
    Public GT13_Alarm As Boolean = False
    Public GT14_Alarm As Boolean = False
    Public GT15_Alarm As Boolean = False
    Public GT16_Alarm As Boolean = False
    Public GT17_Alarm As Boolean = False
    Public GT18_Alarm As Boolean = False
    Public GT19_Alarm As Boolean = False
    Public GT20_Alarm As Boolean = False
    Public GT21_Alarm As Boolean = False
    Public GT22_Alarm As Boolean = False
    Public GT23_Alarm As Boolean = False
    Public GT24_Alarm As Boolean = False
    Public GT25_Alarm As Boolean = False
    Public GT26_Alarm As Boolean = False
    Public GT27_Alarm As Boolean = False
    Public GT28_Alarm As Boolean = False
    Public GT29_Alarm As Boolean = False
    Public GT30_Alarm As Boolean = False
    Public GT31_Alarm As Boolean = False
    Public GT32_Alarm As Boolean = False
    Public GT33_Alarm As Boolean = False
    Public GT34_Alarm As Boolean = False
    Public GT35_Alarm As Boolean = False
    Public GT36_Alarm As Boolean = False
    Public GT37_Alarm As Boolean = False
    Public GT38_Alarm As Boolean = False
    Public GT39_Alarm As Boolean = False
    Public GT40_Alarm As Boolean = False
    Public GT41_Alarm As Boolean = False
    Public GT42_Alarm As Boolean = False
    Public GT43_Alarm As Boolean = False
    Public GT44_Alarm As Boolean = False
    Public GT45_Alarm As Boolean = False
    Public GT46_Alarm As Boolean = False
    Public GT47_Alarm As Boolean = False
    Public GT48_Alarm As Boolean = False
    Public GT49_Alarm As Boolean = False
    Public GT50_Alarm As Boolean = False
    Public GT51_Alarm As Boolean = False
    Public GT52_Alarm As Boolean = False
    Public GT53_Alarm As Boolean = False
    Public GT54_Alarm As Boolean = False
    Public GT55_Alarm As Boolean = False
    Public GT56_Alarm As Boolean = False
    Public GT57_Alarm As Boolean = False
    Public GT58_Alarm As Boolean = False
    Public GT59_Alarm As Boolean = False
    Public GT60_Alarm As Boolean = False
    Public GT61_Alarm As Boolean = False

    Sub Read_OmronPLC_Alarm()
        D00_Alarm()
        D01_Alarm()
        D02_Alarm()
        D03_Alarm()
        D04_Alarm()
        D05_Alarm()
        D06_Alarm()
        D07_Alarm()
        D08_Alarm()
        D09_Alarm()
        D10_Alarm()
        D11_Alarm()
        D12_Alarm()
        D13_Alarm()
        D14_Alarm()
        D15_Alarm()
        D16_Alarm()
        D17_Alarm()
        D18_Alarm()
        D19_Alarm()
        D20_Alarm()
        D21_Alarm()
        D22_Alarm()
        D23_Alarm()
        D24_Alarm()
        D25_Alarm()
        D26_Alarm()
        D27_Alarm()
        D28_Alarm()
        D29_Alarm()
        D30_Alarm()
        D31_Alarm()
        D32_Alarm()
        D33_Alarm()
        D34_Alarm()
        D35_Alarm()
        D36_Alarm()
        D37_Alarm()
        D38_Alarm()
        D39_Alarm()
        D40_Alarm()
        D41_Alarm()
        D42_Alarm()
        D43_Alarm()
        D44_Alarm()
        D45_Alarm()
        D46_Alarm()
        D47_Alarm()
        D48_Alarm()
        D49_Alarm()
        D50_Alarm()
        D51_Alarm()
        D52_Alarm()
        D53_Alarm()
        D54_Alarm()
        D55_Alarm()
        D56_Alarm()
        D57_Alarm()
        D58_Alarm()
        D59_Alarm()
        D60_Alarm()
    End Sub

    ' Selas 01 Sensors Alarm
    Sub D00_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.00")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas01.FillColor = Color.Black

                WIA_Layout_Form.btnS01.FillColor = Color.Lime
                WIA_Layout_Form.btnS01.ForeColor = Color.Black

                Sensors_Form.txtSelas01_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas01_Up.BackColor = Color.Black
                Sensors_Form.picSelas01_Up_Alarm.Visible = False

                GT01_Alarm = False
            Else

                WIA_Layout_Form.btnSelas01.FillColor = Color.Red

                WIA_Layout_Form.btnS01.FillColor = Color.Red
                WIA_Layout_Form.btnS01.ForeColor = Color.White

                Sensors_Form.txtSelas01_Up.ForeColor = Color.White
                Sensors_Form.txtSelas01_Up.BackColor = Color.Red
                Sensors_Form.picSelas01_Up_Alarm.Visible = True

                GT01_Alarm = True

                If GT01_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT01_Location) Then
                        GasLeak_Loc.Add(GT01_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D01_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.01")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas01.FillColor = Color.Black

                WIA_Layout_Form.btnS01.FillColor = Color.Lime
                WIA_Layout_Form.btnS01.ForeColor = Color.Black

                Sensors_Form.txtSelas01_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas01_Mid.BackColor = Color.Black
                Sensors_Form.picSelas01_Mid_Alarm.Visible = False

                GT02_Alarm = False

            Else

                WIA_Layout_Form.btnSelas01.FillColor = Color.Red

                WIA_Layout_Form.btnS01.FillColor = Color.Red
                WIA_Layout_Form.btnS01.ForeColor = Color.White

                Sensors_Form.txtSelas01_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas01_Mid.BackColor = Color.Red
                Sensors_Form.picSelas01_Mid_Alarm.Visible = True

                GT02_Alarm = True

                If GT02_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT02_Location) Then
                        GasLeak_Loc.Add(GT02_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D02_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.02")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas01.FillColor = Color.Black

                WIA_Layout_Form.btnS01.FillColor = Color.Lime
                WIA_Layout_Form.btnS01.ForeColor = Color.Black

                Sensors_Form.txtSelas01_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas01_Low.BackColor = Color.Black
                Sensors_Form.picSelas01_Low_Alarm.Visible = False

                GT03_Alarm = False

            Else

                WIA_Layout_Form.btnSelas01.FillColor = Color.Red

                WIA_Layout_Form.btnS01.FillColor = Color.Red
                WIA_Layout_Form.btnS01.ForeColor = Color.White

                Sensors_Form.txtSelas01_Low.ForeColor = Color.White
                Sensors_Form.txtSelas01_Low.BackColor = Color.Red
                Sensors_Form.picSelas01_Low_Alarm.Visible = True

                GT03_Alarm = True

                If GT03_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT03_Location) Then
                        GasLeak_Loc.Add(GT03_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    ' Selas 02 Sensors Alarm
    Sub D03_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.03")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas02.FillColor = Color.Black

                WIA_Layout_Form.btnS02.FillColor = Color.Lime
                WIA_Layout_Form.btnS02.ForeColor = Color.Black

                Sensors_Form.txtSelas02_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas02_Up.BackColor = Color.Black
                Sensors_Form.picSelas02_Up_Alarm.Visible = False

                GT04_Alarm = False

            Else

                WIA_Layout_Form.btnSelas02.FillColor = Color.Red

                WIA_Layout_Form.btnS02.FillColor = Color.Red
                WIA_Layout_Form.btnS02.ForeColor = Color.White

                Sensors_Form.txtSelas02_Up.ForeColor = Color.White
                Sensors_Form.txtSelas02_Up.BackColor = Color.Red
                Sensors_Form.picSelas02_Up_Alarm.Visible = True

                GT04_Alarm = True

                If GT04_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT04_Location) Then
                        GasLeak_Loc.Add(GT04_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D04_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.04")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas02.FillColor = Color.Black

                WIA_Layout_Form.btnS02.FillColor = Color.Lime
                WIA_Layout_Form.btnS02.ForeColor = Color.Black

                Sensors_Form.txtSelas02_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas02_Mid.BackColor = Color.Black
                Sensors_Form.picSelas02_Mid_Alarm.Visible = False

                GT05_Alarm = False

            Else

                WIA_Layout_Form.btnSelas02.FillColor = Color.Red

                WIA_Layout_Form.btnS02.FillColor = Color.Red
                WIA_Layout_Form.btnS02.ForeColor = Color.White

                Sensors_Form.txtSelas02_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas02_Mid.BackColor = Color.Red
                Sensors_Form.picSelas02_Mid_Alarm.Visible = True

                GT05_Alarm = True

                If GT05_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT05_Location) Then
                        GasLeak_Loc.Add(GT05_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D05_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.05")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas02.FillColor = Color.Black

                WIA_Layout_Form.btnS02.FillColor = Color.Lime
                WIA_Layout_Form.btnS02.ForeColor = Color.Black

                Sensors_Form.txtSelas02_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas02_Low.BackColor = Color.Black
                Sensors_Form.picSelas02_Low_Alarm.Visible = False

                GT06_Alarm = False

            Else

                WIA_Layout_Form.btnSelas02.FillColor = Color.Red

                WIA_Layout_Form.btnS02.FillColor = Color.Red
                WIA_Layout_Form.btnS02.ForeColor = Color.White

                Sensors_Form.txtSelas02_Low.ForeColor = Color.White
                Sensors_Form.txtSelas02_Low.BackColor = Color.Red
                Sensors_Form.picSelas02_Low_Alarm.Visible = True

                GT06_Alarm = True

                If GT06_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT06_Location) Then
                        GasLeak_Loc.Add(GT06_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    ' Selas 03 Sensors Alarm
    Sub D06_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.06")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas03.FillColor = Color.Black

                WIA_Layout_Form.btnS03.FillColor = Color.Lime
                WIA_Layout_Form.btnS03.ForeColor = Color.Black

                Sensors_Form.txtSelas03_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas03_Up.BackColor = Color.Black
                Sensors_Form.picSelas03_Up_Alarm.Visible = False

                GT07_Alarm = False

            Else

                WIA_Layout_Form.btnSelas03.FillColor = Color.Red

                WIA_Layout_Form.btnS03.FillColor = Color.Red
                WIA_Layout_Form.btnS03.ForeColor = Color.White

                Sensors_Form.txtSelas03_Up.ForeColor = Color.White
                Sensors_Form.txtSelas03_Up.BackColor = Color.Red
                Sensors_Form.picSelas03_Up_Alarm.Visible = True

                GT07_Alarm = True

                If GT07_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT07_Location) Then
                        GasLeak_Loc.Add(GT07_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D07_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.07")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas03.FillColor = Color.Black

                WIA_Layout_Form.btnS03.FillColor = Color.Lime
                WIA_Layout_Form.btnS03.ForeColor = Color.Black

                Sensors_Form.txtSelas03_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas03_Mid.BackColor = Color.Black
                Sensors_Form.picSelas03_Mid_Alarm.Visible = False

                GT08_Alarm = False

            Else

                WIA_Layout_Form.btnSelas03.FillColor = Color.Red

                WIA_Layout_Form.btnS03.FillColor = Color.Red
                WIA_Layout_Form.btnS03.ForeColor = Color.White

                Sensors_Form.txtSelas03_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas03_Mid.BackColor = Color.Red
                Sensors_Form.picSelas03_Mid_Alarm.Visible = True

                GT08_Alarm = True

                If GT08_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT08_Location) Then
                        GasLeak_Loc.Add(GT08_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D08_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.08")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas03.FillColor = Color.Black

                WIA_Layout_Form.btnS03.FillColor = Color.Lime
                WIA_Layout_Form.btnS03.ForeColor = Color.Black

                Sensors_Form.txtSelas03_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas03_Low.BackColor = Color.Black
                Sensors_Form.picSelas03_Low_Alarm.Visible = False

                GT09_Alarm = False

            Else

                WIA_Layout_Form.btnSelas03.FillColor = Color.Red

                WIA_Layout_Form.btnS03.FillColor = Color.Red
                WIA_Layout_Form.btnS03.ForeColor = Color.White

                Sensors_Form.txtSelas03_Low.ForeColor = Color.White
                Sensors_Form.txtSelas03_Low.BackColor = Color.Red
                Sensors_Form.picSelas03_Low_Alarm.Visible = True

                GT09_Alarm = True

                If GT09_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT09_Location) Then
                        GasLeak_Loc.Add(GT09_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    ' Selas 04 Sensors Alarm
    Sub D09_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.09")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas04.FillColor = Color.Black

                WIA_Layout_Form.btnS04.FillColor = Color.Lime
                WIA_Layout_Form.btnS04.ForeColor = Color.Black

                Sensors_Form.txtSelas04_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas04_Up.BackColor = Color.Black
                Sensors_Form.picSelas04_Up_Alarm.Visible = False

                GT10_Alarm = False

            Else

                WIA_Layout_Form.btnSelas04.FillColor = Color.Red

                WIA_Layout_Form.btnS04.FillColor = Color.Red
                WIA_Layout_Form.btnS04.ForeColor = Color.White

                Sensors_Form.txtSelas04_Up.ForeColor = Color.White
                Sensors_Form.txtSelas04_Up.BackColor = Color.Red
                Sensors_Form.picSelas04_Up_Alarm.Visible = True

                GT10_Alarm = True

                If GT10_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT10_Location) Then
                        GasLeak_Loc.Add(GT10_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D10_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.10")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas04.FillColor = Color.Black

                WIA_Layout_Form.btnS04.FillColor = Color.Lime
                WIA_Layout_Form.btnS04.ForeColor = Color.Black

                Sensors_Form.txtSelas04_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas04_Mid.BackColor = Color.Black
                Sensors_Form.picSelas04_Mid_Alarm.Visible = False

                GT11_Alarm = False

            Else

                WIA_Layout_Form.btnSelas04.FillColor = Color.Red

                WIA_Layout_Form.btnS04.FillColor = Color.Red
                WIA_Layout_Form.btnS04.ForeColor = Color.White

                Sensors_Form.txtSelas04_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas04_Mid.BackColor = Color.Red
                Sensors_Form.picSelas04_Mid_Alarm.Visible = True

                GT11_Alarm = True

                If GT11_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT11_Location) Then
                        GasLeak_Loc.Add(GT11_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D11_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.11")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas04.FillColor = Color.Black

                WIA_Layout_Form.btnS04.FillColor = Color.Lime
                WIA_Layout_Form.btnS04.ForeColor = Color.Black

                Sensors_Form.txtSelas04_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas04_Low.BackColor = Color.Black
                Sensors_Form.picSelas04_Low_Alarm.Visible = False

                GT12_Alarm = False

            Else

                WIA_Layout_Form.btnSelas04.FillColor = Color.Red

                WIA_Layout_Form.btnS04.FillColor = Color.Red
                WIA_Layout_Form.btnS04.ForeColor = Color.White

                Sensors_Form.txtSelas04_Low.ForeColor = Color.White
                Sensors_Form.txtSelas04_Low.BackColor = Color.Red
                Sensors_Form.picSelas04_Low_Alarm.Visible = True

                GT12_Alarm = True

                If GT12_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT12_Location) Then
                        GasLeak_Loc.Add(GT12_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'Selas 05 Sensor Alarm
    Sub D12_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.12")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas05.FillColor = Color.Black

                WIA_Layout_Form.btnS05.FillColor = Color.Lime
                WIA_Layout_Form.btnS05.ForeColor = Color.Black

                Sensors_Form.txtSelas05_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas05_Up.BackColor = Color.Black
                Sensors_Form.picSelas05_Up_Alarm.Visible = False

                GT13_Alarm = False

            Else

                WIA_Layout_Form.btnSelas05.FillColor = Color.Red

                WIA_Layout_Form.btnS05.FillColor = Color.Red
                WIA_Layout_Form.btnS05.ForeColor = Color.White

                Sensors_Form.txtSelas05_Up.ForeColor = Color.White
                Sensors_Form.txtSelas05_Up.BackColor = Color.Red
                Sensors_Form.picSelas05_Up_Alarm.Visible = True

                GT13_Alarm = True

                If GT13_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT13_Location) Then
                        GasLeak_Loc.Add(GT13_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D13_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.13")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas05.FillColor = Color.Black

                WIA_Layout_Form.btnS05.FillColor = Color.Lime
                WIA_Layout_Form.btnS05.ForeColor = Color.Black

                Sensors_Form.txtSelas05_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas05_Mid.BackColor = Color.Black
                Sensors_Form.picSelas05_Mid_Alarm.Visible = False

                GT14_Alarm = False

            Else

                WIA_Layout_Form.btnSelas05.FillColor = Color.Red

                WIA_Layout_Form.btnS05.FillColor = Color.Red
                WIA_Layout_Form.btnS05.ForeColor = Color.White

                Sensors_Form.txtSelas05_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas05_Mid.BackColor = Color.Red
                Sensors_Form.picSelas05_Mid_Alarm.Visible = True

                GT14_Alarm = True

                If GT14_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT14_Location) Then
                        GasLeak_Loc.Add(GT14_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D14_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.14")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas05.FillColor = Color.Black

                WIA_Layout_Form.btnS05.FillColor = Color.Lime
                WIA_Layout_Form.btnS05.ForeColor = Color.Black

                Sensors_Form.txtSelas05_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas05_Low.BackColor = Color.Black
                Sensors_Form.picSelas05_Low_Alarm.Visible = False

                GT15_Alarm = False

            Else

                WIA_Layout_Form.btnSelas05.FillColor = Color.Red

                WIA_Layout_Form.btnS05.FillColor = Color.Red
                WIA_Layout_Form.btnS05.ForeColor = Color.White

                Sensors_Form.txtSelas05_Low.ForeColor = Color.White
                Sensors_Form.txtSelas05_Low.BackColor = Color.Red
                Sensors_Form.picSelas05_Low_Alarm.Visible = True

                GT15_Alarm = True

                If GT15_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT15_Location) Then
                        GasLeak_Loc.Add(GT15_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'Selas 06 Sensor Alarm
    Sub D15_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C50.15")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas06.FillColor = Color.Black

                WIA_Layout_Form.btnS06.FillColor = Color.Lime
                WIA_Layout_Form.btnS06.ForeColor = Color.Black

                Sensors_Form.txtSelas06_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas06_Up.BackColor = Color.Black
                Sensors_Form.picSelas06_Up_Alarm.Visible = False

                GT16_Alarm = False

            Else

                WIA_Layout_Form.btnSelas06.FillColor = Color.Red

                WIA_Layout_Form.btnS06.FillColor = Color.Red
                WIA_Layout_Form.btnS06.ForeColor = Color.White

                Sensors_Form.txtSelas06_Up.ForeColor = Color.White
                Sensors_Form.txtSelas06_Up.BackColor = Color.Red
                Sensors_Form.picSelas06_Up_Alarm.Visible = True

                GT16_Alarm = True

                If GT16_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT16_Location) Then
                        GasLeak_Loc.Add(GT16_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D16_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.00")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas06.FillColor = Color.Black

                WIA_Layout_Form.btnS06.FillColor = Color.Lime
                WIA_Layout_Form.btnS06.ForeColor = Color.Black

                Sensors_Form.txtSelas06_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas06_Mid.BackColor = Color.Black
                Sensors_Form.picSelas06_Mid_Alarm.Visible = False

                GT17_Alarm = False

            Else

                WIA_Layout_Form.btnSelas06.FillColor = Color.Red

                WIA_Layout_Form.btnS06.FillColor = Color.Red
                WIA_Layout_Form.btnS06.ForeColor = Color.White

                Sensors_Form.txtSelas06_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas06_Mid.BackColor = Color.Red
                Sensors_Form.picSelas06_Mid_Alarm.Visible = True

                GT17_Alarm = True

                If GT17_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT17_Location) Then
                        GasLeak_Loc.Add(GT17_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D17_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.01")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas06.FillColor = Color.Black

                WIA_Layout_Form.btnS06.FillColor = Color.Lime
                WIA_Layout_Form.btnS06.ForeColor = Color.Black

                Sensors_Form.txtSelas06_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas06_Low.BackColor = Color.Black
                Sensors_Form.picSelas06_Low_Alarm.Visible = False

                GT18_Alarm = False

            Else

                WIA_Layout_Form.btnSelas06.FillColor = Color.Red

                WIA_Layout_Form.btnS06.FillColor = Color.Red
                WIA_Layout_Form.btnS06.ForeColor = Color.White

                Sensors_Form.txtSelas06_Low.ForeColor = Color.White
                Sensors_Form.txtSelas06_Low.BackColor = Color.Red
                Sensors_Form.picSelas06_Low_Alarm.Visible = True

                GT18_Alarm = True

                If GT18_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT18_Location) Then
                        GasLeak_Loc.Add(GT18_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'Selas 07 Sensor Alarm
    Sub D18_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.02")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas07.FillColor = Color.Black

                WIA_Layout_Form.btnS07.FillColor = Color.Lime
                WIA_Layout_Form.btnS07.ForeColor = Color.Black

                Sensors_Form.txtSelas07_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas07_Up.BackColor = Color.Black
                Sensors_Form.picSelas07_Up_Alarm.Visible = False

                GT19_Alarm = False

            Else

                WIA_Layout_Form.btnSelas07.FillColor = Color.Red

                WIA_Layout_Form.btnS07.FillColor = Color.Red
                WIA_Layout_Form.btnS07.ForeColor = Color.White

                Sensors_Form.txtSelas07_Up.ForeColor = Color.White
                Sensors_Form.txtSelas07_Up.BackColor = Color.Red
                Sensors_Form.picSelas07_Up_Alarm.Visible = True

                GT19_Alarm = True

                If GT19_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT19_Location) Then
                        GasLeak_Loc.Add(GT19_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D19_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.03")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas07.FillColor = Color.Black

                WIA_Layout_Form.btnS07.FillColor = Color.Lime
                WIA_Layout_Form.btnS07.ForeColor = Color.Black

                Sensors_Form.txtSelas07_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas07_Mid.BackColor = Color.Black
                Sensors_Form.picSelas07_Mid_Alarm.Visible = False

                GT20_Alarm = False

            Else

                WIA_Layout_Form.btnSelas07.FillColor = Color.Red

                WIA_Layout_Form.btnS07.FillColor = Color.Red
                WIA_Layout_Form.btnS07.ForeColor = Color.White

                Sensors_Form.txtSelas07_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas07_Mid.BackColor = Color.Red
                Sensors_Form.picSelas07_Mid_Alarm.Visible = True

                GT20_Alarm = True

                If GT20_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT20_Location) Then
                        GasLeak_Loc.Add(GT20_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D20_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.04")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas07.FillColor = Color.Black

                WIA_Layout_Form.btnS07.FillColor = Color.Lime
                WIA_Layout_Form.btnS07.ForeColor = Color.Black

                Sensors_Form.txtSelas07_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas07_Low.BackColor = Color.Black
                Sensors_Form.picSelas07_Low_Alarm.Visible = False

                GT21_Alarm = False

            Else

                WIA_Layout_Form.btnSelas07.FillColor = Color.Red

                WIA_Layout_Form.btnS07.FillColor = Color.Red
                WIA_Layout_Form.btnS07.ForeColor = Color.White

                Sensors_Form.txtSelas07_Low.ForeColor = Color.White
                Sensors_Form.txtSelas07_Low.BackColor = Color.Red
                Sensors_Form.picSelas07_Low_Alarm.Visible = True

                GT21_Alarm = True

                If GT21_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT21_Location) Then
                        GasLeak_Loc.Add(GT21_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'Selas 08 Sensor Alarm
    Sub D21_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.05")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas08.FillColor = Color.Black

                WIA_Layout_Form.btnS08.FillColor = Color.Lime
                WIA_Layout_Form.btnS08.ForeColor = Color.Black

                Sensors_Form.txtSelas08_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas08_Up.BackColor = Color.Black
                Sensors_Form.picSelas08_Up_Alarm.Visible = False

                GT22_Alarm = False

            Else

                WIA_Layout_Form.btnSelas08.FillColor = Color.Red

                WIA_Layout_Form.btnS08.FillColor = Color.Red
                WIA_Layout_Form.btnS08.ForeColor = Color.White

                Sensors_Form.txtSelas08_Up.ForeColor = Color.White
                Sensors_Form.txtSelas08_Up.BackColor = Color.Red
                Sensors_Form.picSelas08_Up_Alarm.Visible = True

                GT22_Alarm = True

                If GT22_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT22_Location) Then
                        GasLeak_Loc.Add(GT22_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D22_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.06")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas08.FillColor = Color.Black

                WIA_Layout_Form.btnS08.FillColor = Color.Lime
                WIA_Layout_Form.btnS08.ForeColor = Color.Black

                Sensors_Form.txtSelas08_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas08_Mid.BackColor = Color.Black
                Sensors_Form.picSelas08_Mid_Alarm.Visible = False

                GT23_Alarm = False

            Else

                WIA_Layout_Form.btnSelas08.FillColor = Color.Red

                WIA_Layout_Form.btnS08.FillColor = Color.Red
                WIA_Layout_Form.btnS08.ForeColor = Color.White

                Sensors_Form.txtSelas08_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas08_Mid.BackColor = Color.Red
                Sensors_Form.picSelas08_Mid_Alarm.Visible = True

                GT23_Alarm = True

                If GT23_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT23_Location) Then
                        GasLeak_Loc.Add(GT23_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D23_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.07")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas08.FillColor = Color.Black

                WIA_Layout_Form.btnS08.FillColor = Color.Lime
                WIA_Layout_Form.btnS08.ForeColor = Color.Black

                Sensors_Form.txtSelas08_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas08_Low.BackColor = Color.Black
                Sensors_Form.picSelas08_Low_Alarm.Visible = False

                GT24_Alarm = False

            Else

                WIA_Layout_Form.btnSelas08.FillColor = Color.Red

                WIA_Layout_Form.btnS08.FillColor = Color.Red
                WIA_Layout_Form.btnS08.ForeColor = Color.White

                Sensors_Form.txtSelas08_Low.ForeColor = Color.White
                Sensors_Form.txtSelas08_Low.BackColor = Color.Red
                Sensors_Form.picSelas08_Low_Alarm.Visible = True

                GT24_Alarm = True

                If GT24_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT24_Location) Then
                        GasLeak_Loc.Add(GT24_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'Selas 09 Sensor Alarm
    Sub D24_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.08")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas09.FillColor = Color.Black

                WIA_Layout_Form.btnS09.FillColor = Color.Lime
                WIA_Layout_Form.btnS09.ForeColor = Color.Black

                Sensors_Form.txtSelas09_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas09_Up.BackColor = Color.Black
                Sensors_Form.picSelas09_Up_Alarm.Visible = False

                GT25_Alarm = False

            Else

                WIA_Layout_Form.btnSelas09.FillColor = Color.Red

                WIA_Layout_Form.btnS09.FillColor = Color.Red
                WIA_Layout_Form.btnS09.ForeColor = Color.White

                Sensors_Form.txtSelas09_Up.ForeColor = Color.White
                Sensors_Form.txtSelas09_Up.BackColor = Color.Red
                Sensors_Form.picSelas09_Up_Alarm.Visible = True

                GT25_Alarm = True

                If GT25_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT25_Location) Then
                        GasLeak_Loc.Add(GT25_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D25_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.09")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas09.FillColor = Color.Black

                WIA_Layout_Form.btnS09.FillColor = Color.Lime
                WIA_Layout_Form.btnS09.ForeColor = Color.Black

                Sensors_Form.txtSelas09_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas09_Mid.BackColor = Color.Black
                Sensors_Form.picSelas09_Mid_Alarm.Visible = False

                GT26_Alarm = False

            Else

                WIA_Layout_Form.btnSelas09.FillColor = Color.Red

                WIA_Layout_Form.btnS09.FillColor = Color.Red
                WIA_Layout_Form.btnS09.ForeColor = Color.White

                Sensors_Form.txtSelas09_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas09_Mid.BackColor = Color.Red
                Sensors_Form.picSelas09_Mid_Alarm.Visible = True

                GT26_Alarm = True

                If GT26_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT26_Location) Then
                        GasLeak_Loc.Add(GT26_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D26_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.10")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas09.FillColor = Color.Black

                WIA_Layout_Form.btnS09.FillColor = Color.Lime
                WIA_Layout_Form.btnS09.ForeColor = Color.Black

                Sensors_Form.txtSelas09_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas09_Low.BackColor = Color.Black
                Sensors_Form.picSelas09_Low_Alarm.Visible = False

                GT27_Alarm = False

            Else

                WIA_Layout_Form.btnSelas09.FillColor = Color.Red

                WIA_Layout_Form.btnS09.FillColor = Color.Red
                WIA_Layout_Form.btnS09.ForeColor = Color.White

                Sensors_Form.txtSelas09_Low.ForeColor = Color.White
                Sensors_Form.txtSelas09_Low.BackColor = Color.Red
                Sensors_Form.picSelas09_Low_Alarm.Visible = True

                GT27_Alarm = True

                If GT27_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT27_Location) Then
                        GasLeak_Loc.Add(GT27_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'Selas 10 Sensor Alarm
    Sub D27_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.11")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas10.FillColor = Color.Black

                WIA_Layout_Form.btnS10.FillColor = Color.Lime
                WIA_Layout_Form.btnS10.ForeColor = Color.Black

                Sensors_Form.txtSelas10_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas10_Up.BackColor = Color.Black
                Sensors_Form.picSelas10_Up_Alarm.Visible = False

                GT28_Alarm = False

            Else

                WIA_Layout_Form.btnSelas10.FillColor = Color.Red

                WIA_Layout_Form.btnS10.FillColor = Color.Red
                WIA_Layout_Form.btnS10.ForeColor = Color.White

                Sensors_Form.txtSelas10_Up.ForeColor = Color.White
                Sensors_Form.txtSelas10_Up.BackColor = Color.Red
                Sensors_Form.picSelas10_Up_Alarm.Visible = True

                GT28_Alarm = True

                If GT28_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT28_Location) Then
                        GasLeak_Loc.Add(GT28_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D28_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.12")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas10.FillColor = Color.Black

                WIA_Layout_Form.btnS10.FillColor = Color.Lime
                WIA_Layout_Form.btnS10.ForeColor = Color.Black

                Sensors_Form.txtSelas10_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas10_Mid.BackColor = Color.Black
                Sensors_Form.picSelas10_Mid_Alarm.Visible = False

                GT29_Alarm = False

            Else

                WIA_Layout_Form.btnSelas10.FillColor = Color.Red

                WIA_Layout_Form.btnS10.FillColor = Color.Red
                WIA_Layout_Form.btnS10.ForeColor = Color.White

                Sensors_Form.txtSelas10_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas10_Mid.BackColor = Color.Red
                Sensors_Form.picSelas10_Mid_Alarm.Visible = True

                GT29_Alarm = True

                If GT29_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT29_Location) Then
                        GasLeak_Loc.Add(GT29_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D29_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.13")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas10.FillColor = Color.Black

                WIA_Layout_Form.btnS10.FillColor = Color.Lime
                WIA_Layout_Form.btnS10.ForeColor = Color.Black

                Sensors_Form.txtSelas10_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas10_Low.BackColor = Color.Black
                Sensors_Form.picSelas10_Low_Alarm.Visible = False

                GT30_Alarm = False

            Else

                WIA_Layout_Form.btnSelas10.FillColor = Color.Red

                WIA_Layout_Form.btnS10.FillColor = Color.Red
                WIA_Layout_Form.btnS10.ForeColor = Color.White

                Sensors_Form.txtSelas10_Low.ForeColor = Color.White
                Sensors_Form.txtSelas10_Low.BackColor = Color.Red
                Sensors_Form.picSelas10_Low_Alarm.Visible = True

                GT30_Alarm = True

                If GT30_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT30_Location) Then
                        GasLeak_Loc.Add(GT30_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'Selas 11 Sensor Alarm
    Sub D30_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.14")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas11.FillColor = Color.Black

                WIA_Layout_Form.btnS11.FillColor = Color.Lime
                WIA_Layout_Form.btnS11.ForeColor = Color.Black

                Sensors_Form.txtSelas11_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas11_Up.BackColor = Color.Black
                Sensors_Form.picSelas11_Up_Alarm.Visible = False

                GT31_Alarm = False

            Else

                WIA_Layout_Form.btnSelas11.FillColor = Color.Red

                WIA_Layout_Form.btnS11.FillColor = Color.Red
                WIA_Layout_Form.btnS11.ForeColor = Color.White

                Sensors_Form.txtSelas11_Up.ForeColor = Color.White
                Sensors_Form.txtSelas11_Up.BackColor = Color.Red
                Sensors_Form.picSelas11_Up_Alarm.Visible = True

                GT31_Alarm = True

                If GT31_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT31_Location) Then
                        GasLeak_Loc.Add(GT31_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D31_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C51.15")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas11.FillColor = Color.Black

                WIA_Layout_Form.btnS11.FillColor = Color.Lime
                WIA_Layout_Form.btnS11.ForeColor = Color.Black

                Sensors_Form.txtSelas11_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas11_Mid.BackColor = Color.Black
                Sensors_Form.picSelas11_Mid_Alarm.Visible = False

                GT32_Alarm = False
            Else

                WIA_Layout_Form.btnSelas11.FillColor = Color.Red

                WIA_Layout_Form.btnS11.FillColor = Color.Red
                WIA_Layout_Form.btnS11.ForeColor = Color.White

                Sensors_Form.txtSelas11_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas11_Mid.BackColor = Color.Red
                Sensors_Form.picSelas11_Mid_Alarm.Visible = True

                GT32_Alarm = True

                If GT32_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT32_Location) Then
                        GasLeak_Loc.Add(GT32_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D32_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.00")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas11.FillColor = Color.Black

                WIA_Layout_Form.btnS11.FillColor = Color.Lime
                WIA_Layout_Form.btnS11.ForeColor = Color.Black

                Sensors_Form.txtSelas11_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas11_Low.BackColor = Color.Black
                Sensors_Form.picSelas11_Low_Alarm.Visible = False

                GT33_Alarm = False

            Else

                WIA_Layout_Form.btnSelas11.FillColor = Color.Red

                WIA_Layout_Form.btnS11.FillColor = Color.Red
                WIA_Layout_Form.btnS11.ForeColor = Color.White

                Sensors_Form.txtSelas11_Low.ForeColor = Color.White
                Sensors_Form.txtSelas11_Low.BackColor = Color.Red
                Sensors_Form.picSelas11_Low_Alarm.Visible = True

                GT33_Alarm = True

                If GT33_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT33_Location) Then
                        GasLeak_Loc.Add(GT33_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'Selas 12 Sensor Alarm
    Sub D33_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.01")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas12.FillColor = Color.Black

                WIA_Layout_Form.btnS12.FillColor = Color.Lime
                WIA_Layout_Form.btnS12.ForeColor = Color.Black

                Sensors_Form.txtSelas12_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas12_Up.BackColor = Color.Black
                Sensors_Form.picSelas12_Up_Alarm.Visible = False

                GT34_Alarm = False

            Else

                WIA_Layout_Form.btnSelas12.FillColor = Color.Red

                WIA_Layout_Form.btnS12.FillColor = Color.Red
                WIA_Layout_Form.btnS12.ForeColor = Color.White

                Sensors_Form.txtSelas12_Up.ForeColor = Color.White
                Sensors_Form.txtSelas12_Up.BackColor = Color.Red
                Sensors_Form.picSelas12_Up_Alarm.Visible = True

                GT34_Alarm = True

                If GT34_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT34_Location) Then
                        GasLeak_Loc.Add(GT34_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D34_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.02")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas12.FillColor = Color.Black

                WIA_Layout_Form.btnS12.FillColor = Color.Lime
                WIA_Layout_Form.btnS12.ForeColor = Color.Black

                Sensors_Form.txtSelas12_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas12_Mid.BackColor = Color.Black
                Sensors_Form.picSelas12_Mid_Alarm.Visible = False

                GT35_Alarm = False

            Else

                WIA_Layout_Form.btnSelas12.FillColor = Color.Red

                WIA_Layout_Form.btnS12.FillColor = Color.Red
                WIA_Layout_Form.btnS12.ForeColor = Color.White

                Sensors_Form.txtSelas12_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas12_Mid.BackColor = Color.Red
                Sensors_Form.picSelas12_Mid_Alarm.Visible = True

                GT35_Alarm = True

                If GT35_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT35_Location) Then
                        GasLeak_Loc.Add(GT35_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D35_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.03")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas12.FillColor = Color.Black

                WIA_Layout_Form.btnS12.FillColor = Color.Lime
                WIA_Layout_Form.btnS12.ForeColor = Color.Black

                Sensors_Form.txtSelas12_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas12_Low.BackColor = Color.Black
                Sensors_Form.picSelas12_Low_Alarm.Visible = False

                GT36_Alarm = False

            Else

                WIA_Layout_Form.btnSelas12.FillColor = Color.Red

                WIA_Layout_Form.btnS12.FillColor = Color.Red
                WIA_Layout_Form.btnS12.ForeColor = Color.White

                Sensors_Form.txtSelas12_Low.ForeColor = Color.White
                Sensors_Form.txtSelas12_Low.BackColor = Color.Red
                Sensors_Form.picSelas12_Low_Alarm.Visible = True

                GT36_Alarm = True

                If GT36_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT36_Location) Then
                        GasLeak_Loc.Add(GT36_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'Selas 13 Sensor Alarm
    Sub D36_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.04")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas13.FillColor = Color.Black

                WIA_Layout_Form.btnS13.FillColor = Color.Lime
                WIA_Layout_Form.btnS13.ForeColor = Color.Black

                Sensors_Form.txtSelas13_Up.ForeColor = Color.Lime
                Sensors_Form.txtSelas13_Up.BackColor = Color.Black
                Sensors_Form.picSelas13_Up_Alarm.Visible = False

                GT37_Alarm = False

            Else

                WIA_Layout_Form.btnSelas13.FillColor = Color.Red

                WIA_Layout_Form.btnS13.FillColor = Color.Red
                WIA_Layout_Form.btnS13.ForeColor = Color.White

                Sensors_Form.txtSelas13_Up.ForeColor = Color.White
                Sensors_Form.txtSelas13_Up.BackColor = Color.Red
                Sensors_Form.picSelas13_Up_Alarm.Visible = True

                GT37_Alarm = True

                If GT37_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT37_Location) Then
                        GasLeak_Loc.Add(GT37_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D37_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.05")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas13.FillColor = Color.Black

                WIA_Layout_Form.btnS13.FillColor = Color.Lime
                WIA_Layout_Form.btnS13.ForeColor = Color.Black

                Sensors_Form.txtSelas13_Mid.ForeColor = Color.Lime
                Sensors_Form.txtSelas13_Mid.BackColor = Color.Black
                Sensors_Form.picSelas13_Mid_Alarm.Visible = False

                GT38_Alarm = False

            Else

                WIA_Layout_Form.btnSelas13.FillColor = Color.Red

                WIA_Layout_Form.btnS13.FillColor = Color.Red
                WIA_Layout_Form.btnS13.ForeColor = Color.White

                Sensors_Form.txtSelas13_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas13_Mid.BackColor = Color.Red
                Sensors_Form.picSelas13_Mid_Alarm.Visible = True

                GT38_Alarm = True

                If GT38_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT38_Location) Then
                        GasLeak_Loc.Add(GT38_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D38_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.06")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnSelas13.FillColor = Color.Black

                WIA_Layout_Form.btnS13.FillColor = Color.Lime
                WIA_Layout_Form.btnS13.ForeColor = Color.Black

                Sensors_Form.txtSelas13_Low.ForeColor = Color.Lime
                Sensors_Form.txtSelas13_Low.BackColor = Color.Black
                Sensors_Form.picSelas13_Low_Alarm.Visible = False

                GT39_Alarm = False

            Else

                WIA_Layout_Form.btnSelas13.FillColor = Color.Red

                WIA_Layout_Form.btnS13.FillColor = Color.Red
                WIA_Layout_Form.btnS13.ForeColor = Color.White

                Sensors_Form.txtSelas13_Low.ForeColor = Color.White
                Sensors_Form.txtSelas13_Low.BackColor = Color.Red
                Sensors_Form.picSelas13_Low_Alarm.Visible = True

                GT39_Alarm = True

                If GT39_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT39_Location) Then
                        GasLeak_Loc.Add(GT39_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'WAREHOUSE TRENCH SENSOR ALARM
    Sub D39_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.07")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench01.FillColor = Color.Black

                WIA_Layout_Form.btnT01.FillColor = Color.Lime
                WIA_Layout_Form.btnT01.ForeColor = Color.Black

                Sensors_Form.txtTS_01.ForeColor = Color.Lime
                Sensors_Form.txtTS_01.BackColor = Color.Black
                Sensors_Form.picTS_01_Alarm.Visible = False

                GT40_Alarm = False

            Else

                WIA_Layout_Form.btnTrench01.FillColor = Color.Red

                WIA_Layout_Form.btnT01.FillColor = Color.Red
                WIA_Layout_Form.btnT01.ForeColor = Color.White

                Sensors_Form.txtTS_01.ForeColor = Color.White
                Sensors_Form.txtTS_01.BackColor = Color.Red
                Sensors_Form.picTS_01_Alarm.Visible = True

                GT40_Alarm = True

                If GT40_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT40_Location) Then
                        GasLeak_Loc.Add(GT40_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D40_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.08")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench02.FillColor = Color.Black

                WIA_Layout_Form.btnT02.FillColor = Color.Lime
                WIA_Layout_Form.btnT02.ForeColor = Color.Black

                Sensors_Form.txtTS_02.ForeColor = Color.Lime
                Sensors_Form.txtTS_02.BackColor = Color.Black
                Sensors_Form.picTS_02_Alarm.Visible = False

                GT41_Alarm = False

            Else

                WIA_Layout_Form.btnTrench02.FillColor = Color.Red

                WIA_Layout_Form.btnT02.FillColor = Color.Red
                WIA_Layout_Form.btnT02.ForeColor = Color.White

                Sensors_Form.txtTS_02.ForeColor = Color.White
                Sensors_Form.txtTS_02.BackColor = Color.Red
                Sensors_Form.picTS_02_Alarm.Visible = True


                GT41_Alarm = True

                If GT41_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT41_Location) Then
                        GasLeak_Loc.Add(GT41_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'PICO TO NANO TRENCH SENSOR VALUE
    Sub D41_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.09")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench03.FillColor = Color.Black

                WIA_Layout_Form.btnT03.FillColor = Color.Lime
                WIA_Layout_Form.btnT03.ForeColor = Color.Black

                Sensors_Form.txtTS_03.ForeColor = Color.Lime
                Sensors_Form.txtTS_03.BackColor = Color.Black
                Sensors_Form.picTS_03_Alarm.Visible = False

                GT42_Alarm = False

            Else

                WIA_Layout_Form.btnTrench03.FillColor = Color.Red

                WIA_Layout_Form.btnT03.FillColor = Color.Red
                WIA_Layout_Form.btnT03.ForeColor = Color.White

                Sensors_Form.txtTS_03.ForeColor = Color.White
                Sensors_Form.txtTS_03.BackColor = Color.Red
                Sensors_Form.picTS_03_Alarm.Visible = True

                GT42_Alarm = True

                If GT42_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT42_Location) Then
                        GasLeak_Loc.Add(GT42_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D42_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.10")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench04.FillColor = Color.Black

                WIA_Layout_Form.btnT04.FillColor = Color.Lime
                WIA_Layout_Form.btnT04.ForeColor = Color.Black

                Sensors_Form.txtTS_04.ForeColor = Color.Lime
                Sensors_Form.txtTS_04.BackColor = Color.Black
                Sensors_Form.picTS_04_Alarm.Visible = False

                GT43_Alarm = False

            Else

                WIA_Layout_Form.btnTrench04.FillColor = Color.Red

                WIA_Layout_Form.btnT04.FillColor = Color.Red
                WIA_Layout_Form.btnT04.ForeColor = Color.White

                Sensors_Form.txtTS_04.ForeColor = Color.White
                Sensors_Form.txtTS_04.BackColor = Color.Red
                Sensors_Form.picTS_04_Alarm.Visible = True


                GT43_Alarm = True

                If GT43_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT43_Location) Then
                        GasLeak_Loc.Add(GT43_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D43_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.11")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench05.FillColor = Color.Black

                WIA_Layout_Form.btnT05.FillColor = Color.Lime
                WIA_Layout_Form.btnT05.ForeColor = Color.Black

                Sensors_Form.txtTS_05.ForeColor = Color.Lime
                Sensors_Form.txtTS_05.BackColor = Color.Black
                Sensors_Form.picTS_05_Alarm.Visible = False

                GT44_Alarm = False

            Else

                WIA_Layout_Form.btnTrench05.FillColor = Color.Red

                WIA_Layout_Form.btnT05.FillColor = Color.Red
                WIA_Layout_Form.btnT05.ForeColor = Color.White

                Sensors_Form.txtTS_05.ForeColor = Color.White
                Sensors_Form.txtTS_05.BackColor = Color.Red
                Sensors_Form.picTS_05_Alarm.Visible = True


                GT44_Alarm = True

                If GT44_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT44_Location) Then
                        GasLeak_Loc.Add(GT44_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D44_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.12")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench06.FillColor = Color.Black

                WIA_Layout_Form.btnT06.FillColor = Color.Lime
                WIA_Layout_Form.btnT06.ForeColor = Color.Black

                Sensors_Form.txtTS_06.ForeColor = Color.Lime
                Sensors_Form.txtTS_06.BackColor = Color.Black
                Sensors_Form.picTS_06_Alarm.Visible = False

                GT45_Alarm = False

            Else

                WIA_Layout_Form.btnTrench06.FillColor = Color.Red

                WIA_Layout_Form.btnT06.FillColor = Color.Red
                WIA_Layout_Form.btnT06.ForeColor = Color.White

                Sensors_Form.txtTS_06.ForeColor = Color.White
                Sensors_Form.txtTS_06.BackColor = Color.Red
                Sensors_Form.picTS_06_Alarm.Visible = True


                GT45_Alarm = True

                If GT45_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT45_Location) Then
                        GasLeak_Loc.Add(GT45_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D45_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.13")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench07.FillColor = Color.Black

                WIA_Layout_Form.btnT07.FillColor = Color.Lime
                WIA_Layout_Form.btnT07.ForeColor = Color.Black

                Sensors_Form.txtTS_07.ForeColor = Color.Lime
                Sensors_Form.txtTS_07.BackColor = Color.Black
                Sensors_Form.picTS_07_Alarm.Visible = False

                GT46_Alarm = False

            Else

                WIA_Layout_Form.btnTrench07.FillColor = Color.Red

                WIA_Layout_Form.btnT07.FillColor = Color.Red
                WIA_Layout_Form.btnT07.ForeColor = Color.White

                Sensors_Form.txtTS_07.ForeColor = Color.White
                Sensors_Form.txtTS_07.BackColor = Color.Red
                Sensors_Form.picTS_07_Alarm.Visible = True

                GT46_Alarm = True

                If GT46_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT46_Location) Then
                        GasLeak_Loc.Add(GT46_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D46_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.14")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench08.FillColor = Color.Black

                WIA_Layout_Form.btnT08.FillColor = Color.Lime
                WIA_Layout_Form.btnT08.ForeColor = Color.Black

                Sensors_Form.txtTS_08.ForeColor = Color.Lime
                Sensors_Form.txtTS_08.BackColor = Color.Black
                Sensors_Form.picTS_08_Alarm.Visible = False

                GT47_Alarm = False

            Else

                WIA_Layout_Form.btnTrench08.FillColor = Color.Red

                WIA_Layout_Form.btnT08.FillColor = Color.Red
                WIA_Layout_Form.btnT08.ForeColor = Color.White

                Sensors_Form.txtTS_08.ForeColor = Color.White
                Sensors_Form.txtTS_08.BackColor = Color.Red
                Sensors_Form.picTS_08_Alarm.Visible = True


                GT47_Alarm = True

                If GT47_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT47_Location) Then
                        GasLeak_Loc.Add(GT47_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D47_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C52.15")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench09.FillColor = Color.Black

                WIA_Layout_Form.btnT09.FillColor = Color.Lime
                WIA_Layout_Form.btnT09.ForeColor = Color.Black

                Sensors_Form.txtTS_09.ForeColor = Color.Lime
                Sensors_Form.txtTS_09.BackColor = Color.Black
                Sensors_Form.picTS_09_Alarm.Visible = False

                GT48_Alarm = False

            Else

                WIA_Layout_Form.btnTrench09.FillColor = Color.Red

                WIA_Layout_Form.btnT09.FillColor = Color.Red
                WIA_Layout_Form.btnT09.ForeColor = Color.White

                Sensors_Form.txtTS_09.ForeColor = Color.White
                Sensors_Form.txtTS_09.BackColor = Color.Red
                Sensors_Form.picTS_09_Alarm.Visible = True

                GT48_Alarm = True

                If GT48_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT48_Location) Then
                        GasLeak_Loc.Add(GT48_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D48_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.00")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench10.FillColor = Color.Black

                WIA_Layout_Form.btnT10.FillColor = Color.Lime
                WIA_Layout_Form.btnT10.ForeColor = Color.Black

                Sensors_Form.txtTS_10.ForeColor = Color.Lime
                Sensors_Form.txtTS_10.BackColor = Color.Black
                Sensors_Form.picTS_10_Alarm.Visible = False

                GT49_Alarm = False

            Else

                WIA_Layout_Form.btnTrench10.FillColor = Color.Red

                WIA_Layout_Form.btnT10.FillColor = Color.Red
                WIA_Layout_Form.btnT10.ForeColor = Color.White

                Sensors_Form.txtTS_10.ForeColor = Color.White
                Sensors_Form.txtTS_10.BackColor = Color.Red
                Sensors_Form.picTS_10_Alarm.Visible = True

                GT49_Alarm = True

                If GT49_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT49_Location) Then
                        GasLeak_Loc.Add(GT49_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    'PICO TRENCH ALARM VALUE

    Sub D49_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.01")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench11.FillColor = Color.Black

                WIA_Layout_Form.btnT11.FillColor = Color.Lime
                WIA_Layout_Form.btnT11.ForeColor = Color.Black

                Sensors_Form.txtTS_11.ForeColor = Color.Lime
                Sensors_Form.txtTS_11.BackColor = Color.Black
                Sensors_Form.picTS_11_Alarm.Visible = False

                GT50_Alarm = False

            Else

                WIA_Layout_Form.btnTrench11.FillColor = Color.Red

                WIA_Layout_Form.btnT11.FillColor = Color.Red
                WIA_Layout_Form.btnT11.ForeColor = Color.White

                Sensors_Form.txtTS_11.ForeColor = Color.White
                Sensors_Form.txtTS_11.BackColor = Color.Red
                Sensors_Form.picTS_11_Alarm.Visible = True


                GT50_Alarm = True

                If GT50_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT50_Location) Then
                        GasLeak_Loc.Add(GT50_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D50_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.02")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench12.FillColor = Color.Black

                WIA_Layout_Form.btnT12.FillColor = Color.Lime
                WIA_Layout_Form.btnT12.ForeColor = Color.Black

                Sensors_Form.txtTS_12.ForeColor = Color.Lime
                Sensors_Form.txtTS_12.BackColor = Color.Black
                Sensors_Form.picTS_12_Alarm.Visible = False

                GT51_Alarm = False

            Else

                WIA_Layout_Form.btnTrench12.FillColor = Color.Red

                WIA_Layout_Form.btnT12.FillColor = Color.Red
                WIA_Layout_Form.btnT12.ForeColor = Color.White

                Sensors_Form.txtTS_12.ForeColor = Color.White
                Sensors_Form.txtTS_12.BackColor = Color.Red
                Sensors_Form.picTS_12_Alarm.Visible = True


                GT51_Alarm = True

                If GT51_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT51_Location) Then
                        GasLeak_Loc.Add(GT51_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D51_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.03")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench13.FillColor = Color.Black

                WIA_Layout_Form.btnT13.FillColor = Color.Lime
                WIA_Layout_Form.btnT13.ForeColor = Color.Black

                Sensors_Form.txtTS_13.ForeColor = Color.Lime
                Sensors_Form.txtTS_13.BackColor = Color.Black
                Sensors_Form.picTS_13_Alarm.Visible = False

                GT52_Alarm = False

            Else

                WIA_Layout_Form.btnTrench13.FillColor = Color.Red

                WIA_Layout_Form.btnT13.FillColor = Color.Red
                WIA_Layout_Form.btnT13.ForeColor = Color.White

                Sensors_Form.txtTS_13.ForeColor = Color.White
                Sensors_Form.txtTS_13.BackColor = Color.Red
                Sensors_Form.picTS_13_Alarm.Visible = True

                GT52_Alarm = True

                If GT52_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT52_Location) Then
                        GasLeak_Loc.Add(GT52_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D52_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.04")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench14.FillColor = Color.Black

                WIA_Layout_Form.btnT14.FillColor = Color.Lime
                WIA_Layout_Form.btnT14.ForeColor = Color.Black

                Sensors_Form.txtTS_14.ForeColor = Color.Lime
                Sensors_Form.txtTS_14.BackColor = Color.Black
                Sensors_Form.picTS_14_Alarm.Visible = False

                GT53_Alarm = False

            Else

                WIA_Layout_Form.btnTrench14.FillColor = Color.Red

                WIA_Layout_Form.btnT14.FillColor = Color.Red
                WIA_Layout_Form.btnT14.ForeColor = Color.White

                Sensors_Form.txtTS_14.ForeColor = Color.White
                Sensors_Form.txtTS_14.BackColor = Color.Red
                Sensors_Form.picTS_14_Alarm.Visible = True

                GT53_Alarm = True

                If GT53_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT53_Location) Then
                        GasLeak_Loc.Add(GT53_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D53_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.05")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench15.FillColor = Color.Black

                WIA_Layout_Form.btnT15.FillColor = Color.Lime
                WIA_Layout_Form.btnT15.ForeColor = Color.Black

                Sensors_Form.txtTS_15.ForeColor = Color.Lime
                Sensors_Form.txtTS_15.BackColor = Color.Black
                Sensors_Form.picTS_15_Alarm.Visible = False

                GT54_Alarm = False

            Else

                WIA_Layout_Form.btnTrench15.FillColor = Color.Red

                WIA_Layout_Form.btnT15.FillColor = Color.Red
                WIA_Layout_Form.btnT15.ForeColor = Color.White

                Sensors_Form.txtTS_15.ForeColor = Color.White
                Sensors_Form.txtTS_15.BackColor = Color.Red
                Sensors_Form.picTS_15_Alarm.Visible = True

                GT54_Alarm = True

                If GT54_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT54_Location) Then
                        GasLeak_Loc.Add(GT54_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D54_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.06")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench16.FillColor = Color.Black

                WIA_Layout_Form.btnT16.FillColor = Color.Lime
                WIA_Layout_Form.btnT16.ForeColor = Color.Black

                Sensors_Form.txtTS_16.ForeColor = Color.Lime
                Sensors_Form.txtTS_16.BackColor = Color.Black
                Sensors_Form.picTS_16_Alarm.Visible = False

                GT55_Alarm = False

            Else

                WIA_Layout_Form.btnTrench16.FillColor = Color.Red

                WIA_Layout_Form.btnT16.FillColor = Color.Red
                WIA_Layout_Form.btnT16.ForeColor = Color.White

                Sensors_Form.txtTS_16.ForeColor = Color.White
                Sensors_Form.txtTS_16.BackColor = Color.Red
                Sensors_Form.picTS_16_Alarm.Visible = True


                GT55_Alarm = True

                If GT55_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT55_Location) Then
                        GasLeak_Loc.Add(GT55_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D55_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.07")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench17.FillColor = Color.Black

                WIA_Layout_Form.btnT17.FillColor = Color.Lime
                WIA_Layout_Form.btnT17.ForeColor = Color.Black

                Sensors_Form.txtTS_17.ForeColor = Color.Lime
                Sensors_Form.txtTS_17.BackColor = Color.Black
                Sensors_Form.picTS_17_Alarm.Visible = False

                GT56_Alarm = False

            Else

                WIA_Layout_Form.btnTrench17.FillColor = Color.Red

                WIA_Layout_Form.btnT17.FillColor = Color.Red
                WIA_Layout_Form.btnT17.ForeColor = Color.White

                Sensors_Form.txtTS_17.ForeColor = Color.White
                Sensors_Form.txtTS_17.BackColor = Color.Red
                Sensors_Form.picTS_17_Alarm.Visible = True

                GT56_Alarm = True

                If GT56_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT56_Location) Then
                        GasLeak_Loc.Add(GT56_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D56_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.08")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench18.FillColor = Color.Black

                WIA_Layout_Form.btnT18.FillColor = Color.Lime
                WIA_Layout_Form.btnT18.ForeColor = Color.Black

                Sensors_Form.txtTS_18.ForeColor = Color.Lime
                Sensors_Form.txtTS_18.BackColor = Color.Black
                Sensors_Form.picTS_18_Alarm.Visible = False

                GT57_Alarm = False

            Else

                WIA_Layout_Form.btnTrench18.FillColor = Color.Red

                WIA_Layout_Form.btnT18.FillColor = Color.Red
                WIA_Layout_Form.btnT18.ForeColor = Color.White

                Sensors_Form.txtTS_18.ForeColor = Color.White
                Sensors_Form.txtTS_18.BackColor = Color.Red
                Sensors_Form.picTS_18_Alarm.Visible = True

                GT57_Alarm = True

                If GT57_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT57_Location) Then
                        GasLeak_Loc.Add(GT57_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D57_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.09")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench19.FillColor = Color.Black

                WIA_Layout_Form.btnT19.FillColor = Color.Lime
                WIA_Layout_Form.btnT19.ForeColor = Color.Black

                Sensors_Form.txtTS_19.ForeColor = Color.Lime
                Sensors_Form.txtTS_19.BackColor = Color.Black
                Sensors_Form.picTS_19_Alarm.Visible = False

                GT58_Alarm = False

            Else

                WIA_Layout_Form.btnTrench19.FillColor = Color.Red

                WIA_Layout_Form.btnT19.FillColor = Color.Red
                WIA_Layout_Form.btnT19.ForeColor = Color.White

                Sensors_Form.txtTS_19.ForeColor = Color.White
                Sensors_Form.txtTS_19.BackColor = Color.Red
                Sensors_Form.picTS_19_Alarm.Visible = True

                GT58_Alarm = True

                If GT58_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT58_Location) Then
                        GasLeak_Loc.Add(GT58_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D58_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.10")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnTrench20.FillColor = Color.Black

                WIA_Layout_Form.btnT20.FillColor = Color.Lime
                WIA_Layout_Form.btnT20.ForeColor = Color.Black

                Sensors_Form.txtTS_20.ForeColor = Color.Lime
                Sensors_Form.txtTS_20.BackColor = Color.Black
                Sensors_Form.picTS_20_Alarm.Visible = False

                GT59_Alarm = False

            Else

                WIA_Layout_Form.btnTrench20.FillColor = Color.Red

                WIA_Layout_Form.btnT20.FillColor = Color.Red
                WIA_Layout_Form.btnT20.ForeColor = Color.White

                Sensors_Form.txtTS_20.ForeColor = Color.White
                Sensors_Form.txtTS_20.BackColor = Color.Red
                Sensors_Form.picTS_20_Alarm.Visible = True


                GT59_Alarm = True

                If GT59_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT59_Location) Then
                        GasLeak_Loc.Add(GT59_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

    '***************** GAS MIXING ALARM ***********************

    Sub D59_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.11")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnGasMixing1.FillColor = Color.Black

                WIA_Layout_Form.btnGM1.FillColor = Color.Lime
                WIA_Layout_Form.btnGM1.ForeColor = Color.Black

                Sensors_Form.txtGM1.ForeColor = Color.Lime
                Sensors_Form.txtGM1.BackColor = Color.Black
                Sensors_Form.picGM1_Alarm.Visible = False

                GT60_Alarm = False

            Else

                WIA_Layout_Form.btnGasMixing1.FillColor = Color.Red

                WIA_Layout_Form.btnGM1.FillColor = Color.Red
                WIA_Layout_Form.btnGM1.ForeColor = Color.White

                Sensors_Form.txtGM1.ForeColor = Color.White
                Sensors_Form.txtGM1.BackColor = Color.Red
                Sensors_Form.picGM1_Alarm.Visible = True

                GT60_Alarm = True

                If GT60_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT60_Location) Then
                        GasLeak_Loc.Add(GT60_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub
    Sub D60_Alarm()
        Dim readResult = Form1.omronPLC.ReadBool("C53.12")
        Dim alarm_val As String
        If readResult.IsSuccess Then

            alarm_val = If(readResult.Content, "ON", "OFF")

            If Not readResult.Content Then

                WIA_Layout_Form.btnGasMixing4.FillColor = Color.Black

                WIA_Layout_Form.btnGM4.FillColor = Color.Lime
                WIA_Layout_Form.btnGM4.ForeColor = Color.Black

                Sensors_Form.txtGM4.ForeColor = Color.Lime
                Sensors_Form.txtGM4.BackColor = Color.Black
                Sensors_Form.picGM4_Alarm.Visible = False

                GT61_Alarm = False

            Else

                WIA_Layout_Form.btnGasMixing4.FillColor = Color.Red

                WIA_Layout_Form.btnGM4.FillColor = Color.Red
                WIA_Layout_Form.btnGM4.ForeColor = Color.White

                Sensors_Form.txtGM4.ForeColor = Color.White
                Sensors_Form.txtGM4.BackColor = Color.Red
                Sensors_Form.picGM4_Alarm.Visible = True

                GT61_Alarm = True

                If GT61_Alarm = True Then

                    If Not GasLeak_Loc.Contains(GT61_Location) Then
                        GasLeak_Loc.Add(GT61_Location)
                        Design2_Form.TimerMessages.Enabled = True
                        'Console.WriteLine($"{GT01_Location} has been added to the list.")
                    Else
                        'Console.WriteLine($"{GT01_Location} is already in the list and won't be added.")
                    End If
                End If

            End If
        End If
    End Sub

End Module

Module AppConfig_Module
    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Public COM As String
    Public New_COM As String
    Public IP As String
    Public New_IP As String

    Public Mes_Del As Integer
    Public New_Mes_Del As Integer

    Sub Get_COM_NAME()
        Dim name As String = System.Configuration.ConfigurationManager.AppSettings("COM_Name")
        Console.WriteLine("COM name: " & name)

        COM = name
    End Sub

    Sub Get_IP_Address()
        Dim stat As String = System.Configuration.ConfigurationManager.AppSettings("IP_Add")
        Console.WriteLine("Serial Stat: " & stat)

        IP = stat
    End Sub

    Sub Get_Message_Delay()
        Dim Del As String = System.Configuration.ConfigurationManager.AppSettings("Message_Delay")
        Console.WriteLine("Message Delay: " & Del)

        Mes_Del = Del
    End Sub

    Sub Update_COM_NAME()
        config.AppSettings.Settings("COM_Name").Value = New_COM ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_IP_Address()
        config.AppSettings.Settings("IP_Add").Value = New_IP ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Message_Delay()
        config.AppSettings.Settings("Message_Delay").Value = New_Mes_Del ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
End Module

Module Function_Module

    Sub Load_AvailableCOM()
        Dim TegamportName As String() = SerialPort.GetPortNames()
        For Each COMname As String In TegamportName
            Change_COM_IP_Form.cboCOM.Items.Add(COMname)
        Next
    End Sub

    Sub ShowAllSensors()
        WIA_Layout_Form.Close()
        With Sensors_Form
            .TopLevel = False
            Design2_Form.PanelMaster.Controls.Add(Sensors_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub
    Sub ShowLayout()
        With WIA_Layout_Form
            .TopLevel = False
            Design2_Form.PanelMaster.Controls.Add(WIA_Layout_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub Load_AddForm()
        Master_login.Label1.Text = "Please scan your finger. Engineer only"
        Master_login.ShowDialog()
        If Master_login.F1_get_title = "Engineer" Then

            Master_login.Close()
            With Add_Form
                .TopLevel = False
                Design2_Form.PanelMaster.Controls.Add(Add_Form)
                .WindowState = FormWindowState.Maximized
                .BringToFront()
                .Show()
            End With

        Else

            MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If
    End Sub

    Sub Load_Settings()
        Master_login.Label1.Text = "Please scan your finger. Engineer only"
        Master_login.ShowDialog()
        If Master_login.F1_get_title = "Engineer" Then

            Master_login.Close()
            Change_COM_IP_Form.ShowDialog()

        Else

            MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If
    End Sub

    Public Update_MessAndDelay As Boolean

End Module

Module SMS_Module
    Public GlobalSMS As String
    Public Mess As String '= "SMS WIA Gas Leak Monitoring Sample"
    Public Receiver As String
    Public Receivers_Email As String

    Public Sub SerialSetting()
        Design2_Form.SerialPort1.Close()
        Design2_Form.SerialPort1 = New SerialPort

        With Design2_Form.SerialPort1
            .PortName = COM
            .BaudRate = 9600 ' Or whatever the modem requires
            .DataBits = 8
            .Parity = IO.Ports.Parity.None
            .StopBits = IO.Ports.StopBits.One
            .Handshake = IO.Ports.Handshake.None
            .DtrEnable = True
            .RtsEnable = True
            .NewLine = vbCrLf
        End With

        GlobalSMS = Mess

        If Not Design2_Form.SerialPort1.IsOpen Then
            Design2_Form.SerialPort1.Open()
        End If
    End Sub

    Public message_Tosend As String
    Public Sub SMS_Warning()

        Get_Details()

        'Dim Reciever As String = "09393998531;09089555589;09991904845"

        'If Not GasLeak_Loc.Contains(GT01_Location) Then
        '    GasLeak_Loc.Add(GT01_Location)
        'End If

        'If Not GasLeak_Loc.Contains(GT21_Location) Then
        '    GasLeak_Loc.Add(GT21_Location)
        'End If

        'If Not GasLeak_Loc.Contains(GT49_Location) Then
        '    GasLeak_Loc.Add(GT49_Location)
        'End If

        Dim GL_Loc As String() = GasLeak_Loc.ToArray()
        Dim Location_List As String = String.Join(vbNewLine, GL_Loc)

        Try
            ' Array or List of phone numbers to send the SMS to
            Dim phoneNumbers As String() = Receiver.Split(";") '
            message_Tosend = Mess & vbCrLf & Location_List

            SerialSetting()

            ' Set SMS to text mode
            Design2_Form.SerialPort1.Write("AT+CMGF=1" & vbCrLf)
            Thread.Sleep(1000) ' Allow time for response
            Console.WriteLine(Design2_Form.SerialPort1.ReadExisting()) ' For debugging

            ' Loop through each number and send the message
            For Each number As String In phoneNumbers
                ' Remove any leading/trailing spaces
                number = number.Trim()

                ' Set recipient number
                Design2_Form.SerialPort1.Write("AT+CMGS=" & Chr(34) & number & Chr(34) & vbCrLf)
                Thread.Sleep(1000) ' Wait for '>'
                Console.WriteLine(Design2_Form.SerialPort1.ReadExisting()) ' For debugging

                ' Write the SMS content
                Design2_Form.SerialPort1.Write(message_Tosend)
                Thread.Sleep(500) ' Short delay

                ' Send Ctrl+Z to submit the message
                Design2_Form.SerialPort1.Write(Chr(26)) ' Ctrl+Z character
                Thread.Sleep(2000) ' Wait for the SMS to be sent

                ' Get the response from the modem
                Dim response As String = Design2_Form.SerialPort1.ReadExisting()
                Console.WriteLine(response) ' For debugging

                If response.Contains("OK") Then
                    'MsgBox("Message sent to " & number, MsgBoxStyle.Information)
                    Console.WriteLine("Message sent")
                ElseIf response.Contains("ERROR") Then
                    'MsgBox("Failed to send message to " & number, MsgBoxStyle.Critical)
                    Console.WriteLine("ERROR Message Sent")
                End If

                Thread.Sleep(3000) ' Optional: Add delay between messages to avoid network issues
            Next

            'Array.Clear(GL_Loc, 0, GL_Loc.Length)
            'GasLeak_Loc.Clear()

            ' Close the serial port after sending all messages
            Design2_Form.SerialPort1.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Design2_Form.SerialPort1.IsOpen Then
                Design2_Form.SerialPort1.Close()
            End If
        End Try

    End Sub

    Public Sub SMS_NoLeak()

        Get_Details()

        Try
            ' Array or List of phone numbers to send the SMS to
            Dim phoneNumbers As String() = Receiver.Split(";") '
            message_Tosend = "WIA Gas Leak Monitoring Sytem" & vbCrLf & vbCrLf & "There are no more gas leaks detected."

            SerialSetting()

            ' Set SMS to text mode
            Design2_Form.SerialPort1.Write("AT+CMGF=1" & vbCrLf)
            Thread.Sleep(1000) ' Allow time for response
            Console.WriteLine(Design2_Form.SerialPort1.ReadExisting()) ' For debugging

            ' Loop through each number and send the message
            For Each number As String In phoneNumbers
                ' Remove any leading/trailing spaces
                number = number.Trim()

                ' Set recipient number
                Design2_Form.SerialPort1.Write("AT+CMGS=" & Chr(34) & number & Chr(34) & vbCrLf)
                Thread.Sleep(1000) ' Wait for '>'
                Console.WriteLine(Design2_Form.SerialPort1.ReadExisting()) ' For debugging

                ' Write the SMS content
                Design2_Form.SerialPort1.Write(message_Tosend)
                Thread.Sleep(500) ' Short delay

                ' Send Ctrl+Z to submit the message
                Design2_Form.SerialPort1.Write(Chr(26)) ' Ctrl+Z character
                Thread.Sleep(2000) ' Wait for the SMS to be sent

                ' Get the response from the modem
                Dim response As String = Design2_Form.SerialPort1.ReadExisting()
                Console.WriteLine(response) ' For debugging

                If response.Contains("OK") Then
                    'MsgBox("Message sent to " & number, MsgBoxStyle.Information)
                    Console.WriteLine("Message sent")
                ElseIf response.Contains("ERROR") Then
                    'MsgBox("Failed to send message to " & number, MsgBoxStyle.Critical)
                    Console.WriteLine("ERROR Message Sent")
                End If

                Thread.Sleep(3000) ' Optional: Add delay between messages to avoid network issues
            Next

            'Array.Clear(GL_Loc, 0, GL_Loc.Length)
            'GasLeak_Loc.Clear()

            ' Close the serial port after sending all messages
            Design2_Form.SerialPort1.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Design2_Form.SerialPort1.IsOpen Then
                Design2_Form.SerialPort1.Close()
            End If
        End Try

    End Sub

End Module

Module Email_Module
    Public Email As MailMessage

    Sub Send_Email()

        Dim GL_Loc As String() = GasLeak_Loc.ToArray()
        Dim Location_List As String = String.Join("<br>", GL_Loc)

        Dim news_Mes As String
        news_Mes = Mess.Replace("WIA Gas Leak Monitoring Sytem", "")
        Dim Body_Mes As String = news_Mes & "<br>" & Location_List

        Try
            'Dim EmailAdd As String = "gcatapang@littelfuse.com; bmadlangbayan@littelfuse.com; jburog@littelfuse.com; mroxas2@littelfuse.com"
            Dim Recipients As String() = Receivers_Email.Split(";"c)
            Dim SMTP As New SmtpClient

            Email = New MailMessage

            For Each Reciever As String In Recipients
                Email.To.Add(New MailAddress(Reciever.ToString()))
            Next


            Email.From = New MailAddress("WIA_gasleak@littelfuse.com")
            Email.Subject = "WIA Gas Leak Alarm"
            Email.Body = "<div style='font-family: Arial, sans-serif; font-size: 12pt;'>Good day,<br><br>" &
                                        Body_Mes &
                                       "<br></div>
                                        <br> <small style='color:Gray;'><i> This is a system generated mail. Please do not reply.</i></small>"
            Email.IsBodyHtml = True
            ' Set high importance
            Email.Priority = MailPriority.High

            'AddHandler SMTP.SendCompleted, AddressOf SendCompletedCallback

            SMTP.Host = "mailrelay.america.littelfuse.com"
            SMTP.SendAsync(Email, Nothing)

        Catch ex As Exception

            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub

    Sub Send_Email_NoLeak()

        Dim Body_Mes As String = "There are no more gas leaks detected."

        Try
            'Dim EmailAdd As String = "gcatapang@littelfuse.com; bmadlangbayan@littelfuse.com; jburog@littelfuse.com; mroxas2@littelfuse.com"
            Dim Recipients As String() = Receivers_Email.Split(";"c)
            Dim SMTP As New SmtpClient

            Email = New MailMessage

            For Each Reciever As String In Recipients
                Email.To.Add(New MailAddress(Reciever.ToString()))
            Next


            Email.From = New MailAddress("WIA_gasleak@littelfuse.com")
            Email.Subject = "WIA Gas Leak Alarm Update"
            Email.Body = "<div style='font-family: Arial, sans-serif; font-size: 12pt;'>Good day,<br><br>" &
                                        Body_Mes &
                                       "<br></div>
                                        <br> <small style='color:Gray;'><i> This is a system generated mail. Please do not reply.</i></small>"
            Email.IsBodyHtml = True
            ' Set high importance
            Email.Priority = MailPriority.High

            'AddHandler SMTP.SendCompleted, AddressOf SendCompletedCallback

            SMTP.Host = "mailrelay.america.littelfuse.com"
            SMTP.SendAsync(Email, Nothing)

        Catch ex As Exception

            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub

End Module