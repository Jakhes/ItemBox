using ItemLibraray;
using ItemLibraray.DataAccess;
using ItemLibraray.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemBoxUI
{
    public partial class CreateItemUI : Form
    {
        public CreateItemUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ItemModel model = new ItemModel(
                    NameTextBox.Text,
                    DescriptionRichText.Text,
                    ValueTextBox.Text,
                    LoreRichText.Text);

                GlobalConfig.Connection.Create_Item(model);

                NameTextBox.Text = "";
                DescriptionRichText.Text = "";
                ValueTextBox.Text = "0";
                LoreRichText.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int valueNumber = 0;
            bool valueNumberValid = int.TryParse(ValueTextBox.Text, out valueNumber);

            if (!valueNumberValid)
            {
                output = false;
            }
            if (valueNumber < 0)
            {
                output = false;
            }

            return output;
        }
    }
}
