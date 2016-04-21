Public Class main
    Public SAPI = CreateObject("sapi.spvoice")
    Public tpd = New tpdictionary
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtBox1.Clear()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        detailsLab.Text = proText.Text
        detBox.Hide()
        Me.Height = 284
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SAPI.speak(TxtBox1.Text)
    End Sub



    Private Sub SelectAllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem1.Click
        TxtBox1.SelectAll()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem1.Click
        TxtBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem1.Click
        TxtBox1.Paste()
    End Sub

    Private Sub CutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem1.Click
        TxtBox1.Cut()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        TxtBox1.Clear()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub proBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proBut.Click
        SAPI.speak(proText.Text)
        detailsLab.Text = proText.Text & """ Click Here"
        ProgressBar1.Increment(100)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub YellowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YellowToolStripMenuItem.Click
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub RedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub GreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.BackColor = Color.White
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultToolStripMenuItem.Click

    End Sub

    Private Sub proText_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles proText.LostFocus
        Dim word As String, newword
        word = proText.Text.ToString
        If (proText.Text.ToString.Length > 0) Then
            newword = word.Chars(0)
            proText.Text = word.ToString.Replace(newword, newword.ToString.ToUpper())
            detailsLab.Text = proText.Text & """ Click Here"
        End If
    End Sub

    Private Sub proText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proText.TextChanged
        detailsLab.Text = proText.Text & """ Click Here"
        ProgressBar1.Value = 0
    End Sub

    Private Sub detailsLab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detailsLab.Click
        detBox.Show()
        Dim i As Integer, max, min, diff
        i = 1
        max = 476
        min = 284
        diff = max - min
        For i = 1 To diff Step 1
            min += 1
            Me.Height = min   'height increases as the loop increases; a form of sleek
        Next i
        detLab1.Hide()
        detailsLab.Hide()
    End Sub

    Private Sub detHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detHide.Click
        detBox.Hide()
        Me.Height = 284
        detLab1.Show()
        detailsLab.Show()
    End Sub

    Private Sub ProTab_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProTab.GotFocus
        proText.Focus()
    End Sub

    Private Sub tp_cont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tp_cont.Click
        contentsbox.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DictionaryTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DictionaryTool.Click
        Me.Hide()
        tpdictionary.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Hide()
        tpd.show()
    End Sub
    Public Function getWord() As String
        Dim theword = detailsLab.Text.ToString
        Return theword
    End Function
End Class
