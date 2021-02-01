
namespace Congklak2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_player = new System.Windows.Forms.GroupBox();
            this.no_dots = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Home = new System.Windows.Forms.CheckBox();
            this.cb_again = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.tb_player2 = new System.Windows.Forms.TextBox();
            this.tb_player1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_a1 = new System.Windows.Forms.Button();
            this.bt_a2 = new System.Windows.Forms.Button();
            this.bt_a3 = new System.Windows.Forms.Button();
            this.bt_a4 = new System.Windows.Forms.Button();
            this.bt_a5 = new System.Windows.Forms.Button();
            this.bt_b1 = new System.Windows.Forms.Button();
            this.bt_b2 = new System.Windows.Forms.Button();
            this.bt_b3 = new System.Windows.Forms.Button();
            this.bt_b4 = new System.Windows.Forms.Button();
            this.bt_b5 = new System.Windows.Forms.Button();
            this.lb_a0 = new System.Windows.Forms.Label();
            this.lb_a1 = new System.Windows.Forms.Label();
            this.lb_a2 = new System.Windows.Forms.Label();
            this.lb_a3 = new System.Windows.Forms.Label();
            this.lb_a4 = new System.Windows.Forms.Label();
            this.lb_a5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_b1 = new System.Windows.Forms.Label();
            this.lb_b2 = new System.Windows.Forms.Label();
            this.lb_b3 = new System.Windows.Forms.Label();
            this.lb_b4 = new System.Windows.Forms.Label();
            this.lb_b5 = new System.Windows.Forms.Label();
            this.lb_b0 = new System.Windows.Forms.Label();
            this.bt_a6 = new System.Windows.Forms.Button();
            this.lb_a6 = new System.Windows.Forms.Label();
            this.lb_b6 = new System.Windows.Forms.Label();
            this.bt_b6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_playturn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_dt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_bf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_sn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_dots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_player
            // 
            this.gb_player.Controls.Add(this.no_dots);
            this.gb_player.Controls.Add(this.label7);
            this.gb_player.Controls.Add(this.cb_Home);
            this.gb_player.Controls.Add(this.cb_again);
            this.gb_player.Controls.Add(this.label6);
            this.gb_player.Controls.Add(this.bt_start);
            this.gb_player.Controls.Add(this.tb_player2);
            this.gb_player.Controls.Add(this.tb_player1);
            this.gb_player.Controls.Add(this.label2);
            this.gb_player.Controls.Add(this.label1);
            this.gb_player.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_player.Location = new System.Drawing.Point(20, 21);
            this.gb_player.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gb_player.Name = "gb_player";
            this.gb_player.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gb_player.Size = new System.Drawing.Size(347, 461);
            this.gb_player.TabIndex = 0;
            this.gb_player.TabStop = false;
            this.gb_player.Text = "Game";
            // 
            // no_dots
            // 
            this.no_dots.Location = new System.Drawing.Point(107, 335);
            this.no_dots.Name = "no_dots";
            this.no_dots.Size = new System.Drawing.Size(218, 50);
            this.no_dots.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 45);
            this.label7.TabIndex = 31;
            this.label7.Text = "Dots:";
            // 
            // cb_Home
            // 
            this.cb_Home.AutoSize = true;
            this.cb_Home.Location = new System.Drawing.Point(61, 288);
            this.cb_Home.Name = "cb_Home";
            this.cb_Home.Size = new System.Drawing.Size(208, 49);
            this.cb_Home.TabIndex = 32;
            this.cb_Home.Text = "Home First";
            this.cb_Home.UseVisualStyleBackColor = true;
            this.cb_Home.CheckedChanged += new System.EventHandler(this.cb_Home_CheckedChanged);
            // 
            // cb_again
            // 
            this.cb_again.AutoSize = true;
            this.cb_again.Checked = true;
            this.cb_again.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_again.Location = new System.Drawing.Point(61, 233);
            this.cb_again.Name = "cb_again";
            this.cb_again.Size = new System.Drawing.Size(203, 49);
            this.cb_again.TabIndex = 31;
            this.cb_again.Text = "Again First";
            this.cb_again.UseVisualStyleBackColor = true;
            this.cb_again.CheckedChanged += new System.EventHandler(this.cb_again_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 45);
            this.label6.TabIndex = 31;
            this.label6.Text = "Highlight Mode:";
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(199, 401);
            this.bt_start.Margin = new System.Windows.Forms.Padding(6);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(139, 51);
            this.bt_start.TabIndex = 30;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // tb_player2
            // 
            this.tb_player2.Location = new System.Drawing.Point(143, 117);
            this.tb_player2.Margin = new System.Windows.Forms.Padding(6);
            this.tb_player2.Name = "tb_player2";
            this.tb_player2.Size = new System.Drawing.Size(182, 50);
            this.tb_player2.TabIndex = 3;
            // 
            // tb_player1
            // 
            this.tb_player1.Location = new System.Drawing.Point(143, 43);
            this.tb_player1.Margin = new System.Windows.Forms.Padding(6);
            this.tb_player1.Name = "tb_player1";
            this.tb_player1.Size = new System.Drawing.Size(182, 50);
            this.tb_player1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player1:";
            // 
            // bt_a1
            // 
            this.bt_a1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_a1.Location = new System.Drawing.Point(427, 1003);
            this.bt_a1.Margin = new System.Windows.Forms.Padding(6);
            this.bt_a1.Name = "bt_a1";
            this.bt_a1.Size = new System.Drawing.Size(184, 64);
            this.bt_a1.TabIndex = 2;
            this.bt_a1.Text = "A1";
            this.bt_a1.UseVisualStyleBackColor = true;
            this.bt_a1.Click += new System.EventHandler(this.bt_a1_Click);
            // 
            // bt_a2
            // 
            this.bt_a2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_a2.Location = new System.Drawing.Point(660, 1003);
            this.bt_a2.Margin = new System.Windows.Forms.Padding(6);
            this.bt_a2.Name = "bt_a2";
            this.bt_a2.Size = new System.Drawing.Size(184, 64);
            this.bt_a2.TabIndex = 3;
            this.bt_a2.Text = "A2";
            this.bt_a2.UseVisualStyleBackColor = true;
            this.bt_a2.Click += new System.EventHandler(this.bt_a2_Click);
            // 
            // bt_a3
            // 
            this.bt_a3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_a3.Location = new System.Drawing.Point(889, 1003);
            this.bt_a3.Margin = new System.Windows.Forms.Padding(6);
            this.bt_a3.Name = "bt_a3";
            this.bt_a3.Size = new System.Drawing.Size(184, 64);
            this.bt_a3.TabIndex = 4;
            this.bt_a3.Text = "A3";
            this.bt_a3.UseVisualStyleBackColor = true;
            this.bt_a3.Click += new System.EventHandler(this.bt_a3_Click);
            // 
            // bt_a4
            // 
            this.bt_a4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_a4.Location = new System.Drawing.Point(1119, 1003);
            this.bt_a4.Margin = new System.Windows.Forms.Padding(6);
            this.bt_a4.Name = "bt_a4";
            this.bt_a4.Size = new System.Drawing.Size(184, 64);
            this.bt_a4.TabIndex = 5;
            this.bt_a4.Text = "A4";
            this.bt_a4.UseVisualStyleBackColor = true;
            this.bt_a4.Click += new System.EventHandler(this.bt_a4_Click);
            // 
            // bt_a5
            // 
            this.bt_a5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_a5.Location = new System.Drawing.Point(1362, 1003);
            this.bt_a5.Margin = new System.Windows.Forms.Padding(6);
            this.bt_a5.Name = "bt_a5";
            this.bt_a5.Size = new System.Drawing.Size(184, 64);
            this.bt_a5.TabIndex = 6;
            this.bt_a5.Text = "A5";
            this.bt_a5.UseVisualStyleBackColor = true;
            this.bt_a5.Click += new System.EventHandler(this.bt_a5_Click);
            // 
            // bt_b1
            // 
            this.bt_b1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_b1.Location = new System.Drawing.Point(1591, 523);
            this.bt_b1.Margin = new System.Windows.Forms.Padding(6);
            this.bt_b1.Name = "bt_b1";
            this.bt_b1.Size = new System.Drawing.Size(184, 64);
            this.bt_b1.TabIndex = 7;
            this.bt_b1.Text = "B1";
            this.bt_b1.UseVisualStyleBackColor = true;
            this.bt_b1.Click += new System.EventHandler(this.bt_b1_Click);
            // 
            // bt_b2
            // 
            this.bt_b2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_b2.Location = new System.Drawing.Point(1362, 523);
            this.bt_b2.Margin = new System.Windows.Forms.Padding(6);
            this.bt_b2.Name = "bt_b2";
            this.bt_b2.Size = new System.Drawing.Size(184, 64);
            this.bt_b2.TabIndex = 8;
            this.bt_b2.Text = "B2";
            this.bt_b2.UseVisualStyleBackColor = true;
            this.bt_b2.Click += new System.EventHandler(this.bt_b2_Click);
            // 
            // bt_b3
            // 
            this.bt_b3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_b3.Location = new System.Drawing.Point(1119, 523);
            this.bt_b3.Margin = new System.Windows.Forms.Padding(6);
            this.bt_b3.Name = "bt_b3";
            this.bt_b3.Size = new System.Drawing.Size(184, 64);
            this.bt_b3.TabIndex = 9;
            this.bt_b3.Text = "B3";
            this.bt_b3.UseVisualStyleBackColor = true;
            this.bt_b3.Click += new System.EventHandler(this.bt_b3_Click);
            // 
            // bt_b4
            // 
            this.bt_b4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_b4.Location = new System.Drawing.Point(889, 523);
            this.bt_b4.Margin = new System.Windows.Forms.Padding(6);
            this.bt_b4.Name = "bt_b4";
            this.bt_b4.Size = new System.Drawing.Size(184, 64);
            this.bt_b4.TabIndex = 10;
            this.bt_b4.Text = "B4";
            this.bt_b4.UseVisualStyleBackColor = true;
            this.bt_b4.Click += new System.EventHandler(this.bt_b4_Click);
            // 
            // bt_b5
            // 
            this.bt_b5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_b5.Location = new System.Drawing.Point(660, 523);
            this.bt_b5.Margin = new System.Windows.Forms.Padding(6);
            this.bt_b5.Name = "bt_b5";
            this.bt_b5.Size = new System.Drawing.Size(184, 64);
            this.bt_b5.TabIndex = 11;
            this.bt_b5.Text = "B5";
            this.bt_b5.UseVisualStyleBackColor = true;
            this.bt_b5.Click += new System.EventHandler(this.bt_b5_Click);
            // 
            // lb_a0
            // 
            this.lb_a0.AutoSize = true;
            this.lb_a0.BackColor = System.Drawing.Color.Transparent;
            this.lb_a0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_a0.Location = new System.Drawing.Point(201, 752);
            this.lb_a0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_a0.Name = "lb_a0";
            this.lb_a0.Size = new System.Drawing.Size(127, 91);
            this.lb_a0.TabIndex = 12;
            this.lb_a0.Text = "00";
            this.lb_a0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_a1
            // 
            this.lb_a1.AutoSize = true;
            this.lb_a1.BackColor = System.Drawing.Color.Transparent;
            this.lb_a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_a1.Location = new System.Drawing.Point(455, 837);
            this.lb_a1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_a1.Name = "lb_a1";
            this.lb_a1.Size = new System.Drawing.Size(127, 91);
            this.lb_a1.TabIndex = 13;
            this.lb_a1.Text = "00";
            this.lb_a1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_a2
            // 
            this.lb_a2.AutoSize = true;
            this.lb_a2.BackColor = System.Drawing.Color.Transparent;
            this.lb_a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_a2.Location = new System.Drawing.Point(688, 837);
            this.lb_a2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_a2.Name = "lb_a2";
            this.lb_a2.Size = new System.Drawing.Size(127, 91);
            this.lb_a2.TabIndex = 14;
            this.lb_a2.Text = "00";
            this.lb_a2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_a3
            // 
            this.lb_a3.AutoSize = true;
            this.lb_a3.BackColor = System.Drawing.Color.Transparent;
            this.lb_a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_a3.Location = new System.Drawing.Point(926, 837);
            this.lb_a3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_a3.Name = "lb_a3";
            this.lb_a3.Size = new System.Drawing.Size(127, 91);
            this.lb_a3.TabIndex = 15;
            this.lb_a3.Text = "00";
            this.lb_a3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_a4
            // 
            this.lb_a4.AutoSize = true;
            this.lb_a4.BackColor = System.Drawing.Color.Transparent;
            this.lb_a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_a4.Location = new System.Drawing.Point(1147, 837);
            this.lb_a4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_a4.Name = "lb_a4";
            this.lb_a4.Size = new System.Drawing.Size(127, 91);
            this.lb_a4.TabIndex = 16;
            this.lb_a4.Text = "00";
            this.lb_a4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_a5
            // 
            this.lb_a5.AutoSize = true;
            this.lb_a5.BackColor = System.Drawing.Color.Transparent;
            this.lb_a5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_a5.Location = new System.Drawing.Point(1391, 837);
            this.lb_a5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_a5.Name = "lb_a5";
            this.lb_a5.Size = new System.Drawing.Size(127, 91);
            this.lb_a5.TabIndex = 17;
            this.lb_a5.Text = "00";
            this.lb_a5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1264, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 89);
            this.label9.TabIndex = 23;
            this.label9.Text = "00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1095, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 89);
            this.label10.TabIndex = 22;
            this.label10.Text = "00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(892, 674);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 89);
            this.label11.TabIndex = 21;
            this.label11.Text = "00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(710, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 89);
            this.label12.TabIndex = 20;
            this.label12.Text = "00";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(531, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 89);
            this.label13.TabIndex = 19;
            this.label13.Text = "00";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_b1
            // 
            this.lb_b1.AutoSize = true;
            this.lb_b1.BackColor = System.Drawing.Color.Transparent;
            this.lb_b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_b1.Location = new System.Drawing.Point(1620, 652);
            this.lb_b1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_b1.Name = "lb_b1";
            this.lb_b1.Size = new System.Drawing.Size(127, 91);
            this.lb_b1.TabIndex = 22;
            this.lb_b1.Text = "00";
            this.lb_b1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_b2
            // 
            this.lb_b2.AutoSize = true;
            this.lb_b2.BackColor = System.Drawing.Color.Transparent;
            this.lb_b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_b2.Location = new System.Drawing.Point(1391, 652);
            this.lb_b2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_b2.Name = "lb_b2";
            this.lb_b2.Size = new System.Drawing.Size(127, 91);
            this.lb_b2.TabIndex = 21;
            this.lb_b2.Text = "00";
            this.lb_b2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_b3
            // 
            this.lb_b3.AutoSize = true;
            this.lb_b3.BackColor = System.Drawing.Color.Transparent;
            this.lb_b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_b3.Location = new System.Drawing.Point(1158, 652);
            this.lb_b3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_b3.Name = "lb_b3";
            this.lb_b3.Size = new System.Drawing.Size(127, 91);
            this.lb_b3.TabIndex = 20;
            this.lb_b3.Text = "00";
            this.lb_b3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_b4
            // 
            this.lb_b4.AutoSize = true;
            this.lb_b4.BackColor = System.Drawing.Color.Transparent;
            this.lb_b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_b4.Location = new System.Drawing.Point(926, 652);
            this.lb_b4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_b4.Name = "lb_b4";
            this.lb_b4.Size = new System.Drawing.Size(127, 91);
            this.lb_b4.TabIndex = 19;
            this.lb_b4.Text = "00";
            this.lb_b4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_b5
            // 
            this.lb_b5.AutoSize = true;
            this.lb_b5.BackColor = System.Drawing.Color.Transparent;
            this.lb_b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_b5.Location = new System.Drawing.Point(688, 652);
            this.lb_b5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_b5.Name = "lb_b5";
            this.lb_b5.Size = new System.Drawing.Size(127, 91);
            this.lb_b5.TabIndex = 18;
            this.lb_b5.Text = "00";
            this.lb_b5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_b0
            // 
            this.lb_b0.AutoSize = true;
            this.lb_b0.BackColor = System.Drawing.Color.Transparent;
            this.lb_b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_b0.Location = new System.Drawing.Point(1921, 752);
            this.lb_b0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_b0.Name = "lb_b0";
            this.lb_b0.Size = new System.Drawing.Size(127, 91);
            this.lb_b0.TabIndex = 23;
            this.lb_b0.Text = "00";
            this.lb_b0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_a6
            // 
            this.bt_a6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_a6.Location = new System.Drawing.Point(1620, 1003);
            this.bt_a6.Margin = new System.Windows.Forms.Padding(6);
            this.bt_a6.Name = "bt_a6";
            this.bt_a6.Size = new System.Drawing.Size(184, 64);
            this.bt_a6.TabIndex = 24;
            this.bt_a6.Text = "A6";
            this.bt_a6.UseVisualStyleBackColor = true;
            this.bt_a6.Click += new System.EventHandler(this.bt_a6_Click);
            // 
            // lb_a6
            // 
            this.lb_a6.AutoSize = true;
            this.lb_a6.BackColor = System.Drawing.Color.Transparent;
            this.lb_a6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_a6.Location = new System.Drawing.Point(1648, 837);
            this.lb_a6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_a6.Name = "lb_a6";
            this.lb_a6.Size = new System.Drawing.Size(127, 91);
            this.lb_a6.TabIndex = 25;
            this.lb_a6.Text = "00";
            this.lb_a6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_b6
            // 
            this.lb_b6.AutoSize = true;
            this.lb_b6.BackColor = System.Drawing.Color.Transparent;
            this.lb_b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_b6.Location = new System.Drawing.Point(455, 652);
            this.lb_b6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_b6.Name = "lb_b6";
            this.lb_b6.Size = new System.Drawing.Size(127, 91);
            this.lb_b6.TabIndex = 26;
            this.lb_b6.Text = "00";
            this.lb_b6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_b6
            // 
            this.bt_b6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_b6.Location = new System.Drawing.Point(427, 523);
            this.bt_b6.Margin = new System.Windows.Forms.Padding(6);
            this.bt_b6.Name = "bt_b6";
            this.bt_b6.Size = new System.Drawing.Size(184, 64);
            this.bt_b6.TabIndex = 27;
            this.bt_b6.Text = "B6";
            this.bt_b6.UseVisualStyleBackColor = true;
            this.bt_b6.Click += new System.EventHandler(this.bt_b6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 599);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2203, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lb_playturn
            // 
            this.lb_playturn.AutoSize = true;
            this.lb_playturn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_playturn.Location = new System.Drawing.Point(1041, 37);
            this.lb_playturn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_playturn.Name = "lb_playturn";
            this.lb_playturn.Size = new System.Drawing.Size(129, 72);
            this.lb_playturn.TabIndex = 29;
            this.lb_playturn.Text = "turn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_dt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_bf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_sn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(383, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 461);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // tb_dt
            // 
            this.tb_dt.Location = new System.Drawing.Point(6, 240);
            this.tb_dt.Multiline = true;
            this.tb_dt.Name = "tb_dt";
            this.tb_dt.Size = new System.Drawing.Size(388, 215);
            this.tb_dt.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 45);
            this.label5.TabIndex = 32;
            this.label5.Text = "Detail:";
            // 
            // tb_bf
            // 
            this.tb_bf.Location = new System.Drawing.Point(6, 139);
            this.tb_bf.Name = "tb_bf";
            this.tb_bf.Size = new System.Drawing.Size(388, 50);
            this.tb_bf.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 45);
            this.label4.TabIndex = 31;
            this.label4.Text = "Brief:";
            // 
            // lb_sn
            // 
            this.lb_sn.AutoSize = true;
            this.lb_sn.Location = new System.Drawing.Point(101, 46);
            this.lb_sn.Name = "lb_sn";
            this.lb_sn.Size = new System.Drawing.Size(54, 45);
            this.lb_sn.TabIndex = 31;
            this.lb_sn.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 45);
            this.label3.TabIndex = 31;
            this.label3.Text = "S/N: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2240, 1088);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_playturn);
            this.Controls.Add(this.bt_b6);
            this.Controls.Add(this.lb_b6);
            this.Controls.Add(this.lb_a6);
            this.Controls.Add(this.bt_a6);
            this.Controls.Add(this.lb_b0);
            this.Controls.Add(this.lb_b1);
            this.Controls.Add(this.lb_b2);
            this.Controls.Add(this.lb_b3);
            this.Controls.Add(this.lb_b4);
            this.Controls.Add(this.lb_b5);
            this.Controls.Add(this.lb_a5);
            this.Controls.Add(this.lb_a4);
            this.Controls.Add(this.lb_a3);
            this.Controls.Add(this.lb_a2);
            this.Controls.Add(this.lb_a1);
            this.Controls.Add(this.lb_a0);
            this.Controls.Add(this.bt_b5);
            this.Controls.Add(this.bt_b4);
            this.Controls.Add(this.bt_b3);
            this.Controls.Add(this.bt_b2);
            this.Controls.Add(this.bt_b1);
            this.Controls.Add(this.bt_a5);
            this.Controls.Add(this.bt_a4);
            this.Controls.Add(this.bt_a3);
            this.Controls.Add(this.bt_a2);
            this.Controls.Add(this.bt_a1);
            this.Controls.Add(this.gb_player);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Congklak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_player.ResumeLayout(false);
            this.gb_player.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_dots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_player;
        private System.Windows.Forms.TextBox tb_player2;
        private System.Windows.Forms.TextBox tb_player1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_a1;
        private System.Windows.Forms.Button bt_a2;
        private System.Windows.Forms.Button bt_a3;
        private System.Windows.Forms.Button bt_a4;
        private System.Windows.Forms.Button bt_a5;
        private System.Windows.Forms.Button bt_b1;
        private System.Windows.Forms.Button bt_b2;
        private System.Windows.Forms.Button bt_b3;
        private System.Windows.Forms.Button bt_b4;
        private System.Windows.Forms.Button bt_b5;
        private System.Windows.Forms.Label lb_a0;
        private System.Windows.Forms.Label lb_a1;
        private System.Windows.Forms.Label lb_a2;
        private System.Windows.Forms.Label lb_a3;
        private System.Windows.Forms.Label lb_a4;
        private System.Windows.Forms.Label lb_a5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_b1;
        private System.Windows.Forms.Label lb_b2;
        private System.Windows.Forms.Label lb_b3;
        private System.Windows.Forms.Label lb_b4;
        private System.Windows.Forms.Label lb_b5;
        private System.Windows.Forms.Label lb_b0;
        private System.Windows.Forms.Button bt_a6;
        private System.Windows.Forms.Label lb_a6;
        private System.Windows.Forms.Label lb_b6;
        private System.Windows.Forms.Button bt_b6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_playturn;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_sn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_dt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_bf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown no_dots;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_Home;
        private System.Windows.Forms.CheckBox cb_again;
        private System.Windows.Forms.Label label6;
    }
}

