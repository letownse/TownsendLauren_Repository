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
    public partial class Meals : Form
    {
        Dictionary<string, List<MealName>> mealsDictionary = new Dictionary<string, List<MealName>>();
        int sortByNumber;
        
        

        public Meals()
        {
            InitializeComponent();

            

        }

        public Meals(Dictionary<string, List<MealName>> tempDictionary)
        {
            InitializeComponent();

            mealsDictionary = tempDictionary;

            populateDataGrideView(mealsDictionary["All"], 1);

        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            MealsFilter newMealsFilter = new MealsFilter();

            newMealsFilter.buttonSelection += newMealsFilter_buttonSelection;
            newMealsFilter.FormClosed += newMealsFilter_FormClosed;

            newMealsFilter.Show();

        }

        private void newMealsFilter_FormClosed(object sender, EventArgs e)
        {
            MealsFilter filter = new MealsFilter();
            filter = (sender as MealsFilter);

            sortByNumber = filter.setSortSetting();
            string filterSetting = filter.setFilterSetting();

            switch (filterSetting)
            {
                case "All":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["All"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["All"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["All"], 1);
                    }

                    break;
                case "Attack":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Attack"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Attack"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Attack"], 1);
                    }
                    break;
                case "Cold":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Cold"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Cold"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Cold"], 1);
                    }
                    break;
                case "Defense":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Defense"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Defense"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Defense"], 1);
                    }
                    break;
                case "Electro":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Electro"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Electro"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Electro"], 1);
                    }
                    break;
                case "Fireproof":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Fireproof"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Fireproof"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Fireproof"], 1);
                    }
                    break;
                case "Hearts":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Hearts"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Hearts"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Hearts"], 1);
                    }
                    break;
                case "Heat":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Heat"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Heat"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Heat"], 1);
                    }
                    break;
                case "Speed":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Speed"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Speed"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Speed"], 1);
                    }
                    break;
                case "Stamina":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Stamina"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Stamina"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Stamina"], 1);
                    }
                    break;
                case "Stealth":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Stealth"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Stealth"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Stealth"], 1);
                    }
                    break;
                case "Sneaky":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["Sneaky"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["Sneaky"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["Sneaky"], 1);
                    }
                    break;
                case "None":
                    if (sortByNumber == 1)
                    {
                        populateDataGrideView(mealsDictionary["None"], 0);

                    }
                    else if (sortByNumber == 2)
                    {
                        populateDataGrideView(mealsDictionary["None"], 1);
                    }
                    else
                    {
                        populateDataGrideView(mealsDictionary["None"], 1);
                    }
                    break;
                default:
                    break;


            }


        }

        private void newMealsFilter_buttonSelection(object sender, EventArgs e)
        {
            




        }

        private void populateDataGrideView(List<MealName> tempList, int i)
        {
            dgvMeals.Rows.Clear();

            foreach (MealName meal in tempList)
            {
                dgvMeals.Rows.Add(meal.Hearts, meal.Name, meal.BonusAmount);

            }

            if (i == 0)
            {
                //sort DatagridView
                dgvMeals.Sort(dgvMeals.Columns[0], ListSortDirection.Ascending);
            }

            else
            {
                dgvMeals.Sort(dgvMeals.Columns[1], ListSortDirection.Ascending);
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
