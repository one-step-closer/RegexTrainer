Public Class frmClear

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        For Each m As System.Text.RegularExpressions.Match In System.Text.RegularExpressions.Regex.Matches(rtbInit.Text, tbRegex.Text)
            rtbInit.Select(m.Index, m.Length)
            rtbInit.SelectionBackColor = Color.Yellow
        Next
        'If tbInit.Text.Length = 0 Or tbRegex.Text.Length = 0 Then Exit Sub
        'Try
        '    tbResult.Text = System.Text.RegularExpressions.Regex.Replace(tbInit.Text, tbRegex.Text, String.Empty, _
        '                                                               System.Text.RegularExpressions.RegexOptions.IgnoreCase Or _
        '                                                              System.Text.RegularExpressions.RegexOptions.Singleline)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class