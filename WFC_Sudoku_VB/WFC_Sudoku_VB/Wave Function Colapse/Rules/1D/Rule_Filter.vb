Public Class Rule_Filter
    Implements IRuleBase

    Public Sub reset() Implements IRuleBase.reset

    End Sub

    Public Function Evaluate(target As Integer) As Boolean Implements IRuleBase.Evaluate
        Return isAllowed(target)
    End Function

    Public Function evaluateReturnPossibleValues(target As Integer) As Integer() Implements IRuleBase.evaluateReturnPossibleValues
        Return softWhiteList.ToArray()
    End Function

    Public Function evaluateReturnNegativeValues(target As Integer) As Integer() Implements IRuleBase.evaluateReturnNegativeValues
        Return hardBlackList.ToArray()
    End Function

    Public Function evaluateReturnRuleFilter(target As Integer) As Rule_Filter Implements IRuleBase.evaluateReturnRuleFilter
        Return Me
    End Function

    'Local Variables'
    Private softWhiteList As List(Of Integer)
    Private hardBlackList As List(Of Integer)

    'Constructors'
    Public Sub New()
        softWhiteList = New List(Of Integer)(0)
        hardBlackList = New List(Of Integer)(0)
    End Sub
    Public Sub New(softWhiteList As List(Of Integer), hardBlackList As List(Of Integer)
        Me.softWhiteList = softWhiteList
        Me.hardBlackList = hardBlackList
    End Sub
    Public Sub New(filter As Rule_Filter)
        Me.softWhiteList = filter.softWhiteList
        Me.hardBlackList = filter.hardBlackList
    End Sub

    'Functions'
    Private Sub Allow(item As Integer)
        If hardBlackList.Contains(item) Then
            hardBlackList.Remove(item)
        ElseIf Not softWhiteList.Contains(item) Then
            softWhiteList.Add(item)
        End If
    End Sub

    Private Sub deny(item)
        If softWhiteList.Contains(item) Then
            softWhiteList.Remove(item)
        ElseIf Not hardBlackList.Contains(item) Then
            hardBlackList.Add(item)
        End If
    End Sub

    Private Function isAllowed(item As Integer) As Boolean
        Return Not hardBlackList.Contains(item)
    End Function


    'Operators'
    Public Shared Operator -(r1 As Rule_Filter, r2 As Rule_Filter) As Rule_Filter
        Dim retRul As Rule_Filter = New Rule_Filter()
        If Not r1 Is Nothing Then
            For Each item In r1.softWhiteList
                retRul.Allow(item)
            Next
        End If
        If Not r2 Is Nothing Then
            For Each item In r2.softWhiteList
                retRul.Allow(item)
            Next
        End If
        If Not r1 Is Nothing Then
            For Each item In r1.hardBlackList
                retRul.deny(item)
            Next
        End If
        If Not r2 Is Nothing Then
            For Each item In r2.hardBlackList
                retRul.deny(item)
            Next
        End If
        Return retRul
    End Operator
    Public Shared Operator -(r1 As Rule_Filter, BlackList As List(Of Integer))
        Return New Rule_Filter(r1) - New Rule_Filter(New List(Of Integer)(0), BlackList)
    End Operator

    Public Shared Operator +(r1 As Rule_Filter, r2 As Rule_Filter) As Rule_Filter
        Dim retRul As Rule_Filter = New Rule_Filter()
        If Not r1 Is Nothing Then
            For Each item In r1.hardBlackList
                retRul.deny(item)
            Next
        End If
        If Not r2 Is Nothing Then
            For Each item In r2.hardBlackList
                retRul.deny(item)
            Next
        End If
        If Not r1 Is Nothing Then
            For Each item In r1.softWhiteList
                retRul.Allow(item)
            Next
        End If
        If Not r2 Is Nothing Then
            For Each item In r2.softWhiteList
                retRul.Allow(item)
            Next
        End If
        Return retRul
    End Operator
    Public Shared Operator +(r1 As Rule_Filter, WhiteList As List(Of Integer))
        Return New Rule_Filter(r1) - New Rule_Filter(WhiteList, New List(Of Integer)(0))
    End Operator
End Class
