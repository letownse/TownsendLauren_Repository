namespace TownsendLauren_Project
{
    partial class Meals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.lblMeals = new System.Windows.Forms.Label();
            this.dgvMeals = new System.Windows.Forms.DataGridView();
            this.Hearts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 62);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFilters
            // 
            this.btnFilters.AutoSize = true;
            this.btnFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.Location = new System.Drawing.Point(316, 11);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(90, 62);
            this.btnFilters.TabIndex = 9;
            this.btnFilters.Text = "Filters";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // lblMeals
            // 
            this.lblMeals.AutoSize = true;
            this.lblMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeals.Location = new System.Drawing.Point(148, 22);
            this.lblMeals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeals.Name = "lblMeals";
            this.lblMeals.Size = new System.Drawing.Size(101, 37);
            this.lblMeals.TabIndex = 8;
            this.lblMeals.Text = "Meals";
            // 
            // dgvMeals
            // 
            this.dgvMeals.AllowUserToAddRows = false;
            this.dgvMeals.AllowUserToDeleteRows = false;
            this.dgvMeals.AllowUserToResizeColumns = false;
            this.dgvMeals.AllowUserToResizeRows = false;
            this.dgvMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hearts,
            this.mealNameCol,
            this.Bonus});
            this.dgvMeals.Location = new System.Drawing.Point(36, 154);
            this.dgvMeals.Name = "dgvMeals";
            this.dgvMeals.ReadOnly = true;
            this.dgvMeals.RowHeadersVisible = false;
            this.dgvMeals.Size = new System.Drawing.Size(321, 393);
            this.dgvMeals.TabIndex = 11;
            // 
            // Hearts
            // 
            this.Hearts.FillWeight = 55.98914F;
            this.Hearts.HeaderText = "Hearts";
            this.Hearts.Name = "Hearts";
            this.Hearts.ReadOnly = true;
            // 
            // mealNameCol
            // 
            this.mealNameCol.FillWeight = 198.3256F;
            this.mealNameCol.HeaderText = "Name of Meal";
            this.mealNameCol.Name = "mealNameCol";
            this.mealNameCol.ReadOnly = true;
            // 
            // Bonus
            // 
            this.Bonus.FillWeight = 45.68528F;
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.Name = "Bonus";
            this.Bonus.ReadOnly = true;
            // 
            // Meals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 596);
            this.Controls.Add(this.dgvMeals);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.lblMeals);
            this.Name = "Meals";
            this.Text = "Meals";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.Label lblMeals;
        private System.Windows.Forms.DataGridView dgvMeals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hearts;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
    }
}