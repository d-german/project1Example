using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryIntOperatorUI
{
    public partial class BinaryIntOperatorUi : Form
    {
        public BinaryIntOperatorUi()
        {
            InitializeComponent();
        }

        private void ui_radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ui_radioButtonAddition.Checked)
            {
                ui_labelOperator.Text = "+";
            }
            else
            {
                ui_labelOperator.Text = "-";
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
