Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Observer
    Friend Class SystemWideHotKey
        Public Shared MOD_ALT As Integer = &H1
        Public Shared MOD_CONTROL As Integer = &H2
        Public Shared MOD_SHIFT As Integer = &H4
        Public Shared MOD_WIN As Integer = &H8
        Public Shared WM_HOTKEY As Integer = &H312

        <DllImport("user32.dll")>
        Private Shared Function RegisterHotKey(ByVal hWnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vlc As Integer) As Boolean
        End Function

        <DllImport("user32.dll")>
        Private Shared Function UnregisterHotKey(ByVal hWnd As IntPtr, ByVal id As Integer) As Boolean
        End Function

        Private Shared keyId As Integer
        Public Shared Sub RegisterHotKey(ByVal _inForm As Form, ByVal _inKey As Keys)
            Dim modifiers = 0

            If (_inKey And Keys.Alt) = Keys.Alt Then modifiers = modifiers Or MOD_ALT

            If (_inKey And Keys.Control) = Keys.Control Then modifiers = modifiers Or MOD_CONTROL

            If (_inKey And Keys.Shift) = Keys.Shift Then modifiers = modifiers Or MOD_SHIFT

            Dim k = _inKey And Not Keys.Control And Not Keys.Shift And Not Keys.Alt

            Dim DelegMethod As DelegateFunction = Sub()
                                                      keyId = _inForm.GetHashCode()
                                                      RegisterHotKey(_inForm.Handle, keyId, modifiers, k)
                                                  End Sub

            _inForm.Invoke(DelegMethod)
        End Sub

        Private Delegate Sub DelegateFunction()

        Public Shared Sub UnregisterHotKey(ByVal _inForm As Form)
            Try
                Dim df As DelegateFunction = Sub() UnregisterHotKey(_inForm.Handle, keyId)

                _inForm.Invoke(df)
            Catch
            End Try
        End Sub
    End Class
End Namespace
