Public Class form1
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim cantidad_ladrillos As Integer
        Dim precio_unitario As Double
        Dim importe As Double

        cantidad_ladrillos = txtb_cantidad.Text

        If cantidad_ladrillos >= 0 And cantidad_ladrillos <= 999 Then
            precio_unitario = 8.0
        ElseIf cantidad_ladrillos >= 1000 And cantidad_ladrillos <= 5000 Then
            precio_unitario = 7.5
        ElseIf cantidad_ladrillos >= 5001 And cantidad_ladrillos <= 100000 Then
            precio_unitario = 6.5
        ElseIf cantidad_ladrillos >= 100001 Then
            precio_unitario = 5.9
        End If


        importe = precio_unitario * cantidad_ladrillos

        Lbl_unit.Text = precio_unitario
        Lbl_total.Text = importe

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Lbl_total.Text = "_____________________________"
        Lbl_unit.Text = "_____________________________"

        txtb_cliente.Clear()
        txtb_cantidad.Clear()


    End Sub

End Class
