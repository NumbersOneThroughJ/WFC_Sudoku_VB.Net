Public MustInherit Class IRule_2D_Base

    'Row, Collum'
    'Returns true if all conditions allow the current value
    Public MustOverride Function evaluatePoint(x As Integer, y As Integer, map(,) As Integer) As Boolean
    Public Function evaluatePoint(p As Point, map As Integer(,)) As Boolean
        Return evaluatePoint(p.X, p.Y, map)
    End Function
    Public Function evaluateFullTable(map(,) As Integer) As Boolean
        For y = 0 To map.GetLength(0)
            For x = 0 To map.GetLength(1)
                If Not evaluatePoint(x, y, map) Then Return False
            Next
        Next
        Return True
    End Function


End Class
