Imports System.Reflection

Public Class Form1

    Dim importe As Double
    Dim tarjeta, efectivo, cheque As Double
    Dim suma As Double
    Dim magna, premium, diesel As Double 'Acumuladores gasolina (Litros)
    Dim suma_litros As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If rb_magna.Checked Then
            importe = Math.Round(Val(Txtb_magna.Text) * Val(txtb_litros.Text), 2)
            magna += Math.Round(Val(txtb_litros.Text), 2)
            TOTAL_MAGNA.Text = Math.Round(magna, 2)
        ElseIf rb_premium.Checked Then
            importe = Math.Round(Val(Txtb_premium.Text) * Val(txtb_litros.Text), 2)
            premium += Math.Round(Val(txtb_litros.Text), 2)
            TOTAL_PREMIUM.Text = Math.Round(premium, 2)
        Else
            importe = Math.Round(Val(Txtb_diesel.Text) * Val(txtb_litros.Text), 2)
            diesel += Math.Round(Val(txtb_litros.Text), 2)
            TOTAL_DIESEL.Text = Math.Round(diesel, 2)
        End If

        'Suma de litros de gasolina
        suma_litros = Math.Round((magna + premium + diesel), 2)

        'Mostrar suma de los litros
        lbl_suma_combustible.Text = Math.Round(suma_litros, 2)

        'Mostrar importe
        lbl_importe.Text = Math.Round(importe, 2)

        'Mostrar la suma del dinero por tipo de combustible
        lbl_magna_din.Text = Math.Round(magna * Val(Txtb_magna.Text), 2)
        lbl_premium_din.Text = Math.Round(premium * Val(Txtb_premium.Text), 2)
        lbl_diesel_din.Text = Math.Round(diesel * Val(Txtb_diesel.Text), 2)

        'Mostrar suma en los combustibles
        suma_tipo_comb.Text = Math.Round(suma, 2)

        If rb_efectivo.Checked Then
            efectivo += importe
            Total_efectivo.Text = Math.Round(efectivo, 2)
        ElseIf Rb_tarjeta.Checked Then
            tarjeta += importe
            Total_tarjeta.Text = Math.Round(tarjeta, 2)
        Else
            cheque += importe
            total_cheque_lbl.Text = Math.Round(cheque, 2)
        End If

        'Suma 
        suma = efectivo + tarjeta + cheque

        'Mostrar suma
        lbl_suma_pagos.Text = Math.Round(suma, 2)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtb_litros.Clear()
        lbl_importe.Text = ""
        rb_premium.Checked = True
        rb_efectivo.Checked = True
    End Sub
End Class
