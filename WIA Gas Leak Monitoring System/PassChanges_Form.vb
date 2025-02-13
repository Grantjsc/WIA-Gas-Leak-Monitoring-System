﻿Public Class PassChanges_Form
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If txtPass.Text = "gasleakmaster" Then
            If Update_MessAndDelay = True Then
                RecipientDelay_Form.ShowDialog()
                Me.Close()
            Else
                Change_COM_IP_Form.ShowDialog()
                Me.Close()
            End If
        Else
            MsgBox("Wrong password!", MsgBoxStyle.Critical)
            txtPass.Text = ""
        End If
    End Sub

    Private Sub txtPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPass.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtPass.Text = "gasleakmaster" Then
                If Update_MessAndDelay = True Then
                    RecipientDelay_Form.ShowDialog()
                    Me.Close()
                Else
                    Change_COM_IP_Form.ShowDialog()
                    Me.Close()
                End If
            Else
                MsgBox("Wrong password!", MsgBoxStyle.Critical)
                txtPass.Text = ""
            End If
        End If
    End Sub

    Private Sub ChangeSerialPass_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Update_MessAndDelay = False
        Me.Close()
    End Sub
End Class