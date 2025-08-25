using System.Linq;
using System.Text.RegularExpressions;
using VerificationTask.Calculation;
using VerificationTask.Classes;

namespace VerificationTask
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }
         
        private void buttonCalculateHBC_Click(object sender, EventArgs e)
        {
            bool chekedText = CheckTextBox.checkingTextBox(textBoxCounterHBC.ToString());
            if (chekedText == true)
            { 
                double counterHBC = Convert.ToDouble(textBoxCounterHBC.Text);
            }
            double volumetHBC = CalculationVolumeHBC.getVolumeHBC();
        }


        private void textBoxCounterHBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == Convert.ToChar(".")) return;
            else
            e.Handled = true;
        }
    }
}
