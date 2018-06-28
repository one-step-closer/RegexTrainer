<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label3 As System.Windows.Forms.Label
        Dim split As System.Windows.Forms.SplitContainer
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Matches", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Captured Groups", System.Windows.Forms.HorizontalAlignment.Left)
        Dim chNum As System.Windows.Forms.ColumnHeader
        Dim chValue As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.rtbSrc = New System.Windows.Forms.RichTextBox()
        Me.lvResult = New System.Windows.Forms.ListView()
        Me.tbRegex = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lbOptions = New System.Windows.Forms.CheckedListBox()
        Label3 = New System.Windows.Forms.Label()
        split = New System.Windows.Forms.SplitContainer()
        chNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        chValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(split, System.ComponentModel.ISupportInitialize).BeginInit()
        split.Panel1.SuspendLayout()
        split.Panel2.SuspendLayout()
        split.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(2, 7)
        Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(127, 13)
        Label3.TabIndex = 4
        Label3.Text = "–егул€рное выражение"
        '
        'split
        '
        split.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        split.Location = New System.Drawing.Point(133, 30)
        split.Margin = New System.Windows.Forms.Padding(0)
        split.Name = "split"
        '
        'split.Panel1
        '
        split.Panel1.Controls.Add(Me.rtbSrc)
        '
        'split.Panel2
        '
        split.Panel2.Controls.Add(Me.lvResult)
        split.Size = New System.Drawing.Size(647, 528)
        split.SplitterDistance = 319
        split.TabIndex = 6
        '
        'rtbSrc
        '
        Me.rtbSrc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbSrc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbSrc.Location = New System.Drawing.Point(0, 0)
        Me.rtbSrc.Name = "rtbSrc"
        Me.rtbSrc.Size = New System.Drawing.Size(317, 526)
        Me.rtbSrc.TabIndex = 10
        Me.rtbSrc.Tag = "0"
        Me.rtbSrc.Text = ""
        '
        'lvResult
        '
        Me.lvResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {chNum, chValue})
        Me.lvResult.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Matches"
        ListViewGroup1.Name = "lvgMatches"
        ListViewGroup2.Header = "Captured Groups"
        ListViewGroup2.Name = "lvgGroups"
        Me.lvResult.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lvResult.Location = New System.Drawing.Point(0, 0)
        Me.lvResult.MultiSelect = False
        Me.lvResult.Name = "lvResult"
        Me.lvResult.ShowItemToolTips = True
        Me.lvResult.Size = New System.Drawing.Size(322, 526)
        Me.lvResult.TabIndex = 0
        Me.lvResult.UseCompatibleStateImageBehavior = False
        Me.lvResult.View = System.Windows.Forms.View.Details
        '
        'chNum
        '
        chNum.Text = ""
        chNum.Width = 30
        '
        'chValue
        '
        chValue.Text = ""
        chValue.Width = 290
        '
        'tbRegex
        '
        Me.tbRegex.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRegex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbRegex.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbRegex.Location = New System.Drawing.Point(133, 4)
        Me.tbRegex.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbRegex.Name = "tbRegex"
        Me.tbRegex.Size = New System.Drawing.Size(621, 22)
        Me.tbRegex.TabIndex = 5
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.Location = New System.Drawing.Point(757, 4)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(20, 22)
        Me.btnGo.TabIndex = 7
        Me.btnGo.Text = "..."
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lbOptions
        '
        Me.lbOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbOptions.BackColor = System.Drawing.SystemColors.Control
        Me.lbOptions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbOptions.CheckOnClick = True
        Me.lbOptions.IntegralHeight = False
        Me.lbOptions.Location = New System.Drawing.Point(5, 30)
        Me.lbOptions.Name = "lbOptions"
        Me.lbOptions.Size = New System.Drawing.Size(114, 527)
        Me.lbOptions.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.lbOptions)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(split)
        Me.Controls.Add(Me.tbRegex)
        Me.Controls.Add(Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMain"
        Me.Text = "Regex Trainer"
        split.Panel1.ResumeLayout(False)
        split.Panel2.ResumeLayout(False)
        CType(split, System.ComponentModel.ISupportInitialize).EndInit()
        split.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tbRegex As System.Windows.Forms.TextBox
    Private WithEvents lvResult As System.Windows.Forms.ListView
    Private WithEvents btnGo As System.Windows.Forms.Button
    Private WithEvents lbOptions As System.Windows.Forms.CheckedListBox
    Private WithEvents rtbSrc As System.Windows.Forms.RichTextBox

End Class
