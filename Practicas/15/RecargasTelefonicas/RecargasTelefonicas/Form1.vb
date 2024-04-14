Imports RecargasTelefonicas.validaciones.Validaciones
Imports System.IO

Public Class Form1
    Dim cadena As String 'Cadena principal a mandar al archivo
    Dim ARCHIVO As System.IO.StreamWriter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If numero_telefonico() = False Then 'Cacncela el subprograma y no envia los datos si no estan validados
            Return
        End If

        If monto_recarga() = False Then
            Return
        End If

        ' FORMATO DE CADENA A ENVIAR A EL ARCHIVO:
        ' DD/MM/AAAA,12345678,C,000
        ' Donde DD/MM/AAAA corresponde a la fecha de recarga
        ' 12345678 corresponde al numero de celular
        ' C es la compañia 
        ' 000 es el monto de la recarga

        cadena = fecha_recarga() & ","
        cadena += numero_telefonico() & ","
        cadena += compañia() & ","
        cadena += monto_recarga()

        'Agregar datos a listbox

        ListBox1.Items.Add(cadena)

        'Agregar datos al archivo .txt

        ARCHIVO.WriteLine(cadena)
        ARCHIVO.Flush()

        'Limpar los datos del formulario
        limpiar()

    End Sub


    Public Function fecha_recarga() As String
        Dim fecha As String

        fecha = Date.Today

        Return fecha


    End Function

    Public Function compañia() As String

        Dim compañia_recarga As String

        If rb_telcel.Checked = True Then
            compañia_recarga = "T"
        ElseIf rb_atyt.Checked = True Then
            compañia_recarga = "A"
        ElseIf rb_movistar.Checked = True Then
            compañia_recarga = "M"
        ElseIf rb_pillofon.Checked = True Then
            compañia_recarga = "P"
        Else
            compañia_recarga = "U"
        End If

        Return compañia_recarga

    End Function

    Public Function monto_recarga() As String
        Dim monto As String

        monto = cbx_monto.Text

        If monto = "" Then
            MsgBox("Seleccione un monto", MsgBoxStyle.OkOnly)
            Return False
        End If

        If Len(monto) < 3 Then
            monto = "0" & cbx_monto.Text
        End If

        Return monto
    End Function

    Public Function numero_telefonico() As String
        Dim numero As String = ""



        numero = txb_numero_1.Text

        If validaciones.Validaciones.numerotelefonico(numero) = True Then
            MsgBox("El numero telefonico no es valido. Revis de nuevo", MsgBoxStyle.OkOnly)
            Return False
        End If

        If numero <> txb_num_2.Text Then
            MsgBox("El numero telefonico no coincide. Revise de nuevo", MsgBoxStyle.OkOnly)
            Return False
        End If

        Return numero



    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txb_numero_1.ShortcutsEnabled = False 'Desactiva el copiar y pegar
        ARCHIVO = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Carlos Urias\Desktop\recargas\recargas.txt", True)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Beep()
        Close()
        End
    End Sub

    Public Function limpiar()
        rb_telcel.Checked = True 'Activa el primer radio button
        cbx_monto.SelectedIndex = -1
        txb_numero_1.Clear()
        txb_num_2.Clear()


    End Function
End Class
