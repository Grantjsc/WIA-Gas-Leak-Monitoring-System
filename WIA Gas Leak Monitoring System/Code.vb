Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO.Ports
Imports System.Net.Mail
Imports System.Threading
Imports System.Web
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
        Else
            'MessageBox.Show("Failed to read data: " & readResult.Message)
            'Console.WriteLine("Failed to read data: " & readResult.Message)
        End If
    End Sub

    Sub Read_D01()
        Dim readResult = Form1.omronPLC.ReadInt16("D01")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas01_Mid.Text = readResult.Content & " %"
        End If
    End Sub

    Sub Read_D02()
        Dim readResult = Form1.omronPLC.ReadInt16("D02")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas01_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 02 Sensors Value

    Sub Read_D03()
        Dim readResult = Form1.omronPLC.ReadInt16("D03")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas02_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D04()
        Dim readResult = Form1.omronPLC.ReadInt16("D04")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas02_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D05()
        Dim readResult = Form1.omronPLC.ReadInt16("D05")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas02_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 03 Sensors Value
    Sub Read_D06()
        Dim readResult = Form1.omronPLC.ReadInt16("D06")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas03_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D07()
        Dim readResult = Form1.omronPLC.ReadInt16("D07")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas03_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D08()
        Dim readResult = Form1.omronPLC.ReadInt16("D08")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas03_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 04 Sensors Value

    Sub Read_D09()
        Dim readResult = Form1.omronPLC.ReadInt16("D09")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas04_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D10()
        Dim readResult = Form1.omronPLC.ReadInt16("D10")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas04_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D11()
        Dim readResult = Form1.omronPLC.ReadInt16("D11")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas04_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 05 Sensors Value

    Sub Read_D12()
        Dim readResult = Form1.omronPLC.ReadInt16("D12")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas05_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D13()
        Dim readResult = Form1.omronPLC.ReadInt16("D13")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas05_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D14()
        Dim readResult = Form1.omronPLC.ReadInt16("D14")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas05_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 06 Sensors Value

    Sub Read_D15()
        Dim readResult = Form1.omronPLC.ReadInt16("D15")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas06_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D16()
        Dim readResult = Form1.omronPLC.ReadInt16("D16")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas06_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D17()
        Dim readResult = Form1.omronPLC.ReadInt16("D17")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas06_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 07 Sensors Value

    Sub Read_D18()
        Dim readResult = Form1.omronPLC.ReadInt16("D18")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas07_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D19()
        Dim readResult = Form1.omronPLC.ReadInt16("D19")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas07_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D20()
        Dim readResult = Form1.omronPLC.ReadInt16("D20")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas07_Low.Text = readResult.Content & " %"
        End If
    End Sub


    ' Selas 08 Sensors Value

    Sub Read_D21()
        Dim readResult = Form1.omronPLC.ReadInt16("D21")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas08_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D22()
        Dim readResult = Form1.omronPLC.ReadInt16("D22")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas08_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D23()
        Dim readResult = Form1.omronPLC.ReadInt16("D23")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas08_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 09 Sensors Value

    Sub Read_D24()
        Dim readResult = Form1.omronPLC.ReadInt16("D24")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas09_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D25()
        Dim readResult = Form1.omronPLC.ReadInt16("D25")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas09_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D26()
        Dim readResult = Form1.omronPLC.ReadInt16("D26")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas09_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 10 Sensors Value

    Sub Read_D27()
        Dim readResult = Form1.omronPLC.ReadInt16("D27")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas10_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D28()
        Dim readResult = Form1.omronPLC.ReadInt16("D28")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas10_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D29()
        Dim readResult = Form1.omronPLC.ReadInt16("D29")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas10_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 11 Sensors Value

    Sub Read_D30()
        Dim readResult = Form1.omronPLC.ReadInt16("D30")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas11_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D31()
        Dim readResult = Form1.omronPLC.ReadInt16("D31")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas11_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D32()
        Dim readResult = Form1.omronPLC.ReadInt16("D32")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas11_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 12 Sensors Value

    Sub Read_D33()
        Dim readResult = Form1.omronPLC.ReadInt16("D33")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas12_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D34()
        Dim readResult = Form1.omronPLC.ReadInt16("D34")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas12_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D35()
        Dim readResult = Form1.omronPLC.ReadInt16("D35")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas12_Low.Text = readResult.Content & " %"
        End If
    End Sub

    ' Selas 13 Sensors Value

    Sub Read_D36()
        Dim readResult = Form1.omronPLC.ReadInt16("D36")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas13_Up.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D37()
        Dim readResult = Form1.omronPLC.ReadInt16("D37")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas13_Mid.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D38()
        Dim readResult = Form1.omronPLC.ReadInt16("D38")
        If readResult.IsSuccess Then
            Sensors_Form.txtSelas13_Low.Text = readResult.Content & " %"
        End If
    End Sub

    'WAREHOUSE TRENCH SENSOR VALUE
    Sub Read_D39()
        Dim readResult = Form1.omronPLC.ReadInt16("D39")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_01.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D40()
        Dim readResult = Form1.omronPLC.ReadInt16("D40")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_02.Text = readResult.Content & " %"
        End If
    End Sub

    'PICO TO SQUARE NANO TRENCH SENSOR VALUE
    Sub Read_D41()
        Dim readResult = Form1.omronPLC.ReadInt16("D41")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_03.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D42()
        Dim readResult = Form1.omronPLC.ReadInt16("D42")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_04.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D43()
        Dim readResult = Form1.omronPLC.ReadInt16("D43")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_05.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D44()
        Dim readResult = Form1.omronPLC.ReadInt16("D44")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_06.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D45()
        Dim readResult = Form1.omronPLC.ReadInt16("D45")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_07.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D46()
        Dim readResult = Form1.omronPLC.ReadInt16("D46")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_08.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D47()
        Dim readResult = Form1.omronPLC.ReadInt16("D47")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_09.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D48()
        Dim readResult = Form1.omronPLC.ReadInt16("D48")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_10.Text = readResult.Content & " %"
        End If
    End Sub

    'PICO TRENCH SENSOR VALUE
    Sub Read_D49()
        Dim readResult = Form1.omronPLC.ReadInt16("D49")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_11.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D50()
        Dim readResult = Form1.omronPLC.ReadInt16("D50")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_12.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D51()
        Dim readResult = Form1.omronPLC.ReadInt16("D51")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_13.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D52()
        Dim readResult = Form1.omronPLC.ReadInt16("D52")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_14.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D53()
        Dim readResult = Form1.omronPLC.ReadInt16("D53")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_15.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D54()
        Dim readResult = Form1.omronPLC.ReadInt16("D54")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_16.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D55()
        Dim readResult = Form1.omronPLC.ReadInt16("D55")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_17.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D56()
        Dim readResult = Form1.omronPLC.ReadInt16("D56")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_18.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D57()
        Dim readResult = Form1.omronPLC.ReadInt16("D57")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_19.Text = readResult.Content & " %"
        End If
    End Sub
    Sub Read_D58()
        Dim readResult = Form1.omronPLC.ReadInt16("D58")
        If readResult.IsSuccess Then
            Sensors_Form.txtTS_20.Text = readResult.Content & " %"
        End If
    End Sub

    '***************** GAS MIXING ************************
    Sub Read_D59()
        Dim readResult = Form1.omronPLC.ReadInt16("D59")
        If readResult.IsSuccess Then
            Sensors_Form.txtGM1.Text = readResult.Content & " %"
        End If
    End Sub

    Sub Read_D60()
        Dim readResult = Form1.omronPLC.ReadInt16("D60")
        If readResult.IsSuccess Then
            Sensors_Form.txtGM4.Text = readResult.Content & " %"
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
        Dim readResult = Form1.omronPLC.ReadBool(Alarm_Reading1)
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
            Else

                WIA_Layout_Form.btnSelas01.FillColor = Color.Red

                WIA_Layout_Form.btnS01.FillColor = Color.Red
                WIA_Layout_Form.btnS01.ForeColor = Color.White

                Sensors_Form.txtSelas01_Up.ForeColor = Color.White
                Sensors_Form.txtSelas01_Up.BackColor = Color.Red
                Sensors_Form.picSelas01_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas01.FillColor = Color.Red

                WIA_Layout_Form.btnS01.FillColor = Color.Red
                WIA_Layout_Form.btnS01.ForeColor = Color.White

                Sensors_Form.txtSelas01_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas01_Mid.BackColor = Color.Red
                Sensors_Form.picSelas01_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas01.FillColor = Color.Red

                WIA_Layout_Form.btnS01.FillColor = Color.Red
                WIA_Layout_Form.btnS01.ForeColor = Color.White

                Sensors_Form.txtSelas01_Low.ForeColor = Color.White
                Sensors_Form.txtSelas01_Low.BackColor = Color.Red
                Sensors_Form.picSelas01_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas02.FillColor = Color.Red

                WIA_Layout_Form.btnS02.FillColor = Color.Red
                WIA_Layout_Form.btnS02.ForeColor = Color.White

                Sensors_Form.txtSelas02_Up.ForeColor = Color.White
                Sensors_Form.txtSelas02_Up.BackColor = Color.Red
                Sensors_Form.picSelas02_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas02.FillColor = Color.Red

                WIA_Layout_Form.btnS02.FillColor = Color.Red
                WIA_Layout_Form.btnS02.ForeColor = Color.White

                Sensors_Form.txtSelas02_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas02_Mid.BackColor = Color.Red
                Sensors_Form.picSelas02_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas02.FillColor = Color.Red

                WIA_Layout_Form.btnS02.FillColor = Color.Red
                WIA_Layout_Form.btnS02.ForeColor = Color.White

                Sensors_Form.txtSelas02_Low.ForeColor = Color.White
                Sensors_Form.txtSelas02_Low.BackColor = Color.Red
                Sensors_Form.picSelas02_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas03.FillColor = Color.Red

                WIA_Layout_Form.btnS03.FillColor = Color.Red
                WIA_Layout_Form.btnS03.ForeColor = Color.White

                Sensors_Form.txtSelas03_Up.ForeColor = Color.White
                Sensors_Form.txtSelas03_Up.BackColor = Color.Red
                Sensors_Form.picSelas03_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas03.FillColor = Color.Red

                WIA_Layout_Form.btnS03.FillColor = Color.Red
                WIA_Layout_Form.btnS03.ForeColor = Color.White

                Sensors_Form.txtSelas03_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas03_Mid.BackColor = Color.Red
                Sensors_Form.picSelas03_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas03.FillColor = Color.Red

                WIA_Layout_Form.btnS03.FillColor = Color.Red
                WIA_Layout_Form.btnS03.ForeColor = Color.White

                Sensors_Form.txtSelas03_Low.ForeColor = Color.White
                Sensors_Form.txtSelas03_Low.BackColor = Color.Red
                Sensors_Form.picSelas03_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas04.FillColor = Color.Red

                WIA_Layout_Form.btnS04.FillColor = Color.Red
                WIA_Layout_Form.btnS04.ForeColor = Color.White

                Sensors_Form.txtSelas04_Up.ForeColor = Color.White
                Sensors_Form.txtSelas04_Up.BackColor = Color.Red
                Sensors_Form.picSelas04_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas04.FillColor = Color.Red

                WIA_Layout_Form.btnS04.FillColor = Color.Red
                WIA_Layout_Form.btnS04.ForeColor = Color.White

                Sensors_Form.txtSelas04_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas04_Mid.BackColor = Color.Red
                Sensors_Form.picSelas04_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas04.FillColor = Color.Red

                WIA_Layout_Form.btnS04.FillColor = Color.Red
                WIA_Layout_Form.btnS04.ForeColor = Color.White

                Sensors_Form.txtSelas04_Low.ForeColor = Color.White
                Sensors_Form.txtSelas04_Low.BackColor = Color.Red
                Sensors_Form.picSelas04_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas05.FillColor = Color.Red

                WIA_Layout_Form.btnS05.FillColor = Color.Red
                WIA_Layout_Form.btnS05.ForeColor = Color.White

                Sensors_Form.txtSelas05_Up.ForeColor = Color.White
                Sensors_Form.txtSelas05_Up.BackColor = Color.Red
                Sensors_Form.picSelas05_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas05.FillColor = Color.Red

                WIA_Layout_Form.btnS05.FillColor = Color.Red
                WIA_Layout_Form.btnS05.ForeColor = Color.White

                Sensors_Form.txtSelas05_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas05_Mid.BackColor = Color.Red
                Sensors_Form.picSelas05_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas05.FillColor = Color.Red

                WIA_Layout_Form.btnS05.FillColor = Color.Red
                WIA_Layout_Form.btnS05.ForeColor = Color.White

                Sensors_Form.txtSelas05_Low.ForeColor = Color.White
                Sensors_Form.txtSelas05_Low.BackColor = Color.Red
                Sensors_Form.picSelas05_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas06.FillColor = Color.Red

                WIA_Layout_Form.btnS06.FillColor = Color.Red
                WIA_Layout_Form.btnS06.ForeColor = Color.White

                Sensors_Form.txtSelas06_Up.ForeColor = Color.White
                Sensors_Form.txtSelas06_Up.BackColor = Color.Red
                Sensors_Form.picSelas06_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas06.FillColor = Color.Red

                WIA_Layout_Form.btnS06.FillColor = Color.Red
                WIA_Layout_Form.btnS06.ForeColor = Color.White

                Sensors_Form.txtSelas06_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas06_Mid.BackColor = Color.Red
                Sensors_Form.picSelas06_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas06.FillColor = Color.Red

                WIA_Layout_Form.btnS06.FillColor = Color.Red
                WIA_Layout_Form.btnS06.ForeColor = Color.White

                Sensors_Form.txtSelas06_Low.ForeColor = Color.White
                Sensors_Form.txtSelas06_Low.BackColor = Color.Red
                Sensors_Form.picSelas06_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas07.FillColor = Color.Red

                WIA_Layout_Form.btnS07.FillColor = Color.Red
                WIA_Layout_Form.btnS07.ForeColor = Color.White

                Sensors_Form.txtSelas07_Up.ForeColor = Color.White
                Sensors_Form.txtSelas07_Up.BackColor = Color.Red
                Sensors_Form.picSelas07_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas07.FillColor = Color.Red

                WIA_Layout_Form.btnS07.FillColor = Color.Red
                WIA_Layout_Form.btnS07.ForeColor = Color.White

                Sensors_Form.txtSelas07_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas07_Mid.BackColor = Color.Red
                Sensors_Form.picSelas07_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas07.FillColor = Color.Red

                WIA_Layout_Form.btnS07.FillColor = Color.Red
                WIA_Layout_Form.btnS07.ForeColor = Color.White

                Sensors_Form.txtSelas07_Low.ForeColor = Color.White
                Sensors_Form.txtSelas07_Low.BackColor = Color.Red
                Sensors_Form.picSelas07_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas08.FillColor = Color.Red

                WIA_Layout_Form.btnS08.FillColor = Color.Red
                WIA_Layout_Form.btnS08.ForeColor = Color.White

                Sensors_Form.txtSelas08_Up.ForeColor = Color.White
                Sensors_Form.txtSelas08_Up.BackColor = Color.Red
                Sensors_Form.picSelas08_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas08.FillColor = Color.Red

                WIA_Layout_Form.btnS08.FillColor = Color.Red
                WIA_Layout_Form.btnS08.ForeColor = Color.White

                Sensors_Form.txtSelas08_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas08_Mid.BackColor = Color.Red
                Sensors_Form.picSelas08_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas08.FillColor = Color.Red

                WIA_Layout_Form.btnS08.FillColor = Color.Red
                WIA_Layout_Form.btnS08.ForeColor = Color.White

                Sensors_Form.txtSelas08_Low.ForeColor = Color.White
                Sensors_Form.txtSelas08_Low.BackColor = Color.Red
                Sensors_Form.picSelas08_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas09.FillColor = Color.Red

                WIA_Layout_Form.btnS09.FillColor = Color.Red
                WIA_Layout_Form.btnS09.ForeColor = Color.White

                Sensors_Form.txtSelas09_Up.ForeColor = Color.White
                Sensors_Form.txtSelas09_Up.BackColor = Color.Red
                Sensors_Form.picSelas09_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas09.FillColor = Color.Red

                WIA_Layout_Form.btnS09.FillColor = Color.Red
                WIA_Layout_Form.btnS09.ForeColor = Color.White

                Sensors_Form.txtSelas09_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas09_Mid.BackColor = Color.Red
                Sensors_Form.picSelas09_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas09.FillColor = Color.Red

                WIA_Layout_Form.btnS09.FillColor = Color.Red
                WIA_Layout_Form.btnS09.ForeColor = Color.White

                Sensors_Form.txtSelas09_Low.ForeColor = Color.White
                Sensors_Form.txtSelas09_Low.BackColor = Color.Red
                Sensors_Form.picSelas09_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas10.FillColor = Color.Red

                WIA_Layout_Form.btnS10.FillColor = Color.Red
                WIA_Layout_Form.btnS10.ForeColor = Color.White

                Sensors_Form.txtSelas10_Up.ForeColor = Color.White
                Sensors_Form.txtSelas10_Up.BackColor = Color.Red
                Sensors_Form.picSelas10_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas10.FillColor = Color.Red

                WIA_Layout_Form.btnS10.FillColor = Color.Red
                WIA_Layout_Form.btnS10.ForeColor = Color.White

                Sensors_Form.txtSelas10_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas10_Mid.BackColor = Color.Red
                Sensors_Form.picSelas10_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas10.FillColor = Color.Red

                WIA_Layout_Form.btnS10.FillColor = Color.Red
                WIA_Layout_Form.btnS10.ForeColor = Color.White

                Sensors_Form.txtSelas10_Low.ForeColor = Color.White
                Sensors_Form.txtSelas10_Low.BackColor = Color.Red
                Sensors_Form.picSelas10_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas11.FillColor = Color.Red

                WIA_Layout_Form.btnS11.FillColor = Color.Red
                WIA_Layout_Form.btnS11.ForeColor = Color.White

                Sensors_Form.txtSelas11_Up.ForeColor = Color.White
                Sensors_Form.txtSelas11_Up.BackColor = Color.Red
                Sensors_Form.picSelas11_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas11.FillColor = Color.Red

                WIA_Layout_Form.btnS11.FillColor = Color.Red
                WIA_Layout_Form.btnS11.ForeColor = Color.White

                Sensors_Form.txtSelas11_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas11_Mid.BackColor = Color.Red
                Sensors_Form.picSelas11_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas11.FillColor = Color.Red

                WIA_Layout_Form.btnS11.FillColor = Color.Red
                WIA_Layout_Form.btnS11.ForeColor = Color.White

                Sensors_Form.txtSelas11_Low.ForeColor = Color.White
                Sensors_Form.txtSelas11_Low.BackColor = Color.Red
                Sensors_Form.picSelas11_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas12.FillColor = Color.Red

                WIA_Layout_Form.btnS12.FillColor = Color.Red
                WIA_Layout_Form.btnS12.ForeColor = Color.White

                Sensors_Form.txtSelas12_Up.ForeColor = Color.White
                Sensors_Form.txtSelas12_Up.BackColor = Color.Red
                Sensors_Form.picSelas12_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas12.FillColor = Color.Red

                WIA_Layout_Form.btnS12.FillColor = Color.Red
                WIA_Layout_Form.btnS12.ForeColor = Color.White

                Sensors_Form.txtSelas12_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas12_Mid.BackColor = Color.Red
                Sensors_Form.picSelas12_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas12.FillColor = Color.Red

                WIA_Layout_Form.btnS12.FillColor = Color.Red
                WIA_Layout_Form.btnS12.ForeColor = Color.White

                Sensors_Form.txtSelas12_Low.ForeColor = Color.White
                Sensors_Form.txtSelas12_Low.BackColor = Color.Red
                Sensors_Form.picSelas12_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas13.FillColor = Color.Red

                WIA_Layout_Form.btnS13.FillColor = Color.Red
                WIA_Layout_Form.btnS13.ForeColor = Color.White

                Sensors_Form.txtSelas13_Up.ForeColor = Color.White
                Sensors_Form.txtSelas13_Up.BackColor = Color.Red
                Sensors_Form.picSelas13_Up_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas13.FillColor = Color.Red

                WIA_Layout_Form.btnS13.FillColor = Color.Red
                WIA_Layout_Form.btnS13.ForeColor = Color.White

                Sensors_Form.txtSelas13_Mid.ForeColor = Color.White
                Sensors_Form.txtSelas13_Mid.BackColor = Color.Red
                Sensors_Form.picSelas13_Mid_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnSelas13.FillColor = Color.Red

                WIA_Layout_Form.btnS13.FillColor = Color.Red
                WIA_Layout_Form.btnS13.ForeColor = Color.White

                Sensors_Form.txtSelas13_Low.ForeColor = Color.White
                Sensors_Form.txtSelas13_Low.BackColor = Color.Red
                Sensors_Form.picSelas13_Low_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench01.FillColor = Color.Red

                WIA_Layout_Form.btnT01.FillColor = Color.Red
                WIA_Layout_Form.btnT01.ForeColor = Color.White

                Sensors_Form.txtTS_01.ForeColor = Color.White
                Sensors_Form.txtTS_01.BackColor = Color.Red
                Sensors_Form.picTS_01_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench02.FillColor = Color.Red

                WIA_Layout_Form.btnT02.FillColor = Color.Red
                WIA_Layout_Form.btnT02.ForeColor = Color.White

                Sensors_Form.txtTS_02.ForeColor = Color.White
                Sensors_Form.txtTS_02.BackColor = Color.Red
                Sensors_Form.picTS_02_Alarm.Visible = True
            End If
        End If
    End Sub

    'PICO TO SQUARE NANO TRENCH SENSOR VALUE
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
            Else

                WIA_Layout_Form.btnTrench03.FillColor = Color.Red

                WIA_Layout_Form.btnT03.FillColor = Color.Red
                WIA_Layout_Form.btnT03.ForeColor = Color.White

                Sensors_Form.txtTS_03.ForeColor = Color.White
                Sensors_Form.txtTS_03.BackColor = Color.Red
                Sensors_Form.picTS_03_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench04.FillColor = Color.Red

                WIA_Layout_Form.btnT04.FillColor = Color.Red
                WIA_Layout_Form.btnT04.ForeColor = Color.White

                Sensors_Form.txtTS_04.ForeColor = Color.White
                Sensors_Form.txtTS_04.BackColor = Color.Red
                Sensors_Form.picTS_04_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench05.FillColor = Color.Red

                WIA_Layout_Form.btnT05.FillColor = Color.Red
                WIA_Layout_Form.btnT05.ForeColor = Color.White

                Sensors_Form.txtTS_05.ForeColor = Color.White
                Sensors_Form.txtTS_05.BackColor = Color.Red
                Sensors_Form.picTS_05_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench06.FillColor = Color.Red

                WIA_Layout_Form.btnT06.FillColor = Color.Red
                WIA_Layout_Form.btnT06.ForeColor = Color.White

                Sensors_Form.txtTS_06.ForeColor = Color.White
                Sensors_Form.txtTS_06.BackColor = Color.Red
                Sensors_Form.picTS_06_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench07.FillColor = Color.Red

                WIA_Layout_Form.btnT07.FillColor = Color.Red
                WIA_Layout_Form.btnT07.ForeColor = Color.White

                Sensors_Form.txtTS_07.ForeColor = Color.White
                Sensors_Form.txtTS_07.BackColor = Color.Red
                Sensors_Form.picTS_07_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench08.FillColor = Color.Red

                WIA_Layout_Form.btnT08.FillColor = Color.Red
                WIA_Layout_Form.btnT08.ForeColor = Color.White

                Sensors_Form.txtTS_08.ForeColor = Color.White
                Sensors_Form.txtTS_08.BackColor = Color.Red
                Sensors_Form.picTS_08_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench09.FillColor = Color.Red

                WIA_Layout_Form.btnT09.FillColor = Color.Red
                WIA_Layout_Form.btnT09.ForeColor = Color.White

                Sensors_Form.txtTS_09.ForeColor = Color.White
                Sensors_Form.txtTS_09.BackColor = Color.Red
                Sensors_Form.picTS_09_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench10.FillColor = Color.Red

                WIA_Layout_Form.btnT10.FillColor = Color.Red
                WIA_Layout_Form.btnT10.ForeColor = Color.White

                Sensors_Form.txtTS_10.ForeColor = Color.White
                Sensors_Form.txtTS_10.BackColor = Color.Red
                Sensors_Form.picTS_10_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench11.FillColor = Color.Red

                WIA_Layout_Form.btnT11.FillColor = Color.Red
                WIA_Layout_Form.btnT11.ForeColor = Color.White

                Sensors_Form.txtTS_11.ForeColor = Color.White
                Sensors_Form.txtTS_11.BackColor = Color.Red
                Sensors_Form.picTS_11_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench12.FillColor = Color.Red

                WIA_Layout_Form.btnT12.FillColor = Color.Red
                WIA_Layout_Form.btnT12.ForeColor = Color.White

                Sensors_Form.txtTS_12.ForeColor = Color.White
                Sensors_Form.txtTS_12.BackColor = Color.Red
                Sensors_Form.picTS_12_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench13.FillColor = Color.Red

                WIA_Layout_Form.btnT13.FillColor = Color.Red
                WIA_Layout_Form.btnT13.ForeColor = Color.White

                Sensors_Form.txtTS_13.ForeColor = Color.White
                Sensors_Form.txtTS_13.BackColor = Color.Red
                Sensors_Form.picTS_13_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench14.FillColor = Color.Red

                WIA_Layout_Form.btnT14.FillColor = Color.Red
                WIA_Layout_Form.btnT14.ForeColor = Color.White

                Sensors_Form.txtTS_14.ForeColor = Color.White
                Sensors_Form.txtTS_14.BackColor = Color.Red
                Sensors_Form.picTS_14_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench15.FillColor = Color.Red

                WIA_Layout_Form.btnT15.FillColor = Color.Red
                WIA_Layout_Form.btnT15.ForeColor = Color.White

                Sensors_Form.txtTS_15.ForeColor = Color.White
                Sensors_Form.txtTS_15.BackColor = Color.Red
                Sensors_Form.picTS_15_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench16.FillColor = Color.Red

                WIA_Layout_Form.btnT16.FillColor = Color.Red
                WIA_Layout_Form.btnT16.ForeColor = Color.White

                Sensors_Form.txtTS_16.ForeColor = Color.White
                Sensors_Form.txtTS_16.BackColor = Color.Red
                Sensors_Form.picTS_16_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench17.FillColor = Color.Red

                WIA_Layout_Form.btnT17.FillColor = Color.Red
                WIA_Layout_Form.btnT17.ForeColor = Color.White

                Sensors_Form.txtTS_17.ForeColor = Color.White
                Sensors_Form.txtTS_17.BackColor = Color.Red
                Sensors_Form.picTS_17_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench18.FillColor = Color.Red

                WIA_Layout_Form.btnT18.FillColor = Color.Red
                WIA_Layout_Form.btnT18.ForeColor = Color.White

                Sensors_Form.txtTS_18.ForeColor = Color.White
                Sensors_Form.txtTS_18.BackColor = Color.Red
                Sensors_Form.picTS_18_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench19.FillColor = Color.Red

                WIA_Layout_Form.btnT19.FillColor = Color.Red
                WIA_Layout_Form.btnT19.ForeColor = Color.White

                Sensors_Form.txtTS_19.ForeColor = Color.White
                Sensors_Form.txtTS_19.BackColor = Color.Red
                Sensors_Form.picTS_19_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnTrench20.FillColor = Color.Red

                WIA_Layout_Form.btnT20.FillColor = Color.Red
                WIA_Layout_Form.btnT20.ForeColor = Color.White

                Sensors_Form.txtTS_20.ForeColor = Color.White
                Sensors_Form.txtTS_20.BackColor = Color.Red
                Sensors_Form.picTS_20_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnGasMixing1.FillColor = Color.Red

                WIA_Layout_Form.btnGM1.FillColor = Color.Red
                WIA_Layout_Form.btnGM1.ForeColor = Color.White

                Sensors_Form.txtGM1.ForeColor = Color.White
                Sensors_Form.txtGM1.BackColor = Color.Red
                Sensors_Form.picGM1_Alarm.Visible = True
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
            Else

                WIA_Layout_Form.btnGasMixing4.FillColor = Color.Red

                WIA_Layout_Form.btnGM4.FillColor = Color.Red
                WIA_Layout_Form.btnGM4.ForeColor = Color.White

                Sensors_Form.txtGM4.ForeColor = Color.White
                Sensors_Form.txtGM4.BackColor = Color.Red
                Sensors_Form.picGM4_Alarm.Visible = True
            End If
        End If
    End Sub

