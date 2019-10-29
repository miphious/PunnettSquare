namespace PunnettsSquare
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
            this.traitTB1 = new System.Windows.Forms.TextBox();
            this.traitTB2 = new System.Windows.Forms.TextBox();
            this.monohybridBtn = new System.Windows.Forms.Button();
            this.dihybridBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // traitTB1
            // 
            this.traitTB1.Location = new System.Drawing.Point(12, 25);
            this.traitTB1.MaxLength = 1;
            this.traitTB1.Name = "traitTB1";
            this.traitTB1.Size = new System.Drawing.Size(100, 20);
            this.traitTB1.TabIndex = 0;
            // 
            // traitTB2
            // 
            this.traitTB2.Location = new System.Drawing.Point(12, 51);
            this.traitTB2.MaxLength = 1;
            this.traitTB2.Name = "traitTB2";
            this.traitTB2.Size = new System.Drawing.Size(100, 20);
            this.traitTB2.TabIndex = 1;
            // 
            // monohybridBtn
            // 
            this.monohybridBtn.Location = new System.Drawing.Point(138, 25);
            this.monohybridBtn.Name = "monohybridBtn";
            this.monohybridBtn.Size = new System.Drawing.Size(75, 23);
            this.monohybridBtn.TabIndex = 3;
            this.monohybridBtn.Text = "Monohybrid Cross";
            this.monohybridBtn.UseVisualStyleBackColor = true;
            this.monohybridBtn.Click += new System.EventHandler(this.MonohybridBtn_Click);
            // 
            // dihybridBtn
            // 
            this.dihybridBtn.Location = new System.Drawing.Point(138, 51);
            this.dihybridBtn.Name = "dihybridBtn";
            this.dihybridBtn.Size = new System.Drawing.Size(75, 23);
            this.dihybridBtn.TabIndex = 4;
            this.dihybridBtn.Text = "Dihybrid Cross";
            this.dihybridBtn.UseVisualStyleBackColor = true;
            this.dihybridBtn.Click += new System.EventHandler(this.DihybridBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(234, 37);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 321);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.dihybridBtn);
            this.Controls.Add(this.monohybridBtn);
            this.Controls.Add(this.traitTB2);
            this.Controls.Add(this.traitTB1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox traitTB1;
        private System.Windows.Forms.TextBox traitTB2;
        private System.Windows.Forms.Button monohybridBtn;
        private System.Windows.Forms.Button dihybridBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

