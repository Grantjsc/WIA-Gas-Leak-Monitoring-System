Public Class Sensors_Form
    Private Sub Sensors_Form_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub ViewWIABldgLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewWIABldgLayoutToolStripMenuItem.Click
        ShowLayout()
    End Sub

    Private Sub ViewAlarmHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAlarmHistoryToolStripMenuItem.Click
        Load_AlarmHistory()
    End Sub
End Class