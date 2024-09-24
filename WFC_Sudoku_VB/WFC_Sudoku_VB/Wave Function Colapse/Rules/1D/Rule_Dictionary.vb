Public Class Rule_Dictionary
    Implements IRuleBase

    Public Sub reset() Implements IRuleBase.reset

    End Sub

    Public Function Evaluate(target As Integer) As Boolean Implements IRuleBase.Evaluate
        Return ruleLedger(target).Evaluate(target)
    End Function

    Public Function evaluateReturnPossibleValues(target As Integer) As Integer() Implements IRuleBase.evaluateReturnPossibleValues
        Return ruleLedger(target).evaluateReturnPossibleValues(target)
    End Function

    Public Function evaluateReturnNegativeValues(target As Integer) As Integer() Implements IRuleBase.evaluateReturnNegativeValues
        Return ruleLedger(target).evaluateReturnNegativeValues(target)
    End Function

    Public Function evaluateReturnRuleFilter(target As Integer) As Rule_Filter Implements IRuleBase.evaluateReturnRuleFilter
        Return ruleLedger(target).evaluateReturnRuleFilter(target)
    End Function

    'Local Variables'
    Dim ruleLedger As Dictionary(Of Integer, IRuleBase)

    'Constructors'

    Public Sub New()
        ruleLedger = New Dictionary(Of Integer, IRuleBase)
    End Sub
    Public Sub New(IDs As List(Of Integer), Rules As List(Of IRuleBase))
        ruleLedger = New Dictionary(Of Integer, IRuleBase)
        ruleLedger = IDs.Zip(Of IRuleBase)(Rules)
    End Sub
End Class
