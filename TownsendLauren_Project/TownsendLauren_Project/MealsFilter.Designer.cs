namespace TownsendLauren_Project
{
    partial class MealsFilter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFilters = new System.Windows.Forms.Label();
            this.gbSortby = new System.Windows.Forms.GroupBox();
            this.gbMealstoView = new System.Windows.Forms.GroupBox();
            this.rbHearts = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbBonus = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbBonusType = new System.Windows.Forms.RadioButton();
            this.cbBonusSetting = new System.Windows.Forms.ComboBox();
            this.gbSortby.SuspendLayout();
            this.gbMealstoView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 34);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.Location = new System.Drawing.Point(102, 20);
            this.lblFilters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(104, 37);
            this.lblFilters.TabIndex = 12;
            this.lblFilters.Text = "Filters";
            // 
            // gbSortby
            // 
            this.gbSortby.Controls.Add(this.rbBonus);
            this.gbSortby.Controls.Add(this.rbName);
            this.gbSortby.Controls.Add(this.rbHearts);
            this.gbSortby.Location = new System.Drawing.Point(35, 107);
            this.gbSortby.Name = "gbSortby";
            this.gbSortby.Size = new System.Drawing.Size(254, 96);
            this.gbSortby.TabIndex = 13;
            this.gbSortby.TabStop = false;
            this.gbSortby.Text = "Sort by: ";
            // 
            // gbMealstoView
            // 
            this.gbMealstoView.Controls.Add(this.cbBonusSetting);
            this.gbMealstoView.Controls.Add(this.rbBonusType);
            this.gbMealstoView.Controls.Add(this.rbAll);
            this.gbMealstoView.Location = new System.Drawing.Point(35, 234);
            this.gbMealstoView.Name = "gbMealstoView";
            this.gbMealstoView.Size = new System.Drawing.Size(254, 86);
            this.gbMealstoView.TabIndex = 14;
            this.gbMealstoView.TabStop = false;
            this.gbMealstoView.Text = "Meals to view";
            // 
            // rbHearts
            // 
            this.rbHearts.AutoSize = true;
            this.rbHearts.Location = new System.Drawing.Point(16, 19);
            this.rbHearts.Name = "rbHearts";
            this.rbHearts.Size = new System.Drawing.Size(56, 17);
            this.rbHearts.TabIndex = 0;
            this.rbHearts.Text = "Hearts";
            this.rbHearts.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Checked = true;
            this.rbName.Location = new System.Drawing.Point(16, 42);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(79, 17);
            this.rbName.TabIndex = 1;
            this.rbName.TabStop = true;
            this.rbName.Text = "Meal Name";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbBonus
            // 
            this.rbBonus.AutoSize = true;
            this.rbBonus.Location = new System.Drawing.Point(16, 65);
            this.rbBonus.Name = "rbBonus";
            this.rbBonus.Size = new System.Drawing.Size(82, 17);
            this.rbBonus.TabIndex = 2;
            this.rbBonus.Text = "Bonus Type";
            this.rbBonus.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(20, 19);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbBonusType
            // 
            this.rbBonusType.AutoSize = true;
            this.rbBonusType.Location = new System.Drawing.Point(19, 42);
            this.rbBonusType.Name = "rbBonusType";
            this.rbBonusType.Size = new System.Drawing.Size(84, 17);
            this.rbBonusType.TabIndex = 1;
            this.rbBonusType.Text = "Bonus type: ";
            this.rbBonusType.UseVisualStyleBackColor = true;
            // 
            // cbBonusSetting
            // 
            this.cbBonusSetting.FormattingEnabled = true;
            this.cbBonusSetting.Items.AddRange(new object[] {
            "Attack",
            "Cold",
            "Electro",
            "Fireproof",
            "Hearts",
            "Heat",
            "None",
            "Sneaky",
            "Speed",
            "Stamina",
            "Stealth"});
            this.cbBonusSetting.Location = new System.Drawing.Point(99, 41);
            this.cbBonusSetting.MaxDropDownItems = 20;
            this.cbBonusSetting.Name = "cbBonusSetting";
            this.cbBonusSetting.Size = new System.Drawing.Size(121, 21);
            this.cbBonusSetting.Sorted = true;
            this.cbBonusSetting.TabIndex = 2;
            // 
            // MealsFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 343);
            this.Controls.Add(this.gbMealstoView);
            this.Controls.Add(this.gbSortby);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.btnBack);
            this.Name = "MealsFilter";
            this.Text = "MealsFilter";
            this.gbSortby.ResumeLayout(false);
            this.gbSortby.PerformLayout();
            this.gbMealstoView.ResumeLayout(false);
            this.gbMealstoView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.GroupBox gbSortby;
        private System.Windows.Forms.RadioButton rbBonus;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbHearts;
        private System.Windows.Forms.GroupBox gbMealstoView;
        private System.Windows.Forms.ComboBox cbBonusSetting;
        private System.Windows.Forms.RadioButton rbBonusType;
        private System.Windows.Forms.RadioButton rbAll;
    }
}