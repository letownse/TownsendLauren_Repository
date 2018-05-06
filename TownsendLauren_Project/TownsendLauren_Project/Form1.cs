using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TownsendLauren_Project
{
    public partial class Form1 : Form
    {   //create mysql connection
        MySqlConnection conn = new MySqlConnection();

        //create lists to hold meals
        List<MealName> noBonusList = new List<MealName>();
        List<MealName> allList = new List<MealName>();
        List<MealName> AttackList = new List<MealName>();
        List<MealName> ColdList = new List<MealName>();
        List<MealName> DefenseList = new List<MealName>();
        List<MealName> ElectroList = new List<MealName>();
        List<MealName> FireproofList = new List<MealName>();
        List<MealName> HeartsList = new List<MealName>();
        List<MealName> HeatList = new List<MealName>();
        List<MealName> SneakyList = new List<MealName>();
        List<MealName> SpeedList = new List<MealName>();
        List<MealName> StaminaList = new List<MealName>();
        List<MealName> StealthList = new List<MealName>();
        List<MealName> tempList = new List<MealName>();
        DataTable tempTable = new DataTable();
        List<string> ingredientsList = new List<string>();

        Dictionary<string, List<MealName>> tempDictionary = new Dictionary<string, List<MealName>>();
     

        public Form1()
        {

            string constring = BuildConnectionString();
            connect(constring);
            importMeals();
            importIngredientsFromDB();
            addToDictionary();

            InitializeComponent();
   
        }

        //add lists to dictionary
        private void addToDictionary()
        {
            tempDictionary.Add("All", allList);
            tempDictionary.Add("Attack", AttackList);
            tempDictionary.Add("Cold", ColdList);
            tempDictionary.Add("Defense", DefenseList);
            tempDictionary.Add("Electro", ElectroList);
            tempDictionary.Add("Fireproof", FireproofList);
            tempDictionary.Add("Hearts", HeartsList);
            tempDictionary.Add("Heat", HeatList);
            tempDictionary.Add("Speed", SpeedList);
            tempDictionary.Add("Stamina", StaminaList);
            tempDictionary.Add("Sneaky", SneakyList);
            tempDictionary.Add("Stealth", StealthList);
            tempDictionary.Add("None", noBonusList);

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //enter the app options from main display
            this.Hide();
            Main newMain = new Main(tempDictionary, ingredientsList);

            


            newMain.Show();
        }

        //import ingredients list
        public void importIngredientsFromDB()
        {
            string tempNone = string.Format("SELECT ingredient FROM Zelda_Recipes.Ingredients;");

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
               ingredientsList.Add(dr["ingredient"].ToString());
            }

            conn.Close();

            ingredientsList.Sort();

        }

        //import meals to app
        private void importMeals()
        {
            setNoneToList("mealname");
            setAttackToList("mealname");
            setColdToList("mealname");
            setDefenseToList("mealname");
            setElectroToList("mealname");
            setHeartsToList("mealname");
            setHeatToList("mealname");
            setSneakyToList("mealname");
            setSpeedToList("mealname");
            setStaminaToList("mealname");
            setStealthToList("mealname");
            setFireproofToList("mealname");
            setAllToList("mealname");

        }
        private void setNoneToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId WHERE bonusId = 0 ORDER BY {0};", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), "None", "0", dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                noBonusList.Add(tempMeal);
            }

            conn.Close();
        }
        private void setAttackToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT ON m.bonusTime = bT.timeId WHERE m.bonusId = 1 ORDER BY {0}; ", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                AttackList.Add(tempMeal);
            }

            conn.Close();
        }
        private void setColdToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT ON m.bonusTime = bT.timeId WHERE m.bonusId = 2 ORDER BY {0}; ",tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                ColdList.Add(tempMeal);
            }
            conn.Close();
        }
        private void setDefenseToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT ON m.bonusTime = bT.timeId WHERE m.bonusId = 3 ORDER BY {0}; ", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);

            
            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                DefenseList.Add(tempMeal);
            }
            conn.Close();
        }
        private void setElectroToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT ON m.bonusTime = bT.timeId WHERE m.bonusId = 4 ORDER BY {0}; ", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                ElectroList.Add(tempMeal);
            }
            conn.Close();
        }
        private void setHeartsToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT on m.bonusTime = bT.timeId WHERE m.bonusId = 5 ORDER BY {0}; ", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                HeartsList.Add(tempMeal);
            }
            conn.Close();
        }
        private void setHeatToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT ON m.bonusTime = bT.timeId WHERE m.bonusId = 6 ORDER BY {0}; ", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                HeatList.Add(tempMeal);
            }
            conn.Close();
        }
        private void setSneakyToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT ON m.bonusTime = bT.timeId WHERE m.bonusId = 7 ORDER BY {0}; ", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                SneakyList.Add(tempMeal);
            }
            conn.Close();
        }
        private void setSpeedToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT ON m.bonusTime = bT.timeId WHERE m.bonusId = 8 ORDER BY {0}; ", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                SpeedList.Add(tempMeal);
            }
            conn.Close();
        }
        private void setStaminaToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT on m.bonusTime = bT.timeId WHERE m.bonusId = 9 ORDER BY {0}; ", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                StaminaList.Add(tempMeal);
            }
            conn.Close();
        }
        private void setStealthToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT ON m.bonusTime = bT.timeId WHERE m.bonusId = 10 ORDER BY {0}; ", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                StealthList.Add(tempMeal);
            }
            conn.Close();
        }
        private void setFireproofToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT ON m.bonusTime = bT.timeId WHERE m.bonusId = 11 ORDER BY {0}; ", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                FireproofList.Add(tempMeal);
            }
            conn.Close();
        }
        private void setAllToList(string tempString)
        {
            string tempNone = string.Format("SELECT mealName, hearts, bS.bonus, bT.bonusT, i1.ingredient AS i1, i2.ingredient AS i2, i3.ingredient AS i3, i4.ingredient AS i4, i5.ingredient AS i5 FROM Zelda_Recipes.Meals m INNER JOIN Zelda_Recipes.Ingredients i1 ON m.ingredient1 = i1.ingredientId INNER JOIN Zelda_Recipes.Ingredients i2 ON m.ingredient2 = i2.ingredientId INNER JOIN Zelda_Recipes.Ingredients i3 ON m.ingredient3 = i3.ingredientId INNER JOIN Zelda_Recipes.Ingredients i4 ON m.ingredient4 = i4.ingredientId INNER JOIN Zelda_Recipes.Ingredients i5 ON m.ingredient5 = i5.ingredientId INNER JOIN Zelda_Recipes.BonusStatus bS ON m.bonusID = bS.bonusId INNER JOIN Zelda_Recipes.bonusTime bT on m.bonusTime = bT.timeId ORDER BY {0};", tempString);

            MySqlDataAdapter data = new MySqlDataAdapter(tempNone, conn);

            data.SelectCommand.CommandType = CommandType.Text;

            tempTable.Clear();
            data.Fill(tempTable);


            foreach (DataRow dr in tempTable.Rows)
            {
                MealName tempMeal = new MealName(dr["mealName"].ToString(), dr["hearts"].ToString(), dr["bonus"].ToString(), dr["bonusT"].ToString(), dr["i1"].ToString(), dr["i2"].ToString(), dr["i3"].ToString(), dr["i4"].ToString(), dr["i5"].ToString());

                allList.Add(tempMeal);
            }
            conn.Close();
        }



        //connect to database
        public void connect(string myConnectionString)
        {
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch (MySqlException e)
            {
                string msg = "";

                switch (e.Number)
                {
                    case 0:
                        msg = e.ToString();
                        break;
                    case 1042:
                        msg = "Can't resolve host address \n" + myConnectionString;
                        break;
                    case 1045:
                        msg = "Invalid username/password";
                        break;
                    default:
                        msg = e.ToString() + "\n" + myConnectionString;
                        break;

                }
                MessageBox.Show(msg);
            }

        }
        private string BuildConnectionString()
        {
            //set this to IP from file
            return "server=45.33.106.54;uid=pink;pwd=QaWs12#$;database=Zelda_Recipes;port=3306";
        }


        private List<MealName> sendListToForms(string listChoice)
        {
            switch (listChoice)
            {
                case "All":
                    return allList;
                case "Attack":
                    return AttackList;
                case "Cold":
                    return ColdList;
                case "Defense":
                    return DefenseList;
                case "Electro":
                    return ElectroList;
                case "Fireproof":
                    return FireproofList;
                case "Hearts":
                    return HeartsList;
                case "Heat":
                    return HeatList;
                case "Speed":
                    return SpeedList;
                case "Stamina":
                    return StaminaList;
                case "Stealth":
                    return StealthList;
                case "Sneaky":
                    return SneakyList;
                case "None":
                    return noBonusList;
                default:
                    return allList;

            }

        }


    }
}
