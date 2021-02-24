using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM
{
    public partial class FRMCLIENTS : Form
    {
        public FRMCLIENTS()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            CLASS.CLIENTE CLIENTE1 = new CLASS.CLIENTE();
            CLIENTE1.APPATERNO1 = TXTAPPATERNO.Text;
            CLIENTE1.APMATERNO1 = TXTAPMATERNO.Text;
            CLIENTE1.NOMBRES1 = TXTNOMBRE.Text;
            CLIENTE1.CEDULA1 = TXTCEDULA.Text;
            CLIENTE1.SEXO1 = CMBSEXO.Text;
            CLIENTE1.NUMSEGURIDADOCIAL1 = TXTNUMSEGSOCIAL.Text;
            CLIENTE1.CATEGORIA1 = CMBCATEGORIA.Text;
            CLIENTE1.GENERARCODIGOPEDIDO ();
            TXTCODPERSONA.Text = CLIENTE1.CODIGODEPEDIDO1;
            DGVCLIENTES.Rows.Insert(0, CLIENTE1.APPATERNO1, CLIENTE1.APMATERNO1, CLIENTE1.NOMBRES1,CLIENTE1.CEDULA1, CLIENTE1.SEXO1, CLIENTE1.NUMSEGURIDADOCIAL1, CLIENTE1.CATEGORIA1, CLIENTE1.CODIGODEPEDIDO1);
        }
    }
}
