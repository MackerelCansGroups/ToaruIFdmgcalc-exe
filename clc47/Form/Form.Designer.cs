
using System;

namespace calc
{
    partial class Form
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_senzai2 = new System.Windows.Forms.GroupBox();
            this.checkBox_vec = new System.Windows.Forms.CheckBox();
            this.checkBox_vecm = new System.Windows.Forms.CheckBox();
            this.checkBox_vecl = new System.Windows.Forms.CheckBox();
            this.checkBox_lnk = new System.Windows.Forms.CheckBox();
            this.checkBox_anas = new System.Windows.Forms.CheckBox();
            this.checkBox_anam = new System.Windows.Forms.CheckBox();
            this.groupBox_kankyo = new System.Windows.Forms.GroupBox();
            this.label_per = new System.Windows.Forms.Label();
            this.checkBox_break = new System.Windows.Forms.CheckBox();
            this.label_chrBonus = new System.Windows.Forms.Label();
            this.textBox_chrBonus = new System.Windows.Forms.TextBox();
            this.label_bonus = new System.Windows.Forms.Label();
            this.comboBox_bonus = new System.Windows.Forms.ComboBox();
            this.label_super = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.comboBox_super = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_atkBonus = new System.Windows.Forms.Label();
            this.textBox_atkBonus = new System.Windows.Forms.TextBox();
            this.label_maxhp = new System.Windows.Forms.Label();
            this.label_sp2 = new System.Windows.Forms.Label();
            this.label_sp = new System.Windows.Forms.Label();
            this.comboBox_sp2 = new System.Windows.Forms.ComboBox();
            this.label_hp = new System.Windows.Forms.Label();
            this.comboBox_sp = new System.Windows.Forms.ComboBox();
            this.trackBar_n = new System.Windows.Forms.TrackBar();
            this.textBox_maxhp = new System.Windows.Forms.TextBox();
            this.textBox_hp = new System.Windows.Forms.TextBox();
            this.groupBox_senzai1 = new System.Windows.Forms.GroupBox();
            this.checkBox_shien = new System.Windows.Forms.CheckBox();
            this.checkBox_fuku = new System.Windows.Forms.CheckBox();
            this.checkBox_pl = new System.Windows.Forms.CheckBox();
            this.checkBox_pm = new System.Windows.Forms.CheckBox();
            this.groupBox_buf = new System.Windows.Forms.GroupBox();
            this.dataGridView_buf = new System.Windows.Forms.DataGridView();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_savgrid = new System.Windows.Forms.Button();
            this.groupBox_st = new System.Windows.Forms.GroupBox();
            this.label_antidmg = new System.Windows.Forms.Label();
            this.textBox_antidmg = new System.Windows.Forms.TextBox();
            this.checkBox_match = new System.Windows.Forms.CheckBox();
            this.label_slv = new System.Windows.Forms.Label();
            this.label_def = new System.Windows.Forms.Label();
            this.label_atkB = new System.Windows.Forms.Label();
            this.label_atkA = new System.Windows.Forms.Label();
            this.textBox_atkB = new System.Windows.Forms.TextBox();
            this.textBox_atkA = new System.Windows.Forms.TextBox();
            this.textBox_slv = new System.Windows.Forms.TextBox();
            this.comboBox_def = new System.Windows.Forms.ComboBox();
            this.groupBox_res = new System.Windows.Forms.GroupBox();
            this.button_out = new System.Windows.Forms.Button();
            this.dataGridView_res = new System.Windows.Forms.DataGridView();
            this.label_trackBar = new System.Windows.Forms.Label();
            this.groupBox_sp = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_senzai2.SuspendLayout();
            this.groupBox_kankyo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_n)).BeginInit();
            this.groupBox_senzai1.SuspendLayout();
            this.groupBox_buf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buf)).BeginInit();
            this.groupBox_st.SuspendLayout();
            this.groupBox_res.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_res)).BeginInit();
            this.groupBox_sp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_senzai2
            // 
            this.groupBox_senzai2.Controls.Add(this.checkBox_vec);
            this.groupBox_senzai2.Controls.Add(this.checkBox_vecm);
            this.groupBox_senzai2.Controls.Add(this.checkBox_vecl);
            this.groupBox_senzai2.Controls.Add(this.checkBox_lnk);
            this.groupBox_senzai2.Controls.Add(this.checkBox_anas);
            this.groupBox_senzai2.Controls.Add(this.checkBox_anam);
            this.groupBox_senzai2.Location = new System.Drawing.Point(325, 9);
            this.groupBox_senzai2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_senzai2.Name = "groupBox_senzai2";
            this.groupBox_senzai2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_senzai2.Size = new System.Drawing.Size(133, 111);
            this.groupBox_senzai2.TabIndex = 0;
            this.groupBox_senzai2.TabStop = false;
            this.groupBox_senzai2.Text = "潜在2";
            // 
            // checkBox_vec
            // 
            this.checkBox_vec.AutoSize = true;
            this.checkBox_vec.Location = new System.Drawing.Point(5, 17);
            this.checkBox_vec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_vec.Name = "checkBox_vec";
            this.checkBox_vec.Size = new System.Drawing.Size(48, 16);
            this.checkBox_vec.TabIndex = 11;
            this.checkBox_vec.Text = "方向";
            this.checkBox_vec.UseVisualStyleBackColor = true;
            // 
            // checkBox_vecm
            // 
            this.checkBox_vecm.AutoSize = true;
            this.checkBox_vecm.Location = new System.Drawing.Point(5, 37);
            this.checkBox_vecm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_vecm.Name = "checkBox_vecm";
            this.checkBox_vecm.Size = new System.Drawing.Size(60, 16);
            this.checkBox_vecm.TabIndex = 12;
            this.checkBox_vecm.Text = "方向中";
            this.checkBox_vecm.UseVisualStyleBackColor = true;
            // 
            // checkBox_vecl
            // 
            this.checkBox_vecl.AutoSize = true;
            this.checkBox_vecl.Location = new System.Drawing.Point(5, 57);
            this.checkBox_vecl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_vecl.Name = "checkBox_vecl";
            this.checkBox_vecl.Size = new System.Drawing.Size(60, 16);
            this.checkBox_vecl.TabIndex = 13;
            this.checkBox_vecl.Text = "方向大";
            this.checkBox_vecl.UseVisualStyleBackColor = true;
            // 
            // checkBox_lnk
            // 
            this.checkBox_lnk.AutoSize = true;
            this.checkBox_lnk.Location = new System.Drawing.Point(68, 17);
            this.checkBox_lnk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_lnk.Name = "checkBox_lnk";
            this.checkBox_lnk.Size = new System.Drawing.Size(48, 16);
            this.checkBox_lnk.TabIndex = 14;
            this.checkBox_lnk.Text = "連携";
            this.checkBox_lnk.UseVisualStyleBackColor = true;
            // 
            // checkBox_anas
            // 
            this.checkBox_anas.AutoSize = true;
            this.checkBox_anas.Location = new System.Drawing.Point(68, 37);
            this.checkBox_anas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_anas.Name = "checkBox_anas";
            this.checkBox_anas.Size = new System.Drawing.Size(60, 16);
            this.checkBox_anas.TabIndex = 15;
            this.checkBox_anas.Text = "解析小";
            this.checkBox_anas.UseVisualStyleBackColor = true;
            // 
            // checkBox_anam
            // 
            this.checkBox_anam.AutoSize = true;
            this.checkBox_anam.Location = new System.Drawing.Point(68, 57);
            this.checkBox_anam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_anam.Name = "checkBox_anam";
            this.checkBox_anam.Size = new System.Drawing.Size(60, 16);
            this.checkBox_anam.TabIndex = 16;
            this.checkBox_anam.Text = "解析中";
            this.checkBox_anam.UseVisualStyleBackColor = true;
            // 
            // groupBox_kankyo
            // 
            this.groupBox_kankyo.Controls.Add(this.label_per);
            this.groupBox_kankyo.Controls.Add(this.checkBox_break);
            this.groupBox_kankyo.Controls.Add(this.label_chrBonus);
            this.groupBox_kankyo.Controls.Add(this.textBox_chrBonus);
            this.groupBox_kankyo.Controls.Add(this.label_bonus);
            this.groupBox_kankyo.Controls.Add(this.comboBox_bonus);
            this.groupBox_kankyo.Controls.Add(this.label_super);
            this.groupBox_kankyo.Controls.Add(this.label_type);
            this.groupBox_kankyo.Controls.Add(this.comboBox_super);
            this.groupBox_kankyo.Controls.Add(this.comboBox_type);
            this.groupBox_kankyo.Location = new System.Drawing.Point(313, 125);
            this.groupBox_kankyo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_kankyo.Name = "groupBox_kankyo";
            this.groupBox_kankyo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_kankyo.Size = new System.Drawing.Size(145, 115);
            this.groupBox_kankyo.TabIndex = 0;
            this.groupBox_kankyo.TabStop = false;
            this.groupBox_kankyo.Text = "環境";
            // 
            // label_per
            // 
            this.label_per.AutoSize = true;
            this.label_per.Location = new System.Drawing.Point(121, 75);
            this.label_per.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_per.Name = "label_per";
            this.label_per.Size = new System.Drawing.Size(11, 12);
            this.label_per.TabIndex = 32;
            this.label_per.Text = "%";
            // 
            // checkBox_break
            // 
            this.checkBox_break.AutoSize = true;
            this.checkBox_break.Location = new System.Drawing.Point(5, 95);
            this.checkBox_break.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_break.Name = "checkBox_break";
            this.checkBox_break.Size = new System.Drawing.Size(59, 16);
            this.checkBox_break.TabIndex = 21;
            this.checkBox_break.Text = "ブレイク";
            this.checkBox_break.UseVisualStyleBackColor = true;
            // 
            // label_chrBonus
            // 
            this.label_chrBonus.AutoSize = true;
            this.label_chrBonus.Location = new System.Drawing.Point(5, 77);
            this.label_chrBonus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_chrBonus.Name = "label_chrBonus";
            this.label_chrBonus.Size = new System.Drawing.Size(41, 12);
            this.label_chrBonus.TabIndex = 30;
            this.label_chrBonus.Text = "キャラボ";
            // 
            // textBox_chrBonus
            // 
            this.textBox_chrBonus.Location = new System.Drawing.Point(58, 73);
            this.textBox_chrBonus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_chrBonus.Name = "textBox_chrBonus";
            this.textBox_chrBonus.Size = new System.Drawing.Size(60, 19);
            this.textBox_chrBonus.TabIndex = 28;
            // 
            // label_bonus
            // 
            this.label_bonus.AutoSize = true;
            this.label_bonus.Location = new System.Drawing.Point(5, 57);
            this.label_bonus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_bonus.Name = "label_bonus";
            this.label_bonus.Size = new System.Drawing.Size(49, 12);
            this.label_bonus.TabIndex = 0;
            this.label_bonus.Text = "戦線ボナ";
            // 
            // comboBox_bonus
            // 
            this.comboBox_bonus.FormattingEnabled = true;
            this.comboBox_bonus.Location = new System.Drawing.Point(58, 53);
            this.comboBox_bonus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_bonus.Name = "comboBox_bonus";
            this.comboBox_bonus.Size = new System.Drawing.Size(60, 20);
            this.comboBox_bonus.TabIndex = 20;
            // 
            // label_super
            // 
            this.label_super.AutoSize = true;
            this.label_super.Location = new System.Drawing.Point(5, 37);
            this.label_super.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_super.Name = "label_super";
            this.label_super.Size = new System.Drawing.Size(41, 12);
            this.label_super.TabIndex = 0;
            this.label_super.Text = "超属性";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(5, 17);
            this.label_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(29, 12);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "相性";
            // 
            // comboBox_super
            // 
            this.comboBox_super.FormattingEnabled = true;
            this.comboBox_super.Location = new System.Drawing.Point(58, 33);
            this.comboBox_super.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_super.Name = "comboBox_super";
            this.comboBox_super.Size = new System.Drawing.Size(60, 20);
            this.comboBox_super.TabIndex = 19;
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(58, 13);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(60, 20);
            this.comboBox_type.TabIndex = 18;
            // 
            // label_atkBonus
            // 
            this.label_atkBonus.AutoSize = true;
            this.label_atkBonus.Location = new System.Drawing.Point(8, 65);
            this.label_atkBonus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_atkBonus.Name = "label_atkBonus";
            this.label_atkBonus.Size = new System.Drawing.Size(53, 12);
            this.label_atkBonus.TabIndex = 29;
            this.label_atkBonus.Text = "可変倍率";
            // 
            // textBox_atkBonus
            // 
            this.textBox_atkBonus.Location = new System.Drawing.Point(61, 60);
            this.textBox_atkBonus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_atkBonus.Name = "textBox_atkBonus";
            this.textBox_atkBonus.Size = new System.Drawing.Size(65, 19);
            this.textBox_atkBonus.TabIndex = 27;
            // 
            // label_maxhp
            // 
            this.label_maxhp.AutoSize = true;
            this.label_maxhp.Location = new System.Drawing.Point(8, 107);
            this.label_maxhp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_maxhp.Name = "label_maxhp";
            this.label_maxhp.Size = new System.Drawing.Size(44, 12);
            this.label_maxhp.TabIndex = 0;
            this.label_maxhp.Text = "最大HP";
            // 
            // label_sp2
            // 
            this.label_sp2.AutoSize = true;
            this.label_sp2.Location = new System.Drawing.Point(8, 41);
            this.label_sp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_sp2.Name = "label_sp2";
            this.label_sp2.Size = new System.Drawing.Size(29, 12);
            this.label_sp2.TabIndex = 0;
            this.label_sp2.Text = "特攻";
            // 
            // label_sp
            // 
            this.label_sp.AutoSize = true;
            this.label_sp.Location = new System.Drawing.Point(8, 21);
            this.label_sp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_sp.Name = "label_sp";
            this.label_sp.Size = new System.Drawing.Size(29, 12);
            this.label_sp.TabIndex = 0;
            this.label_sp.Text = "必殺";
            // 
            // comboBox_sp2
            // 
            this.comboBox_sp2.FormattingEnabled = true;
            this.comboBox_sp2.Location = new System.Drawing.Point(39, 39);
            this.comboBox_sp2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_sp2.Name = "comboBox_sp2";
            this.comboBox_sp2.Size = new System.Drawing.Size(86, 20);
            this.comboBox_sp2.TabIndex = 26;
            // 
            // label_hp
            // 
            this.label_hp.AutoSize = true;
            this.label_hp.Location = new System.Drawing.Point(8, 87);
            this.label_hp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hp.Name = "label_hp";
            this.label_hp.Size = new System.Drawing.Size(44, 12);
            this.label_hp.TabIndex = 0;
            this.label_hp.Text = "現在HP";
            // 
            // comboBox_sp
            // 
            this.comboBox_sp.FormattingEnabled = true;
            this.comboBox_sp.Location = new System.Drawing.Point(39, 19);
            this.comboBox_sp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_sp.Name = "comboBox_sp";
            this.comboBox_sp.Size = new System.Drawing.Size(86, 20);
            this.comboBox_sp.TabIndex = 25;
            // 
            // trackBar_n
            // 
            this.trackBar_n.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar_n.Location = new System.Drawing.Point(50, 124);
            this.trackBar_n.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBar_n.Name = "trackBar_n";
            this.trackBar_n.Size = new System.Drawing.Size(78, 45);
            this.trackBar_n.TabIndex = 24;
            this.trackBar_n.Value = 10;
            // 
            // textBox_maxhp
            // 
            this.textBox_maxhp.Location = new System.Drawing.Point(61, 102);
            this.textBox_maxhp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_maxhp.Name = "textBox_maxhp";
            this.textBox_maxhp.Size = new System.Drawing.Size(65, 19);
            this.textBox_maxhp.TabIndex = 23;
            // 
            // textBox_hp
            // 
            this.textBox_hp.Location = new System.Drawing.Point(61, 82);
            this.textBox_hp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_hp.Name = "textBox_hp";
            this.textBox_hp.Size = new System.Drawing.Size(65, 19);
            this.textBox_hp.TabIndex = 22;
            // 
            // groupBox_senzai1
            // 
            this.groupBox_senzai1.Controls.Add(this.checkBox_shien);
            this.groupBox_senzai1.Controls.Add(this.checkBox_fuku);
            this.groupBox_senzai1.Controls.Add(this.checkBox_pl);
            this.groupBox_senzai1.Controls.Add(this.checkBox_pm);
            this.groupBox_senzai1.Location = new System.Drawing.Point(250, 9);
            this.groupBox_senzai1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_senzai1.Name = "groupBox_senzai1";
            this.groupBox_senzai1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_senzai1.Size = new System.Drawing.Size(70, 111);
            this.groupBox_senzai1.TabIndex = 0;
            this.groupBox_senzai1.TabStop = false;
            this.groupBox_senzai1.Text = "潜在1";
            // 
            // checkBox_shien
            // 
            this.checkBox_shien.AutoSize = true;
            this.checkBox_shien.Location = new System.Drawing.Point(5, 77);
            this.checkBox_shien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_shien.Name = "checkBox_shien";
            this.checkBox_shien.Size = new System.Drawing.Size(60, 16);
            this.checkBox_shien.TabIndex = 10;
            this.checkBox_shien.Text = "支援大";
            this.checkBox_shien.UseVisualStyleBackColor = true;
            // 
            // checkBox_fuku
            // 
            this.checkBox_fuku.AutoSize = true;
            this.checkBox_fuku.Location = new System.Drawing.Point(5, 57);
            this.checkBox_fuku.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_fuku.Name = "checkBox_fuku";
            this.checkBox_fuku.Size = new System.Drawing.Size(48, 16);
            this.checkBox_fuku.TabIndex = 9;
            this.checkBox_fuku.Text = "複合";
            this.checkBox_fuku.UseVisualStyleBackColor = true;
            // 
            // checkBox_pl
            // 
            this.checkBox_pl.AutoSize = true;
            this.checkBox_pl.Location = new System.Drawing.Point(5, 37);
            this.checkBox_pl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_pl.Name = "checkBox_pl";
            this.checkBox_pl.Size = new System.Drawing.Size(36, 16);
            this.checkBox_pl.TabIndex = 8;
            this.checkBox_pl.Text = "大";
            this.checkBox_pl.UseVisualStyleBackColor = true;
            // 
            // checkBox_pm
            // 
            this.checkBox_pm.AutoSize = true;
            this.checkBox_pm.Location = new System.Drawing.Point(5, 17);
            this.checkBox_pm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_pm.Name = "checkBox_pm";
            this.checkBox_pm.Size = new System.Drawing.Size(36, 16);
            this.checkBox_pm.TabIndex = 7;
            this.checkBox_pm.Text = "中";
            this.checkBox_pm.UseVisualStyleBackColor = true;
            // 
            // groupBox_buf
            // 
            this.groupBox_buf.Controls.Add(this.dataGridView_buf);
            this.groupBox_buf.Location = new System.Drawing.Point(8, 125);
            this.groupBox_buf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_buf.Name = "groupBox_buf";
            this.groupBox_buf.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_buf.Size = new System.Drawing.Size(301, 295);
            this.groupBox_buf.TabIndex = 0;
            this.groupBox_buf.TabStop = false;
            this.groupBox_buf.Text = "バフ/デバフ ";
            // 
            // dataGridView_buf
            // 
            this.dataGridView_buf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_buf.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_buf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buf.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_buf.Location = new System.Drawing.Point(5, 17);
            this.dataGridView_buf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_buf.Name = "dataGridView_buf";
            this.dataGridView_buf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_buf.Size = new System.Drawing.Size(285, 270);
            this.dataGridView_buf.TabIndex = 17;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(61, 348);
            this.button_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(45, 31);
            this.button_clear.TabIndex = 18;
            this.button_clear.Text = "クリア";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_ClickClear);
            // 
            // button_savgrid
            // 
            this.button_savgrid.Location = new System.Drawing.Point(12, 348);
            this.button_savgrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_savgrid.Name = "button_savgrid";
            this.button_savgrid.Size = new System.Drawing.Size(45, 31);
            this.button_savgrid.TabIndex = 7;
            this.button_savgrid.Text = "保存";
            this.button_savgrid.UseVisualStyleBackColor = true;
            this.button_savgrid.Click += new System.EventHandler(this.Button_ClickSav);
            // 
            // groupBox_st
            // 
            this.groupBox_st.Controls.Add(this.label_antidmg);
            this.groupBox_st.Controls.Add(this.textBox_antidmg);
            this.groupBox_st.Controls.Add(this.checkBox_match);
            this.groupBox_st.Controls.Add(this.label_slv);
            this.groupBox_st.Controls.Add(this.label_def);
            this.groupBox_st.Controls.Add(this.label_atkB);
            this.groupBox_st.Controls.Add(this.label_atkA);
            this.groupBox_st.Controls.Add(this.textBox_atkB);
            this.groupBox_st.Controls.Add(this.textBox_atkA);
            this.groupBox_st.Controls.Add(this.textBox_slv);
            this.groupBox_st.Controls.Add(this.comboBox_def);
            this.groupBox_st.Location = new System.Drawing.Point(8, 9);
            this.groupBox_st.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_st.Name = "groupBox_st";
            this.groupBox_st.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_st.Size = new System.Drawing.Size(238, 111);
            this.groupBox_st.TabIndex = 0;
            this.groupBox_st.TabStop = false;
            this.groupBox_st.Text = "ステータス";
            // 
            // label_antidmg
            // 
            this.label_antidmg.AutoSize = true;
            this.label_antidmg.Location = new System.Drawing.Point(157, 59);
            this.label_antidmg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_antidmg.Name = "label_antidmg";
            this.label_antidmg.Size = new System.Drawing.Size(66, 12);
            this.label_antidmg.TabIndex = 30;
            this.label_antidmg.Text = "実ダメ(逆算)";
            // 
            // textBox_antidmg
            // 
            this.textBox_antidmg.Location = new System.Drawing.Point(157, 78);
            this.textBox_antidmg.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_antidmg.Name = "textBox_antidmg";
            this.textBox_antidmg.Size = new System.Drawing.Size(66, 19);
            this.textBox_antidmg.TabIndex = 7;
            // 
            // checkBox_match
            // 
            this.checkBox_match.AutoSize = true;
            this.checkBox_match.Checked = true;
            this.checkBox_match.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_match.Location = new System.Drawing.Point(157, 19);
            this.checkBox_match.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_match.Name = "checkBox_match";
            this.checkBox_match.Size = new System.Drawing.Size(72, 16);
            this.checkBox_match.TabIndex = 6;
            this.checkBox_match.Text = "属性一致";
            this.checkBox_match.UseVisualStyleBackColor = true;
            // 
            // label_slv
            // 
            this.label_slv.AutoSize = true;
            this.label_slv.Location = new System.Drawing.Point(8, 81);
            this.label_slv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_slv.Name = "label_slv";
            this.label_slv.Size = new System.Drawing.Size(26, 12);
            this.label_slv.TabIndex = 0;
            this.label_slv.Text = "SLV";
            // 
            // label_def
            // 
            this.label_def.AutoSize = true;
            this.label_def.Location = new System.Drawing.Point(8, 61);
            this.label_def.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_def.Name = "label_def";
            this.label_def.Size = new System.Drawing.Size(27, 12);
            this.label_def.TabIndex = 0;
            this.label_def.Text = "DEF";
            // 
            // label_atkB
            // 
            this.label_atkB.AutoSize = true;
            this.label_atkB.Location = new System.Drawing.Point(8, 21);
            this.label_atkB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_atkB.Name = "label_atkB";
            this.label_atkB.Size = new System.Drawing.Size(63, 12);
            this.label_atkB.TabIndex = 0;
            this.label_atkB.Text = "ATK(バトル)";
            // 
            // label_atkA
            // 
            this.label_atkA.AutoSize = true;
            this.label_atkA.Location = new System.Drawing.Point(8, 41);
            this.label_atkA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_atkA.Name = "label_atkA";
            this.label_atkA.Size = new System.Drawing.Size(71, 12);
            this.label_atkA.TabIndex = 0;
            this.label_atkA.Text = "ATK(アシスト)";
            // 
            // textBox_atkB
            // 
            this.textBox_atkB.Location = new System.Drawing.Point(87, 19);
            this.textBox_atkB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_atkB.Name = "textBox_atkB";
            this.textBox_atkB.Size = new System.Drawing.Size(66, 19);
            this.textBox_atkB.TabIndex = 3;
            // 
            // textBox_atkA
            // 
            this.textBox_atkA.Location = new System.Drawing.Point(87, 39);
            this.textBox_atkA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_atkA.Name = "textBox_atkA";
            this.textBox_atkA.Size = new System.Drawing.Size(66, 19);
            this.textBox_atkA.TabIndex = 4;
            // 
            // textBox_slv
            // 
            this.textBox_slv.Location = new System.Drawing.Point(87, 79);
            this.textBox_slv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_slv.Name = "textBox_slv";
            this.textBox_slv.Size = new System.Drawing.Size(66, 19);
            this.textBox_slv.TabIndex = 6;
            // 
            // comboBox_def
            // 
            this.comboBox_def.FormattingEnabled = true;
            this.comboBox_def.Location = new System.Drawing.Point(87, 59);
            this.comboBox_def.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_def.Name = "comboBox_def";
            this.comboBox_def.Size = new System.Drawing.Size(66, 20);
            this.comboBox_def.TabIndex = 5;
            // 
            // groupBox_res
            // 
            this.groupBox_res.Controls.Add(this.button_clear);
            this.groupBox_res.Controls.Add(this.button_savgrid);
            this.groupBox_res.Controls.Add(this.button_out);
            this.groupBox_res.Controls.Add(this.dataGridView_res);
            this.groupBox_res.Location = new System.Drawing.Point(463, 9);
            this.groupBox_res.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_res.Name = "groupBox_res";
            this.groupBox_res.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_res.Size = new System.Drawing.Size(242, 411);
            this.groupBox_res.TabIndex = 0;
            this.groupBox_res.TabStop = false;
            this.groupBox_res.Text = "計算結果";
            // 
            // button_out
            // 
            this.button_out.Location = new System.Drawing.Point(187, 348);
            this.button_out.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(45, 31);
            this.button_out.TabIndex = 19;
            this.button_out.Text = "出力";
            this.button_out.UseVisualStyleBackColor = true;
            this.button_out.Click += new System.EventHandler(this.Button_ClickOut);
            // 
            // dataGridView_res
            // 
            this.dataGridView_res.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_res.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_res.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_res.Location = new System.Drawing.Point(6, 17);
            this.dataGridView_res.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_res.Name = "dataGridView_res";
            this.dataGridView_res.ReadOnly = true;
            this.dataGridView_res.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_res.Size = new System.Drawing.Size(232, 386);
            this.dataGridView_res.TabIndex = 27;
            // 
            // label_trackBar
            // 
            this.label_trackBar.AutoSize = true;
            this.label_trackBar.Location = new System.Drawing.Point(8, 131);
            this.label_trackBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_trackBar.Name = "label_trackBar";
            this.label_trackBar.Size = new System.Drawing.Size(41, 12);
            this.label_trackBar.TabIndex = 31;
            this.label_trackBar.Text = "強化数";
            // 
            // groupBox_sp
            // 
            this.groupBox_sp.Controls.Add(this.label_trackBar);
            this.groupBox_sp.Controls.Add(this.trackBar_n);
            this.groupBox_sp.Controls.Add(this.label_atkBonus);
            this.groupBox_sp.Controls.Add(this.label_maxhp);
            this.groupBox_sp.Controls.Add(this.label_sp);
            this.groupBox_sp.Controls.Add(this.comboBox_sp);
            this.groupBox_sp.Controls.Add(this.textBox_atkBonus);
            this.groupBox_sp.Controls.Add(this.label_hp);
            this.groupBox_sp.Controls.Add(this.comboBox_sp2);
            this.groupBox_sp.Controls.Add(this.textBox_maxhp);
            this.groupBox_sp.Controls.Add(this.label_sp2);
            this.groupBox_sp.Controls.Add(this.textBox_hp);
            this.groupBox_sp.Location = new System.Drawing.Point(313, 245);
            this.groupBox_sp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_sp.Name = "groupBox_sp";
            this.groupBox_sp.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_sp.Size = new System.Drawing.Size(145, 175);
            this.groupBox_sp.TabIndex = 1;
            this.groupBox_sp.TabStop = false;
            this.groupBox_sp.Text = "スキル/必殺";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 500;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 425);
            this.Controls.Add(this.groupBox_sp);
            this.Controls.Add(this.groupBox_st);
            this.Controls.Add(this.groupBox_kankyo);
            this.Controls.Add(this.groupBox_buf);
            this.Controls.Add(this.groupBox_senzai2);
            this.Controls.Add(this.groupBox_senzai1);
            this.Controls.Add(this.groupBox_res);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox_senzai2.ResumeLayout(false);
            this.groupBox_senzai2.PerformLayout();
            this.groupBox_kankyo.ResumeLayout(false);
            this.groupBox_kankyo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_n)).EndInit();
            this.groupBox_senzai1.ResumeLayout(false);
            this.groupBox_senzai1.PerformLayout();
            this.groupBox_buf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buf)).EndInit();
            this.groupBox_st.ResumeLayout(false);
            this.groupBox_st.PerformLayout();
            this.groupBox_res.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_res)).EndInit();
            this.groupBox_sp.ResumeLayout(false);
            this.groupBox_sp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_senzai2;
        private System.Windows.Forms.CheckBox checkBox_vec;
        private System.Windows.Forms.CheckBox checkBox_vecm;
        private System.Windows.Forms.CheckBox checkBox_anam;
        private System.Windows.Forms.CheckBox checkBox_anas;
        private System.Windows.Forms.CheckBox checkBox_lnk;
        private System.Windows.Forms.CheckBox checkBox_vecl;
        private System.Windows.Forms.GroupBox groupBox_kankyo;
        private System.Windows.Forms.CheckBox checkBox_break;
        private System.Windows.Forms.GroupBox groupBox_senzai1;
        private System.Windows.Forms.CheckBox checkBox_shien;
        private System.Windows.Forms.CheckBox checkBox_fuku;
        private System.Windows.Forms.CheckBox checkBox_pl;
        private System.Windows.Forms.CheckBox checkBox_pm;
        private System.Windows.Forms.GroupBox groupBox_st;
        private System.Windows.Forms.GroupBox groupBox_buf;
        private System.Windows.Forms.TrackBar trackBar_n;
        private System.Windows.Forms.ComboBox comboBox_def;
        private System.Windows.Forms.GroupBox groupBox_res;
        private System.Windows.Forms.TextBox textBox_slv;
        private System.Windows.Forms.TextBox textBox_maxhp;
        private System.Windows.Forms.TextBox textBox_hp;
        private System.Windows.Forms.Label label_atkA;
        private System.Windows.Forms.Label label_slv;
        private System.Windows.Forms.Label label_def;
        private System.Windows.Forms.Label label_atkB;
        private System.Windows.Forms.DataGridView dataGridView_buf;
        private System.Windows.Forms.DataGridView dataGridView_res;
        private System.Windows.Forms.CheckBox checkBox_match;
        private System.Windows.Forms.ComboBox comboBox_super;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.TextBox textBox_atkB;
        private System.Windows.Forms.TextBox textBox_atkA;
        private System.Windows.Forms.ComboBox comboBox_sp;
        private System.Windows.Forms.ComboBox comboBox_sp2;
        private System.Windows.Forms.Label label_super;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_sp2;
        private System.Windows.Forms.Label label_sp;
        private System.Windows.Forms.Label label_hp;
        private System.Windows.Forms.Label label_bonus;
        private System.Windows.Forms.ComboBox comboBox_bonus;
        private System.Windows.Forms.Label label_maxhp;
        private System.Windows.Forms.TextBox textBox_chrBonus;
        private System.Windows.Forms.TextBox textBox_atkBonus;
        private System.Windows.Forms.Label label_chrBonus;
        private System.Windows.Forms.Label label_atkBonus;
        private System.Windows.Forms.Label label_trackBar;
        private System.Windows.Forms.GroupBox groupBox_sp;
        private System.Windows.Forms.Button button_savgrid;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_out;
        private System.Windows.Forms.Label label_per;
        private System.Windows.Forms.TextBox textBox_antidmg;
        private System.Windows.Forms.Label label_antidmg;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
