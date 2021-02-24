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
    public partial class FRMEMPLEADO : Form
    {
        public FRMEMPLEADO()
        {
            InitializeComponent();
        }

        private void DGVCLIENTES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            CLASS.EMPLEADO EMPLEADO1 = new CLASS.EMPLEADO();
            EMPLEADO1.APPATERNO1 = TXTAPPATERNO.Text;
            EMPLEADO1.APMATERNO1 = TXTAPMATERNO.Text;
            EMPLEADO1.NOMBRES1 = TXTNOMBRES.Text;
            EMPLEADO1.CEDULA1 = TXTCEDULA.Text;
            EMPLEADO1.SEXO1 = CBOSEXO.Text;
            EMPLEADO1.NUMSEGURIDADOCIAL1 = TXTNUMSEGSOCIAL.Text;
            EMPLEADO1.TIPO1 = CBOTIPEMPLEADO.Text;
            EMPLEADO1.TIPODECONTRATO1 = CBOTIPCONTRATO.Text;
            EMPLEADO1.CALCULARSUELDO(1250);
            DGVEMPLEADO.Rows.Insert(0, EMPLEADO1.APPATERNO1, EMPLEADO1.APMATERNO1, EMPLEADO1.NOMBRES1,EMPLEADO1.CEDULA1, EMPLEADO1.SEXO1, EMPLEADO1.NUMSEGURIDADOCIAL1, EMPLEADO1.TIPO1, EMPLEADO1.TIPODECONTRATO1,EMPLEADO1.SUELDO1);
        }
    }
}
