

Public Class Form1
    Dim objeto As New ClassXml
    Dim tecla As New System.Windows.Forms.Keys()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button5.Text = "<<"
        Button4.Text = ">>"
        Button6.Text = "build"
        Label1.Text = "Nombre"
        Label2.Text = "Apellidos"
        Label3.Text = "N.S.S"
        Label4.Text = "Telefono fijo"
        Label5.Text = "Telefono movil"
        Button1.Text = "Cargar "
        Button2.Text = "-->"
        Button3.Text = "<--"
        Label6.Text = "[_________]"
        Label7.Text = "[_________]"
        Label8.Text = "[_________]"
        Label9.Text = "[_________]"
        Label10.Text = "[_________]"
        Button1.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objeto.abrirArchivo(Ruta())
        carga()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        objeto.paAlante()
        carga()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        objeto.paAtras()
        carga()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        objeto.palFinal()
        carga()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        objeto.palPrincipio()
        carga()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (objeto.path(TextBox1.Text)) Then
            Button1.Enabled = True

        End If
    End Sub
    Private Sub carga()
        Label6.Text = objeto.nombre
        Label7.Text = objeto.ape
        Label8.Text = objeto.SS
        Label9.Text = objeto.tlff
        Label10.Text = objeto.tlfm

    End Sub
    Private Function Ruta() As String
        Dim file As New OpenFileDialog
        Dim rut As String = " "
        file.Filter = "Tipo de arcivo *|*"
        file.FileName = "Archivo de programa"
        If (file.ShowDialog = 1) Then
            rut = file.FileName
        End If
        Return rut
    End Function



End Class
