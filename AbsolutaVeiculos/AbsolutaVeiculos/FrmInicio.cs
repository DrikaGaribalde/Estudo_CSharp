using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbsolutaVeiculos
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            
           
          

            
        }

        private void suporteOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
               
        }

        private void ajudaSiplesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCliente newFrmCliente = new FrmCliente();
            //newFrmCliente.ShowDialog();
            newFrmCliente.ShowDialog(); 
           
        }

        private void cadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void automóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutomovel newFrmAutomovel = new FrmAutomovel();
            newFrmAutomovel.ShowDialog(); 

                }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void suporteTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuporte newFrmSuporte = new FrmSuporte();
            newFrmSuporte.ShowDialog(); 
        }

        private void fotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmFotos newFrmFotos = new FrmFotos();
            //newFrmFotos.ShowDialog ();

            FrmBusca newFrmBusca = new FrmBusca();
            newFrmBusca.ShowDialog();

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManual newFrmManual = new FrmManual();
            newFrmManual.ShowDialog();
        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBusca newFrmBusca = new FrmBusca();
            newFrmBusca.ShowDialog();


        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca newFrmMarca = new FrmMarca();
            newFrmMarca.ShowDialog();

        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModelo newFrmModelo = new FrmModelo();
            newFrmModelo.ShowDialog();
        }
    
       
    }
}
