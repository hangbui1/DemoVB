Option Explicit On
Option Strict On

Public Class Mouse
    Private _NumberOfButtons As Integer
    Private _HasLEDs As Boolean

    Public Property Color As String

    Public Property NumberOfButtons As Integer
        Get
            Return _NumberOfButtons
        End Get
        Set(ByVal value As Integer)
            If value <= 4 And value > 0 Then
                _NumberOfButtons = value
            Else
                _NumberOfButtons = 3
            End If
        End Set
    End Property

    Public Property HasLEDs As Boolean
        Get
            Return _HasLEDs
        End Get
        Set(ByVal value As Boolean)
            _HasLEDs = value
        End Set
    End Property

    Public ReadOnly Property LightsAreOn As Boolean
        Get
            If HasLEDs And NumberOfButtons > 2 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    'Contructor
    Public Sub New()
        Color = "Black"
        NumberOfButtons = 3
        HasLEDs = True
    End Sub
End Class
