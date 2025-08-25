using System.Linq;
using System.Text.RegularExpressions;
using VerificationTask.Calculation;
using VerificationTask.Classes;
using static VerificationTask.Calculation.TariffEnums;

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
            double volumeHBC = CalculationVolumeHBC.getVolumeHBC(counter: textBoxCounterHBC.Text.ToString());

            double utilitiesSum = CalculationAccrual.getCost(volumeHBC, TariffEnum.HBC);

            MessageBox.Show(utilitiesSum.ToString());
        }


        private void textBoxCounterHBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == Convert.ToChar(".")) return;
            else
                e.Handled = true;
        }

        private void textBoxCountPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
