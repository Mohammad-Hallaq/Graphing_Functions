namespace MINI_PROJECT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.func_list = new System.Windows.Forms.ComboBox();
            this.X0_val = new System.Windows.Forms.TextBox();
            this.XN_val = new System.Windows.Forms.TextBox();
            this.N_val = new System.Windows.Forms.TextBox();
            this.mypanel = new System.Windows.Forms.Panel();
            this.Y0_val = new System.Windows.Forms.TextBox();
            this.YN_val = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.TextBox();
            this.dc = new System.Windows.Forms.TextBox();
            this.color_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.draw_btn = new System.Windows.Forms.Button();
            this.datalist = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.title = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.th = new System.Windows.Forms.TextBox();
            this.thi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Function";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "XN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Min Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max Y";
            // 
            // func_list
            // 
            this.func_list.FormattingEnabled = true;
            this.func_list.Items.AddRange(new object[] {
            "sin",
            "cos",
            "ln",
            "|X|",
            "X^2",
            "3X+5",
            "tan"});
            this.func_list.Location = new System.Drawing.Point(49, 80);
            this.func_list.Name = "func_list";
            this.func_list.Size = new System.Drawing.Size(121, 21);
            this.func_list.TabIndex = 6;
            this.func_list.SelectedIndexChanged += new System.EventHandler(this.func_list_SelectedIndexChanged);
            // 
            // X0_val
            // 
            this.X0_val.Location = new System.Drawing.Point(86, 207);
            this.X0_val.Name = "X0_val";
            this.X0_val.Size = new System.Drawing.Size(84, 20);
            this.X0_val.TabIndex = 7;
            // 
            // XN_val
            // 
            this.XN_val.Location = new System.Drawing.Point(86, 241);
            this.XN_val.Name = "XN_val";
            this.XN_val.Size = new System.Drawing.Size(84, 20);
            this.XN_val.TabIndex = 8;
            // 
            // N_val
            // 
            this.N_val.Location = new System.Drawing.Point(86, 280);
            this.N_val.Name = "N_val";
            this.N_val.Size = new System.Drawing.Size(84, 20);
            this.N_val.TabIndex = 9;
            // 
            // mypanel
            // 
            this.mypanel.BackColor = System.Drawing.SystemColors.Window;
            this.mypanel.Location = new System.Drawing.Point(229, 154);
            this.mypanel.Name = "mypanel";
            this.mypanel.Size = new System.Drawing.Size(700, 400);
            this.mypanel.TabIndex = 10;
            this.mypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mypanel_Paint);
            this.mypanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.jerry);
            // 
            // Y0_val
            // 
            this.Y0_val.Location = new System.Drawing.Point(607, 52);
            this.Y0_val.Name = "Y0_val";
            this.Y0_val.ReadOnly = true;
            this.Y0_val.Size = new System.Drawing.Size(78, 20);
            this.Y0_val.TabIndex = 11;
            // 
            // YN_val
            // 
            this.YN_val.Location = new System.Drawing.Point(607, 89);
            this.YN_val.Name = "YN_val";
            this.YN_val.ReadOnly = true;
            this.YN_val.Size = new System.Drawing.Size(78, 20);
            this.YN_val.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mouse Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Panel Coordinates";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Drawing Coordinates";
            // 
            // pc
            // 
            this.pc.Location = new System.Drawing.Point(16, 69);
            this.pc.Name = "pc";
            this.pc.ReadOnly = true;
            this.pc.Size = new System.Drawing.Size(78, 20);
            this.pc.TabIndex = 16;
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(123, 69);
            this.dc.Name = "dc";
            this.dc.ReadOnly = true;
            this.dc.Size = new System.Drawing.Size(103, 20);
            this.dc.TabIndex = 17;
            // 
            // color_btn
            // 
            this.color_btn.Location = new System.Drawing.Point(49, 393);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(121, 23);
            this.color_btn.TabIndex = 18;
            this.color_btn.Text = "Color";
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(49, 452);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(121, 23);
            this.clear_btn.TabIndex = 20;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(49, 481);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(121, 23);
            this.save_btn.TabIndex = 21;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(959, 257);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(146, 23);
            this.loadbtn.TabIndex = 22;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.Button5_Click);
            // 
            // draw_btn
            // 
            this.draw_btn.Location = new System.Drawing.Point(49, 422);
            this.draw_btn.Name = "draw_btn";
            this.draw_btn.Size = new System.Drawing.Size(121, 23);
            this.draw_btn.TabIndex = 23;
            this.draw_btn.Text = "Draw";
            this.draw_btn.UseVisualStyleBackColor = true;
            this.draw_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // datalist
            // 
            this.datalist.FormattingEnabled = true;
            this.datalist.Location = new System.Drawing.Point(959, 300);
            this.datalist.Name = "datalist";
            this.datalist.Size = new System.Drawing.Size(146, 238);
            this.datalist.TabIndex = 24;
            this.datalist.SelectedIndexChanged += new System.EventHandler(this.datalist_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pc);
            this.panel1.Controls.Add(this.dc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(703, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 101);
            this.panel1.TabIndex = 25;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.InfoText;
            this.title.Location = new System.Drawing.Point(229, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(211, 89);
            this.title.TabIndex = 26;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // th
            // 
            this.th.Location = new System.Drawing.Point(86, 326);
            this.th.Name = "th";
            this.th.Size = new System.Drawing.Size(84, 20);
            this.th.TabIndex = 27;
            // 
            // thi
            // 
            this.thi.AutoSize = true;
            this.thi.Location = new System.Drawing.Point(26, 332);
            this.thi.Name = "thi";
            this.thi.Size = new System.Drawing.Size(53, 13);
            this.thi.TabIndex = 28;
            this.thi.Text = "Thickness";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 573);
            this.Controls.Add(this.title);
            this.Controls.Add(this.thi);
            this.Controls.Add(this.th);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datalist);
            this.Controls.Add(this.draw_btn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.color_btn);
            this.Controls.Add(this.YN_val);
            this.Controls.Add(this.Y0_val);
            this.Controls.Add(this.mypanel);
            this.Controls.Add(this.N_val);
            this.Controls.Add(this.XN_val);
            this.Controls.Add(this.X0_val);
            this.Controls.Add(this.func_list);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox func_list;
        private System.Windows.Forms.TextBox X0_val;
        private System.Windows.Forms.TextBox XN_val;
        private System.Windows.Forms.TextBox N_val;
        private System.Windows.Forms.Panel mypanel;
        private System.Windows.Forms.TextBox Y0_val;
        private System.Windows.Forms.TextBox YN_val;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pc;
        private System.Windows.Forms.TextBox dc;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button draw_btn;
        private System.Windows.Forms.ListBox datalist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox th;
        private System.Windows.Forms.Label thi;
    }
}

