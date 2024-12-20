Public Class ShowSenVal_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        ThreeVal_Read = True
        lblVal2.Text = "Middle:"
    End Sub

    Private Sub ShowSenVal_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        If ThreeVal_Read = True Then

            lblVal1.Visible = True
            lblVal3.Visible = True

            txtSelas_Up.Visible = True
            txtSelas_Low.Visible = True

            Read_Val1()
            Read_Val2()
            Read_Val3()

            Read_Val1_Alarm()
            Read_Val2_Alarm()
            Read_Val3_Alarm()
        Else
            lblVal1.Visible = False
            lblVal3.Visible = False

            txtSelas_Up.Visible = False
            txtSelas_Low.Visible = False

            Read_Val2()
            Read_Val2_Alarm()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ThreeVal_Read = True Then
            Read_Val1()
            Read_Val2()
            Read_Val3()

            Read_Val1_Alarm()
            Read_Val2_Alarm()
            Read_Val3_Alarm()
        Else

            Read_Val2()
            Read_Val2_Alarm()
        End If
    End Sub
End Class