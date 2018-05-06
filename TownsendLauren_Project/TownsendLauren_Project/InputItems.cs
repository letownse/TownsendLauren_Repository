using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TownsendLauren_Project
{
    public partial class InputItems : Form

    {

        //create list to save user ingredients
        Dictionary<string, int> userIngredientQuantites = new Dictionary<string, int>();


        public InputItems()
        {
            InitializeComponent();
        }

        public InputItems(Dictionary<string,List<MealName>> tempDictionary, List<string> tempIngredientsList)
        {
            InitializeComponent();

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach(string ingredient in tempIngredientsList)
            {
                data.Add(ingredient);
            }

            tbIngredient1.AutoCompleteCustomSource = data;
            tbIngredient2.AutoCompleteCustomSource = data;
            tbIngredient3.AutoCompleteCustomSource = data;
            tbIngredient4.AutoCompleteCustomSource = data;
            tbIngredient5.AutoCompleteCustomSource = data;
            tbIngredient6.AutoCompleteCustomSource = data;
            tbIngredient7.AutoCompleteCustomSource = data;
            tbIngredient8.AutoCompleteCustomSource = data;
            tbIngredient9.AutoCompleteCustomSource = data;
            tbIngredient10.AutoCompleteCustomSource = data;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveItems_Click(object sender, EventArgs e)
        {
            

            


            clearTextBoxes();
        }

        private void clearTextBoxes()
        {
            tbIngredient1.Text = "";
            tbIngredient2.Text = "";
            tbIngredient3.Text = "";
            tbIngredient4.Text = "";
            tbIngredient5.Text = "";
            tbIngredient6.Text = "";
            tbIngredient7.Text = "";
            tbIngredient8.Text = "";
            tbIngredient9.Text = "";
            tbIngredient10.Text = "";

            nudIngredient1.Value = 0;
            nudIngredient10.Value = 0;
            nudIngredient2.Value = 0;
            nudIngredient3.Value = 0;
            nudIngredient4.Value = 0;
            nudIngredient5.Value = 0;
            nudIngredient6.Value = 0;
            nudIngredient7.Value = 0;
            nudIngredient8.Value = 0;
            nudIngredient9.Value = 0;

        }

        private void saveQuantities()
        {
            


        }



    }
}
