using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brew.Funcoes
{
    public partial class ExemploComponente : Form
    {
        public ExemploComponente()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ExemploComponente_Load(object sender, EventArgs e)
        {
            ibuMinimoPgb.SetState(3);
            ibuRealPgb.SetState(1);
            ibuMaximoPgb.SetState(2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //plato = (-1 * 616.868) + (1111.14 * sg) – (630.272 * sg^2) + (135.997 * sg^3)
            double gravity = Convert.ToDouble(textBox1.Text);
            gravity = (((182.4601 * gravity - 775.6821) * gravity + 1262.7794) * gravity - 669.5622);
            label5.Text = Convert.ToString(gravity);
        }



    }
}
