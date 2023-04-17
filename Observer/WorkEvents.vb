Imports System.Collections.Generic
Imports System
Imports System.IO

Imports System.Reflection
Imports System.Security.Cryptography

Namespace Observer
    Friend NotInheritable Class WorkEvents
        Inherits List(Of WorkEventArgs)
        Private Shared _lockObject As Object = New Object()
        Private Shared _syncRoot As Object = New Object()
        ''' Cannot convert FieldDeclarationSyntax, System.NotSupportedException: VolatileKeyword is not supported!
        '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.<>c__DisplayClass33_0.<ConvertModifiersCore>b__3(SyntaxToken x)
        '''    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
        '''    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
        '''    at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
        '''    at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
        ''' 
        ''' Input:
        '''         static volatile Observer.WorkEvents _instance;

        ''' 
        Private Sub New()
        End Sub



        Public Shared ReadOnly Property Instance As WorkEvents
            Get
                If WorkEvents._syncRoot Is Nothing Then
                    SyncLock _syncRoot
                        If WorkEvents._syncRoot Is Nothing Then
                            WorkEvents._syncRoot = New WorkEvents()
                        End If
                    End SyncLock
                End If

                Return WorkEvents._syncRoot
            End Get
        End Property

        Public Sub Add(ByVal wea As WorkEventArgs)
            SyncLock _lockObject
                MyBase.Add(wea)
            End SyncLock
        End Sub

        Public Sub Remove(ByVal wea As WorkEventArgs)
            SyncLock _lockObject
                MyBase.Remove(wea)
            End SyncLock
        End Sub

        Public Function GetEventObject() As WorkEventArgs
            If Count > 0 Then
                If Me(0) IsNot Nothing Then
                    Dim dwoTemp = Me(0)
                    Remove(Me(0))
                    Return dwoTemp
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace
