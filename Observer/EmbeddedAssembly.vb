﻿Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography

Namespace Observer
    Friend Class EmbeddedAssembly
        Private Shared dic As Dictionary(Of String, Assembly)

        Public Shared Sub Load(ByVal embeddedResource As String, ByVal fileName As String)
            If dic Is Nothing Then dic = New Dictionary(Of String, Assembly)()

            Dim ba As Byte() = Nothing
            Dim asm As Assembly = Nothing
            Dim curAsm = Assembly.GetExecutingAssembly()

            Using stm = curAsm.GetManifestResourceStream(embeddedResource)
                If stm Is Nothing Then Throw New Exception(embeddedResource & " is not found in Embedded Resources.")

                ba = New Byte(CInt(stm.Length) - 1) {}
                stm.Read(ba, 0, stm.Length)
                Try
                    asm = Assembly.Load(ba)

                    dic.Add(asm.FullName, asm)
                    Return
                Catch
                End Try
            End Using

            Dim fileOk = False
            Dim tempFile = ""

            Using sha1 = New SHA1CryptoServiceProvider()
                Dim fileHash = BitConverter.ToString(sha1.ComputeHash(ba)).Replace("-", String.Empty)

                tempFile = Path.GetTempPath() & fileName

                If File.Exists(tempFile) Then
                    Dim bb = File.ReadAllBytes(tempFile)
                    Dim fileHash2 = BitConverter.ToString(sha1.ComputeHash(bb)).Replace("-", String.Empty)

                    If Equals(fileHash, fileHash2) Then
                        fileOk = True
                    End If
                Else
                    fileOk = False
                End If
            End Using

            If Not fileOk Then
                File.WriteAllBytes(tempFile, ba)
            End If

            asm = Assembly.LoadFile(tempFile)

            dic.Add(asm.FullName, asm)
        End Sub

        Public Shared Function [Get](ByVal assemblyFullName As String) As Assembly
            If dic Is Nothing OrElse dic.Count = 0 Then Return Nothing

            If dic.ContainsKey(assemblyFullName) Then Return dic(assemblyFullName)

            Return Nothing
        End Function
    End Class
End Namespace
