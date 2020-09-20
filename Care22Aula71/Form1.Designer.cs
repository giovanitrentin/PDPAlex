namespace Care22Aula71
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.taxaUSD = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.taxa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taxaEUR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.taxaBRL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.de = new System.Windows.Forms.ComboBox();
            this.para = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cria Fornecedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(539, 261);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Atualiza Grade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(539, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Atualiza CNPJ com o Total";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.CausesValidation = false;
            this.button6.Location = new System.Drawing.Point(291, 364);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(411, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Converter";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // taxaUSD
            // 
            this.taxaUSD.Location = new System.Drawing.Point(340, 279);
            this.taxaUSD.Name = "taxaUSD";
            this.taxaUSD.Size = new System.Drawing.Size(63, 23);
            this.taxaUSD.TabIndex = 7;
            this.taxaUSD.Text = "5,35";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(639, 335);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(63, 23);
            this.total.TabIndex = 7;
            // 
            // taxa
            // 
            this.taxa.Location = new System.Drawing.Point(460, 335);
            this.taxa.Name = "taxa";
            this.taxa.ReadOnly = true;
            this.taxa.Size = new System.Drawing.Size(63, 23);
            this.taxa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Moeda De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Taxa USD";
            // 
            // taxaEUR
            // 
            this.taxaEUR.Location = new System.Drawing.Point(493, 279);
            this.taxaEUR.Name = "taxaEUR";
            this.taxaEUR.Size = new System.Drawing.Size(63, 23);
            this.taxaEUR.TabIndex = 7;
            this.taxaEUR.Text = "6,86";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Taxa EUR";
            // 
            // taxaBRL
            // 
            this.taxaBRL.Location = new System.Drawing.Point(651, 279);
            this.taxaBRL.Name = "taxaBRL";
            this.taxaBRL.Size = new System.Drawing.Size(63, 23);
            this.taxaBRL.TabIndex = 7;
            this.taxaBRL.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Taxa BRL";
            // 
            // de
            // 
            this.de.CausesValidation = false;
            this.de.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.de.FormattingEnabled = true;
            this.de.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "BRL"});
            this.de.Location = new System.Drawing.Point(291, 335);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(64, 23);
            this.de.TabIndex = 1;
            // 
            // para
            // 
            this.para.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.para.FormattingEnabled = true;
            this.para.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "BRL"});
            this.para.Location = new System.Drawing.Point(372, 335);
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(64, 23);
            this.para.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Moeda Para";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Taxa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "X";
            // 
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(549, 335);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(63, 23);
            this.quantidade.TabIndex = 7;
            this.quantidade.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quantidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(638, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 441);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.para);
            this.Controls.Add(this.de);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taxaBRL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taxaEUR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taxa);
            this.Controls.Add(this.total);
            this.Controls.Add(this.taxaUSD);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox taxaUSD;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox taxa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taxaEUR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taxaBRL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox de;
        private System.Windows.Forms.ComboBox para;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

