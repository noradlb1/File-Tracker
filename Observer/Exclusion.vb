Imports System

Namespace Observer
    Friend Class Exclusion
        Private _filter As String
        Private _id As Integer

        Private Shared counter As Integer

        Public Sub New(ByVal filter As String)
            _filter = filter
            _id = Math.Min(Threading.Interlocked.Increment(counter), counter - 1)
        End Sub

        Public ReadOnly Property Filter As String
            Get
                Return _filter
            End Get
        End Property

        Public ReadOnly Property Id As Integer
            Get
                Return _id
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return _filter
        End Function
    End Class
End Namespace
