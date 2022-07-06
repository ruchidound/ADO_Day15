
namespace ADO_Day15
{
    partial class FrmDisconnected
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
            this.gridDepartment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDepartment
            // 
            this.gridDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepartment.Location = new System.Drawing.Point(43, 46);
            this.gridDepartment.Name = "gridDepartment";
            this.gridDepartment.RowHeadersWidth = 62;
            this.gridDepartment.RowTemplate.Height = 28;
            this.gridDepartment.Size = new System.Drawing.Size(669, 269);
            this.gridDepartment.TabIndex = 0;
            // 
            // FrmDisconnected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridDepartment);
            this.Name = "FrmDisconnected";
            this.Text = "FrmDisconnected";
            this.Load += new System.EventHandler(this.FrmDisconnected_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDepartment;
    }
}