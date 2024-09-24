Public Interface IRuleBase
    Sub reset()
    Function Evaluate(target As Integer) As Boolean
    Function evaluateReturnPossibleValues(target As Integer) As Integer()
    Function evaluateReturnNegativeValues(target As Integer) As Integer()
    Function evaluateReturnRuleFilter(target As Integer) As Rule_Filter
End Interface
