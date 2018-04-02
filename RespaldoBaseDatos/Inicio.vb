
Module Inicio
    Public Sub Main()
        RealizarCopiaSeguridad()
        '  Application.Run(New FrmRespaldo()) ''//Use your main form here
    End Sub

    Sub RealizarCopiaSeguridad()
        Try
            Dim ruta = "C:\GSERespaldo.sql"
            Dim proceso As New Process
            proceso.StartInfo.FileName = "C:\Program Files\MySQL\MySQL Server 5.5\bin\mysqldump.exe"
            proceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            proceso.StartInfo.UseShellExecute = False
            proceso.StartInfo.RedirectStandardOutput = True
            proceso.StartInfo.RedirectStandardInput = True
            proceso.StartInfo.CreateNoWindow = True
            proceso.StartInfo.Arguments = " --opt --force --user=root --password=Soluciones --databases gse -r " & ruta & ""
            proceso.Start()
            proceso.WaitForExit()
            MsgBox(proceso.StartInfo.Arguments)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
End Module
