using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAHO
{
    public partial class BuscarReserva : Form
    {
        int n;
        DataSet ds;

        public BuscarReserva()
        {
            InitializeComponent();
        }

        private void BuscarReserva_Load(object sender, EventArgs e)
        {

            



        }

        private void buscar_Click(object sender, EventArgs e)
        {
            n=Convert.ToInt32(numero.Text);


        



            try
            {
                string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=reserva;";
                string Query = "select cliente.nombres_apellidos, cliente.nacionalidad, habitacion.tipo_habitacion, habitacion.precio, reserva.fecha_entrada,reserva.fecha_salida, reserva.gasto_total FROM cliente INNER JOIN reserva ON cliente.cedula_pasaporte = reserva.cedula_pasaporte INNER join habitacion on cliente.cedula_pasaporte=habitacion.cedula_pasaporte where cliente.cedula_pasaporte=('" + n + "')";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                MessageBox.Show("busqueda realizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }








    //        MySqlDataAdapter con = new MySqlDataAdapter();
    //ds=new DataSet();
  
    //pantalla.DataSource = ds.Tables[1];
        }
    }
}
