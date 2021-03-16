
namespace Winforms
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
            this.gbNumbers = new System.Windows.Forms.GroupBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntAction1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.gbNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNumbers
            // 
            this.gbNumbers.Controls.Add(this.label3);
            this.gbNumbers.Controls.Add(this.label2);
            this.gbNumbers.Controls.Add(this.label1);
            this.gbNumbers.Controls.Add(this.txtNumber3);
            this.gbNumbers.Controls.Add(this.txtNumber2);
            this.gbNumbers.Controls.Add(this.txtNumber1);
            this.gbNumbers.Location = new System.Drawing.Point(66, 29);
            this.gbNumbers.Name = "gbNumbers";
            this.gbNumbers.Size = new System.Drawing.Size(212, 147);
            this.gbNumbers.TabIndex = 0;
            this.gbNumbers.TabStop = false;
            this.gbNumbers.Text = "Getallen";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(82, 38);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(82, 64);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 1;
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(82, 90);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(100, 20);
            this.txtNumber3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Getal1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Getal2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Getal3";
            // 
            // bntAction1
            // 
            this.bntAction1.Location = new System.Drawing.Point(70, 182);
            this.bntAction1.Name = "bntAction1";
            this.bntAction1.Size = new System.Drawing.Size(75, 23);
            this.bntAction1.TabIndex = 1;
            this.bntAction1.Text = "Actie 1";
            this.bntAction1.UseVisualStyleBackColor = true;
            this.bntAction1.Click += new System.EventHandler(this.bntAction1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(293, 198);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(75, 23);
            this.btnFileOpen.TabIndex = 2;
            this.btnFileOpen.Text = "FileOpen";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(293, 38);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(131, 138);
            this.txtText.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.bntAction1);
            this.Controls.Add(this.gbNumbers);
            this.Name = "Form1";
            this.gbNumbers.ResumeLayout(false);
            this.gbNumbers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbNumbers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Button bntAction1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.TextBox txtText;
    }
}

