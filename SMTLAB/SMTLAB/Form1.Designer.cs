namespace SMTLAB
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nud_timer = new System.Windows.Forms.NumericUpDown();
            this.btn_autoget = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txt_browserin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_timer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.46471F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.49862F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nud_timer, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_autoget, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_browserin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.80042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.276507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.79834F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.98753F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.96881F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1437, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nud_timer
            // 
            this.nud_timer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_timer.Location = new System.Drawing.Point(1214, 15);
            this.nud_timer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_timer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_timer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_timer.Name = "nud_timer";
            this.nud_timer.Size = new System.Drawing.Size(156, 44);
            this.nud_timer.TabIndex = 14;
            this.nud_timer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_autoget
            // 
            this.btn_autoget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_autoget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_autoget.Location = new System.Drawing.Point(627, 3);
            this.btn_autoget.Name = "btn_autoget";
            this.btn_autoget.Size = new System.Drawing.Size(231, 69);
            this.btn_autoget.TabIndex = 2;
            this.btn_autoget.Text = "Autorun";
            this.btn_autoget.UseVisualStyleBackColor = true;
            this.btn_autoget.Click += new System.EventHandler(this.btn_autoget_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Location = new System.Drawing.Point(3, 3);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(281, 69);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "Browser folder in";
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // txt_browserin
            // 
            this.txt_browserin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_browserin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_browserin.Location = new System.Drawing.Point(290, 3);
            this.txt_browserin.Multiline = true;
            this.txt_browserin.Name = "txt_browserin";
            this.txt_browserin.Size = new System.Drawing.Size(331, 69);
            this.txt_browserin.TabIndex = 1;
            this.txt_browserin.Text = "D:\\ncvcpqm\\ncvc01\\ftpin\\SMT\\ERP_CLR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(864, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer (s)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox2, 5);
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(3, 112);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.tableLayoutPanel1.SetRowSpan(this.textBox2, 2);
            this.textBox2.Size = new System.Drawing.Size(1431, 292);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 3);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(855, 74);
            this.label2.TabIndex = 6;
            this.label2.Text = "Version: 0.1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(864, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 74);
            this.label3.TabIndex = 15;
            this.label3.Text = "waiting upload";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1151, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 74);
            this.label4.TabIndex = 16;
            this.label4.Text = "60";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_timer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown nud_timer;
        private System.Windows.Forms.Button btn_autoget;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txt_browserin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

