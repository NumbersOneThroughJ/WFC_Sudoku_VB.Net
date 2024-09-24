Imports System.Windows.Forms.VisualStyles

Public Class SudokuInnerSquare
    'Variables'
    Private myNumber As Integer
    Public ReadOnly Property Number() As Integer
        Get
            Return myNumber
        End Get
    End Property
    Private defaultColor As Color
    Private FontSizer As fontAutoSizer(Of RichTextBox)
    Public Event NeedUpdate(val As Boolean)

    ''' <summary>
    ''' Initializes components, center aligns text, sets current font size, and sets number to -1 
    ''' </summary>
    Public Sub New()
        InitializeComponent()

        NumberTextBox.SelectionAlignment = HorizontalAlignment.Center


        FontSizer = New fontAutoSizer(Of RichTextBox)(NumberTextBox)
        FontSizer.resizeTargetFont()

        myNumber = -1
        NumPanel.Visible = True
        defaultColor = BackColor
    End Sub

    'Events'

    ''' <summary>
    ''' upon resizing, the textbox's font will be resized to fit the box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SudokuInnerSquare_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        FontSizer.resizeTargetFont()
    End Sub

    Private Sub NumberTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NumberTextBox.MouseDoubleClick
        resetNumber()
        NumPanel.Visible = True
        RaiseEvent NeedUpdate(True)
    End Sub

    Private Sub NumPanel_PanelClicked(clickedButton As Integer) Handles NumPanel.PanelClicked
        NumPanel.Visible = False
        setNumber(clickedButton)
        RaiseEvent NeedUpdate(True)
    End Sub
    'Functions'

    Public Sub setTextTool(text As String)
        NumberTextBox.Text = text
        NumberTextBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Public Sub resText()
        setTextTool("")
    End Sub

    Public Sub setTextFromNumber()
        setTextTool(myNumber.ToString())
    End Sub

    Public Sub resetNumber()
        myNumber = -1

    End Sub

    Public Sub setNumber(num As Integer)
        If num = -1 Then
            resetNumber()
        End If
        If (num >= 0) And (num <= 9) Then
            Me.myNumber = num
            setTextFromNumber()
            NumPanel.Visible = False
        End If
    End Sub

    Public Sub setAvailableNumbers(availableNums() As Integer)
        If (Not availableNums.Contains(Number)) And (Number <> -1) Then
            availableNums = availableNums.Concat({Number})
        End If
        NumPanel.setPossibleNumbers(availableNums)
    End Sub

    Public Sub setPriority(highlighted As Boolean)
        BackColor = If(highlighted, Color.LightGoldenrodYellow, defaultColor)
    End Sub

End Class
