Imports System.Windows.Forms

Namespace Observer
    Public Class WorkEventArgs
        Private _fileName As String
        Private _eventType As String
        Private _currentItem As ListViewItem

        Public Sub New(ByVal fileName As String, ByVal eventType As String, ByVal currentItem As ListViewItem)
            _fileName = fileName
            _eventType = eventType

            If currentItem IsNot Nothing Then
                _currentItem = currentItem
            End If
        End Sub

        Public ReadOnly Property FileName As String
            Get
                Return _fileName
            End Get
        End Property

        Public ReadOnly Property EventType As String
            Get
                Return _eventType
            End Get
        End Property

        Public ReadOnly Property CurrentItem As ListViewItem
            Get
                If _currentItem IsNot Nothing Then
                    Return _currentItem
                Else
                    Return Nothing
                End If
            End Get
        End Property
    End Class
End Namespace
