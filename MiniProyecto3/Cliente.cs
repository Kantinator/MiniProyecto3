using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Celular { get; set; }

    // Constructor principal
    public Cliente(string nombre, string correo, string celular)
    {
        Nombre = nombre;
        Correo = correo;
        Celular = celular;
    }

    // Constructor adicional para ListarPorPlan
    public Cliente(int idCliente, string nombre)
    {
        IdCliente = idCliente;
        Nombre = nombre;
    }

    // Método para crear un cliente en la base de datos
    public bool CrearCliente()
    {
        try
        {
            using (var conexion = new SqlConnection("tu_conexion_a_base_de_datos"))
            {
                conexion.Open();
                string consulta = "INSERT INTO Clientes (Nombre, Correo, Celular) VALUES (@Nombre, @Correo, @Celular)";

                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                    comando.Parameters.AddWithValue("@Correo", this.Correo);
                    comando.Parameters.AddWithValue("@Celular", this.Celular);

                    int resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al crear el cliente: " + ex.Message);
            return false;
        }
    }

    // Método para listar clientes por plan
    public static List<Cliente> ListarPorPlan(int idPlan)
    {
        List<Cliente> clientes = new List<Cliente>();

        try
        {
            using (SqlConnection conexion = new SqlConnection("tu_conexion_a_base_de_datos"))
            {
                string consulta = @"SELECT Cliente.id_cliente, Cliente.nombre_cliente 
                                    FROM Cliente 
                                    JOIN Afiliacion ON Cliente.id_cliente = Afiliacion.id_cliente 
                                    WHERE Afiliacion.id_plan = @IdPlan";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdPlan", idPlan);
                conexion.Open();

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        //usamos el segundo constructor
                        clientes.Add(new Cliente(lector.GetInt32(0), lector.GetString(1)));
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al listar clientes por plan: " + ex.Message);
        }

        return clientes;
    }
}
