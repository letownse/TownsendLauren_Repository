namespace TownsendLauren_Project
{
    partial class Main
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
            this.btnIngredients = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnMeals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngredients
            // 
            this.btnIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredients.Location = new System.Drawing.Point(92, 388);
            this.btnIngredients.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.Size = new System.Drawing.Size(253, 88);
            this.btnIngredients.TabIndex = 5;
            this.btnIngredients.Text = "View Ingredients";
            this.btnIngredients.UseVisualStyleBackColor = true;
            this.btnIngredients.Click += new System.EventHandler(this.btnIngredients_Click);
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(92, 284);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(253, 88);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "Input Ingredients";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnMeals
            // 
            this.btnMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeals.Location = new System.Drawing.Point(92, 177);
            this.btnMeals.Margin = new System.Windows.Forms.Padding(2);
            this.btnMeals.Name = "btnMeals";
            this.btnMeals.Size = new System.Drawing.Size(253, 88);
            this.btnMeals.TabIndex = 3;
            this.btnMeals.Text = "View Meals";
            this.btnMeals.UseVisualStyleBackColor = true;
            this.btnMeals.Click += new System.EventHandler(this.btnMeals_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 596);
            this.Controls.Add(this.btnIngredients);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnMeals);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngredients;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnMeals;
    }
}