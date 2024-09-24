Public Class NumberSelectPanel
    Public Event PanelClicked(clickedButton As Integer)

    Private buttons = New NumberButton() {NumberButton1, NumberButton2, NumberButton3, NumberButton4, NumberButton5, NumberButton6, NumberButton7, NumberButton8, NumberButton9}

    Public Sub New()
        InitializeComponent()

        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Private Sub NumberButton_Click(sender As Object, e As EventArgs) Handles NumberButton1.Click, NumberButton2.Click, NumberButton3.Click, NumberButton4.Click, NumberButton5.Click, NumberButton6.Click, NumberButton7.Click, NumberButton8.Click, NumberButton9.Click
        Dim NB As NumberButton = sender
        RaiseEvent PanelClicked(NB.number)
    End Sub

    Private Function getButton(index As Integer) As NumberButton
        Return buttons(index - 1)
    End Function

    Private Sub resetEnableButtons(state As Boolean)
        For index = 1 To 9
            getButton(index).Enabled = True
        Next
    End Sub

    Public Sub setPossibleNumbers(enableds() As Integer)
        For Each index As Integer In enableds
            getButton(index).Enabled = True
        Next
    End Sub

End Class
