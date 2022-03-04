Public Class Form1
    
    Function Restar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero - 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function
    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero + 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeroEntrante As String = Label3.Text
        numeroEntrante = Restar(numeroEntrante)
        Label3.Text = numeroEntrante
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numeroEntrante As String = Label4.Text
        numeroEntrante = Restar(numeroEntrante)
        Label4.Text = numeroEntrante
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numeroEntrante As String = Label3.Text
        numeroEntrante = Aumentar(numeroEntrante)
        Label3.Text = numeroEntrante
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim numeroEntrante As String = Label4.Text
        numeroEntrante = Aumentar(numeroEntrante)
        Label4.Text = numeroEntrante
    End Sub
    Function Suma(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA + numB
        Return resultado
    End Function
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim txtA = Label3.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Label4.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoSuma = Suma(numA, numB)
        Label6.Text = resultadoSuma.ToString()
    End Sub
    Function Resta(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA - numB
        Return resultado
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim txtA = Label3.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Label4.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoResta = Resta(numA, numB)
        Label6.Text = resultadoResta.ToString()
    End Sub
    Function Multiplicar(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA * numB
        Return resultado
    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim txtA = Label3.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Label4.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoMult = Multiplicar(numA, numB)
        Label6.Text = resultadoMult.ToString()
    End Sub
    Function Dividir(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA / numB
        Return resultado
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim txtA = Label3.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Label4.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoDiv = Dividir(numA, numB)
        Label6.Text = resultadoDiv.ToString()
    End Sub
    Sub limpiar()
        Label3.Text = "0"
        Label4.Text = "0"
        Label6.Text = ""
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        limpiar()
    End Sub
End Class
