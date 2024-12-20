Imports System.Threading

Public Class Change_COM_IP_Form
    Private Sub Change_COM_IP_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Load_AvailableCOM()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If String.IsNullOrEmpty(cboCOM.Text) Then
            MsgBox("Please choose COM name!", MsgBoxStyle.Critical)
        Else
            New_COM = cboCOM.Text
            Update_COM_NAME()
            Thread.Sleep(100)
            Get_COM_NAME()

            cboCOM.Items.Clear()
            cboCOM.Text = Nothing
            MsgBox("COM name is changed!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles btnIP_Change.Click
        If String.IsNullOrEmpty(txtIP.Text) Then
            MsgBox("Please enter valid IP addess!", MsgBoxStyle.Critical)
        Else
            New_IP = txtIP.Text
            Update_IP_Address()
            Thread.Sleep(100)
            Get_IP_Address()

            txtIP.Clear()
            MsgBox("IP address is changed!", MsgBoxStyle.Information)
            Connect_toPLC()
        End If
    End Sub

    Private Sub txtIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIP.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) <> 46 Then
                If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub
End Class