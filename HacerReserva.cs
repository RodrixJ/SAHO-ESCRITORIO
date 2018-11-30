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
    public partial class HacerReserva : Form
    {
        public HacerReserva()
        {
            InitializeComponent();
        }
        //datos de cliente
        string nombrea;
        string nacionalid;
        string sexo;
        string tipo;
        string cedul;
        int totalg;
        int numdias=1;
        //servicios
        string sertv;
        string serinter;
        string serdesa;
        string seraire;
        int numc=0;
        int precio;

        
        int prueba = 1;
        int probando;

        //vaiables de precio
        int individua = 12;
        int matrimonia = 45;
        int tipotres = 60;
        int tele = 5;
        int air = 5;
        int inter = 6;
        int desa = 5;

        //control cantidad de cuarto 
        string[] cuartosin = new string[3];
        string[] cuartosma = new string[3];
        string[] cuartosdo = new string[3];


        private void HacerReserva_Load(object sender, EventArgs e)
        {
            //campos bloqueados
            nombre.Enabled = false;
            cedula.Enabled = false;
            nacionalidad.Enabled = false;
            dias.Enabled = false;
            cuarto.Enabled = false;
            fechae.Enabled = false;
            fechasa.Enabled = false;
            total.Enabled = false;
            m.Enabled = false;
            f.Enabled = false;
            tv.Enabled = false;
            internet.Enabled = false;
            aire.Enabled = false;
            desayuno.Enabled = false;
        }

        private void agregar_Click(object sender, EventArgs e)
        {

            //desbloquea campos al seleccionar un tipo habitacion
            
            if(indivudual.Checked==false && matrimonial.Checked==false && doble.Checked==false){
                MessageBox.Show("Elija tipo de habitacion");

            }
            else{
                m.Enabled = true;
                f.Enabled = true;
            nombre.Enabled = true;
            cedula.Enabled = true;
            nacionalidad.Enabled = true;
            dias.Enabled = true;
            cuarto.Enabled = true;
            fechae.Enabled = true;
            fechasa.Enabled = true;
            }
        }

        private void indivudual_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Individual";
            precio = 12;
            //control calculos automaticos de total basandose en el tipo de cuarto individual
          
            dias.Text = Convert.ToString(prueba);

            if (dias.Text != "")
            {

                individua = individua * Convert.ToInt32(dias.Text);

            }
            if (Convert.ToInt32(dias.Text) > 1)
            {
                dias.Text = Convert.ToString(prueba);
            }

            tv.Checked = false;
            internet.Checked = false;
            desayuno.Checked = false;
            aire.Checked = false;



            if (indivudual.Checked == true)
            {
                tv.Enabled = true;
                internet.Enabled = true;
                aire.Enabled = true;
                desayuno.Enabled = true;
           

                total.Text = Convert.ToString(individua);
                totalg = individua;
                individua=individua / Convert.ToInt32(dias.Text);

            }



        }

        private void matrimonial_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Matrimonial";
            precio = 25;
            //control calculos automaticos de total basandose en el tipo de cuarto matrimonial
            dias.Text = Convert.ToString(prueba);

            if (dias.Text == "")
            {
                matrimonia = matrimonia * Convert.ToInt32(dias.Text);
            }

           

            tv.Checked = false;
            internet.Checked = false;
            desayuno.Checked = false;
            aire.Checked = false;

            if (matrimonial.Checked == true)
            {
                tv.Enabled = true;
                internet.Enabled = true;
                aire.Enabled = true;
                desayuno.Enabled = true;
            }
            if (matrimonial.Checked == true)
            {

                total.Text = Convert.ToString(matrimonia);
                totalg = matrimonia;
                matrimonia = matrimonia / Convert.ToInt32(dias.Text);
            }
        }

        private void doble_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Doble";
            precio = 60;
            //control calculos automaticos de total basandose en el tipo de cuarto doble
           
             dias.Text = Convert.ToString(prueba);

             if (dias.Text != "")
             {

                 tipotres = tipotres * Convert.ToInt32(dias.Text);

             }


             if (Convert.ToInt32(dias.Text) > 1)
             {
                 dias.Text = Convert.ToString(prueba);
             }

            tv.Checked = false;
            internet.Checked = false;
            desayuno.Checked = false;
            aire.Checked = false;

            if (doble.Checked == true)
            {
                tv.Enabled = true;
                internet.Enabled = true;
                aire.Enabled = true;
                desayuno.Enabled = true;
            }

            if (doble.Checked == true)
            {

                total.Text = Convert.ToString(tipotres);
                totalg = tipotres;
                tipotres = tipotres / Convert.ToInt32(dias.Text);

            }
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            // asignacion del nombre
            nombrea = nombre.Text;


        }

        private void cedula_TextChanged(object sender, EventArgs e)
        {
            // asignacion cedula
            cedul = cedula.Text;
        }

        private void nacionalidad_TextChanged(object sender, EventArgs e)
        {
            // asignacion del nacionalidad
            nacionalid = nacionalidad.Text;
        }

        private void dias_TextChanged(object sender, EventArgs e)
        {

            //asignacion de dias en el hotel ademas calculo de de factura basandose en los dias que se hospedara
            probando = totalg;

         
                if (dias.Text != "")
                {
                    numdias = Convert.ToInt32(dias.Text);
                    totalg = totalg * numdias;
                    total.Text = Convert.ToString(totalg);

                }
                else
                {
                    if (dias.Text =="")
                    {

                        totalg = totalg / numdias;
                        if (totalg > 0)
                        {
                            total.Text = Convert.ToString(totalg);
                        }
                    }
                }
            }




            
           


        

        private void cuarto_TextChanged(object sender, EventArgs e)
        {
            numc = 3;

        }

        private void tv_CheckedChanged(object sender, EventArgs e)
        {
            sertv = "Utiliza";
            //calculo de factura basandose en los servicios de television

            if (tv.Checked == false)
            {
                if (Convert.ToInt32(dias.Text) > 1)
                {
                    tele = tele * Convert.ToInt32(dias.Text);
                }
               
                totalg = totalg - tele;
                total.Text = Convert.ToString(totalg);
                tele = tele / Convert.ToInt32(dias.Text);
           
            }
            else
            {
                if (tv.Checked == true)
                {
                    dias.Text = Convert.ToString(prueba);
                    if (dias.Text != "")
                    {
                        tele = tele * Convert.ToInt32(dias.Text);

                    }
                    if (indivudual.Checked == true)
                    {
                        totalg = individua + tele;
                        total.Text = Convert.ToString(totalg);
                 

                    }
                    if (matrimonial.Checked == true)
                    {
                        totalg = matrimonia + tele;
                        total.Text = Convert.ToString(totalg);
                        

                    }

                    if (doble.Checked == true)
                    {
                        totalg = tipotres + tele;
                        total.Text = Convert.ToString(totalg);
                      
                    }

                }

                if (internet.Checked == true)
                {
                    totalg = totalg + inter;
                    total.Text = Convert.ToString(totalg);
                }

                if (desayuno.Checked == true)
                {
                    totalg = totalg + desa;
                    total.Text = Convert.ToString(totalg);
                }

                if (aire.Checked == true)
                {
                    totalg = totalg + air;
                    total.Text = Convert.ToString(totalg);
                }
            }

        }

        private void internet_CheckedChanged(object sender, EventArgs e)
        {
            serinter = "Utiliza";

            //calculo de factura basandose en los servicios de internet
            if (internet.Checked == false)
            {
                if (Convert.ToInt32(dias.Text) > 1)
                {
                    inter = inter * Convert.ToInt32(dias.Text);
                }
               
                totalg = totalg - inter;
                total.Text = Convert.ToString(totalg);
                inter = inter / Convert.ToInt32(dias.Text);
           


            }
            else
            {

                if (internet.Checked == true)
                {
                    dias.Text = Convert.ToString(prueba);

                    if (dias.Text != "")
                    {
                        inter = inter * Convert.ToInt32(dias.Text);

                    }


                    if (indivudual.Checked == true)
                    {
                        totalg = individua + inter;
                        total.Text = Convert.ToString(totalg);
                        

                    }
                    if (matrimonial.Checked == true)
                    {
                        totalg = matrimonia + inter;
                        total.Text = Convert.ToString(totalg);
                     

                    }

                    if (doble.Checked == true)
                    {
                        totalg = tipotres + inter;
                        total.Text = Convert.ToString(totalg);
                      

                    }

                }

                if (tv.Checked == true)
                {
                    totalg = totalg + tele;
                    total.Text = Convert.ToString(totalg);
                }

                if (desayuno.Checked == true)
                {
                    totalg = totalg + desa;
                    total.Text = Convert.ToString(totalg);
                }

                if (aire.Checked == true)
                {
                    totalg = totalg + air;
                    total.Text = Convert.ToString(totalg);
                }


            }

        }

        private void aire_CheckedChanged(object sender, EventArgs e)
        {
            seraire = "Utiliza";
            if (aire.Checked == false)
            {
                if (Convert.ToInt32(dias.Text) > 1)
                {
                    air = air * Convert.ToInt32(dias.Text);
                }


                totalg = totalg - air;
                total.Text = Convert.ToString(totalg);
                air = air / Convert.ToInt32(dias.Text);
            }
            else
            {

                if (aire.Checked == true)
                {
                    dias.Text = Convert.ToString(prueba);
                    if (dias.Text != "")
                    {
                        air = air * Convert.ToInt32(dias.Text);

                    }

                    if (indivudual.Checked == true)
                    {
                        totalg = individua + air;
                        total.Text = Convert.ToString(totalg);
                     

                    }
                    if (matrimonial.Checked == true)
                    {
                        totalg = matrimonia + air;
                        total.Text = Convert.ToString(totalg);
                     

                    }

                    if (doble.Checked == true)
                    {
                        totalg = tipotres + air;
                        total.Text = Convert.ToString(totalg);
                       

                    }

                }

                if (internet.Checked == true)
                {
                    totalg = totalg + inter;
                    total.Text = Convert.ToString(totalg);
                }

                if (desayuno.Checked == true)
                {
                    totalg = totalg + desa;
                    total.Text = Convert.ToString(totalg);
                }

                if (tv.Checked == true)
                {
                    totalg = totalg + tele;
                    total.Text = Convert.ToString(totalg);
                }
            }

        }

        private void desayuno_CheckedChanged(object sender, EventArgs e)
        {
            serdesa = "Utiliza";
            //calculo de factura basandose en los servicios de dasayuno
           
            if (desayuno.Checked == false)
            {

                if (Convert.ToInt32(dias.Text) > 1)
                {
                    desa = desa * Convert.ToInt32(dias.Text);
                }

                totalg = totalg - desa;
                total.Text = Convert.ToString(totalg);
                air = desa / Convert.ToInt32(dias.Text);
              
            }
            else
            {

                if (desayuno.Checked == true)
                {
                    dias.Text = Convert.ToString(prueba);
                    if (dias.Text != "")
                    {
                        desa = desa * Convert.ToInt32(dias.Text);

                    }


                    if (indivudual.Checked == true)
                    {
                        totalg = individua + desa;
                        total.Text = Convert.ToString(totalg);
                       
                    }
                    if (matrimonial.Checked == true)
                    {
                        totalg = matrimonia + desa;
                        total.Text = Convert.ToString(totalg);
                     

                    }

                    if (doble.Checked == true)
                    {
                        totalg = tipotres + desa;
                        total.Text = Convert.ToString(totalg);
                     

                    }

                }

                if (internet.Checked == true)
                {
                    totalg = totalg + inter;
                    total.Text = Convert.ToString(totalg);
                }

                if (aire.Checked == true)
                {
                    totalg = totalg + air;
                    total.Text = Convert.ToString(totalg);
                }

                if (tv.Checked == true)
                {
                    totalg = totalg + tele;
                    total.Text = Convert.ToString(totalg);
                }

            }

        }

        private void nombre_Enter(object sender, EventArgs e)
        {
            //codigo borra contenido del campo
            if (nombre.Text == "Nombre y apellido del cliente")
            {
                nombre.Text = "";
                nombre.ForeColor = Color.LightGray;
            }
        }

        private void nombre_Leave(object sender, EventArgs e)
        {
          
            if (nombre.Text == "")
            {
                nombre.Text = "Nombre y apellido del cliente";
                nombre.ForeColor = Color.DimGray;
            }
        }

        private void cedula_Enter(object sender, EventArgs e)
        {
            if (cedula.Text == "Numero de cedula o pasaporte")
            {
                cedula.Text = "";
                cedula.ForeColor = Color.LightGray;
            }
        }

        private void cedula_Leave(object sender, EventArgs e)
        {
            //limpiar Campo
            if (cedula.Text == "")
            {
                cedula.Text = "Numero de cedula o pasaporte";
                cedula.ForeColor = Color.DimGray;
            }
        }

        private void nacionalidad_Enter(object sender, EventArgs e)
        {

            //limpiar campo
            if (nacionalidad.Text == "Nacionalidad")
            {
                nacionalidad.Text = "";
                nacionalidad.ForeColor = Color.LightGray;
            }
        }

        private void nacionalidad_Leave(object sender, EventArgs e)
        {

            {
                nacionalidad.Text = "Nacionalidad";
                nacionalidad.ForeColor = Color.DimGray;
            }
        }

        private void dias_Enter(object sender, EventArgs e)
        {
            //limpiar campo de dias 
            if (dias.Text == "Nro de dias a hospedar")
            {
                dias.Text = "";
                dias.ForeColor = Color.LightGray;
            }
        }

        private void dias_Leave(object sender, EventArgs e)
        {
            {
                //dias.Text = "Nacionalidad";
                //dias.ForeColor = Color.DimGray;
            }
        }

        private void cuarto_Enter(object sender, EventArgs e)
        {
            if (cuarto.Text == "Numero de cuarto")
            {
                cuarto.Text = "";
                cuarto.ForeColor = Color.LightGray;
            }
        }

        private void cuarto_Leave(object sender, EventArgs e)
        {
            
                //cuarto.Text = "Numero de cuarto";
                //cuarto.ForeColor = Color.DimGray;


                
            }
        

        private void vercuarto_Click(object sender, EventArgs e)
        {

            // control de los cuartos del hotel
            if(indivudual.Checked==true){
                MessageBox.Show("cuarto 1:"+ cuartosin[0] + "\n" + "cuarto 2:" + cuartosin[1] + "\n" + "cuarto 3:" + cuartosin[2] );
              

            }

            if (matrimonial.Checked == true)
            {
                MessageBox.Show("cuarto 4:" + cuartosma[0] + "\n" + "cuarto 5:" + cuartosma[1] + "\n" + "cuarto 6:" + cuartosma[2]);


            }

            if (doble.Checked == true)
            {
                MessageBox.Show("cuarto 7:" + cuartosdo[0] + "\n" + "cuarto 8:" + cuartosdo[1] + "\n" + "cuarto 9:" + cuartosdo[2]);


            }

        }

        private void guadarreserva_Click(object sender, EventArgs e)
        {
            if (indivudual.Checked == true)
            {
                //numc=int.Parse(guadarreserva.Text);
                

                if (Convert.ToInt32(cuarto.Text) > 3 || Convert.ToInt32(cuarto.Text) < 0)
                {
                    MessageBox.Show("Este numero de cuarto no existe en este tipo");
                }
                else
                {
                    switch (Convert.ToInt32(cuarto.Text))
                    {
                        case 1: cuartosin[0] = "Ocupado";
                            numc = Convert.ToInt32(cuarto.Text);
                            cuarto.Clear();
                            break;

                        case 2: cuartosin[1] = "Ocupado";
                            numc = Convert.ToInt32(cuarto.Text);
                            cuarto.Clear();
                            break;

                        case 3: cuartosin[2] = "Ocupado";
                            numc = Convert.ToInt32(cuarto.Text);
                            cuarto.Clear();


                            break;
                    }
                

                }
            }
            if (matrimonial.Checked == true)
            {

                
                if (Convert.ToInt32(cuarto.Text) > 6 || Convert.ToInt32(cuarto.Text) < 4)
                {
                    MessageBox.Show("Este numero de cuarto no existe en este tipo");
                }
                else
                {
                    switch (Convert.ToInt32(cuarto.Text))
                    {
                        case 4: cuartosma[0] = "Ocupado";
                            numc = Convert.ToInt32(cuarto.Text);
                            cuarto.Clear();
                            break;

                        case 5: cuartosma[1] = "Ocupado";
                            numc = Convert.ToInt32(cuarto.Text);
                            cuarto.Clear();
                            break;

                        case 6: cuartosma[2] = "Ocupado";
                            numc = Convert.ToInt32(cuarto.Text);
                            cuarto.Clear();
                            break;
                    }


                }
            }

            if (doble.Checked == true)
            {

                
                if (Convert.ToInt32(cuarto.Text) > 9 || Convert.ToInt32(cuarto.Text) < 7)
                {
                    MessageBox.Show("Este numero de cuarto no existe en este tipo");
                }
                else
                {
                    switch (Convert.ToInt32(cuarto.Text))
                    {
                        case 7: cuartosdo[0] = "Ocupado";
                            numc = Convert.ToInt32(cuarto.Text);
                            cuarto.Clear();
                            break;

                        case 8: cuartosdo[1] = "Ocupado";
                            numc = Convert.ToInt32(cuarto.Text);
                            cuarto.Clear();
                            break;

                        case 9: cuartosdo[2] = "Ocupado";
                            numc = Convert.ToInt32(cuarto.Text);
                            cuarto.Clear();
                            break;
                    }


                }

            } 
            
            //control de servicios



            if (tv.Checked == false)
            {
                sertv = "No utiliza";
            }
            if (internet.Checked == false)
            {
                serinter = "No utiliza";
            }
            if (aire.Checked == false)
            {
                seraire = "No utiliza";
            }
            if (desayuno.Checked == false)
            {
                serdesa = "No utiliza";
            }



            //registros y conexion a la base de datos 
            try {
                string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=reserva;";
                string Query = "INSERT INTO cliente(cedula_pasaporte, nacionalidad, nombres_apellidos, sexo) VALUES('" + cedul + "','" + nacionalid + "','" + nombrea + "','" + sexo + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                MessageBox.Show("Datos guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string MyConnection3 = "datasource=127.0.0.1;port=3306;username=root;password=;database=reserva;";
                string Query2 = "INSERT INTO reserva(fecha_entrada, fecha_Salida, gasto_total, numero_dias,cedula_pasaporte) VALUES('" + this.fechae.Text + "','" + this.fechasa.Text + "','" + totalg + "','" + numdias + "','" + cedul + "');";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                MySqlCommand MyCommand3 = new MySqlCommand(Query2, MyConn3);
                MySqlDataReader MyReader3;
                MyConn3.Open();
                MyReader3 = MyCommand3.ExecuteReader();
                MyConn3.Close();
                MessageBox.Show("Datos guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string MyConnection4 = "datasource=127.0.0.1;port=3306;username=root;password=;database=reserva;";
                string Query3 = "INSERT INTO habitacion(tipo_habitacion,numero_habitacion,precio,cedula_pasaporte) VALUES('" + tipo + "','" + numc + "','" + precio + "','" + cedul + "');";
               MySqlConnection MyConn4 = new MySqlConnection(MyConnection4);
                MySqlCommand MyCommand4 = new MySqlCommand(Query3, MyConn4);
                MySqlDataReader MyReader4;
                MyConn4.Open();
                MyReader4 = MyCommand4.ExecuteReader();
                MyConn4.Close();
                MessageBox.Show("Datos guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string MyConnection5 = "datasource=127.0.0.1;port=3306;username=root;password=;database=reserva;";
                string Query4 = "INSERT INTO servicios(tv_cable,internet,aire_acondicionado,desayuno,id_habitacion) VALUES('" + sertv + "','" + serinter + "','" + seraire + "','" + serdesa + "','" + numc + "');";
                MySqlConnection MyConn5 = new MySqlConnection(MyConnection5);
                MySqlCommand MyCommand5 = new MySqlCommand(Query4, MyConn5);
                MySqlDataReader MyReader5;
                MyConn5.Open();
                MyReader5 = MyCommand5.ExecuteReader();
                MyConn5.Close();
                MessageBox.Show("Datos guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            nombre.Clear();
            cedula.Clear();
            nacionalidad.Clear();
            dias.Clear();
            cuarto.Clear();
            m.Checked = false;
            f.Checked = false;
            indivudual.Checked = false;
            matrimonial.Checked = false;
            doble.Checked = false;
            internet.Checked = false;
            desayuno.Checked = false;
            tv.Checked = false;
            aire.Checked = false;
            total.Text = "";



            /*
            try
            {
            string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=reserva;"; 
            
            string Query = "INSERT INTO cliente(cedula_pasaporte, nacionalidad, nombres_apellidos, sexo) VALUES('" + cedul + "','" + nacionalid + "','" + nombrea + "','" + sexo + "');";
            
                //MessageBox.Show("INSERT INTO reserva(fecha_entrada, fecha_Salida, gasto_total, numero_dias,cedula_pasaporte) VALUES('" + this.fechae.Text + "','" + this.fechasa.Text + "','" + totalg + "','" + numdias + "','" + cedul + "';");
                
            
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            MyConn2.Close();

            string MyConnection3 = "datasource=127.0.0.1;port=3306;username=root;password=;database=reserva;";
            string Query2 = "INSERT INTO reserva(fecha_entrada, fecha_Salida, gasto_total, numero_dias,cedula_pasaporte) VALUES('" + this.fechae.Text + "','" + this.fechasa.Text + "','" + totalg + "','" + numdias + "','" + cedul + "');";
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
            MySqlCommand MyCommand3 = new MySqlCommand(Query2, MyConn3);
            MySqlDataReader MyReader3;
            MyConn3.Open();
            MyReader3 = MyCommand3.ExecuteReader();
            MyConn3.Close();

            string MyConnection4 = "datasource=127.0.0.1;port=3306;username=root;password=;database=reserva;";
            string Query3 = "INSERT INTO habitacion(tipo_habitacion,numero_habitacion,precio,cedula_pasaporte) VALUES('" + tipo + "','" + numc + "','" + precio + "','" + cedul + "');";    
            MySqlConnection MyConn4 = new MySqlConnection(MyConnection4);
            MySqlCommand MyCommand4 = new MySqlCommand(Query3, MyConn4);
            MySqlDataReader MyReader4;
            MyConn4.Open();
            MyReader4 = MyCommand4.ExecuteReader();
            MyConn4.Close();

            string MyConnection5 = "datasource=127.0.0.1;port=3306;username=root;password=;database=reserva;";
            string Query4 = "INSERT INTO servicios(tv_cable,internet,aire_acondicionado,desayuno,id_habitacion) VALUES('" + sertv + "','" + serinter + "','" + seraire + "','" + serdesa + "','"+ prueba +"');";
            MySqlConnection MyConn5 = new MySqlConnection(MyConnection5);
            MySqlCommand MyCommand5 = new MySqlCommand(Query4, MyConn5);
            MySqlDataReader MyReader5;
            MyConn5.Open();
            MyReader5 = MyCommand5.ExecuteReader();
            MyConn5.Close();

            string MyConnection6 = "datasource=127.0.0.1;port=3306;username=root;password=;database=reserva;";
            MySqlConnection MyConn6 = new MySqlConnection(MyConnection6);            
            MySqlCommand MyCommand6 = new MySqlCommand(Query, MyConn6);
            MySqlDataReader MyReader6;
            MyConn6.Open(); 
            MyReader6 = MyCommand6.ExecuteReader();
            MessageBox.Show("Datos guardados correctamente");
            MyConn6.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */
            //ocupar cuarto seleccionado
            
  














        }

        private void m_CheckedChanged(object sender, EventArgs e)
        {
            if(m.Checked==true){
                sexo = "masculino";

            }
        }

        private void f_CheckedChanged(object sender, EventArgs e)
        {
            if (f.Checked == true)
            {
                sexo = "femenino";

            }

        }

        private void fechasa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechae_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
