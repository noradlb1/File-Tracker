Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports System.Drawing
Imports System.IO

Namespace Observer
    Public Class SettingsJson
        Public Property Color As Theme
        Public Property Path As String
        Public Property Exclusions As List(Of String)
        Public Property FileModifiedEvent As Boolean
        Public Property FileCreatedEvent As Boolean
        Public Property FileDeletedEvent As Boolean
        Public Property FileRenamedEvent As Boolean
        Public Property ExclusionsEnabled As Boolean
    End Class

    Public Class Options
        Friend Shared ForegroundColor As Color = Color.MediumOrchid
        Friend Shared BackgroundColor As Color = Color.FromArgb(20, 20, 20)

        Friend ReadOnly Shared ThemeFlag As String = "themeable"
        Private ReadOnly Shared SettingsFile As String = Application.StartupPath & "\Observer.json"

        Friend Shared CurrentOptions As SettingsJson = New SettingsJson()

        Friend Shared Function GetSelfAndChildrenRecursive(ByVal parent As Control) As IEnumerable(Of Control)
            Dim controls As List(Of Control) = New List(Of Control)()

            For Each child As Control In parent.Controls
                controls.AddRange(GetSelfAndChildrenRecursive(child))
            Next

            controls.Add(parent)
            Return controls
        End Function

        Friend Shared Sub ApplyTheme(ByVal f As Form)
            Select Case CurrentOptions.Color
                Case Theme.Caramel
                    SetTheme(f, Color.DarkOrange, Color.Chocolate)
                Case Theme.Lime
                    SetTheme(f, Color.LimeGreen, Color.ForestGreen)
                Case Theme.Magma
                    SetTheme(f, Color.Tomato, Color.Red)
                Case Theme.Minimal
                    SetTheme(f, Color.Gray, Color.DimGray)
                Case Theme.Ocean
                    SetTheme(f, Color.DodgerBlue, Color.RoyalBlue)
                Case Theme.Zerg
                    SetTheme(f, Color.MediumOrchid, Color.DarkOrchid)
            End Select
        End Sub

        Private Shared Sub SetTheme(ByVal f As Form, ByVal c1 As Color, ByVal c2 As Color)
            ForegroundColor = c1

            Enumerable.ToList(GetSelfAndChildrenRecursive(f).OfType(Of Button)()).ForEach(Sub(b) b.BackColor = c1)
            Enumerable.ToList(GetSelfAndChildrenRecursive(f).OfType(Of Button)()).ForEach(Sub(b) b.FlatAppearance.BorderColor = c1)
            Enumerable.ToList(GetSelfAndChildrenRecursive(f).OfType(Of Button)()).ForEach(Sub(b) b.FlatAppearance.MouseDownBackColor = c2)
            Enumerable.ToList(GetSelfAndChildrenRecursive(f).OfType(Of Button)()).ForEach(Sub(b) b.FlatAppearance.MouseOverBackColor = c2)

            For Each tmp In GetSelfAndChildrenRecursive(f).OfType(Of Label)().ToList()
                If Equals(CStr(tmp.Tag), ThemeFlag) Then
                    tmp.ForeColor = c1
                End If
            Next
            For Each tmp In GetSelfAndChildrenRecursive(f).OfType(Of LinkLabel)().ToList()
                If Equals(CStr(tmp.Tag), ThemeFlag) Then
                    tmp.LinkColor = c1
                    tmp.VisitedLinkColor = c1
                    tmp.ActiveLinkColor = c2
                End If
            Next
            For Each tmp In GetSelfAndChildrenRecursive(f).OfType(Of CheckBox)().ToList()
                If Equals(CStr(tmp.Tag), ThemeFlag) Then
                    tmp.ForeColor = c1
                End If
            Next
        End Sub

        Friend Shared Sub SaveSettings()
            If File.Exists(SettingsFile) Then
                File.Delete(SettingsFile)

                Using fs = File.Open(SettingsFile, FileMode.OpenOrCreate)
                    Using sw As StreamWriter = New StreamWriter(fs)
                        Using jw As JsonWriter = New JsonTextWriter(sw)
                            jw.Formatting = Formatting.Indented

                            Dim serializer As JsonSerializer = New JsonSerializer()
                            serializer.Serialize(jw, CurrentOptions)
                        End Using
                    End Using
                End Using
            End If
        End Sub

        Friend Shared Sub LoadSettings()
            If Not File.Exists(SettingsFile) Then
                CurrentOptions.Color = Theme.Zerg
                CurrentOptions.Exclusions = New List(Of String)()
                CurrentOptions.FileCreatedEvent = True
                CurrentOptions.FileDeletedEvent = True
                CurrentOptions.FileModifiedEvent = True
                CurrentOptions.FileRenamedEvent = True
                CurrentOptions.ExclusionsEnabled = True
                CurrentOptions.Path = String.Empty

                Using fs = File.Open(SettingsFile, FileMode.CreateNew)
                    Using sw As StreamWriter = New StreamWriter(fs)
                        Using jw As JsonWriter = New JsonTextWriter(sw)
                            jw.Formatting = Formatting.Indented

                            Dim serializer As JsonSerializer = New JsonSerializer()
                            serializer.Serialize(jw, CurrentOptions)
                        End Using
                    End Using
                End Using
            Else
                CurrentOptions = JsonConvert.DeserializeObject(Of SettingsJson)(File.ReadAllText(SettingsFile))
            End If
        End Sub
    End Class
End Namespace
