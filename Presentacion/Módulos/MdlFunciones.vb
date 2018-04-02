Option Explicit On
Imports Logica_Negocios
Module MdlFunciones

    Private ReadOnly Utilidades As New Utilidades

    Public Sub SeleccionaClickDerecho(ByVal sender As System.Object, ByVal e As Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then

            ' Si se ha pulsado el botón derecho del ratón,
            ' seleccionamos la fila completa del control
            ' DataGridView.
            '
            With sender

                Dim hti As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)

                ' Obtenemos la parte del control a las que
                ' pertenecen las coordenadas.
                '
                If hti.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell = _
                    .Rows(hti.RowIndex).Cells(hti.ColumnIndex)
                End If

            End With
        End If
    End Sub

    Public Sub CambiarControlADataGrid(ByVal dgvMostrarDatos As DataGridView, ByVal e As Windows.Forms.KeyEventArgs, ByVal txtDatos As TextBox, ByVal txtSiguiente As Object, ByVal txtSiguiente2 As Object)
        If e.KeyValue = 40 Then
            With dgvMostrarDatos
                If .Visible Then
                    .Focus()
                    .Rows(0).Selected = True
                End If
            End With
        ElseIf e.KeyData = Keys.Enter And Trim(txtDatos.Text) = "" Then
            txtSiguiente.Focus()
            dgvMostrarDatos.Visible = False
        ElseIf e.KeyData = Keys.Enter Then
            txtSiguiente2.Focus()
            dgvMostrarDatos.Visible = False
        End If
    End Sub

    Public Sub FormatoNumTelefono(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))

        Dim texto As TextBox = sender

        Dim cant = texto.Text.Length
        Dim cant2 = texto.Text.Length

        If keyAscii = 8 Then
            cant = cant - 1
        Else
            cant = cant + 1
        End If

        keyAscii = CShort(Utilidades.SoloNumeros(keyAscii))

        If keyAscii = 0 Then e.Handled = True

        If cant = 4 And cant2 < cant Then
            texto.Text = texto.Text & e.KeyChar & "-"
            e.Handled = True
            texto.Select(texto.Text.Length, 0)
        End If
    End Sub

    Public Class OrdenarColumnaNumerica
        Implements IComparer

        Private ReadOnly _sortOrderModifier As Integer = 1
        Private ReadOnly _col As Integer = 0

        Public Sub New(ByVal sortOrder As SortOrder, ByVal columna As Integer)
            _col = columna
            If sortOrder = sortOrder.Descending Then
                _sortOrderModifier = -1
            ElseIf sortOrder = sortOrder.Ascending Then
                _sortOrderModifier = 1
            End If
        End Sub

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
            Implements IComparer.Compare

            Dim dataGridViewRow1 As DataGridViewRow = CType(x, DataGridViewRow)
            Dim dataGridViewRow2 As DataGridViewRow = CType(y, DataGridViewRow)

            Return (Math.Sign(CLng(dataGridViewRow1.Cells(_col).Value) - CLng(dataGridViewRow2.Cells(_col).Value))) * _sortOrderModifier
        End Function
    End Class

    Public Sub CambiarColorCelda(ByVal dataGridView As DataGridView, ByVal columna As Integer, ByVal fila As Integer)
        dataGridView.Item(columna, fila).Style.BackColor = Color.OrangeRed
    End Sub

    Public Sub VerificarExistencias(ByVal textBox As TextBox)
        If CDbl(textBox.Text) < 0 Then
            textBox.BackColor = Color.OrangeRed
        Else
            textBox.BackColor = System.Drawing.SystemColors.Window
        End If
    End Sub

    Public Sub FormatoFecha(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))

        Dim texto As TextBox = sender

        Dim cant = texto.Text.Length
        Dim cant2 = texto.Text.Length

        If keyAscii = 8 Then
            cant = cant - 1
        Else
            cant = cant + 1
        End If

        Dim num = keyAscii
        keyAscii = CShort(Utilidades.SoloNumeros(keyAscii))

        If keyAscii = 0 And num <> 47 Then
            e.Handled = True
        Else
            Dim letraAnterior = String.Empty
            Dim numSlah = 0
            If (cant2 >= 1) Then
                letraAnterior = texto.Text.Substring(cant2 - 1, 1)
                numSlah = texto.Text.Split("/").Length - 1
            End If
            If num = 47 Then
                If letraAnterior <> "/" And numSlah <= 2 Then
                    If cant = 2 And cant2 < cant Then
                        texto.Text = "0" & texto.Text
                        texto.Select(texto.Text.Length, 0)
                    End If

                    If cant = 5 And cant2 < cant Then
                        texto.Text = texto.Text.Insert(3, "0")
                        texto.Select(texto.Text.Length, 0)
                    End If
                Else
                    e.Handled = True
                End If
            Else
                If cant = 2 And cant2 < cant Then
                    texto.Text = texto.Text & e.KeyChar & "/"
                    e.Handled = True
                    texto.Select(texto.Text.Length, 0)
                End If

                If cant = 5 And cant2 < cant Then
                    texto.Text = texto.Text & e.KeyChar & "/"
                    e.Handled = True
                    texto.Select(texto.Text.Length, 0)
                End If
            End If

        End If

    End Sub
End Module
