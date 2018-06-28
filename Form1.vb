Imports System.Text.RegularExpressions
Public Class frmMain

    
    Private Sub DoRegex()
        lvResult.Items.Clear()
        If rtbSrc.Text.Length > 0 And tbRegex.Text.Length > 0 Then
            rtbSrc.Select(0, rtbSrc.TextLength) : rtbSrc.SelectionBackColor = rtbSrc.BackColor
            rtbSrc.SelectionStart = 0 : rtbSrc.SelectionLength = 0 : rtbSrc.Tag = 0
            Try
                Dim m As MatchCollection = Regex.Matches(rtbSrc.Text, tbRegex.Text, GetOptionFlag)
                For itm As Integer = 0 To m.Count - 1

                    rtbSrc.Select(m(itm).Index, m(itm).Length) : rtbSrc.SelectionBackColor = Color.Yellow

                    Dim lvi As New ListViewItem((itm + 1).ToString, lvResult.Groups(0))
                    lvi.SubItems.Add("[" + m(itm).Value + "]")
                    lvResult.Items.Add(lvi)
                    For itg As Integer = 0 To m(itm).Groups.Count - 1
                        Dim lvg As New ListViewItem((itm + 1).ToString + "." + (itg).ToString, lvResult.Groups(1))
                        lvg.SubItems.Add("[" + m(itm).Groups(itg).Value + "]")
                        lvResult.Items.Add(lvg)
                    Next
                Next
            Catch
            End Try
            rtbSrc.SelectionStart = 0 : rtbSrc.SelectionLength = 0 : rtbSrc.Tag = 1
        End If
    End Sub
    Private Function GetOptionFlag() As RegexOptions
        Dim retval As RegexOptions
        For Each s As String In lbOptions.CheckedItems
            retval = retval Or [Enum].Parse(GetType(RegexOptions), s, True)
        Next
        Return retval
    End Function
    
    Private Sub tbRegex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbRegex.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F5 Then
            DoRegex()
        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, lbOptions.KeyDown
        If e.KeyCode = Keys.F5 Then
            DoRegex()
        End If
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        DoRegex()
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbOptions.Items.AddRange([Enum].GetNames(GetType(RegexOptions)))
        Viewstate_Load()
        If rtbSrc.Text <> "" And tbRegex.Text <> "" Then DoRegex()
    End Sub
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If rtbSrc.Text <> "" Or tbRegex.Text <> "" Then Viewstate_Save()
    End Sub
    Private Sub rtbSrc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtbSrc.TextChanged
        If CByte(rtbSrc.Tag) = 1 Then
            Dim iTmpSelStart As Integer = rtbSrc.SelectionStart
            rtbSrc.Select(0, rtbSrc.TextLength) : rtbSrc.SelectionBackColor = rtbSrc.BackColor
            rtbSrc.SelectionStart = iTmpSelStart : rtbSrc.SelectionLength = 0
            rtbSrc.Tag = 0
        End If
    End Sub



    Private Sub Viewstate_Save()
        Dim fs As IO.FileStream = Nothing
        Dim swr As IO.StreamWriter = Nothing
        Try
            fs = New IO.FileStream(Process.GetCurrentProcess().MainModule.FileName.ToLower.Replace(".vshost", "").Replace("exe", "state"), _
                                IO.FileMode.Create, IO.FileAccess.Write)
            swr = New IO.StreamWriter(fs)
            swr.WriteLine(Me.tbRegex.Text)
            swr.WriteLine(Me.rtbSrc.Text)
        Catch
        Finally
            If swr IsNot Nothing Then : swr.Close() : swr.Dispose() : End If
            If fs IsNot Nothing Then : fs.Close() : fs.Dispose() : End If
        End Try
    End Sub
    Private Sub Viewstate_Load()
        Dim fs As IO.FileStream = Nothing
        Dim sr As IO.StreamReader = Nothing
        Try
            fs = New IO.FileStream(Process.GetCurrentProcess().MainModule.FileName.ToLower.Replace(".vshost", "").Replace("exe", "state"), _
                                IO.FileMode.Open, IO.FileAccess.Read)
            sr = New IO.StreamReader(fs)
            Me.tbRegex.Text = sr.ReadLine
            Me.rtbSrc.Text = sr.ReadToEnd
        Catch
        Finally
            If sr IsNot Nothing Then : sr.Close() : sr.Dispose() : End If
            If fs IsNot Nothing Then : fs.Close() : fs.Dispose() : End If
        End Try
    End Sub


End Class
