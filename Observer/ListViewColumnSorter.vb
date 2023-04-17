Imports System
Imports System.Collections
Imports System.Windows.Forms

Namespace Observer
    Public Class ListViewColumnSorter
        Implements IComparer
        ''' <summary>
        ''' Specifies the column to be sorted
        ''' </summary>
        Private columnToSort As Integer

        ''' <summary>
        ''' Specifies the order in which to sort (i.e. 'Ascending').
        ''' </summary>
        Private orderOfSort As SortOrder

        ''' <summary>
        ''' Case insensitive comparer object
        ''' </summary>
        Private objectCompare As CaseInsensitiveComparer

        ''' <summary>
        ''' Initializes a new instance of the ListViewColumnSorter class
        ''' </summary>
        Public Sub New()
            ' Initialize the column to '0'
            columnToSort = 0

            ' Initialize the sort order to 'none'
            orderOfSort = SortOrder.None

            ' Initialize the CaseInsensitiveComparer object
            objectCompare = New CaseInsensitiveComparer()
        End Sub

        ''' <summary>
        ''' Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
        ''' </summary>
        Public Property SortColumn As Integer
            Get
                Return columnToSort
            End Get

            Set(ByVal value As Integer)
                columnToSort = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
        ''' </summary>
        Public Property Order As SortOrder
            Get
                Return orderOfSort
            End Get

            Set(ByVal value As SortOrder)
                orderOfSort = value
            End Set
        End Property

        ''' <summary>
        ''' This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
        ''' </summary>
        ''' <paramname="x">First object to be compared</param>
        ''' <paramname="y">Second object to be compared</param>
        ''' <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            Dim compareResult As Integer
            Dim listviewX, listviewY As ListViewItem

            ' Cast the objects to be compared to ListViewItem objects
            listviewX = CType(x, ListViewItem)
            listviewY = CType(y, ListViewItem)

            ' Compare the two items
            Try
                ' if the numeric sort (try) fails, then we want
                ' to do the text sort (catch)
                compareResult = objectCompare.Compare(Convert.ToInt64(listviewX.SubItems(columnToSort).Text), Convert.ToInt64(listviewY.SubItems(columnToSort).Text))
            Catch
                compareResult = objectCompare.Compare(listviewX.SubItems(columnToSort).Text, listviewY.SubItems(columnToSort).Text)
            End Try

            ' Calculate correct return value based on object comparison
            If orderOfSort = SortOrder.Ascending Then
                ' Ascending sort is selected, return normal result of compare operation
                Return compareResult
            ElseIf orderOfSort = SortOrder.Descending Then
                ' Descending sort is selected, return negative result of compare operation
                Return -compareResult
            Else
                ' Return '0' to indicate they are equal
                Return 0
            End If
        End Function
    End Class
End Namespace
