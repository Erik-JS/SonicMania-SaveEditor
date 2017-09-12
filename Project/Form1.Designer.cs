namespace SonicMania_SaveEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opt8 = new System.Windows.Forms.RadioButton();
            this.opt7 = new System.Windows.Forms.RadioButton();
            this.opt6 = new System.Windows.Forms.RadioButton();
            this.opt5 = new System.Windows.Forms.RadioButton();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.btnResetGR = new System.Windows.Forms.Button();
            this.cboSpecialStage = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEmerald7 = new System.Windows.Forms.CheckBox();
            this.chkEmerald6 = new System.Windows.Forms.CheckBox();
            this.chkEmerald5 = new System.Windows.Forms.CheckBox();
            this.chkEmerald4 = new System.Windows.Forms.CheckBox();
            this.chkEmerald3 = new System.Windows.Forms.CheckBox();
            this.chkEmerald2 = new System.Windows.Forms.CheckBox();
            this.chkEmerald1 = new System.Windows.Forms.CheckBox();
            this.cboCharacter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.TextBox();
            this.cboZone = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTargetScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAllGold = new System.Windows.Forms.Button();
            this.btnAllSilver = new System.Windows.Forms.Button();
            this.btnAllBlank = new System.Windows.Forms.Button();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSilver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBS1 = new System.Windows.Forms.Button();
            this.lblBlueSpheres = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.menuSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAsToolStripMenuItem.Text = "Save &as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // menuSeparator1
            // 
            this.menuSeparator1.Name = "menuSeparator1";
            this.menuSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 369);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnResetGR);
            this.tabPage1.Controls.Add(this.cboSpecialStage);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cboCharacter);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cboState);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtLives);
            this.tabPage1.Controls.Add(this.cboZone);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtTargetScore);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtScore);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Saved games";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opt8);
            this.groupBox2.Controls.Add(this.opt7);
            this.groupBox2.Controls.Add(this.opt6);
            this.groupBox2.Controls.Add(this.opt5);
            this.groupBox2.Controls.Add(this.opt4);
            this.groupBox2.Controls.Add(this.opt3);
            this.groupBox2.Controls.Add(this.opt2);
            this.groupBox2.Controls.Add(this.opt1);
            this.groupBox2.Location = new System.Drawing.Point(49, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 49);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select slot";
            // 
            // opt8
            // 
            this.opt8.AutoSize = true;
            this.opt8.Location = new System.Drawing.Point(30, 19);
            this.opt8.Name = "opt8";
            this.opt8.Size = new System.Drawing.Size(14, 13);
            this.opt8.TabIndex = 0;
            this.opt8.TabStop = true;
            this.opt8.UseVisualStyleBackColor = true;
            // 
            // opt7
            // 
            this.opt7.AutoSize = true;
            this.opt7.Location = new System.Drawing.Point(80, 19);
            this.opt7.Name = "opt7";
            this.opt7.Size = new System.Drawing.Size(14, 13);
            this.opt7.TabIndex = 1;
            this.opt7.TabStop = true;
            this.opt7.UseVisualStyleBackColor = true;
            // 
            // opt6
            // 
            this.opt6.AutoSize = true;
            this.opt6.Location = new System.Drawing.Point(130, 19);
            this.opt6.Name = "opt6";
            this.opt6.Size = new System.Drawing.Size(14, 13);
            this.opt6.TabIndex = 2;
            this.opt6.TabStop = true;
            this.opt6.UseVisualStyleBackColor = true;
            // 
            // opt5
            // 
            this.opt5.AutoSize = true;
            this.opt5.Location = new System.Drawing.Point(180, 19);
            this.opt5.Name = "opt5";
            this.opt5.Size = new System.Drawing.Size(14, 13);
            this.opt5.TabIndex = 3;
            this.opt5.TabStop = true;
            this.opt5.UseVisualStyleBackColor = true;
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.Location = new System.Drawing.Point(230, 19);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(14, 13);
            this.opt4.TabIndex = 4;
            this.opt4.TabStop = true;
            this.opt4.UseVisualStyleBackColor = true;
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Location = new System.Drawing.Point(280, 19);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(14, 13);
            this.opt3.TabIndex = 5;
            this.opt3.TabStop = true;
            this.opt3.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(330, 19);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(14, 13);
            this.opt2.TabIndex = 6;
            this.opt2.TabStop = true;
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Checked = true;
            this.opt1.Location = new System.Drawing.Point(380, 19);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(14, 13);
            this.opt1.TabIndex = 7;
            this.opt1.TabStop = true;
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // btnResetGR
            // 
            this.btnResetGR.Location = new System.Drawing.Point(285, 291);
            this.btnResetGR.Name = "btnResetGR";
            this.btnResetGR.Size = new System.Drawing.Size(121, 27);
            this.btnResetGR.TabIndex = 20;
            this.btnResetGR.Text = "Reset giant rings";
            this.btnResetGR.UseVisualStyleBackColor = true;
            this.btnResetGR.Click += new System.EventHandler(this.btnResetGR_Click);
            // 
            // cboSpecialStage
            // 
            this.cboSpecialStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpecialStage.FormattingEnabled = true;
            this.cboSpecialStage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboSpecialStage.Location = new System.Drawing.Point(285, 264);
            this.cboSpecialStage.Name = "cboSpecialStage";
            this.cboSpecialStage.Size = new System.Drawing.Size(121, 21);
            this.cboSpecialStage.TabIndex = 19;
            this.cboSpecialStage.SelectedIndexChanged += new System.EventHandler(this.cboSpecialStage_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Next Special Stage:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEmerald7);
            this.groupBox1.Controls.Add(this.chkEmerald6);
            this.groupBox1.Controls.Add(this.chkEmerald5);
            this.groupBox1.Controls.Add(this.chkEmerald4);
            this.groupBox1.Controls.Add(this.chkEmerald3);
            this.groupBox1.Controls.Add(this.chkEmerald2);
            this.groupBox1.Controls.Add(this.chkEmerald1);
            this.groupBox1.Location = new System.Drawing.Point(79, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 44);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chaos Emeralds";
            // 
            // chkEmerald7
            // 
            this.chkEmerald7.AutoSize = true;
            this.chkEmerald7.Location = new System.Drawing.Point(141, 19);
            this.chkEmerald7.Name = "chkEmerald7";
            this.chkEmerald7.Size = new System.Drawing.Size(15, 14);
            this.chkEmerald7.TabIndex = 6;
            this.chkEmerald7.UseVisualStyleBackColor = true;
            // 
            // chkEmerald6
            // 
            this.chkEmerald6.AutoSize = true;
            this.chkEmerald6.Location = new System.Drawing.Point(120, 19);
            this.chkEmerald6.Name = "chkEmerald6";
            this.chkEmerald6.Size = new System.Drawing.Size(15, 14);
            this.chkEmerald6.TabIndex = 5;
            this.chkEmerald6.UseVisualStyleBackColor = true;
            // 
            // chkEmerald5
            // 
            this.chkEmerald5.AutoSize = true;
            this.chkEmerald5.Location = new System.Drawing.Point(99, 19);
            this.chkEmerald5.Name = "chkEmerald5";
            this.chkEmerald5.Size = new System.Drawing.Size(15, 14);
            this.chkEmerald5.TabIndex = 4;
            this.chkEmerald5.UseVisualStyleBackColor = true;
            // 
            // chkEmerald4
            // 
            this.chkEmerald4.AutoSize = true;
            this.chkEmerald4.Location = new System.Drawing.Point(78, 19);
            this.chkEmerald4.Name = "chkEmerald4";
            this.chkEmerald4.Size = new System.Drawing.Size(15, 14);
            this.chkEmerald4.TabIndex = 3;
            this.chkEmerald4.UseVisualStyleBackColor = true;
            // 
            // chkEmerald3
            // 
            this.chkEmerald3.AutoSize = true;
            this.chkEmerald3.Location = new System.Drawing.Point(57, 19);
            this.chkEmerald3.Name = "chkEmerald3";
            this.chkEmerald3.Size = new System.Drawing.Size(15, 14);
            this.chkEmerald3.TabIndex = 2;
            this.chkEmerald3.UseVisualStyleBackColor = true;
            // 
            // chkEmerald2
            // 
            this.chkEmerald2.AutoSize = true;
            this.chkEmerald2.Location = new System.Drawing.Point(36, 19);
            this.chkEmerald2.Name = "chkEmerald2";
            this.chkEmerald2.Size = new System.Drawing.Size(15, 14);
            this.chkEmerald2.TabIndex = 1;
            this.chkEmerald2.UseVisualStyleBackColor = true;
            // 
            // chkEmerald1
            // 
            this.chkEmerald1.AutoSize = true;
            this.chkEmerald1.Location = new System.Drawing.Point(15, 19);
            this.chkEmerald1.Name = "chkEmerald1";
            this.chkEmerald1.Size = new System.Drawing.Size(15, 14);
            this.chkEmerald1.TabIndex = 0;
            this.chkEmerald1.UseVisualStyleBackColor = true;
            // 
            // cboCharacter
            // 
            this.cboCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCharacter.FormattingEnabled = true;
            this.cboCharacter.Items.AddRange(new object[] {
            "Sonic and Tails",
            "Sonic",
            "Tails",
            "Knuckles"});
            this.cboCharacter.Location = new System.Drawing.Point(79, 149);
            this.cboCharacter.Name = "cboCharacter";
            this.cboCharacter.Size = new System.Drawing.Size(121, 21);
            this.cboCharacter.TabIndex = 16;
            this.cboCharacter.SelectedIndexChanged += new System.EventHandler(this.cboCharacter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Character:";
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "New",
            "Continue from zone",
            "Clear"});
            this.cboState.Location = new System.Drawing.Point(79, 98);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 21);
            this.cboState.TabIndex = 14;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "State:";
            // 
            // txtLives
            // 
            this.txtLives.Location = new System.Drawing.Point(285, 99);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(125, 20);
            this.txtLives.TabIndex = 12;
            this.txtLives.TextChanged += new System.EventHandler(this.txtLives_TextChanged);
            this.txtLives.Leave += new System.EventHandler(this.txtLives_Leave);
            // 
            // cboZone
            // 
            this.cboZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZone.FormattingEnabled = true;
            this.cboZone.Items.AddRange(new object[] {
            "Green Hill",
            "Chemical Plant",
            "Studiopolis",
            "Flying Battery",
            "Press Garden",
            "Stardust Speedway",
            "Hydrocity",
            "Mirage Saloon",
            "Oil Ocean",
            "Lava Reef",
            "Metallic Madness",
            "Titanic Monarch",
            "Egg Reverie"});
            this.cboZone.Location = new System.Drawing.Point(79, 200);
            this.cboZone.Name = "cboZone";
            this.cboZone.Size = new System.Drawing.Size(121, 21);
            this.cboZone.TabIndex = 10;
            this.cboZone.SelectedIndexChanged += new System.EventHandler(this.cboZone_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zone:";
            // 
            // txtTargetScore
            // 
            this.txtTargetScore.Location = new System.Drawing.Point(285, 201);
            this.txtTargetScore.Name = "txtTargetScore";
            this.txtTargetScore.Size = new System.Drawing.Size(125, 20);
            this.txtTargetScore.TabIndex = 8;
            this.txtTargetScore.TextChanged += new System.EventHandler(this.txtTargetScore_TextChanged);
            this.txtTargetScore.Leave += new System.EventHandler(this.txtTargetScore_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Target score for next 1UP bonus:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(285, 150);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(125, 20);
            this.txtScore.TabIndex = 6;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            this.txtScore.Leave += new System.EventHandler(this.txtScore_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lives:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAllGold);
            this.tabPage2.Controls.Add(this.btnAllSilver);
            this.tabPage2.Controls.Add(this.btnAllBlank);
            this.tabPage2.Controls.Add(this.txtGold);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtSilver);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnBS1);
            this.tabPage2.Controls.Add(this.lblBlueSpheres);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Blue Spheres / Medals";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAllGold
            // 
            this.btnAllGold.Location = new System.Drawing.Point(285, 310);
            this.btnAllGold.Name = "btnAllGold";
            this.btnAllGold.Size = new System.Drawing.Size(90, 27);
            this.btnAllGold.TabIndex = 8;
            this.btnAllGold.Text = "All gold";
            this.btnAllGold.UseVisualStyleBackColor = true;
            this.btnAllGold.Click += new System.EventHandler(this.btnAllGold_Click);
            // 
            // btnAllSilver
            // 
            this.btnAllSilver.Location = new System.Drawing.Point(285, 284);
            this.btnAllSilver.Name = "btnAllSilver";
            this.btnAllSilver.Size = new System.Drawing.Size(90, 27);
            this.btnAllSilver.TabIndex = 7;
            this.btnAllSilver.Text = "All silver";
            this.btnAllSilver.UseVisualStyleBackColor = true;
            this.btnAllSilver.Click += new System.EventHandler(this.btnAllSilver_Click);
            // 
            // btnAllBlank
            // 
            this.btnAllBlank.Location = new System.Drawing.Point(285, 261);
            this.btnAllBlank.Name = "btnAllBlank";
            this.btnAllBlank.Size = new System.Drawing.Size(90, 27);
            this.btnAllBlank.TabIndex = 6;
            this.btnAllBlank.Text = "All blank";
            this.btnAllBlank.UseVisualStyleBackColor = true;
            this.btnAllBlank.Click += new System.EventHandler(this.btnAllBlank_Click);
            // 
            // txtGold
            // 
            this.txtGold.Enabled = false;
            this.txtGold.Location = new System.Drawing.Point(163, 305);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(99, 20);
            this.txtGold.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Gold:";
            // 
            // txtSilver
            // 
            this.txtSilver.Enabled = false;
            this.txtSilver.Location = new System.Drawing.Point(163, 281);
            this.txtSilver.Name = "txtSilver";
            this.txtSilver.Size = new System.Drawing.Size(99, 20);
            this.txtSilver.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silver:";
            // 
            // btnBS1
            // 
            this.btnBS1.BackColor = System.Drawing.Color.White;
            this.btnBS1.Location = new System.Drawing.Point(125, 112);
            this.btnBS1.Name = "btnBS1";
            this.btnBS1.Size = new System.Drawing.Size(32, 32);
            this.btnBS1.TabIndex = 1;
            this.btnBS1.UseVisualStyleBackColor = false;
            // 
            // lblBlueSpheres
            // 
            this.lblBlueSpheres.AutoSize = true;
            this.lblBlueSpheres.Location = new System.Drawing.Point(29, 29);
            this.lblBlueSpheres.Name = "lblBlueSpheres";
            this.lblBlueSpheres.Size = new System.Drawing.Size(471, 52);
            this.lblBlueSpheres.TabIndex = 0;
            this.lblBlueSpheres.Text = resources.GetString("lblBlueSpheres.Text");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 404);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonic Mania - SaveData.bin Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboZone;
        private System.Windows.Forms.TextBox txtLives;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCharacter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEmerald7;
        private System.Windows.Forms.CheckBox chkEmerald6;
        private System.Windows.Forms.CheckBox chkEmerald5;
        private System.Windows.Forms.CheckBox chkEmerald4;
        private System.Windows.Forms.CheckBox chkEmerald3;
        private System.Windows.Forms.CheckBox chkEmerald2;
        private System.Windows.Forms.CheckBox chkEmerald1;
        private System.Windows.Forms.ComboBox cboSpecialStage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnResetGR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton opt8;
        private System.Windows.Forms.RadioButton opt7;
        private System.Windows.Forms.RadioButton opt6;
        private System.Windows.Forms.RadioButton opt5;
        private System.Windows.Forms.RadioButton opt4;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.Label lblBlueSpheres;
        private System.Windows.Forms.Button btnBS1;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSilver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllGold;
        private System.Windows.Forms.Button btnAllSilver;
        private System.Windows.Forms.Button btnAllBlank;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

