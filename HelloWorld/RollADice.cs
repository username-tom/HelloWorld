using System.Diagnostics;
using System;

namespace HelloWorld
{
    public partial class RollADice : Form
    {
        int diceRoll = 6;
        int diceSides = 6;
        Random rdm = new Random();

        public RollADice()
        {
            InitializeComponent();
        }

        private void ButtonRoll_Click(object sender, EventArgs e)
        {
            diceRoll = rdm.Next(1, diceSides + 1);
            LabelOutput.Text = diceRoll.ToString();
        }

        private void ComboSides_SelectionChanged()
        {
            if (ComboSides.SelectedItem != null)
            {
                var selectedSides = ComboSides.SelectedItem.ToString();
                if (selectedSides != null)
                {
                    diceSides = int.Parse(selectedSides);
                }
            }
        }

        private void ComboSides_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboSides_SelectionChanged();
        }
    }
}
