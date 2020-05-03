namespace WindowsFormsApplication15
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.rdbtoplama = new System.Windows.Forms.RadioButton();
            this.rdbcarpma = new System.Windows.Forms.RadioButton();
            this.rdbcıkarma = new System.Windows.Forms.RadioButton();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.rdbbölme = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(100, 23);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(119, 20);
            this.txtsayi1.TabIndex = 1;
            this.txtsayi1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsayi1_KeyDown);
            this.txtsayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsayi1_KeyPress);
            // 
            // rdbtoplama
            // 
            this.rdbtoplama.AutoSize = true;
            this.rdbtoplama.Location = new System.Drawing.Point(113, 134);
            this.rdbtoplama.Name = "rdbtoplama";
            this.rdbtoplama.Size = new System.Drawing.Size(66, 17);
            this.rdbtoplama.TabIndex = 2;
            this.rdbtoplama.TabStop = true;
            this.rdbtoplama.Text = "Toplama";
            this.rdbtoplama.UseVisualStyleBackColor = true;
            // 
            // rdbcarpma
            // 
            this.rdbcarpma.AutoSize = true;
            this.rdbcarpma.Location = new System.Drawing.Point(113, 157);
            this.rdbcarpma.Name = "rdbcarpma";
            this.rdbcarpma.Size = new System.Drawing.Size(61, 17);
            this.rdbcarpma.TabIndex = 3;
            this.rdbcarpma.TabStop = true;
            this.rdbcarpma.Text = "Çarpma";
            this.rdbcarpma.UseVisualStyleBackColor = true;
            // 
            // rdbcıkarma
            // 
            this.rdbcıkarma.AutoSize = true;
            this.rdbcıkarma.Location = new System.Drawing.Point(113, 181);
            this.rdbcıkarma.Name = "rdbcıkarma";
            this.rdbcıkarma.Size = new System.Drawing.Size(63, 17);
            this.rdbcıkarma.TabIndex = 4;
            this.rdbcıkarma.TabStop = true;
            this.rdbcıkarma.Text = "Çıkarma";
            this.rdbcıkarma.UseVisualStyleBackColor = true;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(100, 61);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(119, 20);
            this.txtsayi2.TabIndex = 5;
            // 
            // rdbbölme
            // 
            this.rdbbölme.AutoSize = true;
            this.rdbbölme.Location = new System.Drawing.Point(113, 205);
            this.rdbbölme.Name = "rdbbölme";
            this.rdbbölme.Size = new System.Drawing.Size(54, 17);
            this.rdbbölme.TabIndex = 6;
            this.rdbbölme.TabStop = true;
            this.rdbbölme.Text = "Bölme";
            this.rdbbölme.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(35, 253);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(247, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 310);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.rdbbölme);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.rdbcıkarma);
            this.Controls.Add(this.rdbcarpma);
            this.Controls.Add(this.rdbtoplama);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.RadioButton rdbtoplama;
        private System.Windows.Forms.RadioButton rdbcarpma;
        private System.Windows.Forms.RadioButton rdbcıkarma;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.RadioButton rdbbölme;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

