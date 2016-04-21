Public Class tpdictionary

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub tpdictionary_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        main.Visible = True
    End Sub

    Private Sub tpdictionary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tpdSearchlabel.Text = main.getWord()
        tpdSearchbox.Text = main.getWord()
    End Sub

    Private Sub tpdSearchbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpdSearchbox.TextChanged
        tpdSearchlabel.Text = tpdSearchbox.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        main.SAPI.speak(tpdSearchlabel.Text)
    End Sub


    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        tpdAboutbox.Visible = True
    End Sub

End Class