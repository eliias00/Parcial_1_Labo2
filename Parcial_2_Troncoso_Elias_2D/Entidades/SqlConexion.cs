using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Excepciones;

namespace Entidades
{
    public static class SqlConexion
    {
        static SqlConnection sqlConexion;
        static SqlCommand sqlComando;
        static SqlDataReader dr;
        /// <summary>
        /// Establece el server a conectar (Temas: SQL y Base de Datos).
        /// </summary>
        static SqlConexion()
        {
            sqlConexion = new SqlConnection("Server = DESKTOP-SGS1I29\\SQLEXPRESS07 ; Database=Parcial_2 ; Trusted_Connection = True");
            sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexion;
        }
        public static bool Conexion(string query)
        {
            bool retorno = false;

            sqlComando.Connection = sqlConexion;
            try
            {
                sqlComando.CommandText = query;
                sqlConexion.Open();

                if (sqlComando.ExecuteNonQuery() > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new sqlErrorExc(ex);
            }
            finally
            {
                sqlConexion.Close();
            }
            return retorno;
        }
        public static bool Insert(PedidosVan pedido)
        {
            string query = "Insert into PedidosVan(Producto, NumPedido, Domicilio, Telefono, EstPedido, Delivery)" +
                " values (@auxProd, @auxNumPedido, @auxDomicilio, @auxTelefono, @auxEstPed, @auxDelivery)";

            sqlComando.Parameters.Clear();
            sqlComando.Parameters.Add(new SqlParameter("@auxProd", pedido.Productos.ToString()));
            sqlComando.Parameters.Add(new SqlParameter("@auxNumPedido", pedido.NumPedido));
            sqlComando.Parameters.Add(new SqlParameter("@auxDomicilio", pedido.Domicilio));
            sqlComando.Parameters.Add(new SqlParameter("@auxTelefono", pedido.Telefono));
            sqlComando.Parameters.Add(new SqlParameter("@auxEstPed", pedido.EstadoPedido));
            sqlComando.Parameters.Add(new SqlParameter("@auxDelivery", pedido.DelivRequerimiento.ToString()));
            return Conexion(query);

        }
        public static bool Update(PedidosVan pedido)
        {
            string query = "Update PedidosVan set EstPedido = @auxEstPed where NumPedido = @auxNumPedido";

            sqlComando.Parameters.Clear();
            sqlComando.Parameters.Add(new SqlParameter("@auxNumPedido", pedido.NumPedido));
            sqlComando.Parameters.Add(new SqlParameter("@auxEstPed", pedido.EstadoPedido));
            return Conexion(query);
        }
    }
}
