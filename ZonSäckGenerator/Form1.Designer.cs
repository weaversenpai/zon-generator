namespace ZonSäckGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.HarderLife = new System.Windows.Forms.RadioButton();
            this.btnGen = new System.Windows.Forms.Button();
            this.HardLife = new System.Windows.Forms.RadioButton();
            this.EasyLife = new System.Windows.Forms.RadioButton();
            this.SmallBackpack = new System.Windows.Forms.RadioButton();
            this.MediumBackpack = new System.Windows.Forms.RadioButton();
            this.LargeBackpack = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.debugListbox = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkboxWeapon = new System.Windows.Forms.CheckBox();
            this.checkboxRare = new System.Windows.Forms.CheckBox();
            this.Music = new System.Windows.Forms.Button();
            this.HasardKnapp = new System.Windows.Forms.Button();
            this.GeneratorKnapp = new System.Windows.Forms.Button();
            this.FyndKnapp = new System.Windows.Forms.Button();
            this.textFynd = new System.Windows.Forms.Label();
            this.textGenerator = new System.Windows.Forms.Label();
            this.textHasard = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.labelUppslag = new System.Windows.Forms.Label();
            this.FyndUppslagCheckbox = new System.Windows.Forms.CheckBox();
            this.FyndUppslag = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("AgencyFB Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inväntar order...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Font = new System.Drawing.Font("Scala Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 36);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 304);
            this.listBox1.TabIndex = 2;
            // 
            // HarderLife
            // 
            this.HarderLife.AutoSize = true;
            this.HarderLife.Font = new System.Drawing.Font("Scala Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HarderLife.Location = new System.Drawing.Point(6, 87);
            this.HarderLife.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HarderLife.Name = "HarderLife";
            this.HarderLife.Size = new System.Drawing.Size(125, 17);
            this.HarderLife.TabIndex = 4;
            this.HarderLife.Text = "Totalt Jävla Mörker";
            this.HarderLife.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.SystemColors.Control;
            this.btnGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGen.Location = new System.Drawing.Point(908, 493);
            this.btnGen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(100, 57);
            this.btnGen.TabIndex = 5;
            this.btnGen.Text = "Generera";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // HardLife
            // 
            this.HardLife.AutoSize = true;
            this.HardLife.Font = new System.Drawing.Font("Scala Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardLife.Location = new System.Drawing.Point(6, 55);
            this.HardLife.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HardLife.Name = "HardLife";
            this.HardLife.Size = new System.Drawing.Size(100, 17);
            this.HardLife.TabIndex = 6;
            this.HardLife.Text = "Uppförsbacke";
            this.HardLife.UseVisualStyleBackColor = true;
            // 
            // EasyLife
            // 
            this.EasyLife.AutoSize = true;
            this.EasyLife.Checked = true;
            this.EasyLife.Font = new System.Drawing.Font("Scala Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyLife.Location = new System.Drawing.Point(6, 26);
            this.EasyLife.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EasyLife.Name = "EasyLife";
            this.EasyLife.Size = new System.Drawing.Size(102, 17);
            this.EasyLife.TabIndex = 7;
            this.EasyLife.TabStop = true;
            this.EasyLife.Text = "Solskensdagar";
            this.EasyLife.UseVisualStyleBackColor = true;
            // 
            // SmallBackpack
            // 
            this.SmallBackpack.AutoSize = true;
            this.SmallBackpack.Checked = true;
            this.SmallBackpack.Font = new System.Drawing.Font("Scala Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallBackpack.Location = new System.Drawing.Point(17, 26);
            this.SmallBackpack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SmallBackpack.Name = "SmallBackpack";
            this.SmallBackpack.Size = new System.Drawing.Size(105, 17);
            this.SmallBackpack.TabIndex = 8;
            this.SmallBackpack.TabStop = true;
            this.SmallBackpack.Text = "Mindre Portfölj";
            this.SmallBackpack.UseVisualStyleBackColor = true;
            this.SmallBackpack.CheckedChanged += new System.EventHandler(this.SmallBackpack_CheckedChanged);
            // 
            // MediumBackpack
            // 
            this.MediumBackpack.AutoSize = true;
            this.MediumBackpack.Font = new System.Drawing.Font("Scala Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumBackpack.Location = new System.Drawing.Point(17, 55);
            this.MediumBackpack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MediumBackpack.Name = "MediumBackpack";
            this.MediumBackpack.Size = new System.Drawing.Size(125, 17);
            this.MediumBackpack.TabIndex = 9;
            this.MediumBackpack.Text = "Ordentlig Ryggsäck";
            this.MediumBackpack.UseVisualStyleBackColor = true;
            this.MediumBackpack.CheckedChanged += new System.EventHandler(this.MediumBackpack_CheckedChanged);
            // 
            // LargeBackpack
            // 
            this.LargeBackpack.AutoSize = true;
            this.LargeBackpack.Font = new System.Drawing.Font("Scala Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargeBackpack.Location = new System.Drawing.Point(17, 87);
            this.LargeBackpack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LargeBackpack.Name = "LargeBackpack";
            this.LargeBackpack.Size = new System.Drawing.Size(106, 17);
            this.LargeBackpack.TabIndex = 10;
            this.LargeBackpack.Text = "Koffert Av Rang";
            this.LargeBackpack.UseVisualStyleBackColor = true;
            this.LargeBackpack.CheckedChanged += new System.EventHandler(this.LargeBackpack_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.SmallBackpack);
            this.groupBox1.Controls.Add(this.LargeBackpack);
            this.groupBox1.Controls.Add(this.MediumBackpack);
            this.groupBox1.Font = new System.Drawing.Font("AgencyFB Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(362, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(158, 115);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grovlek";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.EasyLife);
            this.groupBox2.Controls.Add(this.HardLife);
            this.groupBox2.Controls.Add(this.HarderLife);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("AgencyFB Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(362, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(158, 115);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prylkvalisort";
            // 
            // debugListbox
            // 
            this.debugListbox.FormattingEnabled = true;
            this.debugListbox.ItemHeight = 12;
            this.debugListbox.Location = new System.Drawing.Point(16, 351);
            this.debugListbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.debugListbox.Name = "debugListbox";
            this.debugListbox.Size = new System.Drawing.Size(121, 208);
            this.debugListbox.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox1.Font = new System.Drawing.Font("Scala Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(362, 380);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(128, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Visa automatknack";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkboxWeapon
            // 
            this.checkboxWeapon.AutoSize = true;
            this.checkboxWeapon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkboxWeapon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkboxWeapon.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.checkboxWeapon.Font = new System.Drawing.Font("Scala Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxWeapon.Location = new System.Drawing.Point(362, 296);
            this.checkboxWeapon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkboxWeapon.Name = "checkboxWeapon";
            this.checkboxWeapon.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.checkboxWeapon.Size = new System.Drawing.Size(113, 19);
            this.checkboxWeapon.TabIndex = 15;
            this.checkboxWeapon.Text = "Inkludera vapen";
            this.checkboxWeapon.UseVisualStyleBackColor = false;
            this.checkboxWeapon.CheckedChanged += new System.EventHandler(this.checkboxWeapon_CheckedChanged);
            // 
            // checkboxRare
            // 
            this.checkboxRare.AutoSize = true;
            this.checkboxRare.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkboxRare.Font = new System.Drawing.Font("Scala Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxRare.Location = new System.Drawing.Point(362, 321);
            this.checkboxRare.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkboxRare.Name = "checkboxRare";
            this.checkboxRare.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.checkboxRare.Size = new System.Drawing.Size(151, 19);
            this.checkboxRare.TabIndex = 16;
            this.checkboxRare.Text = "Inkludera rart fornskrot";
            this.checkboxRare.UseVisualStyleBackColor = false;
            this.checkboxRare.CheckedChanged += new System.EventHandler(this.checkboxRare_CheckedChanged);
            // 
            // Music
            // 
            this.Music.AccessibleName = "Musik";
            this.Music.Location = new System.Drawing.Point(908, 446);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(100, 29);
            this.Music.TabIndex = 17;
            this.Music.Text = "Slå på Stämning";
            this.Music.UseVisualStyleBackColor = true;
            this.Music.Click += new System.EventHandler(this.Music_Click);
            // 
            // HasardKnapp
            // 
            this.HasardKnapp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HasardKnapp.BackgroundImage")));
            this.HasardKnapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HasardKnapp.Font = new System.Drawing.Font("Scala Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HasardKnapp.Location = new System.Drawing.Point(702, 39);
            this.HasardKnapp.Margin = new System.Windows.Forms.Padding(0);
            this.HasardKnapp.Name = "HasardKnapp";
            this.HasardKnapp.Size = new System.Drawing.Size(280, 371);
            this.HasardKnapp.TabIndex = 18;
            this.HasardKnapp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HasardKnapp.UseVisualStyleBackColor = true;
            this.HasardKnapp.Click += new System.EventHandler(this.HasardKnapp_Click);
            // 
            // GeneratorKnapp
            // 
            this.GeneratorKnapp.BackColor = System.Drawing.Color.DimGray;
            this.GeneratorKnapp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeneratorKnapp.BackgroundImage")));
            this.GeneratorKnapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeneratorKnapp.Font = new System.Drawing.Font("Scala Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratorKnapp.Location = new System.Drawing.Point(368, 36);
            this.GeneratorKnapp.Name = "GeneratorKnapp";
            this.GeneratorKnapp.Size = new System.Drawing.Size(280, 371);
            this.GeneratorKnapp.TabIndex = 19;
            this.GeneratorKnapp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GeneratorKnapp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.GeneratorKnapp.UseVisualStyleBackColor = false;
            this.GeneratorKnapp.Click += new System.EventHandler(this.GeneratorKnapp_Click);
            // 
            // FyndKnapp
            // 
            this.FyndKnapp.BackColor = System.Drawing.Color.DimGray;
            this.FyndKnapp.BackgroundImage = global::ZonSäckGenerator.Properties.Resources.post_apocalyptic_looter_by_notmuchnormal_dbetemg;
            this.FyndKnapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FyndKnapp.Font = new System.Drawing.Font("Scala Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FyndKnapp.Location = new System.Drawing.Point(33, 36);
            this.FyndKnapp.Name = "FyndKnapp";
            this.FyndKnapp.Size = new System.Drawing.Size(280, 371);
            this.FyndKnapp.TabIndex = 20;
            this.FyndKnapp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FyndKnapp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.FyndKnapp.UseVisualStyleBackColor = false;
            this.FyndKnapp.Click += new System.EventHandler(this.FyndKnapp_Click);
            // 
            // textFynd
            // 
            this.textFynd.AutoSize = true;
            this.textFynd.BackColor = System.Drawing.Color.Transparent;
            this.textFynd.Font = new System.Drawing.Font("Scala Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFynd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textFynd.Location = new System.Drawing.Point(91, 410);
            this.textFynd.Name = "textFynd";
            this.textFynd.Size = new System.Drawing.Size(148, 24);
            this.textFynd.TabIndex = 21;
            this.textFynd.Text = "Skapa Zonfynd";
            // 
            // textGenerator
            // 
            this.textGenerator.AutoSize = true;
            this.textGenerator.BackColor = System.Drawing.Color.Transparent;
            this.textGenerator.Font = new System.Drawing.Font("Scala Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textGenerator.Location = new System.Drawing.Point(391, 410);
            this.textGenerator.Name = "textGenerator";
            this.textGenerator.Size = new System.Drawing.Size(222, 24);
            this.textGenerator.TabIndex = 22;
            this.textGenerator.Text = "Generera Zonfararsäck";
            // 
            // textHasard
            // 
            this.textHasard.AutoSize = true;
            this.textHasard.BackColor = System.Drawing.Color.Transparent;
            this.textHasard.Font = new System.Drawing.Font("Scala Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHasard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textHasard.Location = new System.Drawing.Point(753, 410);
            this.textHasard.Name = "textHasard";
            this.textHasard.Size = new System.Drawing.Size(155, 24);
            this.textHasard.TabIndex = 23;
            this.textHasard.Text = "Zonfararhasard";
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(429, 536);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(150, 23);
            this.menuButton.TabIndex = 24;
            this.menuButton.Text = "Tillbaka till Meny";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // labelUppslag
            // 
            this.labelUppslag.AutoSize = true;
            this.labelUppslag.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelUppslag.Font = new System.Drawing.Font("AgencyFB Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUppslag.Location = new System.Drawing.Point(659, 13);
            this.labelUppslag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUppslag.Name = "labelUppslag";
            this.labelUppslag.Size = new System.Drawing.Size(96, 22);
            this.labelUppslag.TabIndex = 26;
            this.labelUppslag.Text = "Fynduppslag";
            // 
            // FyndUppslagCheckbox
            // 
            this.FyndUppslagCheckbox.AutoSize = true;
            this.FyndUppslagCheckbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FyndUppslagCheckbox.Font = new System.Drawing.Font("Scala Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FyndUppslagCheckbox.Location = new System.Drawing.Point(361, 296);
            this.FyndUppslagCheckbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FyndUppslagCheckbox.Name = "FyndUppslagCheckbox";
            this.FyndUppslagCheckbox.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.FyndUppslagCheckbox.Size = new System.Drawing.Size(96, 19);
            this.FyndUppslagCheckbox.TabIndex = 27;
            this.FyndUppslagCheckbox.Text = "Fynduppslag";
            this.FyndUppslagCheckbox.UseVisualStyleBackColor = false;
            // 
            // FyndUppslag
            // 
            this.FyndUppslag.FormattingEnabled = true;
            this.FyndUppslag.ItemHeight = 12;
            this.FyndUppslag.Location = new System.Drawing.Point(654, 39);
            this.FyndUppslag.Name = "FyndUppslag";
            this.FyndUppslag.Size = new System.Drawing.Size(347, 184);
            this.FyndUppslag.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ZonSäckGenerator.Properties.Resources.Marodörer;
            this.ClientSize = new System.Drawing.Size(1024, 628);
            this.Controls.Add(this.FyndUppslag);
            this.Controls.Add(this.FyndUppslagCheckbox);
            this.Controls.Add(this.labelUppslag);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.textHasard);
            this.Controls.Add(this.textGenerator);
            this.Controls.Add(this.textFynd);
            this.Controls.Add(this.FyndKnapp);
            this.Controls.Add(this.HasardKnapp);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.checkboxRare);
            this.Controls.Add(this.checkboxWeapon);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.debugListbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GeneratorKnapp);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Scala Sans", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZonSäckGenerator 1.5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton HarderLife;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.RadioButton HardLife;
        private System.Windows.Forms.RadioButton EasyLife;
        private System.Windows.Forms.RadioButton SmallBackpack;
        private System.Windows.Forms.RadioButton MediumBackpack;
        private System.Windows.Forms.RadioButton LargeBackpack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox debugListbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkboxWeapon;
        private System.Windows.Forms.CheckBox checkboxRare;
        private System.Windows.Forms.Button Music;
        private System.Windows.Forms.Button HasardKnapp;
        private System.Windows.Forms.Button GeneratorKnapp;
        private System.Windows.Forms.Button FyndKnapp;
        private System.Windows.Forms.Label textFynd;
        private System.Windows.Forms.Label textGenerator;
        private System.Windows.Forms.Label textHasard;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label labelUppslag;
        private System.Windows.Forms.CheckBox FyndUppslagCheckbox;
        private System.Windows.Forms.ListBox FyndUppslag;
    }
}

