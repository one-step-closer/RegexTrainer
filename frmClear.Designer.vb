<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClear
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim split1 As System.Windows.Forms.SplitContainer
        Dim lblInit As System.Windows.Forms.Label
        Dim lblResult As System.Windows.Forms.Label
        Dim lblRegex As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClear))
        Me.tbInit = New System.Windows.Forms.TextBox()
        Me.tbResult = New System.Windows.Forms.TextBox()
        Me.tbRegex = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.rtbInit = New System.Windows.Forms.RichTextBox()
        split1 = New System.Windows.Forms.SplitContainer()
        lblInit = New System.Windows.Forms.Label()
        lblResult = New System.Windows.Forms.Label()
        lblRegex = New System.Windows.Forms.Label()
        split1.Panel1.SuspendLayout()
        split1.Panel2.SuspendLayout()
        split1.SuspendLayout()
        Me.SuspendLayout()
        '
        'split1
        '
        split1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        split1.Location = New System.Drawing.Point(4, 32)
        split1.Name = "split1"
        '
        'split1.Panel1
        '
        split1.Panel1.Controls.Add(Me.rtbInit)
        split1.Panel1.Controls.Add(Me.tbInit)
        split1.Panel1.Controls.Add(lblInit)
        '
        'split1.Panel2
        '
        split1.Panel2.Controls.Add(Me.tbResult)
        split1.Panel2.Controls.Add(lblResult)
        split1.Size = New System.Drawing.Size(775, 530)
        split1.SplitterDistance = 387
        split1.TabIndex = 0
        '
        'tbInit
        '
        Me.tbInit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbInit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbInit.Location = New System.Drawing.Point(0, 21)
        Me.tbInit.Multiline = True
        Me.tbInit.Name = "tbInit"
        Me.tbInit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbInit.Size = New System.Drawing.Size(387, 185)
        Me.tbInit.TabIndex = 3
        '
        'lblInit
        '
        lblInit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblInit.BackColor = System.Drawing.SystemColors.ActiveCaption
        lblInit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        lblInit.ForeColor = System.Drawing.SystemColors.HighlightText
        lblInit.Location = New System.Drawing.Point(0, 0)
        lblInit.Name = "lblInit"
        lblInit.Size = New System.Drawing.Size(387, 18)
        lblInit.TabIndex = 2
        lblInit.Text = "Исходный текст"
        lblInit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbResult
        '
        Me.tbResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbResult.Location = New System.Drawing.Point(0, 21)
        Me.tbResult.Multiline = True
        Me.tbResult.Name = "tbResult"
        Me.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbResult.Size = New System.Drawing.Size(384, 508)
        Me.tbResult.TabIndex = 4
        '
        'lblResult
        '
        lblResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption
        lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        lblResult.ForeColor = System.Drawing.SystemColors.HighlightText
        lblResult.Location = New System.Drawing.Point(0, 0)
        lblResult.Name = "lblResult"
        lblResult.Size = New System.Drawing.Size(387, 18)
        lblResult.TabIndex = 3
        lblResult.Text = "Итоговый текст"
        lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRegex
        '
        lblRegex.AutoSize = True
        lblRegex.Location = New System.Drawing.Point(12, 9)
        lblRegex.Name = "lblRegex"
        lblRegex.Size = New System.Drawing.Size(130, 13)
        lblRegex.TabIndex = 1
        lblRegex.Text = "Регулярное выражение:"
        '
        'tbRegex
        '
        Me.tbRegex.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRegex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbRegex.Location = New System.Drawing.Point(148, 6)
        Me.tbRegex.Name = "tbRegex"
        Me.tbRegex.Size = New System.Drawing.Size(607, 20)
        Me.tbRegex.TabIndex = 2
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.Location = New System.Drawing.Point(759, 6)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(20, 20)
        Me.btnGo.TabIndex = 8
        Me.btnGo.Text = "..."
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'rtbInit
        '
        Me.rtbInit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbInit.Location = New System.Drawing.Point(0, 224)
        Me.rtbInit.Name = "rtbInit"
        Me.rtbInit.Size = New System.Drawing.Size(370, 305)
        Me.rtbInit.TabIndex = 4
        Me.rtbInit.Text = ""
        '
        'frmClear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.tbRegex)
        Me.Controls.Add(lblRegex)
        Me.Controls.Add(split1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClear"
        Me.Text = "Очистка текста"
        split1.Panel1.ResumeLayout(False)
        split1.Panel1.PerformLayout()
        split1.Panel2.ResumeLayout(False)
        split1.Panel2.PerformLayout()
        split1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tbRegex As System.Windows.Forms.TextBox
    Private WithEvents tbInit As System.Windows.Forms.TextBox
    Private WithEvents tbResult As System.Windows.Forms.TextBox
    Private WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents rtbInit As System.Windows.Forms.RichTextBox
End Class
