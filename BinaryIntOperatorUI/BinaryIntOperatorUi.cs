using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleClassLib;

namespace BinaryIntOperatorUI
{
    public partial class BinaryIntOperatorUi : Form
    {
        private IBinaryIntOperator BuildBinaryIntOperator()
        {
            IBinaryIntOperator res;
            if(ui_radioButtonAddition.Checked)
            {
                res = new IntAddition();
            }
            else
            {
                res = new IntSubtraction();
            }

            return res;
        }
        public BinaryIntOperatorUi()
        {
            InitializeComponent();
        }

        private void ui_radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            ui_labelOperator.Text = ui_radioButtonAddition.Checked ? "+" : "-";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if(int.TryParse(ui_textBoxX.Text, out var x) && 
               int.TryParse(ui_textBoxY.Text, out var y))
            {
                ui_textBoxResult.Text = BuildBinaryIntOperator().Operate(x, y).ToString();
            }

        }
    }
}
