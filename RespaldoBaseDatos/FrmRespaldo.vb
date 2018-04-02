Public Class FrmRespaldo

    Private copia = New CopiaSeguridad()

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click

    End Sub

    Private Sub btnCopiaSeguridad_Click(sender As Object, e As EventArgs) Handles btnCopiaSeguridad.Click
        RealizarCopiaSeguridad()
    End Sub


    Sub RealizarCopiaSeguridad()
        Try
            Dim proceso As New Process
            proceso.StartInfo.FileName = "C:\Program Files\MySQL\MySQL Server 5.5\bin\mysqldump.exe"
            proceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            proceso.StartInfo.UseShellExecute = False
            proceso.StartInfo.RedirectStandardOutput = True
            proceso.StartInfo.RedirectStandardInput = True
            proceso.StartInfo.CreateNoWindow = True
            proceso.StartInfo.Arguments = " -u root -pSoluciones gse > C:\Users\Server\Desktop\GSERespaldo.sql"
            proceso.Start()
            proceso.WaitForExit()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
End Class
