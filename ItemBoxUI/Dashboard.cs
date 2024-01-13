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
    public partial class Dashboard : Form
    {
        List<SystemModel> systems = new List<SystemModel>();
        BindingSource bindingSource = new BindingSource();

        public Dashboard()
        {
            InitializeComponent();

            systems.Add(new SystemModel("1", "Greate"));

            LoadSystems();

            HookUpDropdown();
        }

        private void HookUpDropdown()
        {
            bindingSource.DataSource = systems;
            SystemsCombobox.DataSource = bindingSource;
            SystemsCombobox.DisplayMember = "Name";
        }

        private void LoadSystems()
        {
            // Get saved SystemModels from Database
            // Update bindingsource
        }

        private void CreateSystemButton_Click(object sender, EventArgs e)
        {
            // Open new Create System Form 
        }

        private void LoadSystemButton_Click(object sender, EventArgs e)
        {
            // open new SystemView with selected SystemModel
            // Close this Form
        }
    }
}
