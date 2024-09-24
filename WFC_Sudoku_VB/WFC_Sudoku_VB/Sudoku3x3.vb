Imports System.ComponentModel

Public Class Sudoku3x3
    Private loc As Point
    <Browsable(True)>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property LocalLocation As Point
        Get
            Return loc
        End Get
        Set(value As Point)
            loc = value
        End Set
    End Property

    Public Event NeedUpdate(val As Boolean)
    Private innerSquares(,) As SudokuInnerSquare

    Public Sub New()
        InitializeComponent()

        innerSquares = {
            {SudokuInnerSquare1, SudokuInnerSquare2, SudokuInnerSquare3},
            {SudokuInnerSquare4, SudokuInnerSquare5, SudokuInnerSquare6},
            {SudokuInnerSquare7, SudokuInnerSquare8, SudokuInnerSquare9}}
    End Sub

    Public Function GetRow(row As Integer) As Integer()
        row = row Mod 3
        Dim nums() As Integer
        Select Case row
            Case 0
                nums = {SudokuInnerSquare1.Number, SudokuInnerSquare2.Number, SudokuInnerSquare3.Number}
            Case 1
                nums = {SudokuInnerSquare3.Number, SudokuInnerSquare4.Number, SudokuInnerSquare5.Number}
            Case 2
                nums = {SudokuInnerSquare7.Number, SudokuInnerSquare8.Number, SudokuInnerSquare9.Number}
        End Select
        Return nums
    End Function

    Public Sub SetAvailables(possibles(,)() As Integer)
        For x = 0 To 2
            Dim xI = localLocation.X * 3 + x
            For y = 0 To 2
                Dim yI = localLocation.Y * 3 + x
                innerSquares(y, x).setAvailableNumbers(possibles(yI, xI))
            Next
        Next
    End Sub

    Public Sub SetPriority(x As Integer, y As Integer, highlighted As Boolean)
        innerSquares(y, x).setPriority(highlighted)
    End Sub
    Public Sub SetPriority(p As Point, highlighted As Boolean)
        setPriority(p.X, p.Y, highlighted)
    End Sub

    Public Sub SetNumber(x As Integer, y As Integer, val As Integer)
        innerSquares(y, x).setNumber(val)
    End Sub
    Public Sub SetNumber(p As Point, val As Integer)
        setNumber(p.X, p.Y, val)
    End Sub

    Public Sub Reset()
        For Each sq As SudokuInnerSquare In innerSquares
            sq.setNumber(-1)
            sq.setPriority(False)
        Next
    End Sub

    Public Sub ResetPoint(p As Point)
        innerSquares(p.Y, p.X).resetNumber()
    End Sub

    Public Sub resetAllPriorities()
        For Each sq As SudokuInnerSquare In innerSquares
            sq.setPriority(False)
        Next
    End Sub

    Private Sub SudokuInnerSquare2_NeedUpdate(val As Boolean) Handles SudokuInnerSquare1.NeedUpdate, SudokuInnerSquare2.NeedUpdate, SudokuInnerSquare3.NeedUpdate, SudokuInnerSquare4.NeedUpdate, SudokuInnerSquare5.NeedUpdate, SudokuInnerSquare6.NeedUpdate, SudokuInnerSquare7.NeedUpdate, SudokuInnerSquare8.NeedUpdate, SudokuInnerSquare9.NeedUpdate
        RaiseEvent NeedUpdate(True)
    End Sub
End Class
