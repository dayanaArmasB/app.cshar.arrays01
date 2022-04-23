using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            /*GenerateRandomNumbers();
            Random random = new Random();*/

        }

        private void grp_Vector1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            string mresult = "";
            //componentes del vector 1    
            Util myvectorclass1 = new Util();
            myvectorclass1.vec[0] = Convert.ToInt32(txt_component1_1.Text);
            myvectorclass1.vec[1] = Convert.ToInt32(txt_component1_2.Text);
            myvectorclass1.vec[2] = Convert.ToInt32(txt_component1_3.Text);
            myvectorclass1.vec[3] = Convert.ToInt32(txt_component1_4.Text);
            myvectorclass1.vec[4] = Convert.ToInt32(txt_component1_5.Text);

            //componentes del vector 2    
            Util myvectorclass2 = new Util();
            myvectorclass2.vec[0] = Convert.ToInt32(txt_component2_1.Text);
            myvectorclass2.vec[1] = Convert.ToInt32(txt_component2_2.Text);
            myvectorclass2.vec[2] = Convert.ToInt32(txt_component2_3.Text);
            myvectorclass2.vec[3] = Convert.ToInt32(txt_component2_4.Text);
            myvectorclass2.vec[4] = Convert.ToInt32(txt_component2_5.Text);


            Util myvectorclasssum  = new Util();

            myvectorclasssum = myvectorclass1 + myvectorclass2;

            mresult = "El vector suma es :\n ";
            for (int i = 0; i < myvectorclasssum.vec.Length; i++)
            {
                mresult  += myvectorclasssum.vec[i].ToString() + "\n ";
            }

            txt_result.Text = mresult;
        }


        /*private void GenerateRandomNumbers()
        {
            
            txt_component1_1.Text = r
            txt_component1_2.Text = "3";
            txt_component1_3.Text = "4";

        }*/

        
    }
}
