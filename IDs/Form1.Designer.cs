namespace IDs
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.idNumber = new System.Windows.Forms.Label();
            this.btnSaveImages = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imgPath = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.txtSemester = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLevel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbPro = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.05228F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbPro);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtSemester);
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 747);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.crystalReportViewer1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 397);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(864, 350);
            this.panel5.TabIndex = 5;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(864, 350);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.idNumber);
            this.panel2.Controls.Add(this.btnSaveImages);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(864, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 747);
            this.panel2.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.Red;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReset.Iconimage")));
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(14, 310);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(336, 57);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // idNumber
            // 
            this.idNumber.AutoSize = true;
            this.idNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumber.Location = new System.Drawing.Point(139, 495);
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(66, 24);
            this.idNumber.TabIndex = 3;
            this.idNumber.Text = "label1";
            // 
            // btnSaveImages
            // 
            this.btnSaveImages.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveImages.BorderRadius = 0;
            this.btnSaveImages.ButtonText = "Save & Load ID";
            this.btnSaveImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveImages.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveImages.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveImages.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveImages.Iconimage")));
            this.btnSaveImages.Iconimage_right = null;
            this.btnSaveImages.Iconimage_right_Selected = null;
            this.btnSaveImages.Iconimage_Selected = null;
            this.btnSaveImages.IconMarginLeft = 0;
            this.btnSaveImages.IconMarginRight = 0;
            this.btnSaveImages.IconRightVisible = true;
            this.btnSaveImages.IconRightZoom = 0D;
            this.btnSaveImages.IconVisible = true;
            this.btnSaveImages.IconZoom = 90D;
            this.btnSaveImages.IsTab = false;
            this.btnSaveImages.Location = new System.Drawing.Point(27, 397);
            this.btnSaveImages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveImages.Name = "btnSaveImages";
            this.btnSaveImages.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveImages.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSaveImages.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveImages.selected = false;
            this.btnSaveImages.Size = new System.Drawing.Size(304, 59);
            this.btnSaveImages.TabIndex = 3;
            this.btnSaveImages.Text = "Save & Load ID";
            this.btnSaveImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveImages.Textcolor = System.Drawing.Color.White;
            this.btnSaveImages.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImages.Click += new System.EventHandler(this.btnSaveImages_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(331, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save and Load ID";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.imgPath);
            this.panel4.Location = new System.Drawing.Point(6, 657);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 81);
            this.panel4.TabIndex = 3;
            // 
            // imgPath
            // 
            this.imgPath.Location = new System.Drawing.Point(3, 56);
            this.imgPath.Name = "imgPath";
            this.imgPath.Size = new System.Drawing.Size(345, 22);
            this.imgPath.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picPhoto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 185);
            this.panel3.TabIndex = 0;
            // 
            // picPhoto
            // 
            this.picPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picPhoto.Image")));
            this.picPhoto.Location = new System.Drawing.Point(0, 0);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(354, 185);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.picPhoto_Click);
            // 
            // txtSemester
            // 
            this.txtSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSemester.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSemester.HintForeColor = System.Drawing.Color.Empty;
            this.txtSemester.HintText = "Enter Semester";
            this.txtSemester.isPassword = false;
            this.txtSemester.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSemester.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSemester.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSemester.LineThickness = 3;
            this.txtSemester.Location = new System.Drawing.Point(325, 177);
            this.txtSemester.Margin = new System.Windows.Forms.Padding(4);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(197, 44);
            this.txtSemester.TabIndex = 1;
            this.txtSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLevel
            // 
            this.txtLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLevel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLevel.HintForeColor = System.Drawing.Color.Empty;
            this.txtLevel.HintText = "Enter Level";
            this.txtLevel.isPassword = false;
            this.txtLevel.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLevel.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLevel.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLevel.LineThickness = 3;
            this.txtLevel.Location = new System.Drawing.Point(30, 177);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(171, 44);
            this.txtLevel.TabIndex = 1;
            this.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSurname
            // 
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSurname.HintForeColor = System.Drawing.Color.Empty;
            this.txtSurname.HintText = "Enter Surname";
            this.txtSurname.isPassword = false;
            this.txtSurname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSurname.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSurname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSurname.LineThickness = 3;
            this.txtSurname.Location = new System.Drawing.Point(30, 97);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(492, 44);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "Enter Name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(30, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(492, 44);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbPro
            // 
            this.cmbPro.FormattingEnabled = true;
            this.cmbPro.Items.AddRange(new object[] {
            "BSc in Computer Science",
            "BSc in Electronic",
            "BSc in Telecommunication"});
            this.cmbPro.Location = new System.Drawing.Point(30, 270);
            this.cmbPro.Name = "cmbPro";
            this.cmbPro.Size = new System.Drawing.Size(472, 24);
            this.cmbPro.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSemester;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLevel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveImages;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label idNumber;
        private System.Windows.Forms.TextBox imgPath;
        private System.Windows.Forms.Panel panel5;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cmbPro;
    }
}

