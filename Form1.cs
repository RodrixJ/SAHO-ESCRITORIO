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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region funcionalidades
        //capturar posicion y tamaño antes de maximizar
        int lx, ly;
        int sw, sh;
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        
        }
         #endregion
        private void AbrirFormulario<Miform>() where Miform : Form, new()
        {

            Form formulario;
            formulario = panelformularios.Controls.OfType<Miform>().FirstOrDefault();//busca en la coleccion el formulario
            //si el formulario no existe
            if (formulario == null)
            {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            //si el formulario existe
            else
            {
                formulario.BringToFront();
            }

        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Inicio>();
            Inicio.BackColor = Color.FromArgb(89, 100, 112);
        }

        private void HacerReserva_Click(object sender, EventArgs e)
        {
            AbrirFormulario<HacerReserva>();
            HacerReserva.BackColor = Color.FromArgb(89, 100, 112);
        }

        private void BuscarReserva_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BuscarReserva>();
            BuscarReserva.BackColor = Color.FromArgb(89, 100, 112);
        }
    }


}
