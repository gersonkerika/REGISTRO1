Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connectionString As String = "Server=localhost;Port=3306;Database=alikler_sillas;Uid=root;Pwd= teamo123;"
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)
    Dim adapter As MySqlDataAdapter
    Dim dataTable As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Sub LoadData()
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM alkiler"
            adapter = New MySqlDataAdapter(query, connection)
            dataTable = New DataTable()
            adapter.Fill(dataTable)
            ' DataGridView1.DataSource = dataTable ' No asignamos aquí porque lo haremos en Form2 o cuando sea necesario
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub BTNALKILAR_Click(sender As Object, e As EventArgs) Handles BTNALKILAR.Click
        Dim dni As String = txtdni.Text.Trim()
        Dim nombre As String = txtnombre.Text.Trim()
        Dim direccion As String = txtdireccion.Text.Trim()
        Dim celular As String = txtcelular.Text.Trim()
        Dim evento As String = txtevento.Text.Trim()

        ' Obtener y validar la cantidad de sillas
        Dim cantidadSillas As Integer
        If Not Integer.TryParse(txtsillas.Text, cantidadSillas) Then
            MessageBox.Show("Ingrese un número válido para la cantidad de sillas.")
            Return
        End If

        ' Validación básica de los datos (puedes expandir esto según tus necesidades)
        If dni = "" Or nombre = "" Or direccion = "" Or celular = "" Or evento = "" Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return
        End If

        Try
            connection.Open()
            Dim query As String = "INSERT INTO alkiler (dni, nombre, direccion, celular, evento_alkiler, cantidad_sillas, cantidad_dias, fecha_devolucion) " &
                              "VALUES (@dni, @nombre, @direccion, @celular, @evento, @cantidad_sillas, @cantidad_dias, @fecha_devolucion)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@dni", dni)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            cmd.Parameters.AddWithValue("@celular", celular)
            cmd.Parameters.AddWithValue("@evento", evento)
            cmd.Parameters.AddWithValue("@cantidad_sillas", cantidadSillas)
            cmd.Parameters.AddWithValue("@cantidad_dias", cantidadSillas)
            cmd.Parameters.AddWithValue("@fecha_devolucion", cantidadSillas)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Regisstro De Alkiler Completado.")
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error al almacenar los datos: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        ' Limpiar los campos después de ingresar los datos
        txtdni.Clear()
        txtnombre.Clear()
        txtdireccion.Clear()
        txtcelular.Clear()
        txtevento.Clear()
        txtsillas.Clear() ' Limpiar el TextBox de cantidad de sillas
        numCantidadSillas.Clear()
        TextBox1.Clear()
    End Sub
End Class
