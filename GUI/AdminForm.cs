using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachineSystem.GUI
{
    public partial class AdminForm : Form
    {
        private readonly DataAccess.TextFileDatabase fdb = new("../../../Resourses/Data.txt");

        public AdminForm()
        {
            InitializeComponent();
        }

        private void SwitchIcon_Click(object sender, EventArgs e)
        {
           new GUI.UserForm().Show();
            this.Hide();
        }

        private void DisplaySoldItems()
        {
            sailedCoffeeQuantity.Text     = SailedItems.SailedCoffee.ToString();
            sailedCappuchinoQuantity.Text = SailedItems.SailedCappuchino.ToString();
            sailedLateQuantity.Text       = SailedItems.SailedLate.ToString();
        }

        private void DisplayInventoryData()
        {
            // Read the available ingredients from the database
            waterQuantity.Text   = fdb.ReadFieldById(1, 2, ',');
            milkQuantity.Text    = fdb.ReadFieldById(2, 2, ',');
            coffeeQuantity.Text  = fdb.ReadFieldById(3, 2, ',');
            sugarQuantity.Text   = fdb.ReadFieldById(4, 2, ',');
            vanillaQuantity.Text = fdb.ReadFieldById(5, 2, ',');
            caramelQuantity.Text = fdb.ReadFieldById(6, 2, ',');
        }

        private void LoadingAdminForm(object sender, EventArgs e)
        {
            // Displaying the number of sold items from the SailedItems class
            sailedCoffeeQuantity.Text = SailedItems.SailedCoffee.ToString();
            sailedLateQuantity.Text = SailedItems.SailedLate.ToString();
            sailedCappuchinoQuantity.Text = SailedItems.SailedCappuchino.ToString();
            // Displaying the total amount earned from the sold items
            earnedFromCoffee.Text = (SailedItems.SailedCoffee * 12).ToString();
            earnedFromLate.Text = (SailedItems.SailedLate * 15).ToString();
            earnedFromCappuchino.Text = (SailedItems.SailedCappuchino * 20).ToString();

            // Display inventory data
            DisplayInventoryData();

            // Display Sold items data
            DisplaySoldItems();
        }
    }
}
