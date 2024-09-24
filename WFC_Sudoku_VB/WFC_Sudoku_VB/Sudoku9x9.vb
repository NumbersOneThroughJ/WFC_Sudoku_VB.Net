Public Class Sudoku9x9
    Private sudoku3x3_arr(,) As Sudoku3x3
    Public Event NeedUpdate(val As Boolean)

    Public Sub New()
        InitializeComponent()

        sudoku3x3_arr = {
            {Sudoku3x31, Sudoku3x32, Sudoku3x33},
            {Sudoku3x34, Sudoku3x35, Sudoku3x36},
            {Sudoku3x37, Sudoku3x38, Sudoku3x39}
        }
    End Sub

    Public Function getRow(bigRow As Integer, row As Integer) As Integer()
        row = row Mod 3
        Select Case bigRow
            Case 0
                Return Sudoku3x31.GetRow(row).Concat(Sudoku3x32.GetRow(row)).Concat(Sudoku3x33.GetRow(row))
            Case 1
                Return Sudoku3x34.GetRow(row).Concat(Sudoku3x35.GetRow(row)).Concat(Sudoku3x36.GetRow(row))
            Case 2
                Return Sudoku3x37.GetRow(row).Concat(Sudoku3x38.GetRow(row)).Concat(Sudoku3x39.GetRow(row))
        End Select
        Return New Integer() {}
    End Function

    Public Function getTable() As Integer(,)
        Dim table(9, 9) As Integer
        For y = 0 To 2
            For x = 0 To 2
                Dim row = getRow(y, x)
                For i = 0 To 8
                    table((y * 3) + x, i) = row(i)
                Next
            Next
        Next
        Return table
    End Function

    Public Sub setAvailables(possibles(,)() As Integer)
        For x = 0 To 2
            For y = 0 To 2
                sudoku3x3_arr(x, y).SetAvailables(possibles)
                sudoku3x3_arr(x, y).resetAllPriorities()
            Next
        Next
    End Sub

    Public Sub highlightSquares(points() As Point)
        For Each p As Point In points
            Dim subX As Integer = p.X / 3
            Dim subY As Integer = p.Y / 3
            Dim x1 = p.X Mod 3
            Dim y1 = p.Y Mod 3
            Dim subPoint As Point = New Point(x1, y1)
            sudoku3x3_arr(subY, subX).SetPriority(subPoint, True)
        Next
    End Sub

    Public Sub setNumber(p As Point, val As Integer)
        Dim subX As Integer = p.X / 3
        Dim subY As Integer = p.Y / 3
        Dim x1 = p.X Mod 3
        Dim y1 = p.Y Mod 3
        Dim subPoint As Point = New Point(x1, y1)
        sudoku3x3_arr(subY, subX).SetNumber(subPoint, val)
    End Sub

    Public Sub setBoard(map(,) As Integer)
        For x = 0 To 8
            For y = 0 To 9
                setNumber(New Point(x, y), map(y, x))
            Next
        Next
    End Sub

    Public Sub resetPoint(p As Point)
        Dim subX As Integer = p.X / 3
        Dim subY As Integer = p.Y / 3
        Dim x1 = p.X Mod 3
        Dim y1 = p.Y Mod 3
        Dim subPoint As Point = New Point(x1, y1)
        sudoku3x3_arr(subY, subX).ResetPoint(subPoint)
    End Sub

    Public Sub reset()
        For Each sq As Sudoku3x3 In sudoku3x3_arr
            sq.Reset()
        Next
    End Sub

    Private Sub Sudoku3x3_NeedUpdate(val As Boolean) Handles Sudoku3x31.NeedUpdate, Sudoku3x32.NeedUpdate, Sudoku3x33.NeedUpdate, Sudoku3x34.NeedUpdate, Sudoku3x35.NeedUpdate, Sudoku3x36.NeedUpdate, Sudoku3x37.NeedUpdate, Sudoku3x38.NeedUpdate, Sudoku3x39.NeedUpdate
        RaiseEvent NeedUpdate(True)
    End Sub
End Class
