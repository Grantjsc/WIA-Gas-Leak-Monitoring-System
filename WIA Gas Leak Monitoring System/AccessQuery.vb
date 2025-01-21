'Imports System.Data.OleDb

'Module Query_Module

'    Public GT01_Val As Decimal
'    Public GT02_Val As Decimal
'    Public GT03_Val As Decimal
'    Public GT04_Val As Decimal
'    Public GT05_Val As Decimal
'    Public GT06_Val As Decimal
'    Public GT07_Val As Decimal
'    Public GT08_Val As Decimal
'    Public GT09_Val As Decimal
'    Public GT10_Val As Decimal
'    Public GT11_Val As Decimal
'    Public GT12_Val As Decimal
'    Public GT13_Val As Decimal
'    Public GT14_Val As Decimal
'    Public GT15_Val As Decimal
'    Public GT16_Val As Decimal
'    Public GT17_Val As Decimal
'    Public GT18_Val As Decimal
'    Public GT19_Val As Decimal
'    Public GT20_Val As Decimal
'    Public GT21_Val As Decimal
'    Public GT22_Val As Decimal
'    Public GT23_Val As Decimal
'    Public GT24_Val As Decimal
'    Public GT25_Val As Decimal
'    Public GT26_Val As Decimal
'    Public GT27_Val As Decimal
'    Public GT28_Val As Decimal
'    Public GT29_Val As Decimal
'    Public GT30_Val As Decimal
'    Public GT31_Val As Decimal
'    Public GT32_Val As Decimal
'    Public GT33_Val As Decimal
'    Public GT34_Val As Decimal
'    Public GT35_Val As Decimal
'    Public GT36_Val As Decimal
'    Public GT37_Val As Decimal
'    Public GT38_Val As Decimal
'    Public GT39_Val As Decimal
'    Public GT40_Val As Decimal
'    Public GT41_Val As Decimal
'    Public GT42_Val As Decimal
'    Public GT43_Val As Decimal
'    Public GT44_Val As Decimal
'    Public GT45_Val As Decimal
'    Public GT46_Val As Decimal
'    Public GT47_Val As Decimal
'    Public GT48_Val As Decimal
'    Public GT49_Val As Decimal
'    Public GT50_Val As Decimal
'    Public GT51_Val As Decimal
'    Public GT52_Val As Decimal
'    Public GT53_Val As Decimal
'    Public GT54_Val As Decimal
'    Public GT55_Val As Decimal
'    Public GT56_Val As Decimal
'    Public GT57_Val As Decimal
'    Public GT58_Val As Decimal
'    Public GT59_Val As Decimal
'    Public GT60_Val As Decimal
'    Public GT61_Val As Decimal



'    'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\WIA Gas Leak Monitoring.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfwiagasleak
'    'Data Source=BTMESSQLDEV03;Initial Catalog=LFPHPICO;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True

'    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\WIA Gas Leak Monitoring.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfwiagasleak"
'    Public Dbconnection As New OleDbConnection(connString)
'    Public Biometric_Name As String

'    Sub ConOpen()
'        If Dbconnection.State = ConnectionState.Closed Then
'            Dbconnection.Open()
'        End If
'    End Sub

'    Sub ConClose()
'        If Dbconnection.State = ConnectionState.Open Then
'            Dbconnection.Close()
'        End If
'    End Sub

'    Sub Get_Details()
'        Try
'            Dim MyData As String
'            Dim cmd As New OleDbCommand
'            Dim Data As New DataTable
'            Dim adap As New OleDbDataAdapter
'            ConOpen()

'            MyData = "SELECT * FROM Details_tb WHERE ID = 1 "
'            cmd.Connection = Dbconnection
'            cmd.CommandText = MyData
'            adap.SelectCommand = cmd

'            adap.Fill(Data)

'            'Clear_Datas()

'            If Data.Rows.Count > 0 Then

'                Receiver = Data.Rows(0).Item("Receiver_Number").ToString
'                Mess = Data.Rows(0).Item("Message").ToString

'            Else
'                MsgBox("No details found in the database!", MessageBoxIcon.Error)
'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        Finally
'            ConClose()
'        End Try
'    End Sub

'    Sub Update_GT_ValDb()
'        Try

'            Dim query As String = "UPDATE WIA_GLM_GT_Value 
'                               SET GT01 = @GT_01, GT02 = @GT_02, GT03 = @GT_03, GT04 = @GT_04, GT05 = @GT_05, 
'                               GT06 = @GT_06, GT07 = @GT_07, GT08 = @GT_08, GT09 = @GT_09, GT10 = @GT_10, 
'                               GT11 = @GT_11, GT12 = @GT_12, GT13 = @GT_13, GT14 = @GT_14, GT15 = @GT_15, 
'                               GT16 = @GT_16, GT17 = @GT_17, GT18 = @GT_18, GT19 = @GT_19, GT20 = @GT_20, 
'                               GT21 = @GT_21, GT22 = @GT_22, GT23 = @GT_23, GT24 = @GT_24, GT25 = @GT_25, 
'                               GT26 = @GT_26, GT27 = @GT_27, GT28 = @GT_28, GT29 = @GT_29, GT30 = @GT_30, 
'                               GT31 = @GT_31, GT32 = @GT_32, GT33 = @GT_33, GT34 = @GT_34, GT35 = @GT_35, 
'                               GT36 = @GT_36, GT37 = @GT_37, GT38 = @GT_38, GT39 = @GT_39, GT40 = @GT_40, 
'                               GT41 = @GT_41, GT42 = @GT_42, GT43 = @GT_43, GT44 = @GT_44, GT45 = @GT_45, 
'                               GT46 = @GT_46, GT47 = @GT_47, GT48 = @GT_48, GT49 = @GT_49, GT50 = @GT_50, 
'                               GT51 = @GT_51, GT52 = @GT_52, GT53 = @GT_53, GT54 = @GT_54, GT55 = @GT_55, 
'                               GT56 = @GT_56, GT57 = @GT_57, GT58 = @GT_58, GT59 = @GT_59, GT60 = @GT_60, 
'                               GT61 = @GT_61
'                               WHERE ID = 1"