End Module

Module Query_Module
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\WIA Gas Leak Monitoring.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfwiagasleak"
    Public Dbconnection As New OleDbConnection(connString)
    Public Biometric_Name As String

    Sub ConOpen()
        If Dbconnection.State = ConnectionState.Closed Then
            Dbconnection.Open()
        End If
    End Sub

    Sub ConClose()
        If Dbconnection.State = ConnectionState.Open Then
            Dbconnection.Close()
        End If
    End Sub

    Sub Get_Details()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            ConOpen()

            MyData = "SELECT * FROM Details_tb WHERE ID = 1 "
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            'Clear_Datas()

            If Data.Rows.Count > 0 Then

                Receiver = Data.Rows(0).Item("Receiver_Number").ToString
                Mess = Data.Rows(0).Item("Message").ToString

            Else
                MsgBox("No details found in the database!", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub
End Module

Module AppConfig_Module
    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Public COM As String
    Public New_COM As String
    Public IP As String
    Public New_IP As String

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
End Module

Module SMS_Module
    Public GlobalSMS As String
    Public Mess As String '= "SMS WIA Gas Leak Monitoring Sample"
    Public Receiver As String

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

    Public Sub SMS_Warning()

        Get_Details()

        'Dim Reciever As String = "09393998531;09089555589;09991904845"

        Try
            ' Array or List of phone numbers to send the SMS to
            Dim phoneNumbers As String() = Receiver.Split(";") '
            Dim message As String = Mess

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
                Design2_Form.SerialPort1.Write(message)
                Thread.Sleep(500) ' Short delay

                ' Send Ctrl+Z to submit the message
                Design2_Form.SerialPort1.Write(Chr(26)) ' Ctrl+Z character
                Thread.Sleep(2000) ' Wait for the SMS to be sent

                ' Get the response from the modem
                Dim response As String = Design2_Form.SerialPort1.ReadExisting()
                Console.WriteLine(response) ' For debugging

                If response.Contains("OK") Then
                    MsgBox("Message sent to " & number, MsgBoxStyle.Information)
                ElseIf response.Contains("ERROR") Then
                    MsgBox("Failed to send message to " & number, MsgBoxStyle.Critical)
                End If

                Thread.Sleep(3000) ' Optional: Add delay between messages to avoid network issues
            Next

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
        Try
            Dim EmailAdd As String = "gcatapang@littelfuse.com; bmadlangbayan@littelfuse.com; jburog@littelfuse.com; mroxas2@littelfuse.com"
            Dim Recipients As String() = EmailAdd.Split(";"c)
            Dim SMTP As New SmtpClient

            Email = New MailMessage

            For Each Reciever As String In Recipients
                Email.To.Add(New MailAddress(Reciever.ToString()))
            Next


            Email.From = New MailAddress("WIA_gasleak@littelfuse.com")
            Email.Subject = "WIA Gas Leak Alarm"
            Email.Body = "<div style='font-family: Arial, sans-serif; font-size: 12pt;'>Good day,<br><br>
                                        This is a sample email for Gas Leak Monitoring System. 
                                       <br><br>
                                        Thank you.</div>
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