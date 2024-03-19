Public Class Form1
    Dim aguinaldo_acum As Double = 0
    Dim impuestos_acum As Double = 0
    Dim sueldo As Double
    Dim años As Byte
    Dim aguinaldo_sub As Double
    Dim aguinaldo_tot As Double
    Dim impuestos As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sueldo = txtb_sueldo.Text
        años = txtb_años.Text


        'Calcular el aguinaldo bruto

        If años < 1 Then
            aguinaldo_sub = sueldo * 15
        ElseIf años >= 1 And años < 2 Then
            aguinaldo_sub = sueldo * 18
        ElseIf años >= 2 And años < 5 Then
            aguinaldo_sub = sueldo * 20
        ElseIf años >= 5 And años < 10 Then
            aguinaldo_sub = sueldo * 25
        ElseIf años >= 10 Then
            aguinaldo_sub = sueldo * 30
        End If


        'Calcular impuestos

        impuestos = (aguinaldo_sub * 0.098)


        'Calcular el aguinaldo neto
        aguinaldo_tot = aguinaldo_sub - impuestos

        'Acumular aguinaldo
        aguinaldo_acum += aguinaldo_tot

        'Acumular impuestos
        impuestos_acum += impuestos



        'Imprimir resultados en el formulario

        lbl_aguinaldo.Text = Math.Round(aguinaldo_tot, 2)

        lbl_aguinaldo_t.Text = Math.Round(aguinaldo_acum, 2)

        lbl_impuestos_t.Text = Math.Round(impuestos_acum, 2)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Limpiar text box

        txtb_empleado.Clear()
        txtb_años.Clear()
        txtb_sueldo.Clear()


        'Limpiar label de aguinaldo a pagar

        lbl_aguinaldo.Text = ""


    End Sub
End Class
