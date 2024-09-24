<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SudokuInnerSquare
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        NumberTextBox = New RichTextBox()
        NumPanel = New NumberSelectPanel()
        SuspendLayout()
        ' 
        ' NumberTextBox
        ' 
        NumberTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NumberTextBox.Location = New Point(0, 0)
        NumberTextBox.Multiline = False
        NumberTextBox.Name = "NumberTextBox"
        NumberTextBox.ReadOnly = True
        NumberTextBox.ScrollBars = RichTextBoxScrollBars.None
        NumberTextBox.Size = New Size(150, 150)
        NumberTextBox.TabIndex = 0
        NumberTextBox.Text = "1"
        ' 
        ' NumPanel
        ' 
        NumPanel.Dock = DockStyle.Fill
        NumPanel.Location = New Point(0, 0)
        NumPanel.Name = "NumPanel"
        NumPanel.Size = New Size(150, 150)
        NumPanel.TabIndex = 1
        ' 
        ' SudokuInnerSquare
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(NumPanel)
        Controls.Add(NumberTextBox)
        Name = "SudokuInnerSquare"
        ResumeLayout(False)
    End Sub

    Friend WithEvents NumberTextBox As RichTextBox
    Friend WithEvents NumPanel As NumberSelectPanel

End Class
