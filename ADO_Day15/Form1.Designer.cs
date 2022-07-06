
namespace ADO_Day15
{
    partial class Form1
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
            this.LblCity = new System.Windows.Forms.Label();
            this.ComboCity = new System.Windows.Forms.ComboBox();
            this.GridEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCity.Location = new System.Drawing.Point(209, 83);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(188, 26);
            this.LblCity.TabIndex = 0;
            this.LblCity.Text = "Select City Name:";
            // 
            // ComboCity
            // 
            this.ComboCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCity.FormattingEnabled = true;
            this.ComboCity.Location = new System.Drawing.Point(421, 83);
            this.ComboCity.Name = "ComboCity";
            this.ComboCity.Size = new System.Drawing.Size(205, 34);
            this.ComboCity.TabIndex = 1;
            this.ComboCity.SelectedIndexChanged += new System.EventHandler(this.ComboCity_SelectedIndexChanged);
            // 
            // GridEmployee
            // 
            this.GridEmployee.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployee.Location = new System.Drawing.Point(53, 150);
            this.GridEmployee.Name = "GridEmployee";
            this.GridEmployee.RowHeadersWidth = 62;
            this.GridEmployee.RowTemplate.Height = 28;
            this.GridEmployee.Size = new System.Drawing.Size(703, 272);
            this.GridEmployee.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 493);
            this.Controls.Add(this.GridEmployee);
            this.Controls.Add(this.ComboCity);
            this.Controls.Add(this.LblCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.ComboBox ComboCity;
        private System.Windows.Forms.DataGridView GridEmployee;
    }
}

