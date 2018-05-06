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
    public partial class MealsFilter : Form
    {
        public EventHandler buttonSelection;
        public EventHandler filterSettingSelection;


        public MealsFilter()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            if (buttonSelection != null)
            {
                buttonSelection(this, new EventArgs());
            }
            if (filterSettingSelection != null)
            {
                filterSettingSelection(this, new EventArgs());
            }


        }

        public int setSortSetting()
        {
            int sortNumber;

            if (rbHearts.Checked == true)
            {
                sortNumber = 1;
            }
            else if (rbName.Checked == true)
            {
                sortNumber = 2;
            }
            else
            {
                sortNumber = 3;
            }

            return sortNumber;
        }

        public string setFilterSetting()
        {
            string filterSetting;

            if (rbAll.Checked == true)
            {
                filterSetting = "All";
            }

            else
            {
                filterSetting = cbBonusSetting.Text;
            }

            return filterSetting;
        }

    }
}
