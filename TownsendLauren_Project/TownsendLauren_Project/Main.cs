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
    public partial class Main : Form
    {
        Dictionary<string, List<MealName>> mainFormDictionary = new Dictionary<string, List<MealName>>();
        List<string> ingredientsList = new List<string>();

        Dictionary<string, int> userIngredientQuantities = new Dictionary<string, int>();

        public Main()
        {
            InitializeComponent();
        }

        public Main(Dictionary<string,List<MealName>> tempDictionary, List<string> tempIngredients)
        {
            InitializeComponent();

            mainFormDictionary = tempDictionary;

            ingredientsList = tempIngredients;

        }

        private void btnMeals_Click(object sender, EventArgs e)
        {
            //code to open meal form
            this.Hide();
            Meals newMealsForm = new Meals(mainFormDictionary);

            newMealsForm.FormClosed += newMealsForm_FormClosed;

            newMealsForm.Show();
        }

        public void newMealsForm_FormClosed(object sender, EventArgs e)
        {
            this.Show();

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            //code to open Ingredient Input form
            this.Hide();
            InputItems newInputForm = new InputItems(mainFormDictionary, ingredientsList);
            newInputForm.FormClosed += newInputForm_FormClosed;

            newInputForm.Show();
        }

        public void newInputForm_FormClosed(object sender, EventArgs e)
        {
            AvailableMeals newAvailable = new AvailableMeals();


             newAvailable.Show();

        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            //code to open Ingredient list form
            this.Hide();
            Ingredients newIngredientList = new Ingredients();
            newIngredientList.Show();
        }
    }
}
