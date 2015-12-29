<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.JokeID = New System.Windows.Forms.Label()
        Me.ContentBox = New System.Windows.Forms.RichTextBox()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'JokeID
        '
        Me.JokeID.AutoSize = True
        Me.JokeID.Location = New System.Drawing.Point(12, 0)
        Me.JokeID.Name = "JokeID"
        Me.JokeID.Size = New System.Drawing.Size(30, 13)
        Me.JokeID.TabIndex = 0
        Me.JokeID.Text = "Joke"
        '
        'ContentBox
        '
        Me.ContentBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContentBox.BackColor = System.Drawing.SystemColors.Window
        Me.ContentBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentBox.Location = New System.Drawing.Point(15, 16)
        Me.ContentBox.Name = "ContentBox"
        Me.ContentBox.ReadOnly = True
        Me.ContentBox.Size = New System.Drawing.Size(332, 159)
        Me.ContentBox.TabIndex = 1
        Me.ContentBox.Text = ""
        '
        'NewButton
        '
        Me.NewButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewButton.Location = New System.Drawing.Point(15, 181)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(158, 29)
        Me.NewButton.TabIndex = 2
        Me.NewButton.Text = "New Joke"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyButton.Location = New System.Drawing.Point(179, 181)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(168, 29)
        Me.CopyButton.TabIndex = 3
        Me.CopyButton.Text = "Copy to clipboard"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoEllipsis = True
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.WindowText
        Me.LinkLabel1.Location = New System.Drawing.Point(2, 213)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(80, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "From ICNb.com"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 230)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.ContentBox)
        Me.Controls.Add(Me.JokeID)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "JSON"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JokeID As System.Windows.Forms.Label
    Friend WithEvents ContentBox As System.Windows.Forms.RichTextBox
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
