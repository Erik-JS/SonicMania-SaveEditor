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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtContinues = new System.Windows.Forms.TextBox();
            this.opt11 = new System.Windows.Forms.RadioButton();
            this.opt12 = new System.Windows.Forms.RadioButton();
            this.opt13 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnChar1 = new System.Windows.Forms.Button();
            this.btnChar2 = new System.Windows.Forms.Button();
            this.btnChar3 = new System.Windows.Forms.Button();
            this.btnChar4 = new System.Windows.Forms.Button();
            this.btnChar5 = new System.Windows.Forms.Button();
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            this.tabPage1.Controls.Add(this.btnChar5);
            this.tabPage1.Controls.Add(this.btnChar4);
            this.tabPage1.Controls.Add(this.btnChar3);
            this.tabPage1.Controls.Add(this.btnChar2);
            this.tabPage1.Controls.Add(this.btnChar1);
            this.tabPage1.Controls.Add(this.txtContinues);
            this.tabPage1.Controls.Add(this.label10);
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
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.opt13);
            this.groupBox2.Controls.Add(this.opt12);
            this.groupBox2.Controls.Add(this.opt11);
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
            this.groupBox2.Size = new System.Drawing.Size(421, 64);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select slot";
            // 
            // opt8
            // 
            this.opt8.AutoSize = true;
            this.opt8.Location = new System.Drawing.Point(15, 19);
            this.opt8.Name = "opt8";
            this.opt8.Size = new System.Drawing.Size(14, 13);
            this.opt8.TabIndex = 0;
            this.opt8.TabStop = true;
            this.opt8.UseVisualStyleBackColor = true;
            // 
            // opt7
            // 
            this.opt7.AutoSize = true;
            this.opt7.Location = new System.Drawing.Point(46, 19);
            this.opt7.Name = "opt7";
            this.opt7.Size = new System.Drawing.Size(14, 13);
            this.opt7.TabIndex = 1;
            this.opt7.TabStop = true;
            this.opt7.UseVisualStyleBackColor = true;
            // 
            // opt6
            // 
            this.opt6.AutoSize = true;
            this.opt6.Location = new System.Drawing.Point(77, 19);
            this.opt6.Name = "opt6";
            this.opt6.Size = new System.Drawing.Size(14, 13);
            this.opt6.TabIndex = 2;
            this.opt6.TabStop = true;
            this.opt6.UseVisualStyleBackColor = true;
            // 
            // opt5
            // 
            this.opt5.AutoSize = true;
            this.opt5.Location = new System.Drawing.Point(108, 19);
            this.opt5.Name = "opt5";
            this.opt5.Size = new System.Drawing.Size(14, 13);
            this.opt5.TabIndex = 3;
            this.opt5.TabStop = true;
            this.opt5.UseVisualStyleBackColor = true;
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.Location = new System.Drawing.Point(139, 19);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(14, 13);
            this.opt4.TabIndex = 4;
            this.opt4.TabStop = true;
            this.opt4.UseVisualStyleBackColor = true;
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Location = new System.Drawing.Point(170, 19);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(14, 13);
            this.opt3.TabIndex = 5;
            this.opt3.TabStop = true;
            this.opt3.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(201, 19);
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
            this.opt1.Location = new System.Drawing.Point(232, 19);
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
            this.btnResetGR.TabIndex = 18;
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
            this.cboSpecialStage.TabIndex = 17;
            this.cboSpecialStage.SelectedIndexChanged += new System.EventHandler(this.cboSpecialStage_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 16;
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
            this.groupBox1.Location = new System.Drawing.Point(64, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 44);
            this.groupBox1.TabIndex = 15;
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
            "Knuckles",
            "Mighty",
            "Ray"});
            this.cboCharacter.Location = new System.Drawing.Point(79, 162);
            this.cboCharacter.Name = "cboCharacter";
            this.cboCharacter.Size = new System.Drawing.Size(121, 21);
            this.cboCharacter.TabIndex = 4;
            this.cboCharacter.SelectedIndexChanged += new System.EventHandler(this.cboCharacter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
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
            this.cboState.Location = new System.Drawing.Point(79, 110);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 21);
            this.cboState.TabIndex = 2;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "State:";
            // 
            // txtLives
            // 
            this.txtLives.Location = new System.Drawing.Point(292, 110);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(58, 20);
            this.txtLives.TabIndex = 8;
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
            this.cboZone.Location = new System.Drawing.Point(79, 217);
            this.cboZone.Name = "cboZone";
            this.cboZone.Size = new System.Drawing.Size(121, 21);
            this.cboZone.TabIndex = 6;
            this.cboZone.SelectedIndexChanged += new System.EventHandler(this.cboZone_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Zone:";
            // 
            // txtTargetScore
            // 
            this.txtTargetScore.Location = new System.Drawing.Point(289, 217);
            this.txtTargetScore.Name = "txtTargetScore";
            this.txtTargetScore.Size = new System.Drawing.Size(125, 20);
            this.txtTargetScore.TabIndex = 14;
            this.txtTargetScore.TextChanged += new System.EventHandler(this.txtTargetScore_TextChanged);
            this.txtTargetScore.Leave += new System.EventHandler(this.txtTargetScore_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Target score for next 1UP bonus:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(289, 162);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(125, 20);
            this.txtScore.TabIndex = 12;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            this.txtScore.Leave += new System.EventHandler(this.txtScore_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
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
            this.btnAllGold.TabIndex = 39;
            this.btnAllGold.Text = "All gold";
            this.btnAllGold.UseVisualStyleBackColor = true;
            this.btnAllGold.Click += new System.EventHandler(this.btnAllGold_Click);
            // 
            // btnAllSilver
            // 
            this.btnAllSilver.Location = new System.Drawing.Point(285, 284);
            this.btnAllSilver.Name = "btnAllSilver";
            this.btnAllSilver.Size = new System.Drawing.Size(90, 27);
            this.btnAllSilver.TabIndex = 38;
            this.btnAllSilver.Text = "All silver";
            this.btnAllSilver.UseVisualStyleBackColor = true;
            this.btnAllSilver.Click += new System.EventHandler(this.btnAllSilver_Click);
            // 
            // btnAllBlank
            // 
            this.btnAllBlank.Location = new System.Drawing.Point(285, 261);
            this.btnAllBlank.Name = "btnAllBlank";
            this.btnAllBlank.Size = new System.Drawing.Size(90, 27);
            this.btnAllBlank.TabIndex = 37;
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
            this.txtGold.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Gold:";
            // 
            // txtSilver
            // 
            this.txtSilver.Enabled = false;
            this.txtSilver.Location = new System.Drawing.Point(163, 281);
            this.txtSilver.Name = "txtSilver";
            this.txtSilver.Size = new System.Drawing.Size(99, 20);
            this.txtSilver.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 33;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Continues:";
            // 
            // txtContinues
            // 
            this.txtContinues.Location = new System.Drawing.Point(356, 110);
            this.txtContinues.Name = "txtContinues";
            this.txtContinues.Size = new System.Drawing.Size(58, 20);
            this.txtContinues.TabIndex = 10;
            this.txtContinues.TextChanged += new System.EventHandler(this.txtContinues_TextChanged);
            this.txtContinues.Leave += new System.EventHandler(this.txtContinues_Leave);
            // 
            // opt11
            // 
            this.opt11.AutoSize = true;
            this.opt11.Location = new System.Drawing.Point(320, 19);
            this.opt11.Name = "opt11";
            this.opt11.Size = new System.Drawing.Size(14, 13);
            this.opt11.TabIndex = 8;
            this.opt11.TabStop = true;
            this.opt11.UseVisualStyleBackColor = true;
            // 
            // opt12
            // 
            this.opt12.AutoSize = true;
            this.opt12.Location = new System.Drawing.Point(351, 19);
            this.opt12.Name = "opt12";
            this.opt12.Size = new System.Drawing.Size(14, 13);
            this.opt12.TabIndex = 9;
            this.opt12.TabStop = true;
            this.opt12.UseVisualStyleBackColor = true;
            // 
            // opt13
            // 
            this.opt13.AutoSize = true;
            this.opt13.Location = new System.Drawing.Point(382, 19);
            this.opt13.Name = "opt13";
            this.opt13.Size = new System.Drawing.Size(14, 13);
            this.opt13.TabIndex = 10;
            this.opt13.TabStop = true;
            this.opt13.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Mania";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Encore";
            // 
            // btnChar1
            // 
            this.btnChar1.Location = new System.Drawing.Point(79, 162);
            this.btnChar1.Name = "btnChar1";
            this.btnChar1.Size = new System.Drawing.Size(30, 28);
            this.btnChar1.TabIndex = 19;
            this.btnChar1.Text = "1";
            this.btnChar1.UseVisualStyleBackColor = true;
            // 
            // btnChar2
            // 
            this.btnChar2.Location = new System.Drawing.Point(110, 162);
            this.btnChar2.Name = "btnChar2";
            this.btnChar2.Size = new System.Drawing.Size(30, 28);
            this.btnChar2.TabIndex = 20;
            this.btnChar2.Text = "2";
            this.btnChar2.UseVisualStyleBackColor = true;
            // 
            // btnChar3
            // 
            this.btnChar3.Location = new System.Drawing.Point(141, 162);
            this.btnChar3.Name = "btnChar3";
            this.btnChar3.Size = new System.Drawing.Size(30, 28);
            this.btnChar3.TabIndex = 21;
            this.btnChar3.Text = "3";
            this.btnChar3.UseVisualStyleBackColor = true;
            // 
            // btnChar4
            // 
            this.btnChar4.Location = new System.Drawing.Point(172, 162);
            this.btnChar4.Name = "btnChar4";
            this.btnChar4.Size = new System.Drawing.Size(30, 28);
            this.btnChar4.TabIndex = 22;
            this.btnChar4.Text = "4";
            this.btnChar4.UseVisualStyleBackColor = true;
            // 
            // btnChar5
            // 
            this.btnChar5.Location = new System.Drawing.Point(203, 162);
            this.btnChar5.Name = "btnChar5";
            this.btnChar5.Size = new System.Drawing.Size(30, 28);
            this.btnChar5.TabIndex = 23;
            this.btnChar5.Text = "5";
            this.btnChar5.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TextBox txtContinues;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton opt13;
        private System.Windows.Forms.RadioButton opt12;
        private System.Windows.Forms.RadioButton opt11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnChar5;
        private System.Windows.Forms.Button btnChar4;
        private System.Windows.Forms.Button btnChar3;
        private System.Windows.Forms.Button btnChar2;
        private System.Windows.Forms.Button btnChar1;
    }
}

