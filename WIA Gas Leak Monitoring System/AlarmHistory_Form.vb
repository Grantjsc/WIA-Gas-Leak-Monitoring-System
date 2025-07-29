Public Class AlarmHistory_Form

    Private Sub AlarmHistory_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        View_History()
    End Sub
    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        ShowAllSensors()
    End Sub

    Private Sub ViewAlarmHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAlarmHistoryToolStripMenuItem.Click
        ShowLayout()
    End Sub

End Class