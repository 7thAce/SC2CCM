namespace Starcraft_Mod_Manager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.wolSelectBox = new System.Windows.Forms.ComboBox();
            this.wolTitleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wolSetButton = new System.Windows.Forms.Button();
            this.wolDeleteButton = new System.Windows.Forms.Button();
            this.wolRestoreButton = new System.Windows.Forms.Button();
            this.wolBox = new System.Windows.Forms.GroupBox();
            this.wolWarningImg = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.wolVersionBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.wolAuthorBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hotsTitleBox = new System.Windows.Forms.TextBox();
            this.hotsSetButton = new System.Windows.Forms.Button();
            this.hotsSelectBox = new System.Windows.Forms.ComboBox();
            this.hotsDeleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hotsRestoreButton = new System.Windows.Forms.Button();
            this.hotsBox = new System.Windows.Forms.GroupBox();
            this.hotsWarningImg = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.hotsVersionBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.hotsAuthorBox = new System.Windows.Forms.TextBox();
            this.ncoBox = new System.Windows.Forms.GroupBox();
            this.ncoWarningImg = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ncoRestoreButton = new System.Windows.Forms.Button();
            this.ncoVersionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ncoAuthorBox = new System.Windows.Forms.TextBox();
            this.ncoDeleteButton = new System.Windows.Forms.Button();
            this.ncoSelectBox = new System.Windows.Forms.ComboBox();
            this.ncoSetButton = new System.Windows.Forms.Button();
            this.ncoTitleBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lotvBox = new System.Windows.Forms.GroupBox();
            this.lotvWarningImg = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lotvRestoreButton = new System.Windows.Forms.Button();
            this.lotvVersionBox = new System.Windows.Forms.TextBox();
            this.lotvDeleteButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lotvAuthorBox = new System.Windows.Forms.TextBox();
            this.lotvSetButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lotvTitleBox = new System.Windows.Forms.TextBox();
            this.lotvSelectBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.findSC2Dialogue = new System.Windows.Forms.OpenFileDialog();
            this.importPicturebox = new System.Windows.Forms.PictureBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.selectFolderDialogue = new System.Windows.Forms.OpenFileDialog();
            this.wolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wolWarningImg)).BeginInit();
            this.hotsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotsWarningImg)).BeginInit();
            this.ncoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncoWarningImg)).BeginInit();
            this.lotvBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotvWarningImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active Mod";
            // 
            // wolSelectBox
            // 
            this.wolSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wolSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wolSelectBox.FormattingEnabled = true;
            this.wolSelectBox.Location = new System.Drawing.Point(1, 165);
            this.wolSelectBox.Name = "wolSelectBox";
            this.wolSelectBox.Size = new System.Drawing.Size(188, 21);
            this.wolSelectBox.TabIndex = 3;
            this.wolSelectBox.SelectedIndexChanged += new System.EventHandler(this.wolSelectBox_SelectedIndexChanged);
            // 
            // wolTitleBox
            // 
            this.wolTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.wolTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wolTitleBox.Location = new System.Drawing.Point(1, 42);
            this.wolTitleBox.Name = "wolTitleBox";
            this.wolTitleBox.Size = new System.Drawing.Size(188, 20);
            this.wolTitleBox.TabIndex = 4;
            this.wolTitleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select WoL Mod";
            // 
            // wolSetButton
            // 
            this.wolSetButton.Enabled = false;
            this.wolSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wolSetButton.Location = new System.Drawing.Point(6, 192);
            this.wolSetButton.Name = "wolSetButton";
            this.wolSetButton.Size = new System.Drawing.Size(178, 23);
            this.wolSetButton.TabIndex = 6;
            this.wolSetButton.Text = "Set to Active Campaign";
            this.wolSetButton.UseVisualStyleBackColor = true;
            this.wolSetButton.Click += new System.EventHandler(this.wolSetButton_Click);
            // 
            // wolDeleteButton
            // 
            this.wolDeleteButton.Enabled = false;
            this.wolDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wolDeleteButton.Location = new System.Drawing.Point(6, 221);
            this.wolDeleteButton.Name = "wolDeleteButton";
            this.wolDeleteButton.Size = new System.Drawing.Size(178, 23);
            this.wolDeleteButton.TabIndex = 7;
            this.wolDeleteButton.Text = "Delete Mod Files";
            this.wolDeleteButton.UseVisualStyleBackColor = true;
            this.wolDeleteButton.Click += new System.EventHandler(this.wolDeleteButton_Click);
            // 
            // wolRestoreButton
            // 
            this.wolRestoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wolRestoreButton.Location = new System.Drawing.Point(6, 250);
            this.wolRestoreButton.Name = "wolRestoreButton";
            this.wolRestoreButton.Size = new System.Drawing.Size(178, 23);
            this.wolRestoreButton.TabIndex = 8;
            this.wolRestoreButton.Text = "Restore to Unmodified";
            this.wolRestoreButton.UseVisualStyleBackColor = true;
            this.wolRestoreButton.Click += new System.EventHandler(this.wolRestoreButton_Click);
            // 
            // wolBox
            // 
            this.wolBox.BackColor = System.Drawing.SystemColors.Control;
            this.wolBox.Controls.Add(this.wolWarningImg);
            this.wolBox.Controls.Add(this.label10);
            this.wolBox.Controls.Add(this.wolVersionBox);
            this.wolBox.Controls.Add(this.label9);
            this.wolBox.Controls.Add(this.wolAuthorBox);
            this.wolBox.Controls.Add(this.wolRestoreButton);
            this.wolBox.Controls.Add(this.wolDeleteButton);
            this.wolBox.Controls.Add(this.wolSetButton);
            this.wolBox.Controls.Add(this.label2);
            this.wolBox.Controls.Add(this.wolTitleBox);
            this.wolBox.Controls.Add(this.wolSelectBox);
            this.wolBox.Controls.Add(this.label1);
            this.wolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.wolBox.Location = new System.Drawing.Point(12, 12);
            this.wolBox.Name = "wolBox";
            this.wolBox.Size = new System.Drawing.Size(190, 279);
            this.wolBox.TabIndex = 0;
            this.wolBox.TabStop = false;
            this.wolBox.Text = "Wings of Liberty";
            // 
            // wolWarningImg
            // 
            this.wolWarningImg.Image = ((System.Drawing.Image)(resources.GetObject("wolWarningImg.Image")));
            this.wolWarningImg.Location = new System.Drawing.Point(5, 21);
            this.wolWarningImg.Name = "wolWarningImg";
            this.wolWarningImg.Size = new System.Drawing.Size(20, 19);
            this.wolWarningImg.TabIndex = 13;
            this.wolWarningImg.TabStop = false;
            this.wolWarningImg.Visible = false;
            this.wolWarningImg.MouseHover += new System.EventHandler(this.handleWarningHover);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(74, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Version";
            // 
            // wolVersionBox
            // 
            this.wolVersionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.wolVersionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wolVersionBox.Location = new System.Drawing.Point(51, 120);
            this.wolVersionBox.Name = "wolVersionBox";
            this.wolVersionBox.Size = new System.Drawing.Size(88, 20);
            this.wolVersionBox.TabIndex = 11;
            this.wolVersionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Author";
            // 
            // wolAuthorBox
            // 
            this.wolAuthorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.wolAuthorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wolAuthorBox.Location = new System.Drawing.Point(1, 81);
            this.wolAuthorBox.Name = "wolAuthorBox";
            this.wolAuthorBox.Size = new System.Drawing.Size(188, 20);
            this.wolAuthorBox.TabIndex = 9;
            this.wolAuthorBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select HotS Mod";
            // 
            // hotsTitleBox
            // 
            this.hotsTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.hotsTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotsTitleBox.Location = new System.Drawing.Point(1, 42);
            this.hotsTitleBox.Name = "hotsTitleBox";
            this.hotsTitleBox.Size = new System.Drawing.Size(188, 20);
            this.hotsTitleBox.TabIndex = 11;
            this.hotsTitleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // hotsSetButton
            // 
            this.hotsSetButton.Enabled = false;
            this.hotsSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotsSetButton.Location = new System.Drawing.Point(6, 192);
            this.hotsSetButton.Name = "hotsSetButton";
            this.hotsSetButton.Size = new System.Drawing.Size(178, 23);
            this.hotsSetButton.TabIndex = 13;
            this.hotsSetButton.Text = "Set to Active Campaign";
            this.hotsSetButton.UseVisualStyleBackColor = true;
            this.hotsSetButton.Click += new System.EventHandler(this.hotsSetButton_Click);
            // 
            // hotsSelectBox
            // 
            this.hotsSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotsSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotsSelectBox.FormattingEnabled = true;
            this.hotsSelectBox.Location = new System.Drawing.Point(1, 165);
            this.hotsSelectBox.Name = "hotsSelectBox";
            this.hotsSelectBox.Size = new System.Drawing.Size(188, 21);
            this.hotsSelectBox.TabIndex = 10;
            this.hotsSelectBox.SelectedIndexChanged += new System.EventHandler(this.hotsSelectBox_SelectedIndexChanged);
            // 
            // hotsDeleteButton
            // 
            this.hotsDeleteButton.Enabled = false;
            this.hotsDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotsDeleteButton.Location = new System.Drawing.Point(6, 221);
            this.hotsDeleteButton.Name = "hotsDeleteButton";
            this.hotsDeleteButton.Size = new System.Drawing.Size(178, 23);
            this.hotsDeleteButton.TabIndex = 14;
            this.hotsDeleteButton.Text = "Delete Mod Files";
            this.hotsDeleteButton.UseVisualStyleBackColor = true;
            this.hotsDeleteButton.Click += new System.EventHandler(this.hotsDeleteButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Active Mod";
            // 
            // hotsRestoreButton
            // 
            this.hotsRestoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotsRestoreButton.Location = new System.Drawing.Point(6, 250);
            this.hotsRestoreButton.Name = "hotsRestoreButton";
            this.hotsRestoreButton.Size = new System.Drawing.Size(178, 23);
            this.hotsRestoreButton.TabIndex = 15;
            this.hotsRestoreButton.Text = "Restore to Unmodified";
            this.hotsRestoreButton.UseVisualStyleBackColor = true;
            this.hotsRestoreButton.Click += new System.EventHandler(this.hotsRestoreButton_Click);
            // 
            // hotsBox
            // 
            this.hotsBox.BackColor = System.Drawing.SystemColors.Control;
            this.hotsBox.Controls.Add(this.hotsWarningImg);
            this.hotsBox.Controls.Add(this.label11);
            this.hotsBox.Controls.Add(this.hotsRestoreButton);
            this.hotsBox.Controls.Add(this.hotsVersionBox);
            this.hotsBox.Controls.Add(this.label4);
            this.hotsBox.Controls.Add(this.label12);
            this.hotsBox.Controls.Add(this.hotsAuthorBox);
            this.hotsBox.Controls.Add(this.hotsDeleteButton);
            this.hotsBox.Controls.Add(this.hotsSelectBox);
            this.hotsBox.Controls.Add(this.hotsSetButton);
            this.hotsBox.Controls.Add(this.hotsTitleBox);
            this.hotsBox.Controls.Add(this.label3);
            this.hotsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotsBox.Location = new System.Drawing.Point(208, 12);
            this.hotsBox.Name = "hotsBox";
            this.hotsBox.Size = new System.Drawing.Size(190, 279);
            this.hotsBox.TabIndex = 1;
            this.hotsBox.TabStop = false;
            this.hotsBox.Text = "Heart of the Swarm";
            // 
            // hotsWarningImg
            // 
            this.hotsWarningImg.Image = ((System.Drawing.Image)(resources.GetObject("hotsWarningImg.Image")));
            this.hotsWarningImg.Location = new System.Drawing.Point(5, 21);
            this.hotsWarningImg.Name = "hotsWarningImg";
            this.hotsWarningImg.Size = new System.Drawing.Size(20, 19);
            this.hotsWarningImg.TabIndex = 17;
            this.hotsWarningImg.TabStop = false;
            this.hotsWarningImg.Visible = false;
            this.hotsWarningImg.MouseHover += new System.EventHandler(this.handleWarningHover);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(74, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Version";
            // 
            // hotsVersionBox
            // 
            this.hotsVersionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.hotsVersionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotsVersionBox.Location = new System.Drawing.Point(51, 120);
            this.hotsVersionBox.Name = "hotsVersionBox";
            this.hotsVersionBox.Size = new System.Drawing.Size(88, 20);
            this.hotsVersionBox.TabIndex = 15;
            this.hotsVersionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(74, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Author";
            // 
            // hotsAuthorBox
            // 
            this.hotsAuthorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.hotsAuthorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotsAuthorBox.Location = new System.Drawing.Point(1, 81);
            this.hotsAuthorBox.Name = "hotsAuthorBox";
            this.hotsAuthorBox.Size = new System.Drawing.Size(188, 20);
            this.hotsAuthorBox.TabIndex = 13;
            this.hotsAuthorBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // ncoBox
            // 
            this.ncoBox.BackColor = System.Drawing.SystemColors.Control;
            this.ncoBox.Controls.Add(this.ncoWarningImg);
            this.ncoBox.Controls.Add(this.label15);
            this.ncoBox.Controls.Add(this.ncoRestoreButton);
            this.ncoBox.Controls.Add(this.ncoVersionBox);
            this.ncoBox.Controls.Add(this.label5);
            this.ncoBox.Controls.Add(this.label16);
            this.ncoBox.Controls.Add(this.ncoAuthorBox);
            this.ncoBox.Controls.Add(this.ncoDeleteButton);
            this.ncoBox.Controls.Add(this.ncoSelectBox);
            this.ncoBox.Controls.Add(this.ncoSetButton);
            this.ncoBox.Controls.Add(this.ncoTitleBox);
            this.ncoBox.Controls.Add(this.label6);
            this.ncoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncoBox.Location = new System.Drawing.Point(600, 12);
            this.ncoBox.Name = "ncoBox";
            this.ncoBox.Size = new System.Drawing.Size(190, 279);
            this.ncoBox.TabIndex = 17;
            this.ncoBox.TabStop = false;
            this.ncoBox.Text = "Nova Covert Ops";
            // 
            // ncoWarningImg
            // 
            this.ncoWarningImg.Image = ((System.Drawing.Image)(resources.GetObject("ncoWarningImg.Image")));
            this.ncoWarningImg.Location = new System.Drawing.Point(5, 21);
            this.ncoWarningImg.Name = "ncoWarningImg";
            this.ncoWarningImg.Size = new System.Drawing.Size(20, 19);
            this.ncoWarningImg.TabIndex = 25;
            this.ncoWarningImg.TabStop = false;
            this.ncoWarningImg.Visible = false;
            this.ncoWarningImg.MouseHover += new System.EventHandler(this.handleWarningHover);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(74, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Version";
            // 
            // ncoRestoreButton
            // 
            this.ncoRestoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncoRestoreButton.Location = new System.Drawing.Point(6, 250);
            this.ncoRestoreButton.Name = "ncoRestoreButton";
            this.ncoRestoreButton.Size = new System.Drawing.Size(178, 23);
            this.ncoRestoreButton.TabIndex = 15;
            this.ncoRestoreButton.Text = "Restore to Unmodified";
            this.ncoRestoreButton.UseVisualStyleBackColor = true;
            this.ncoRestoreButton.Click += new System.EventHandler(this.ncoRestoreButton_Click);
            // 
            // ncoVersionBox
            // 
            this.ncoVersionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ncoVersionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncoVersionBox.Location = new System.Drawing.Point(51, 120);
            this.ncoVersionBox.Name = "ncoVersionBox";
            this.ncoVersionBox.Size = new System.Drawing.Size(88, 20);
            this.ncoVersionBox.TabIndex = 23;
            this.ncoVersionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Active Mod";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(74, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Author";
            // 
            // ncoAuthorBox
            // 
            this.ncoAuthorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ncoAuthorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncoAuthorBox.Location = new System.Drawing.Point(1, 81);
            this.ncoAuthorBox.Name = "ncoAuthorBox";
            this.ncoAuthorBox.Size = new System.Drawing.Size(188, 20);
            this.ncoAuthorBox.TabIndex = 21;
            this.ncoAuthorBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // ncoDeleteButton
            // 
            this.ncoDeleteButton.Enabled = false;
            this.ncoDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncoDeleteButton.Location = new System.Drawing.Point(6, 221);
            this.ncoDeleteButton.Name = "ncoDeleteButton";
            this.ncoDeleteButton.Size = new System.Drawing.Size(178, 23);
            this.ncoDeleteButton.TabIndex = 14;
            this.ncoDeleteButton.Text = "Delete Mod Files";
            this.ncoDeleteButton.UseVisualStyleBackColor = true;
            this.ncoDeleteButton.Click += new System.EventHandler(this.ncoDeleteButton_Click);
            // 
            // ncoSelectBox
            // 
            this.ncoSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ncoSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncoSelectBox.FormattingEnabled = true;
            this.ncoSelectBox.Location = new System.Drawing.Point(1, 165);
            this.ncoSelectBox.Name = "ncoSelectBox";
            this.ncoSelectBox.Size = new System.Drawing.Size(188, 21);
            this.ncoSelectBox.TabIndex = 10;
            this.ncoSelectBox.SelectedIndexChanged += new System.EventHandler(this.ncoSelectBox_SelectedIndexChanged);
            // 
            // ncoSetButton
            // 
            this.ncoSetButton.Enabled = false;
            this.ncoSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncoSetButton.Location = new System.Drawing.Point(6, 192);
            this.ncoSetButton.Name = "ncoSetButton";
            this.ncoSetButton.Size = new System.Drawing.Size(178, 23);
            this.ncoSetButton.TabIndex = 13;
            this.ncoSetButton.Text = "Set to Active Campaign";
            this.ncoSetButton.UseVisualStyleBackColor = true;
            this.ncoSetButton.Click += new System.EventHandler(this.ncoSetButton_Click);
            // 
            // ncoTitleBox
            // 
            this.ncoTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ncoTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncoTitleBox.Location = new System.Drawing.Point(1, 42);
            this.ncoTitleBox.Name = "ncoTitleBox";
            this.ncoTitleBox.Size = new System.Drawing.Size(188, 20);
            this.ncoTitleBox.TabIndex = 11;
            this.ncoTitleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Select NCO Mod";
            // 
            // lotvBox
            // 
            this.lotvBox.BackColor = System.Drawing.SystemColors.Control;
            this.lotvBox.Controls.Add(this.lotvWarningImg);
            this.lotvBox.Controls.Add(this.label13);
            this.lotvBox.Controls.Add(this.lotvRestoreButton);
            this.lotvBox.Controls.Add(this.lotvVersionBox);
            this.lotvBox.Controls.Add(this.lotvDeleteButton);
            this.lotvBox.Controls.Add(this.label14);
            this.lotvBox.Controls.Add(this.lotvAuthorBox);
            this.lotvBox.Controls.Add(this.lotvSetButton);
            this.lotvBox.Controls.Add(this.label7);
            this.lotvBox.Controls.Add(this.lotvTitleBox);
            this.lotvBox.Controls.Add(this.lotvSelectBox);
            this.lotvBox.Controls.Add(this.label8);
            this.lotvBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotvBox.Location = new System.Drawing.Point(404, 12);
            this.lotvBox.Name = "lotvBox";
            this.lotvBox.Size = new System.Drawing.Size(190, 279);
            this.lotvBox.TabIndex = 16;
            this.lotvBox.TabStop = false;
            this.lotvBox.Text = "Legacy of the Void";
            // 
            // lotvWarningImg
            // 
            this.lotvWarningImg.Image = ((System.Drawing.Image)(resources.GetObject("lotvWarningImg.Image")));
            this.lotvWarningImg.Location = new System.Drawing.Point(5, 21);
            this.lotvWarningImg.Name = "lotvWarningImg";
            this.lotvWarningImg.Size = new System.Drawing.Size(20, 19);
            this.lotvWarningImg.TabIndex = 21;
            this.lotvWarningImg.TabStop = false;
            this.lotvWarningImg.Visible = false;
            this.lotvWarningImg.MouseHover += new System.EventHandler(this.handleWarningHover);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(74, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Version";
            // 
            // lotvRestoreButton
            // 
            this.lotvRestoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotvRestoreButton.Location = new System.Drawing.Point(6, 250);
            this.lotvRestoreButton.Name = "lotvRestoreButton";
            this.lotvRestoreButton.Size = new System.Drawing.Size(178, 23);
            this.lotvRestoreButton.TabIndex = 8;
            this.lotvRestoreButton.Text = "Restore to Unmodified";
            this.lotvRestoreButton.UseVisualStyleBackColor = true;
            this.lotvRestoreButton.Click += new System.EventHandler(this.lotvRestoreButton_Click);
            // 
            // lotvVersionBox
            // 
            this.lotvVersionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lotvVersionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotvVersionBox.Location = new System.Drawing.Point(51, 120);
            this.lotvVersionBox.Name = "lotvVersionBox";
            this.lotvVersionBox.Size = new System.Drawing.Size(88, 20);
            this.lotvVersionBox.TabIndex = 19;
            this.lotvVersionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // lotvDeleteButton
            // 
            this.lotvDeleteButton.Enabled = false;
            this.lotvDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotvDeleteButton.Location = new System.Drawing.Point(6, 221);
            this.lotvDeleteButton.Name = "lotvDeleteButton";
            this.lotvDeleteButton.Size = new System.Drawing.Size(178, 23);
            this.lotvDeleteButton.TabIndex = 7;
            this.lotvDeleteButton.Text = "Delete Mod Files";
            this.lotvDeleteButton.UseVisualStyleBackColor = true;
            this.lotvDeleteButton.Click += new System.EventHandler(this.lotvDeleteButton_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(74, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Author";
            // 
            // lotvAuthorBox
            // 
            this.lotvAuthorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lotvAuthorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotvAuthorBox.Location = new System.Drawing.Point(1, 81);
            this.lotvAuthorBox.Name = "lotvAuthorBox";
            this.lotvAuthorBox.Size = new System.Drawing.Size(188, 20);
            this.lotvAuthorBox.TabIndex = 17;
            this.lotvAuthorBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // lotvSetButton
            // 
            this.lotvSetButton.Enabled = false;
            this.lotvSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotvSetButton.Location = new System.Drawing.Point(6, 192);
            this.lotvSetButton.Name = "lotvSetButton";
            this.lotvSetButton.Size = new System.Drawing.Size(178, 23);
            this.lotvSetButton.TabIndex = 6;
            this.lotvSetButton.Text = "Set to Active Campaign";
            this.lotvSetButton.UseVisualStyleBackColor = true;
            this.lotvSetButton.Click += new System.EventHandler(this.lotvSetButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Select LotV Mod";
            // 
            // lotvTitleBox
            // 
            this.lotvTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lotvTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotvTitleBox.Location = new System.Drawing.Point(1, 42);
            this.lotvTitleBox.Name = "lotvTitleBox";
            this.lotvTitleBox.Size = new System.Drawing.Size(188, 20);
            this.lotvTitleBox.TabIndex = 4;
            this.lotvTitleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayBox_KeyDown);
            // 
            // lotvSelectBox
            // 
            this.lotvSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lotvSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotvSelectBox.FormattingEnabled = true;
            this.lotvSelectBox.Location = new System.Drawing.Point(1, 165);
            this.lotvSelectBox.Name = "lotvSelectBox";
            this.lotvSelectBox.Size = new System.Drawing.Size(188, 21);
            this.lotvSelectBox.TabIndex = 3;
            this.lotvSelectBox.SelectedIndexChanged += new System.EventHandler(this.lotvSelectBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Active Mod";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(732, 300);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(58, 58);
            this.importButton.TabIndex = 19;
            this.importButton.Text = "Select\r\nZip to\r\nImport";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(668, 300);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(58, 58);
            this.installButton.TabIndex = 20;
            this.installButton.Text = "Refresh";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // findSC2Dialogue
            // 
            this.findSC2Dialogue.FileName = "StarCraft II.exe";
            // 
            // importPicturebox
            // 
            this.importPicturebox.BackColor = System.Drawing.SystemColors.Control;
            this.importPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("importPicturebox.Image")));
            this.importPicturebox.Location = new System.Drawing.Point(12, 301);
            this.importPicturebox.Margin = new System.Windows.Forms.Padding(0);
            this.importPicturebox.Name = "importPicturebox";
            this.importPicturebox.Size = new System.Drawing.Size(386, 56);
            this.importPicturebox.TabIndex = 21;
            this.importPicturebox.TabStop = false;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(405, 301);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(256, 56);
            this.logBox.TabIndex = 22;
            this.logBox.Text = "";
            this.logBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.logBox_KeyDown);
            // 
            // selectFolderDialogue
            // 
            this.selectFolderDialogue.Multiselect = true;
            // 
            // SC2CCM
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 367);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.importPicturebox);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.ncoBox);
            this.Controls.Add(this.hotsBox);
            this.Controls.Add(this.lotvBox);
            this.Controls.Add(this.wolBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SC2CCM";
            this.Text = "StarCraft II Custom Campaign Manager v1.03";
            this.Load += new System.EventHandler(this.SC2MM_Load);
            this.Shown += new System.EventHandler(this.SC2MM_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SC2CCM_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SC2CCM_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.SC2CCM_DragOver);
            this.DragLeave += new System.EventHandler(this.SC2CCM_DragLeave);
            this.wolBox.ResumeLayout(false);
            this.wolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wolWarningImg)).EndInit();
            this.hotsBox.ResumeLayout(false);
            this.hotsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotsWarningImg)).EndInit();
            this.ncoBox.ResumeLayout(false);
            this.ncoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncoWarningImg)).EndInit();
            this.lotvBox.ResumeLayout(false);
            this.lotvBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotvWarningImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wolSelectBox;
        private System.Windows.Forms.TextBox wolTitleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button wolSetButton;
        private System.Windows.Forms.Button wolDeleteButton;
        private System.Windows.Forms.Button wolRestoreButton;
        private System.Windows.Forms.GroupBox wolBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hotsTitleBox;
        private System.Windows.Forms.Button hotsSetButton;
        private System.Windows.Forms.ComboBox hotsSelectBox;
        private System.Windows.Forms.Button hotsDeleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hotsRestoreButton;
        private System.Windows.Forms.GroupBox hotsBox;
        private System.Windows.Forms.GroupBox ncoBox;
        private System.Windows.Forms.Button ncoRestoreButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ncoDeleteButton;
        private System.Windows.Forms.ComboBox ncoSelectBox;
        private System.Windows.Forms.Button ncoSetButton;
        private System.Windows.Forms.TextBox ncoTitleBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox lotvBox;
        private System.Windows.Forms.Button lotvRestoreButton;
        private System.Windows.Forms.Button lotvDeleteButton;
        private System.Windows.Forms.Button lotvSetButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lotvTitleBox;
        private System.Windows.Forms.ComboBox lotvSelectBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox wolAuthorBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox wolVersionBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox hotsVersionBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox hotsAuthorBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ncoVersionBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ncoAuthorBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox lotvVersionBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox lotvAuthorBox;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.OpenFileDialog findSC2Dialogue;
        private System.Windows.Forms.PictureBox importPicturebox;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.PictureBox wolWarningImg;
        private System.Windows.Forms.PictureBox hotsWarningImg;
        private System.Windows.Forms.PictureBox ncoWarningImg;
        private System.Windows.Forms.PictureBox lotvWarningImg;
        private System.Windows.Forms.OpenFileDialog selectFolderDialogue;
    }
}

