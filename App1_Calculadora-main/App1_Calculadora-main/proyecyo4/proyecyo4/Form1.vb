Public Class Form1
    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Dim Numero1 As Integer = Integer.Parse(Caja1.Text)
        Dim Numero2 As Integer = Integer.Parse(Caja2.Text)
        Dim Resultado As Integer = Numero1 + Numero2
        Etiqueta4.Text = Resultado.ToString()
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        Dim Numero1 As Integer = Integer.Parse(Caja1.Text)
        Dim Numero2 As Integer = Integer.Parse(Caja2.Text)
        Dim Resultado As Integer = Numero1 - Numero2
        Etiqueta4.Text = Resultado.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        Dim Numero1 As Integer = Integer.Parse(Caja1.Text)
        Dim Numero2 As Integer = Integer.Parse(Caja2.Text)
        Dim Resultado As Integer = Numero1 * Numero2
        Etiqueta4.Text = Resultado.ToString()
    End Sub

    Private Sub Boton3_Click(sender As Object, e As EventArgs) Handles Boton3.Click
        Dim Numero1 As Integer = Integer.Parse(Caja1.Text)
        Dim Numero2 As Integer = Integer.Parse(Caja2.Text)
        Dim Resultado As Integer = Numero1 / Numero2
        Etiqueta4.Text = Resultado.ToString()
    End Sub
End Class
