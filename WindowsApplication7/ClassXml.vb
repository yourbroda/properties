Imports System.Xml
Public Class ClassXml
    Dim documento As New XmlDocument
    Public Property nombre As String
        Get
            nombre = nombre1

        End Get
        Set(value As String)
            nombre1 = value
        End Set
    End Property
    Private nombre1 As String
    Public Property ape As String
        Get
            ape = apellidos
        End Get
        Set(value As String)
            apellidos = value
        End Set
    End Property
    Dim apellidos As String
    Public Property SS As String
        Get
            SS = numeroSS

        End Get
        Set(value As String)
            numeroSS = value
        End Set
    End Property
    Dim numeroSS As String
    Public Property tlff As String
        Get
            tlff = tlfFijoS

        End Get
        Set(value As String)
            tlfFijoS = value
        End Set
    End Property
    Dim tlfFijoS As String
    Public Property tlfm As String
        Get
            tlfm = tlfMovilS

        End Get
        Set(value As String)
            tlfMovilS = value

        End Set
    End Property
    Dim tlfMovilS As String

    Dim estructura As String

    Dim listaEmpleados As XmlNodeList = Nothing
    Dim unEmpleado As XmlNode
    Dim cont As Integer = 0

    Public Sub abrirArchivo(ruta As String)


        documento.Load(ruta)

        Try
            unEmpleado = listaEmpleados.Item(cont)

            'Seleccionamos el id del empleado.
            Dim idEmpleado As Integer = Convert.ToInt32(unEmpleado.SelectSingleNode("idEmpleado").InnerText)







            nombre = unEmpleado.SelectSingleNode("nombre").InnerText


            apellidos = unEmpleado.SelectSingleNode("apellidos").InnerText


            numeroSS = unEmpleado.SelectSingleNode("numeroSS").InnerText


            Dim telefonos As XmlNodeList = unEmpleado.SelectSingleNode("telefonos").ChildNodes


            Dim tlfFijo As XmlNode = telefonos(0)
            Dim tlfMovil As XmlNode = telefonos(1)

            tlfFijoS = tlfFijo.InnerText
            tlfMovilS = tlfMovil.InnerText

        Catch ex As Exception
            cont = 0
            MsgBox("No hay datos")

            unEmpleado = listaEmpleados.Item(cont)

            'Seleccionamos el id del empleado.
            Dim idEmpleado As Integer = Convert.ToInt32(unEmpleado.SelectSingleNode("idEmpleado").InnerText)







            nombre = unEmpleado.SelectSingleNode("nombre").InnerText




            apellidos = unEmpleado.SelectSingleNode("apellidos").InnerText


            numeroSS = unEmpleado.SelectSingleNode("numeroSS").InnerText


            Dim telefonos As XmlNodeList = unEmpleado.SelectSingleNode("telefonos").ChildNodes


            Dim tlfFijo As XmlNode = telefonos(0)
            Dim tlfMovil As XmlNode = telefonos(1)

            tlfFijoS = tlfFijo.InnerText
            tlfMovilS = tlfMovil.InnerText

        End Try

    End Sub
    Public Sub paAlante()
        cont = cont + 1
        Try
            unEmpleado = listaEmpleados.Item(cont)

            'Seleccionamos el id del empleado.
            Dim idEmpleado As Integer = Convert.ToInt32(unEmpleado.SelectSingleNode("idEmpleado").InnerText)




            Console.WriteLine()


            nombre = unEmpleado.SelectSingleNode("nombre").InnerText


            apellidos = unEmpleado.SelectSingleNode("apellidos").InnerText


            numeroSS = unEmpleado.SelectSingleNode("numeroSS").InnerText


            Dim telefonos As XmlNodeList = unEmpleado.SelectSingleNode("telefonos").ChildNodes


            Dim tlfFijo As XmlNode = telefonos(0)
            Dim tlfMovil As XmlNode = telefonos(1)

            tlfFijoS = tlfFijo.InnerText
            tlfMovilS = tlfMovil.InnerText

        Catch ex As Exception
            cont = 0
            MsgBox("No hay datos")

            unEmpleado = listaEmpleados.Item(cont)

            'Seleccionamos el id del empleado.
            Dim idEmpleado As Integer = Convert.ToInt32(unEmpleado.SelectSingleNode("idEmpleado").InnerText)




            Console.WriteLine()


            nombre = unEmpleado.SelectSingleNode("nombre").InnerText


            apellidos = unEmpleado.SelectSingleNode("apellidos").InnerText


            numeroSS = unEmpleado.SelectSingleNode("numeroSS").InnerText


            Dim telefonos As XmlNodeList = unEmpleado.SelectSingleNode("telefonos").ChildNodes


            Dim tlfFijo As XmlNode = telefonos(0)
            Dim tlfMovil As XmlNode = telefonos(1)

            tlfFijoS = tlfFijo.InnerText
            tlfMovilS = tlfMovil.InnerText

        End Try
    End Sub
    Public Sub paAtras()
        cont = cont - 1
        Try
            unEmpleado = listaEmpleados.Item(cont)

            'Seleccionamos el id del empleado.
            Dim idEmpleado As Integer = Convert.ToInt32(unEmpleado.SelectSingleNode("idEmpleado").InnerText)




            Console.WriteLine()


            nombre = unEmpleado.SelectSingleNode("nombre").InnerText


            apellidos = unEmpleado.SelectSingleNode("apellidos").InnerText


            numeroSS = unEmpleado.SelectSingleNode("numeroSS").InnerText


            Dim telefonos As XmlNodeList = unEmpleado.SelectSingleNode("telefonos").ChildNodes


            Dim tlfFijo As XmlNode = telefonos(0)
            Dim tlfMovil As XmlNode = telefonos(1)

            tlfFijoS = tlfFijo.InnerText
            tlfMovilS = tlfMovil.InnerText

        Catch ex As Exception
            cont = listaEmpleados.Count - 1
            MsgBox("No hay datos")

            unEmpleado = listaEmpleados.Item(cont)

            'Seleccionamos el id del empleado.
            Dim idEmpleado As Integer = Convert.ToInt32(unEmpleado.SelectSingleNode("idEmpleado").InnerText)




            Console.WriteLine()


            nombre = unEmpleado.SelectSingleNode("nombre").InnerText


            apellidos = unEmpleado.SelectSingleNode("apellidos").InnerText


            numeroSS = unEmpleado.SelectSingleNode("numeroSS").InnerText


            Dim telefonos As XmlNodeList = unEmpleado.SelectSingleNode("telefonos").ChildNodes


            Dim tlfFijo As XmlNode = telefonos(0)
            Dim tlfMovil As XmlNode = telefonos(1)

            tlfFijoS = tlfFijo.InnerText
            tlfMovilS = tlfMovil.InnerText

        End Try
    End Sub
    Public Sub palPrincipio()
        cont = 0
        Try
            unEmpleado = listaEmpleados.Item(cont)

            'Seleccionamos el id del empleado.
            Dim idEmpleado As Integer = Convert.ToInt32(unEmpleado.SelectSingleNode("idEmpleado").InnerText)




            Console.WriteLine()


            nombre = unEmpleado.SelectSingleNode("nombre").InnerText


            apellidos = unEmpleado.SelectSingleNode("apellidos").InnerText


            numeroSS = unEmpleado.SelectSingleNode("numeroSS").InnerText


            Dim telefonos As XmlNodeList = unEmpleado.SelectSingleNode("telefonos").ChildNodes


            Dim tlfFijo As XmlNode = telefonos(0)
            Dim tlfMovil As XmlNode = telefonos(1)

            tlfFijoS = tlfFijo.InnerText
            tlfMovilS = tlfMovil.InnerText

        Catch ex As Exception
            cont = 0
            MsgBox("No hay datos")

            unEmpleado = listaEmpleados.Item(cont)

            'Seleccionamos el id del empleado.
            Dim idEmpleado As Integer = Convert.ToInt32(unEmpleado.SelectSingleNode("idEmpleado").InnerText)




            Console.WriteLine()


            nombre = unEmpleado.SelectSingleNode("nombre").InnerText


            apellidos = unEmpleado.SelectSingleNode("apellidos").InnerText


            numeroSS = unEmpleado.SelectSingleNode("numeroSS").InnerText


            Dim telefonos As XmlNodeList = unEmpleado.SelectSingleNode("telefonos").ChildNodes


            Dim tlfFijo As XmlNode = telefonos(0)
            Dim tlfMovil As XmlNode = telefonos(1)

            tlfFijoS = tlfFijo.InnerText
            tlfMovilS = tlfMovil.InnerText

        End Try
    End Sub
    Public Sub palFinal()
        cont = listaEmpleados.Count - 1
        Try
            unEmpleado = listaEmpleados.Item(cont)

            'Seleccionamos el id del empleado.
            Dim idEmpleado As Integer = Convert.ToInt32(unEmpleado.SelectSingleNode("idEmpleado").InnerText)




            Console.WriteLine()


            nombre = unEmpleado.SelectSingleNode("nombre").InnerText


            apellidos = unEmpleado.SelectSingleNode("apellidos").InnerText


            numeroSS = unEmpleado.SelectSingleNode("numeroSS").InnerText


            Dim telefonos As XmlNodeList = unEmpleado.SelectSingleNode("telefonos").ChildNodes


            Dim tlfFijo As XmlNode = telefonos(0)
            Dim tlfMovil As XmlNode = telefonos(1)

            tlfFijoS = tlfFijo.InnerText
            tlfMovilS = tlfMovil.InnerText

        Catch ex As Exception
            cont = 0
            MsgBox("No hay datos")

            unEmpleado = listaEmpleados.Item(cont)

            'Seleccionamos el id del empleado.
            Dim idEmpleado As Integer = Convert.ToInt32(unEmpleado.SelectSingleNode("idEmpleado").InnerText)




            Console.WriteLine()


            nombre = unEmpleado.SelectSingleNode("nombre").InnerText


            apellidos = unEmpleado.SelectSingleNode("apellidos").InnerText


            numeroSS = unEmpleado.SelectSingleNode("numeroSS").InnerText


            Dim telefonos As XmlNodeList = unEmpleado.SelectSingleNode("telefonos").ChildNodes


            Dim tlfFijo As XmlNode = telefonos(0)
            Dim tlfMovil As XmlNode = telefonos(1)

            tlfFijoS = tlfFijo.InnerText
            tlfMovilS = tlfMovil.InnerText

        End Try
    End Sub
    Public Function path(camino As String) As Boolean
        estructura = camino
        listaEmpleados = documento.SelectNodes(estructura)
        Return True
    End Function

End Class
