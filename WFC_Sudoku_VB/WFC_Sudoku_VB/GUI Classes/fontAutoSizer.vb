Public Class fontAutoSizer(Of T As TextBoxBase)

    'The font ratio of pixel height'
    ReadOnly FontToPixelRatio As Single = 8.0 / 16.0

    'private record of the textbox who's font needs to be resized'
    Private target As T
    'constructor that sets the target'
    Public Sub New(target As T)
        Me.target = target
    End Sub

    ''' <summary>
    ''' Resizes the setTarget based on the size of the text box
    ''' </summary>
    Public Sub resizeTargetFont()
        Dim targetFont As Font = target.Font
        Dim newFontSize = Math.Min(target.Size.Height, target.Size.Width) * FontToPixelRatio
        target.Font = New Font(targetFont.FontFamily, newFontSize)
    End Sub


End Class
