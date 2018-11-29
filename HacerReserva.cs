using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAHO
{
    public partial class HacerReserva : Form
    {
        public HacerReserva()
        {
            InitializeComponent();
        }
        string nombrea;
        string nacionalid;
        string sexo;
        string tipo;
        string cedul;
        int totalg;
        int numdias;
        string sertv;
        string serinter;
        string serdesa;
        string seraire;
        int numc;


        int individua = 12;
        int matrimonia = 45;
        int tipotres = 60;
        int tele = 5;
        int air = 5;
        int inter = 6;
        int desa = 5;




        private void HacerReserva_Load(object sender, EventArgs e)
        {



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
            nombre.Enabled = true;
            cedula.Enabled = true;
            nacionalidad.Enabled = true;
            dias.Enabled = true;
            cuarto.Enabled = true;
            fechae.Enabled = true;
            fechasa.Enabled = true;
        }

        private void indivudual_CheckedChanged(object sender, EventArgs e)
        {

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
            }

            if (indivudual.Checked == true)
            {

                total.Text = Convert.ToString(individua);

            }



        }

        private void matrimonial_CheckedChanged(object sender, EventArgs e)
        {

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

            }
        }

        private void doble_CheckedChanged(object sender, EventArgs e)
        {

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

            }
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            nombrea = nombre.ToString();


        }

        private void cedula_TextChanged(object sender, EventArgs e)
        {
            cedul = cedula.ToString();
        }

        private void nacionalidad_TextChanged(object sender, EventArgs e)
        {
            nacionalid = nacionalidad.ToString();
        }

        private void dias_TextChanged(object sender, EventArgs e)
        {
            
           
           
            
            if(dias.Text!=""){
                numdias = Convert.ToInt32(dias.Text);
            totalg = totalg * numdias;
            total.Text = Convert.ToString(totalg);
            }





        }

        private void cuarto_TextChanged(object sender, EventArgs e)
        {

            if (cuarto.Text != "")
            {
                numc = Convert.ToInt32(cuarto.Text);
            }


        }

        private void tv_CheckedChanged(object sender, EventArgs e)
        {
            if (tv.Checked == false)
            {
                totalg = totalg - tele;
                total.Text = Convert.ToString(totalg);
            }
            else
            {
                if (tv.Checked == true)
                {
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
            if (internet.Checked == false)
            {
                totalg = totalg - inter;
                total.Text = Convert.ToString(totalg);
            }
            else
            {

                if (internet.Checked == true)
                {
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

            if (aire.Checked == false)
            {
                totalg = totalg - air;
                total.Text = Convert.ToString(totalg);
            }
            else
            {

                if (aire.Checked == true)
                {
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

            if (desayuno.Checked == false)
            {
                totalg = totalg - desa;
                total.Text = Convert.ToString(totalg);
            }
            else
            {

                if (desayuno.Checked == true)
                {
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

            if (cedula.Text == "")
            {
                cedula.Text = "Numero de cedula o pasaporte";
                cedula.ForeColor = Color.DimGray;
            }
        }

        private void nacionalidad_Enter(object sender, EventArgs e)
        {
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
            if (dias.Text == "Nro de dias a hospedar")
            {
                dias.Text = "";
                dias.ForeColor = Color.LightGray;
            }
        }

        private void dias_Leave(object sender, EventArgs e)
        {
            {
                dias.Text = "Nacionalidad";
                dias.ForeColor = Color.DimGray;
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
            {
                cuarto.Text = "Numero de cuarto";
                cuarto.ForeColor = Color.DimGray;
            }
        }
    }
}
