namespace TownsendLauren_Project
{
    partial class Meal
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
            this.lblItems = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblHearts = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMealName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(175, 405);
            this.lblItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(63, 125);
            this.lblItems.TabIndex = 17;
            this.lblItems.Text = "None\r\nNone\r\nNone\r\nNone\r\nNone";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(152, 371);
            this.lblIngredients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(118, 25);
            this.lblIngredients.TabIndex = 16;
            this.lblIngredients.Text = "Ingredients";
            this.lblIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.Location = new System.Drawing.Point(143, 314);
            this.lblBonus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(136, 25);
            this.lblBonus.TabIndex = 15;
            this.lblBonus.Text = "Bonus: None";
            this.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHearts
            // 
            this.lblHearts.AutoSize = true;
            this.lblHearts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHearts.Location = new System.Drawing.Point(161, 289);
            this.lblHearts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHearts.Name = "lblHearts";
            this.lblHearts.Size = new System.Drawing.Size(99, 25);
            this.lblHearts.TabIndex = 14;
            this.lblHearts.Text = "Hearts: 0";
            this.lblHearts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(148, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblMealName
            // 
            this.lblMealName.AutoSize = true;
            this.lblMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealName.Location = new System.Drawing.Point(117, 73);
            this.lblMealName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMealName.Name = "lblMealName";
            this.lblMealName.Size = new System.Drawing.Size(194, 39);
            this.lblMealName.TabIndex = 12;
            this.lblMealName.Text = "Meal Name";
            this.lblMealName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(22, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 61);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 596);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblHearts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMealName);
            this.Controls.Add(this.btnBack);
            this.Name = "Meal";
            this.Text = "Meal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblHearts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMealName;
        private System.Windows.Forms.Button btnBack;
    }
}