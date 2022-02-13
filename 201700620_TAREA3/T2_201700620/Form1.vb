Public Class Form1
    Private Sub button_calcular_Click(sender As Object, e As EventArgs) Handles button_calcular.Click
        If (check_compra.Checked) Then
            calculo_compra()
        End If
        If (check_venta.Checked) Then
            calculo_venta()
        End If
    End Sub

    Private Sub calculo_compra()
        If (text_compra.Text.Equals("")) Then
            MsgBox("¡ERROR! No se ha ingresado ninguna cantidad a comprar.")
        Else
            Dim valor_compra As Double = text_compra.Text
            Dim valor_moneda = 1.0
            Dim seleccion_moneda = False
            If (check_dolar_compra.Checked) Then
                valor_moneda = 7.69
            ElseIf (check_peso_compra.Checked) Then
                valor_moneda = 0.38
            ElseIf (check_euro_compra.Checked) Then
                valor_moneda = 8.79
            ElseIf (check_colon_compra.Checked) Then
                valor_moneda = 0.012
            End If
            If (valor_moneda = 1) Then
                MsgBox("¡ERROR! No se ha seleccionado la moneda a comprar.")
            Else
                Dim total_compra = (valor_compra / valor_moneda)
                total_compra = total_compra + (total_compra * 0.025)
                label_total_compra.Text = "TOTAL COMPRA (#):" + Math.Round(total_compra, 2).ToString()
            End If
        End If
    End Sub

    Private Sub calculo_venta()
        If (text_venta.Text.Equals("")) Then
            MsgBox("¡ERROR! No se ha ingresado ninguna cantidad a vender.")
        Else
            Dim valor_venta As Double = text_venta.Text
            Dim valor_moneda = 1.0
            If (check_dolar_venta.Checked) Then
                valor_moneda = 7.69
            ElseIf (check_peso_venta.Checked) Then
                valor_moneda = 0.38
            ElseIf (check_euro_venta.Checked) Then
                valor_moneda = 8.79
            ElseIf (check_colon_venta.Checked) Then
                valor_moneda = 0.012
            End If
            If (valor_moneda = 1) Then
                MsgBox("¡ERROR! No se ha seleccionado la moneda a vender.")
            Else
                Dim total_venta = (valor_venta * valor_moneda)
                total_venta = total_venta + (total_venta * 0.03)
                label_total_venta.Text = "TOTAL VENTA (Q):" + Math.Round(total_venta, 2).ToString()
            End If
        End If
    End Sub

    Private Sub button_limpiar_Click(sender As Object, e As EventArgs) Handles button_limpiar.Click
        check_compra.Checked = False
        check_venta.Checked = False

        text_compra.Text = ""
        text_venta.Text = ""

        check_dolar_compra.Checked = False
        check_peso_compra.Checked = False
        check_euro_compra.Checked = False
        check_colon_compra.Checked = False

        check_dolar_venta.Checked = False
        check_peso_venta.Checked = False
        check_euro_venta.Checked = False
        check_colon_venta.Checked = False

        label_total_compra.Text = "TOTAL COMPRA (#):"
        label_total_venta.Text = "TOTAL VENTA (Q):"
    End Sub

    Private Sub button_salir_Click(sender As Object, e As EventArgs) Handles button_salir.Click
        Dim result = MsgBox("¿Estás seguro de querer salir?", vbYesNo)
        If result = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class