'            Using command As New OleDbCommand(query, Dbconnection)
'                command.Parameters.AddWithValue("@GT_01", GT01_Val)
'                command.Parameters.AddWithValue("@GT_02", GT02_Val)
'                command.Parameters.AddWithValue("@GT_03", GT03_Val)
'                command.Parameters.AddWithValue("@GT_04", GT04_Val)
'                command.Parameters.AddWithValue("@GT_05", GT05_Val)
'                command.Parameters.AddWithValue("@GT_06", GT06_Val)
'                command.Parameters.AddWithValue("@GT_07", GT07_Val)
'                command.Parameters.AddWithValue("@GT_08", GT08_Val)
'                command.Parameters.AddWithValue("@GT_09", GT09_Val)
'                command.Parameters.AddWithValue("@GT_10", GT10_Val)
'                command.Parameters.AddWithValue("@GT_11", GT11_Val)
'                command.Parameters.AddWithValue("@GT_12", GT12_Val)
'                command.Parameters.AddWithValue("@GT_13", GT13_Val)
'                command.Parameters.AddWithValue("@GT_14", GT14_Val)
'                command.Parameters.AddWithValue("@GT_15", GT15_Val)
'                command.Parameters.AddWithValue("@GT_16", GT16_Val)
'                command.Parameters.AddWithValue("@GT_17", GT17_Val)
'                command.Parameters.AddWithValue("@GT_18", GT18_Val)
'                command.Parameters.AddWithValue("@GT_19", GT19_Val)
'                command.Parameters.AddWithValue("@GT_20", GT20_Val)
'                command.Parameters.AddWithValue("@GT_21", GT21_Val)
'                command.Parameters.AddWithValue("@GT_22", GT22_Val)
'                command.Parameters.AddWithValue("@GT_23", GT23_Val)
'                command.Parameters.AddWithValue("@GT_24", GT24_Val)
'                command.Parameters.AddWithValue("@GT_25", GT25_Val)
'                command.Parameters.AddWithValue("@GT_26", GT26_Val)
'                command.Parameters.AddWithValue("@GT_27", GT27_Val)
'                command.Parameters.AddWithValue("@GT_28", GT28_Val)
'                command.Parameters.AddWithValue("@GT_29", GT29_Val)
'                command.Parameters.AddWithValue("@GT_30", GT30_Val)
'                command.Parameters.AddWithValue("@GT_31", GT31_Val)
'                command.Parameters.AddWithValue("@GT_32", GT32_Val)
'                command.Parameters.AddWithValue("@GT_33", GT33_Val)
'                command.Parameters.AddWithValue("@GT_34", GT34_Val)
'                command.Parameters.AddWithValue("@GT_35", GT35_Val)
'                command.Parameters.AddWithValue("@GT_36", GT36_Val)
'                command.Parameters.AddWithValue("@GT_37", GT37_Val)
'                command.Parameters.AddWithValue("@GT_38", GT38_Val)
'                command.Parameters.AddWithValue("@GT_39", GT39_Val)
'                command.Parameters.AddWithValue("@GT_40", GT40_Val)
'                command.Parameters.AddWithValue("@GT_41", GT41_Val)
'                command.Parameters.AddWithValue("@GT_42", GT42_Val)
'                command.Parameters.AddWithValue("@GT_43", GT43_Val)
'                command.Parameters.AddWithValue("@GT_44", GT44_Val)
'                command.Parameters.AddWithValue("@GT_45", GT45_Val)
'                command.Parameters.AddWithValue("@GT_46", GT46_Val)
'                command.Parameters.AddWithValue("@GT_47", GT47_Val)
'                command.Parameters.AddWithValue("@GT_48", GT48_Val)
'                command.Parameters.AddWithValue("@GT_49", GT49_Val)
'                command.Parameters.AddWithValue("@GT_50", GT50_Val)
'                command.Parameters.AddWithValue("@GT_51", GT51_Val)
'                command.Parameters.AddWithValue("@GT_52", GT52_Val)
'                command.Parameters.AddWithValue("@GT_53", GT53_Val)
'                command.Parameters.AddWithValue("@GT_54", GT54_Val)
'                command.Parameters.AddWithValue("@GT_55", GT55_Val)
'                command.Parameters.AddWithValue("@GT_56", GT56_Val)
'                command.Parameters.AddWithValue("@GT_57", GT57_Val)
'                command.Parameters.AddWithValue("@GT_58", GT58_Val)
'                command.Parameters.AddWithValue("@GT_59", GT59_Val)
'                command.Parameters.AddWithValue("@GT_60", GT60_Val)
'                command.Parameters.AddWithValue("@GT_61", GT61_Val)


'                ConOpen()
'                command.ExecuteNonQuery()

'                ConClose()
'            End Using

'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        End Try
'    End Sub
'End Module