using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownsendLauren_Project
{
    public class MealName
    {
        private string _name;
        private string _hearts;
        private string _bonusType;
        private string _bonusAmount;
        private string _item1;
        private string _item2;
        private string _item3;
        private string _item4;
        private string _item5;

        public string Name { get => _name; set => _name = value; }
        public string Hearts { get => _hearts; set => _hearts = value; }
        public string BonusType { get => _bonusType; set => _bonusType = value; }
        public string BonusAmount { get => _bonusAmount; set => _bonusAmount = value; }
        public string Item1 { get => _item1; set => _item1 = value; }
        public string Item2 { get => _item2; set => _item2 = value; }
        public string Item3 { get => _item3; set => _item3 = value; }
        public string Item4 { get => _item4; set => _item4 = value; }
        public string Item5 { get => _item5; set => _item5 = value; }

        public MealName(string Name, string Hearts, string BonusType, string BonusAmount, string Item1, string Item2, string Item3, string Item4, string Item5)
        {
            _name = Name;
            _hearts = Hearts;
            _bonusType = BonusType;
            _bonusAmount = BonusAmount;
            _item1 = Item1;
            _item2 = Item2;
            _item3 = Item3;
            _item4 = Item4;
            _item5 = Item5;
        }

        public MealName()
        {

        }


    }
}
