namespace Rest_Ad_System
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.Meal = new System.Windows.Forms.TextBox();
            this.Drinks = new System.Windows.Forms.TextBox();
            this.Total_Price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Meal
            // 
            this.Meal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Meal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Meal.Location = new System.Drawing.Point(313, 159);
            this.Meal.Name = "Meal";
            this.Meal.ReadOnly = true;
            this.Meal.Size = new System.Drawing.Size(141, 26);
            this.Meal.TabIndex = 19;
            this.Meal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Drinks
            // 
            this.Drinks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drinks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drinks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Drinks.Location = new System.Drawing.Point(313, 219);
            this.Drinks.Name = "Drinks";
            this.Drinks.ReadOnly = true;
            this.Drinks.Size = new System.Drawing.Size(141, 26);
            this.Drinks.TabIndex = 20;
            this.Drinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Total_Price
            // 
            this.Total_Price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Total_Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Total_Price.Location = new System.Drawing.Point(313, 285);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.ReadOnly = true;
            this.Total_Price.Size = new System.Drawing.Size(141, 26);
            this.Total_Price.TabIndex = 21;
            this.Total_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.Total_Price);
            this.Controls.Add(this.Drinks);
            this.Controls.Add(this.Meal);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Meal;
        public System.Windows.Forms.TextBox Drinks;
        public System.Windows.Forms.TextBox Total_Price;
        public System.Windows.Forms.Button button1;
    }
}