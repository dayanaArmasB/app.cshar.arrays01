using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_sobrecarga_suma_vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grp_Vector1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //componentes del vector 1            
            var Vec[0] = new Vectores(Convert.ToInt32(txt_component1_1.Text));
            var Vec[1] = new Vectores(Convert.ToInt32(txt_component1_2.Text));
            var Vec[2] = new Vectores(Convert.ToInt32(txt_component1_3.Text));
            var Vec[3] = new Vectores(Convert.ToInt32(txt_component1_4.Text));
            var Vec[4] = new Vectores(Convert.ToInt32(txt_component1_5.Text));
            // componentes del vector 2
            var Vec[0] = new Vectores(Convert.ToInt32(txt_component2_1.Text));
            var Vec[1] = new Vectores(Convert.ToInt32(txt_component2_2.Text));
            var Vec[2] = new Vectores(Convert.ToInt32(txt_component2_3.Text));
            var Vec[3] = new Vectores(Convert.ToInt32(txt_component2_4.Text));
            var Vec[4] = new Vectores(Convert.ToInt32(txt_component2_5.Text));

            txt_result =
        }
    }
}
