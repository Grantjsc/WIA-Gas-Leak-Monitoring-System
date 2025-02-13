Public Class RecipientDelay_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Update_MessAndDelay = False
        Me.Close()
    End Sub

    Private Sub RecipientDelay_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_Recipients_NumberEmail()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtNumber.Text) Then
            MsgBox("Please enter mobile number of recipients!", MsgBoxStyle.Critical)
            txtNumber.Focus()
        ElseIf String.IsNullOrEmpty(txtEmail.Text) Then
            MsgBox("Please enter email of recipients!", MsgBoxStyle.Critical)
            txtEmail.Focus()
        Else
            Update_Recipients_NumberEmail()
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If String.IsNullOrEmpty(cboMinutes.Text) Then
            MsgBox("Please select how many minutes the delay is!", MsgBoxStyle.Critical)
            cboMinutes.Focus()
        Else
            New_Mes_Del = CInt(cboMinutes.Text) * 60000
            Update_Message_Delay()
            Get_Message_Delay()
            MsgBox("Delay for sending SMS and Email is now updated.")
            cboMinutes.Text = Nothing
        End If
    End Sub

End Class