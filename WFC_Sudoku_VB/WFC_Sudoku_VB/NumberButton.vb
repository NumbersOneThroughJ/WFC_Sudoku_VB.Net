Imports System.ComponentModel

Public Class NumberButton
    Inherits Button
    Private myNumber As Integer

    <Browsable(True)>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property number As Integer
        Get
            Return myNumber
        End Get
        Set(value As Integer)
            myNumber = value
        End Set
    End Property
End Class
