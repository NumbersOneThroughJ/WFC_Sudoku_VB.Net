<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sudoku3x3
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
        TableLayoutPanel1 = New TableLayoutPanel()
        SudokuInnerSquare1 = New SudokuInnerSquare()
        SudokuInnerSquare2 = New SudokuInnerSquare()
        SudokuInnerSquare3 = New SudokuInnerSquare()
        SudokuInnerSquare4 = New SudokuInnerSquare()
        SudokuInnerSquare5 = New SudokuInnerSquare()
        SudokuInnerSquare6 = New SudokuInnerSquare()
        SudokuInnerSquare7 = New SudokuInnerSquare()
        SudokuInnerSquare8 = New SudokuInnerSquare()
        SudokuInnerSquare9 = New SudokuInnerSquare()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = SystemColors.GrayText
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 1F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 1F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 1F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33334F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 1F))
        TableLayoutPanel1.Controls.Add(SudokuInnerSquare1, 1, 1)
        TableLayoutPanel1.Controls.Add(SudokuInnerSquare2, 3, 1)
        TableLayoutPanel1.Controls.Add(SudokuInnerSquare3, 5, 1)
        TableLayoutPanel1.Controls.Add(SudokuInnerSquare4, 1, 3)
        TableLayoutPanel1.Controls.Add(SudokuInnerSquare5, 3, 3)
        TableLayoutPanel1.Controls.Add(SudokuInnerSquare6, 5, 3)
        TableLayoutPanel1.Controls.Add(SudokuInnerSquare7, 1, 5)
        TableLayoutPanel1.Controls.Add(SudokuInnerSquare8, 3, 5)
        TableLayoutPanel1.Controls.Add(SudokuInnerSquare9, 5, 5)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 1F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 1F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 1F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 1F))
        TableLayoutPanel1.Size = New Size(453, 435)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' SudokuInnerSquare1
        ' 
        SudokuInnerSquare1.Location = New Point(1, 1)
        SudokuInnerSquare1.Margin = New Padding(0)
        SudokuInnerSquare1.Name = "SudokuInnerSquare1"
        SudokuInnerSquare1.Size = New Size(149, 143)
        SudokuInnerSquare1.TabIndex = 0
        ' 
        ' SudokuInnerSquare2
        ' 
        SudokuInnerSquare2.Location = New Point(151, 1)
        SudokuInnerSquare2.Margin = New Padding(0)
        SudokuInnerSquare2.Name = "SudokuInnerSquare2"
        SudokuInnerSquare2.Size = New Size(149, 143)
        SudokuInnerSquare2.TabIndex = 1
        ' 
        ' SudokuInnerSquare3
        ' 
        SudokuInnerSquare3.Location = New Point(301, 1)
        SudokuInnerSquare3.Margin = New Padding(0)
        SudokuInnerSquare3.Name = "SudokuInnerSquare3"
        SudokuInnerSquare3.Size = New Size(149, 143)
        SudokuInnerSquare3.TabIndex = 2
        ' 
        ' SudokuInnerSquare4
        ' 
        SudokuInnerSquare4.Location = New Point(1, 145)
        SudokuInnerSquare4.Margin = New Padding(0)
        SudokuInnerSquare4.Name = "SudokuInnerSquare4"
        SudokuInnerSquare4.Size = New Size(149, 143)
        SudokuInnerSquare4.TabIndex = 3
        ' 
        ' SudokuInnerSquare5
        ' 
        SudokuInnerSquare5.Location = New Point(151, 145)
        SudokuInnerSquare5.Margin = New Padding(0)
        SudokuInnerSquare5.Name = "SudokuInnerSquare5"
        SudokuInnerSquare5.Size = New Size(149, 143)
        SudokuInnerSquare5.TabIndex = 4
        ' 
        ' SudokuInnerSquare6
        ' 
        SudokuInnerSquare6.Location = New Point(301, 145)
        SudokuInnerSquare6.Margin = New Padding(0)
        SudokuInnerSquare6.Name = "SudokuInnerSquare6"
        SudokuInnerSquare6.Size = New Size(149, 143)
        SudokuInnerSquare6.TabIndex = 5
        ' 
        ' SudokuInnerSquare7
        ' 
        SudokuInnerSquare7.Location = New Point(1, 289)
        SudokuInnerSquare7.Margin = New Padding(0)
        SudokuInnerSquare7.Name = "SudokuInnerSquare7"
        SudokuInnerSquare7.Size = New Size(149, 143)
        SudokuInnerSquare7.TabIndex = 6
        ' 
        ' SudokuInnerSquare8
        ' 
        SudokuInnerSquare8.Location = New Point(151, 289)
        SudokuInnerSquare8.Margin = New Padding(0)
        SudokuInnerSquare8.Name = "SudokuInnerSquare8"
        SudokuInnerSquare8.Size = New Size(149, 143)
        SudokuInnerSquare8.TabIndex = 7
        ' 
        ' SudokuInnerSquare9
        ' 
        SudokuInnerSquare9.Location = New Point(301, 289)
        SudokuInnerSquare9.Margin = New Padding(0)
        SudokuInnerSquare9.Name = "SudokuInnerSquare9"
        SudokuInnerSquare9.Size = New Size(149, 143)
        SudokuInnerSquare9.TabIndex = 8
        ' 
        ' Sudoku3x3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "Sudoku3x3"
        Size = New Size(453, 435)
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SudokuInnerSquare1 As SudokuInnerSquare
    Friend WithEvents SudokuInnerSquare2 As SudokuInnerSquare
    Friend WithEvents SudokuInnerSquare3 As SudokuInnerSquare
    Friend WithEvents SudokuInnerSquare4 As SudokuInnerSquare
    Friend WithEvents SudokuInnerSquare5 As SudokuInnerSquare
    Friend WithEvents SudokuInnerSquare6 As SudokuInnerSquare
    Friend WithEvents SudokuInnerSquare7 As SudokuInnerSquare
    Friend WithEvents SudokuInnerSquare8 As SudokuInnerSquare
    Friend WithEvents SudokuInnerSquare9 As SudokuInnerSquare

End Class
