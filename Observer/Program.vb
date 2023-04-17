Imports System
Imports System.Reflection
Imports System.Windows.Forms

Namespace Observer
    Friend Module Program
        ' VERSION PROPERTIES 
        ' DO NOT LEAVE THEM EMPTY 

        ' Enter current version here
        Friend ReadOnly Major As Single = 1
        Friend ReadOnly Minor As Single = 2

        ' END OF VERSION PROPERTIES 

        Friend Function GetCurrentVersionToString() As String
            Return Major.ToString() & "." & Minor.ToString()
        End Function

        Friend Function GetCurrentVersion() As Single
            Return Single.Parse(GetCurrentVersionToString())
        End Function

        Private resource As String = "Observer.Newtonsoft.Json.dll"

        <STAThread>
        Private Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            EmbeddedAssembly.Load(resource, resource.Replace("Observer.", String.Empty))
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CurrentDomain_AssemblyResolve

            Options.LoadSettings()
            Call Application.Run(New MainForm())
        End Sub

        Private Function CurrentDomain_AssemblyResolve(ByVal sender As Object, ByVal args As ResolveEventArgs) As Assembly
            Return EmbeddedAssembly.Get(args.Name)
        End Function
    End Module
End Namespace
