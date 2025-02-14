namespace UserCRUD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFizetes = new System.Windows.Forms.NumericUpDown();
            this.buttonKuldes = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFizetes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonKuldes);
            this.groupBox1.Controls.Add(this.numericUpDownFizetes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNev);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(98, 31);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(204, 26);
            this.textBoxNev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fizetés";
            // 
            // numericUpDownFizetes
            // 
            this.numericUpDownFizetes.Location = new System.Drawing.Point(449, 38);
            this.numericUpDownFizetes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownFizetes.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownFizetes.Name = "numericUpDownFizetes";
            this.numericUpDownFizetes.Size = new System.Drawing.Size(228, 26);
            this.numericUpDownFizetes.TabIndex = 3;
            this.numericUpDownFizetes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonKuldes
            // 
            this.buttonKuldes.Location = new System.Drawing.Point(98, 94);
            this.buttonKuldes.Name = "buttonKuldes";
            this.buttonKuldes.Size = new System.Drawing.Size(160, 37);
            this.buttonKuldes.TabIndex = 4;
            this.buttonKuldes.Text = "Kuldes";
            this.buttonKuldes.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(517, 94);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(160, 37);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(288, 94);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 37);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Módosítás";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Felhasználó nyílvántartás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFizetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownFizetes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonKuldes;
    }
}

