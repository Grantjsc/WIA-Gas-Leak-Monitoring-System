Imports System.Data.OleDb
Imports System.Data.SqlClient

Module Query_Module

    Public GT01_Val As Decimal
    Public GT02_Val As Decimal
    Public GT03_Val As Decimal
    Public GT04_Val As Decimal
    Public GT05_Val As Decimal
    Public GT06_Val As Decimal
    Public GT07_Val As Decimal
    Public GT08_Val As Decimal
    Public GT09_Val As Decimal
    Public GT10_Val As Decimal
    Public GT11_Val As Decimal
    Public GT12_Val As Decimal
    Public GT13_Val As Decimal
    Public GT14_Val As Decimal
    Public GT15_Val As Decimal
    Public GT16_Val As Decimal
    Public GT17_Val As Decimal
    Public GT18_Val As Decimal
    Public GT19_Val As Decimal
    Public GT20_Val As Decimal
    Public GT21_Val As Decimal
    Public GT22_Val As Decimal
    Public GT23_Val As Decimal
    Public GT24_Val As Decimal
    Public GT25_Val As Decimal
    Public GT26_Val As Decimal
    Public GT27_Val As Decimal
    Public GT28_Val As Decimal
    Public GT29_Val As Decimal
    Public GT30_Val As Decimal
    Public GT31_Val As Decimal
    Public GT32_Val As Decimal
    Public GT33_Val As Decimal
    Public GT34_Val As Decimal
    Public GT35_Val As Decimal
    Public GT36_Val As Decimal
    Public GT37_Val As Decimal
    Public GT38_Val As Decimal
    Public GT39_Val As Decimal
    Public GT40_Val As Decimal
    Public GT41_Val As Decimal
    Public GT42_Val As Decimal
    Public GT43_Val As Decimal
    Public GT44_Val As Decimal
    Public GT45_Val As Decimal
    Public GT46_Val As Decimal
    Public GT47_Val As Decimal
    Public GT48_Val As Decimal
    Public GT49_Val As Decimal
    Public GT50_Val As Decimal
    Public GT51_Val As Decimal
    Public GT52_Val As Decimal
    Public GT53_Val As Decimal
    Public GT54_Val As Decimal
    Public GT55_Val As Decimal
    Public GT56_Val As Decimal
    Public GT57_Val As Decimal
    Public GT58_Val As Decimal
    Public GT59_Val As Decimal
    Public GT60_Val As Decimal
    Public GT61_Val As Decimal



    'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\WIA Gas Leak Monitoring.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfwiagasleak
    'Data Source=BTMESSQLDEV03;Initial Catalog=LFPHPICO;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True

    Public connString As String = "Data Source=BTMESSQLDEV03;Initial Catalog=LFPHPICO;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True"
    Public Dbconnection As New SqlConnection(connString)
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

    'Sub Get_Details()
    '    Try
    '        Dim MyData As String
    '        Dim cmd As New SqlCommand
    '        Dim Data As New DataTable
    '        Dim adap As New SqlDataAdapter
    '        ConOpen()

    '        MyData = "SELECT * FROM Details_tb WHERE ID = 1 "
    '        cmd.Connection = Dbconnection
    '        cmd.CommandText = MyData
    '        adap.SelectCommand = cmd

    '        adap.Fill(Data)

    '        'Clear_Datas()

    '        If Data.Rows.Count > 0 Then

    '            Receiver = Data.Rows(0).Item("Receiver_Number").ToString
    '            Mess = Data.Rows(0).Item("Message").ToString

    '        Else
    '            MsgBox("No details found in the database!", MessageBoxIcon.Error)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        ConClose()
    '    End Try
    'End Sub

    Sub Update_GT_ValDb()
        Try

            Dim query As String = "UPDATE WIA_GLM_GT_Value 
                               SET GT01 = @GT_01, GT02 = @GT_02, GT03 = @GT_03, GT04 = @GT_04, GT05 = @GT_05, 
                               GT06 = @GT_06, GT07 = @GT_07, GT08 = @GT_08, GT09 = @GT_09, GT10 = @GT_10, 
                               GT11 = @GT_11, GT12 = @GT_12, GT13 = @GT_13, GT14 = @GT_14, GT15 = @GT_15, 
                               GT16 = @GT_16, GT17 = @GT_17, GT18 = @GT_18, GT19 = @GT_19, GT20 = @GT_20, 
                               GT21 = @GT_21, GT22 = @GT_22, GT23 = @GT_23, GT24 = @GT_24, GT25 = @GT_25, 
                               GT26 = @GT_26, GT27 = @GT_27, GT28 = @GT_28, GT29 = @GT_29, GT30 = @GT_30, 
                               GT31 = @GT_31, GT32 = @GT_32, GT33 = @GT_33, GT34 = @GT_34, GT35 = @GT_35, 
                               GT36 = @GT_36, GT37 = @GT_37, GT38 = @GT_38, GT39 = @GT_39, GT40 = @GT_40, 
                               GT41 = @GT_41, GT42 = @GT_42, GT43 = @GT_43, GT44 = @GT_44, GT45 = @GT_45, 
                               GT46 = @GT_46, GT47 = @GT_47, GT48 = @GT_48, GT49 = @GT_49, GT50 = @GT_50, 
                               GT51 = @GT_51, GT52 = @GT_52, GT53 = @GT_53, GT54 = @GT_54, GT55 = @GT_55, 
                               GT56 = @GT_56, GT57 = @GT_57, GT58 = @GT_58, GT59 = @GT_59, GT60 = @GT_60, 
                               GT61 = @GT_61
                               WHERE ID = 1"

            Using command As New SqlCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@GT_01", GT01_Val)
                command.Parameters.AddWithValue("@GT_02", GT02_Val)
                command.Parameters.AddWithValue("@GT_03", GT03_Val)
                command.Parameters.AddWithValue("@GT_04", GT04_Val)
                command.Parameters.AddWithValue("@GT_05", GT05_Val)
                command.Parameters.AddWithValue("@GT_06", GT06_Val)
                command.Parameters.AddWithValue("@GT_07", GT07_Val)
                command.Parameters.AddWithValue("@GT_08", GT08_Val)
                command.Parameters.AddWithValue("@GT_09", GT09_Val)
                command.Parameters.AddWithValue("@GT_10", GT10_Val)
                command.Parameters.AddWithValue("@GT_11", GT11_Val)
                command.Parameters.AddWithValue("@GT_12", GT12_Val)
                command.Parameters.AddWithValue("@GT_13", GT13_Val)
                command.Parameters.AddWithValue("@GT_14", GT14_Val)
                command.Parameters.AddWithValue("@GT_15", GT15_Val)
                command.Parameters.AddWithValue("@GT_16", GT16_Val)
                command.Parameters.AddWithValue("@GT_17", GT17_Val)
                command.Parameters.AddWithValue("@GT_18", GT18_Val)
                command.Parameters.AddWithValue("@GT_19", GT19_Val)
                command.Parameters.AddWithValue("@GT_20", GT20_Val)
                command.Parameters.AddWithValue("@GT_21", GT21_Val)
                command.Parameters.AddWithValue("@GT_22", GT22_Val)
                command.Parameters.AddWithValue("@GT_23", GT23_Val)
                command.Parameters.AddWithValue("@GT_24", GT24_Val)
                command.Parameters.AddWithValue("@GT_25", GT25_Val)
                command.Parameters.AddWithValue("@GT_26", GT26_Val)
                command.Parameters.AddWithValue("@GT_27", GT27_Val)
                command.Parameters.AddWithValue("@GT_28", GT28_Val)
                command.Parameters.AddWithValue("@GT_29", GT29_Val)
                command.Parameters.AddWithValue("@GT_30", GT30_Val)
                command.Parameters.AddWithValue("@GT_31", GT31_Val)
                command.Parameters.AddWithValue("@GT_32", GT32_Val)
                command.Parameters.AddWithValue("@GT_33", GT33_Val)
                command.Parameters.AddWithValue("@GT_34", GT34_Val)
                command.Parameters.AddWithValue("@GT_35", GT35_Val)
                command.Parameters.AddWithValue("@GT_36", GT36_Val)
                command.Parameters.AddWithValue("@GT_37", GT37_Val)
                command.Parameters.AddWithValue("@GT_38", GT38_Val)
                command.Parameters.AddWithValue("@GT_39", GT39_Val)
                command.Parameters.AddWithValue("@GT_40", GT40_Val)
                command.Parameters.AddWithValue("@GT_41", GT41_Val)
                command.Parameters.AddWithValue("@GT_42", GT42_Val)
                command.Parameters.AddWithValue("@GT_43", GT43_Val)
                command.Parameters.AddWithValue("@GT_44", GT44_Val)
                command.Parameters.AddWithValue("@GT_45", GT45_Val)
                command.Parameters.AddWithValue("@GT_46", GT46_Val)
                command.Parameters.AddWithValue("@GT_47", GT47_Val)
                command.Parameters.AddWithValue("@GT_48", GT48_Val)
                command.Parameters.AddWithValue("@GT_49", GT49_Val)
                command.Parameters.AddWithValue("@GT_50", GT50_Val)
                command.Parameters.AddWithValue("@GT_51", GT51_Val)
                command.Parameters.AddWithValue("@GT_52", GT52_Val)
                command.Parameters.AddWithValue("@GT_53", GT53_Val)
                command.Parameters.AddWithValue("@GT_54", GT54_Val)
                command.Parameters.AddWithValue("@GT_55", GT55_Val)
                command.Parameters.AddWithValue("@GT_56", GT56_Val)
                command.Parameters.AddWithValue("@GT_57", GT57_Val)
                command.Parameters.AddWithValue("@GT_58", GT58_Val)
                command.Parameters.AddWithValue("@GT_59", GT59_Val)
                command.Parameters.AddWithValue("@GT_60", GT60_Val)
                command.Parameters.AddWithValue("@GT_61", GT61_Val)


                ConOpen()
                command.ExecuteNonQuery()

                ConClose()
            End Using

        Catch ex As Exception
            Design2_Form.TimerSaveDb.Enabled = False
            MsgBox(ex.Message, vbCritical)
            Application.ExitThread()
        End Try
    End Sub

    Sub Save_AlarmHistory()
        Dim mycommand As String

        Dim Gt_Number As Integer = D70
        Dim Val As String = D71
        Dim DT As String = D73 & "/" & D74 & "/" & D72 & " " & D75 & ":" & D76
        Dim AlarmType As String = D77

        Dim Loc As String

        Select Case Gt_Number
            Case 1
                Loc = "Selas 01: Upper"
            Case 2
                Loc = "Selas 01: Middle"
            Case 3
                Loc = "Selas 01: Lower"
            Case 4
                Loc = "Selas 02: Upper"
            Case 5
                Loc = "Selas 02: Middle"
            Case 6
                Loc = "Selas 02: Lower"
            Case 7
                Loc = "Selas 03: Upper"
            Case 8
                Loc = "Selas 03: Middle"
            Case 9
                Loc = "Selas 03: Lower"
            Case 10
                Loc = "Selas 04: Upper"
            Case 11
                Loc = "Selas 04: Middle"
            Case 12
                Loc = "Selas 04: Lower"
            Case 13
                Loc = "Selas 05: Upper"
            Case 14
                Loc = "Selas 05: Middle"
            Case 15
                Loc = "Selas 05: Lower"
            Case 16
                Loc = "Selas 06: Upper"
            Case 17
                Loc = "Selas 06: Middle"
            Case 18
                Loc = "Selas 06: Lower"
            Case 19
                Loc = "Selas 07: Upper"
            Case 20
                Loc = "Selas 07: Middle"
            Case 21
                Loc = "Selas 07: Lower"
            Case 22
                Loc = "Selas 08: Upper"
            Case 23
                Loc = "Selas 08: Middle"
            Case 24
                Loc = "Selas 08: Lower"
            Case 25
                Loc = "Selas 09: Upper"
            Case 26
                Loc = "Selas 09: Middle"
            Case 27
                Loc = "Selas 09: Lower"
            Case 28
                Loc = "Selas 10: Upper"
            Case 29
                Loc = "Selas 10: Middle"
            Case 30
                Loc = "Selas 10: Lower"
            Case 31
                Loc = "Selas 11: Upper"
            Case 32
                Loc = "Selas 11: Middle"
            Case 33
                Loc = "Selas 11: Lower"
            Case 34
                Loc = "Selas 12: Upper"
            Case 35
                Loc = "Selas 12: Middle"
            Case 36
                Loc = "Selas 12: Lower"
            Case 37
                Loc = "Selas 13: Upper"
            Case 38
                Loc = "Selas 13: Middle"
            Case 39
                Loc = "Selas 13: Lower"
            Case 40
                Loc = "Warehouse: Trench 01"
            Case 41
                Loc = "Warehouse: Trench 02"
            Case 42
                Loc = "PICO to NANO: Trench 03"
            Case 43
                Loc = "PICO to NANO: Trench 04"
            Case 44
                Loc = "PICO to NANO: Trench 05"
            Case 45
                Loc = "PICO to NANO: Trench 06"
            Case 46
                Loc = "PICO to NANO: Trench 07"
            Case 47
                Loc = "PICO to NANO: Trench 08"
            Case 48
                Loc = "PICO to NANO: Trench 09"
            Case 49
                Loc = "PICO to NANO: Trench 10"
            Case 50
                Loc = "PICO: Trench 11"
            Case 51
                Loc = "PICO: Trench 12"
            Case 52
                Loc = "PICO: Trench 13"
            Case 53
                Loc = "PICO: Trench 14"
            Case 54
                Loc = "PICO: Trench 15"
            Case 55
                Loc = "PICO: Trench 16"
            Case 56
                Loc = "PICO: Trench 17"
            Case 57
                Loc = "PICO: Trench 18"
            Case 58
                Loc = "PICO: Trench 19"
            Case 59
                Loc = "PICO: Trench 20"
            Case 60
                Loc = "Gas Mixing: 1"
            Case 61
                Loc = "Gas Mixing: 4"
            Case 9999
                Loc = "Reset"
            Case Else
                Loc = "Unknown Location"
        End Select


        Try
            ConOpen()
            mycommand = "INSERT INTO [WIA_GLM_History] ([GT_Number],[Location],[Value],[DateAndTime],[Alarm_Type]) 
                                VALUES (@gt, @lctn, @val, @DateTime, @type)"
            Using command As New SqlCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@gt", Gt_Number)
                command.Parameters.AddWithValue("@lctn", Loc)
                command.Parameters.AddWithValue("@val", Val)
                command.Parameters.AddWithValue("@DateTime", DT)
                command.Parameters.AddWithValue("@type", AlarmType)
                command.ExecuteNonQuery()
            End Using
            ConClose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub View_History()
        Dim command As New SqlCommand("", Dbconnection)
        Dim table As New DataTable

        ConOpen()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            command.CommandText = "SELECT TOP(50) GT_Number, Location, Value, DateAndTime, Alarm_Type FROM WIA_GLM_History ORDER BY ID DESC"

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            AlarmHistory_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In AlarmHistory_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 12, FontStyle.Bold)
                column.HeaderCell.Style.ForeColor = Color.White
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 11)
            Next

            AlarmHistory_Form.DataGridView1.Columns("GT_Number").HeaderText = "Gas Transmitter"
            AlarmHistory_Form.DataGridView1.Columns("Location").HeaderText = "GT Location"
            AlarmHistory_Form.DataGridView1.Columns("Value").HeaderText = "Value"
            AlarmHistory_Form.DataGridView1.Columns("DateAndTime").HeaderText = "Date and Time"
            AlarmHistory_Form.DataGridView1.Columns("Alarm_Type").HeaderText = "Alarm Type"

            AlarmHistory_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
            AlarmHistory_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
            AlarmHistory_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
            AlarmHistory_Form.DataGridView1.DefaultCellStyle.ForeColor = Color.Black

            AlarmHistory_Form.DataGridView1.EnableHeadersVisualStyles = False
            AlarmHistory_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen

        End If
        ConClose()
    End Sub

    Sub UpdateLocation()
        Try
            ConOpen()

            Dim query As String = "UPDATE WIA_GLM_History 
            SET Location = 
                CASE 
                    WHEN GT_Number = 1 THEN 'Selas 01: Upper'
                    WHEN GT_Number = 2 THEN 'Selas 01: Middle'
                    WHEN GT_Number = 3 THEN 'Selas 01: Lower'
                    WHEN GT_Number = 4 THEN 'Selas 02: Upper'
                    WHEN GT_Number = 5 THEN 'Selas 02: Middle'
                    WHEN GT_Number = 6 THEN 'Selas 02: Lower'
                    WHEN GT_Number = 7 THEN 'Selas 03: Upper'
                    WHEN GT_Number = 8 THEN 'Selas 03: Middle'
                    WHEN GT_Number = 9 THEN 'Selas 03: Lower'
                    WHEN GT_Number = 10 THEN 'Selas 04: Upper'
                    WHEN GT_Number = 11 THEN 'Selas 04: Middle'
                    WHEN GT_Number = 12 THEN 'Selas 04: Lower'
                    WHEN GT_Number = 13 THEN 'Selas 05: Upper'
                    WHEN GT_Number = 14 THEN 'Selas 05: Middle'
                    WHEN GT_Number = 15 THEN 'Selas 05: Lower'
                    WHEN GT_Number = 16 THEN 'Selas 06: Upper'
                    WHEN GT_Number = 17 THEN 'Selas 06: Middle'
                    WHEN GT_Number = 18 THEN 'Selas 06: Lower'
                    WHEN GT_Number = 19 THEN 'Selas 07: Upper'
                    WHEN GT_Number = 20 THEN 'Selas 07: Middle'
                    WHEN GT_Number = 21 THEN 'Selas 07: Lower'
                    WHEN GT_Number = 22 THEN 'Selas 08: Upper'
                    WHEN GT_Number = 23 THEN 'Selas 08: Middle'
                    WHEN GT_Number = 24 THEN 'Selas 08: Lower'
                    WHEN GT_Number = 25 THEN 'Selas 09: Upper'
                    WHEN GT_Number = 26 THEN 'Selas 09: Middle'
                    WHEN GT_Number = 27 THEN 'Selas 09: Lower'
                    WHEN GT_Number = 28 THEN 'Selas 10: Upper'
                    WHEN GT_Number = 29 THEN 'Selas 10: Middle'
                    WHEN GT_Number = 30 THEN 'Selas 10: Lower'
                    WHEN GT_Number = 31 THEN 'Selas 11: Upper'
                    WHEN GT_Number = 32 THEN 'Selas 11: Middle'
                    WHEN GT_Number = 33 THEN 'Selas 11: Lower'
                    WHEN GT_Number = 34 THEN 'Selas 12: Upper'
                    WHEN GT_Number = 35 THEN 'Selas 12: Middle'
                    WHEN GT_Number = 36 THEN 'Selas 12: Lower'
                    WHEN GT_Number = 37 THEN 'Selas 13: Upper'
                    WHEN GT_Number = 38 THEN 'Selas 13: Middle'
                    WHEN GT_Number = 39 THEN 'Selas 13: Lower'
                    WHEN GT_Number = 40 THEN 'Warehouse: Trench 01'
                    WHEN GT_Number = 41 THEN 'Warehouse: Trench 02'
                    WHEN GT_Number = 42 THEN 'PICO to NANO: Trench 03'
                    WHEN GT_Number = 43 THEN 'PICO to NANO: Trench 04'
                    WHEN GT_Number = 44 THEN 'PICO to NANO: Trench 05'
                    WHEN GT_Number = 45 THEN 'PICO to NANO: Trench 06'
                    WHEN GT_Number = 46 THEN 'PICO to NANO: Trench 07'
                    WHEN GT_Number = 47 THEN 'PICO to NANO: Trench 08'
                    WHEN GT_Number = 48 THEN 'PICO to NANO: Trench 09'
                    WHEN GT_Number = 49 THEN 'PICO to NANO: Trench 10'
                    WHEN GT_Number = 50 THEN 'PICO: Trench 11'
                    WHEN GT_Number = 51 THEN 'PICO: Trench 12'
                    WHEN GT_Number = 52 THEN 'PICO: Trench 13'
                    WHEN GT_Number = 53 THEN 'PICO: Trench 14'
                    WHEN GT_Number = 54 THEN 'PICO: Trench 15'
                    WHEN GT_Number = 55 THEN 'PICO: Trench 16'
                    WHEN GT_Number = 56 THEN 'PICO: Trench 17'
                    WHEN GT_Number = 57 THEN 'PICO: Trench 18'
                    WHEN GT_Number = 58 THEN 'PICO: Trench 19'
                    WHEN GT_Number = 59 THEN 'PICO: Trench 20'
                    WHEN GT_Number = 60 THEN 'Gas Mixing: 1'
                    WHEN GT_Number = 61 THEN 'Gas Mixing: 4'
                    WHEN GT_Number = 9999 THEN 'Reset'
                    ELSE 'Unknown Location'
                END"

            Dim cmd As New SqlCommand(query, Dbconnection)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            MessageBox.Show(rowsAffected.ToString() & " rows updated.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ConClose()
        End Try
    End Sub



End Module