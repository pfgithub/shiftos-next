Public Class basicwm_renderer
    Inherits ToolStripProfessionalRenderer
    Public Sub New()
        MyBase.New(New BasicWM.ColorTable())
    End Sub
End Class
