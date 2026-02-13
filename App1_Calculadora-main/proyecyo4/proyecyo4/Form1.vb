Public Class Form1
    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Mas.Click
        Dim Numero1 As Integer = Integer.Parse(Num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Num2.Text)
        Dim Resultado As Integer = Numero1 + Numero2
        Etiqueta4.Text = Resultado.ToString()
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Resta.Click
        Dim Numero1 As Integer = Integer.Parse(Num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Num2.Text)
        Dim Resultado As Integer = Numero1 - Numero2
        Etiqueta4.Text = Resultado.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Por.Click
        Dim Numero1 As Integer = Integer.Parse(Num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Num2.Text)
        Dim Resultado As Integer = Numero1 * Numero2
        Etiqueta4.Text = Resultado.ToString()
    End Sub

    Private Sub Boton3_Click(sender As Object, e As EventArgs) Handles Dividir.Click
        Dim Numero1 As Integer = Integer.Parse(Num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Num2.Text)
        Dim Resultado As Integer = Numero1 / Numero2
        Etiqueta4.Text = Resultado.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Boton0_Click(sender As Object, e As EventArgs) Handles Boton0.Click
        Num1.Text = Num1.Text & "0"
    End Sub

    Private Sub Boton1_Click_1(sender As Object, e As EventArgs) Handles Boton1.Click
        Num1.Text = Num1.Text & "1"
    End Sub

    Private Sub Boton2_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        Num1.Text = Num1.Text & "2"
    End Sub

    Private Sub Boton3_Click_1(sender As Object, e As EventArgs) Handles Boton3.Click
        Num1.Text = Num1.Text & "3"
    End Sub

    Private Sub Boton4_Click(sender As Object, e As EventArgs) Handles Boton4.Click
        Num1.Text = Num1.Text & "4"
    End Sub

    Private Sub Boton5_Click(sender As Object, e As EventArgs) Handles Boton5.Click
        Num1.Text = Num1.Text & "5"
    End Sub

    Private Sub Boton6_Click(sender As Object, e As EventArgs) Handles Boton6.Click
        Num1.Text = Num1.Text & "6"
    End Sub

    Private Sub Boton7_Click(sender As Object, e As EventArgs) Handles Boton7.Click
        Num1.Text = Num1.Text & "7"
    End Sub

    Private Sub Boton8_Click(sender As Object, e As EventArgs) Handles Boton8.Click
        Num1.Text = Num1.Text & "8"
    End Sub

    Private Sub Boton9_Click(sender As Object, e As EventArgs) Handles Boton9.Click
        Num1.Text = Num1.Text & "9"
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Num1.Text = "0"
    End Sub

    Private Sub Etiqueta4_Click(sender As Object, e As EventArgs) Handles Etiqueta4.Click

    End Sub
End Class
