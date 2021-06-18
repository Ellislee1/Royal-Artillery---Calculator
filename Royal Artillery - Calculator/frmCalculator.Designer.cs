
namespace Royal_Artillery___Calculator
{
    partial class frmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.txtDist = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDistance = new System.Windows.Forms.RadioButton();
            this.radGrid = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAlt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTgtAlt = new System.Windows.Forms.TextBox();
            this.txtBatAlt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artilleryRangeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogImportGun = new System.Windows.Forms.OpenFileDialog();
            this.lstL118Results = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblL118FlightTime = new System.Windows.Forms.Label();
            this.lblL118Elevation = new System.Windows.Forms.Label();
            this.lblL118Charge = new System.Windows.Forms.Label();
            this.tabguns = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabguns.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(132, 77);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(100, 20);
            this.txtDist.TabIndex = 0;
            this.txtDist.TextChanged += new System.EventHandler(this.txtDist_TextChanged);
            this.txtDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDist_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDistance);
            this.groupBox1.Controls.Add(this.radGrid);
            this.groupBox1.Controls.Add(this.txtDist);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance Calcuation";
            // 
            // radDistance
            // 
            this.radDistance.AutoSize = true;
            this.radDistance.Checked = true;
            this.radDistance.Location = new System.Drawing.Point(20, 78);
            this.radDistance.Name = "radDistance";
            this.radDistance.Size = new System.Drawing.Size(84, 17);
            this.radDistance.TabIndex = 1;
            this.radDistance.TabStop = true;
            this.radDistance.Text = "Distance (m)";
            this.radDistance.UseVisualStyleBackColor = true;
            this.radDistance.CheckedChanged += new System.EventHandler(this.radDistance_CheckedChanged);
            // 
            // radGrid
            // 
            this.radGrid.AutoSize = true;
            this.radGrid.Enabled = false;
            this.radGrid.Location = new System.Drawing.Point(20, 36);
            this.radGrid.Name = "radGrid";
            this.radGrid.Size = new System.Drawing.Size(97, 17);
            this.radGrid.TabIndex = 0;
            this.radGrid.Text = "Grid Reference";
            this.radGrid.UseVisualStyleBackColor = true;
            this.radGrid.CheckedChanged += new System.EventHandler(this.radGrid_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAlt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTgtAlt);
            this.groupBox2.Controls.Add(this.txtBatAlt);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 111);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Altitude Calcuation";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Location = new System.Drawing.Point(111, 95);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(13, 13);
            this.lblAlt.TabIndex = 6;
            this.lblAlt.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Altitude Difference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target Altitude (m)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Battery Altitude (m)";
            // 
            // txtTgtAlt
            // 
            this.txtTgtAlt.Location = new System.Drawing.Point(110, 57);
            this.txtTgtAlt.Name = "txtTgtAlt";
            this.txtTgtAlt.Size = new System.Drawing.Size(48, 20);
            this.txtTgtAlt.TabIndex = 4;
            this.txtTgtAlt.TextChanged += new System.EventHandler(this.txtTgtAlt_TextChanged);
            this.txtTgtAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTgtAlt_KeyPress);
            // 
            // txtBatAlt
            // 
            this.txtBatAlt.Location = new System.Drawing.Point(110, 26);
            this.txtBatAlt.Name = "txtBatAlt";
            this.txtBatAlt.Size = new System.Drawing.Size(48, 20);
            this.txtBatAlt.TabIndex = 3;
            this.txtBatAlt.TextChanged += new System.EventHandler(this.txtBatAlt_TextChanged);
            this.txtBatAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBatAlt_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artilleryRangeTableToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // artilleryRangeTableToolStripMenuItem
            // 
            this.artilleryRangeTableToolStripMenuItem.Name = "artilleryRangeTableToolStripMenuItem";
            this.artilleryRangeTableToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.artilleryRangeTableToolStripMenuItem.Text = "Artillery Range Table";
            this.artilleryRangeTableToolStripMenuItem.Click += new System.EventHandler(this.artilleryRangeTableToolStripMenuItem_Click);
            // 
            // openFileDialogImportGun
            // 
            this.openFileDialogImportGun.DefaultExt = "csv";
            this.openFileDialogImportGun.FileName = "openFileDialog1";
            this.openFileDialogImportGun.Filter = "\"csv files (*.csv)|*.csv|All files (*.*)|*.*\"";
            this.openFileDialogImportGun.Title = "Import Gun";
            // 
            // lstL118Results
            // 
            this.lstL118Results.FormattingEnabled = true;
            this.lstL118Results.Location = new System.Drawing.Point(6, 6);
            this.lstL118Results.Name = "lstL118Results";
            this.lstL118Results.Size = new System.Drawing.Size(217, 108);
            this.lstL118Results.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblL118FlightTime);
            this.groupBox3.Controls.Add(this.lblL118Elevation);
            this.groupBox3.Controls.Add(this.lblL118Charge);
            this.groupBox3.Location = new System.Drawing.Point(6, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 111);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Optimal Results";
            // 
            // lblL118FlightTime
            // 
            this.lblL118FlightTime.AutoSize = true;
            this.lblL118FlightTime.Location = new System.Drawing.Point(6, 95);
            this.lblL118FlightTime.Name = "lblL118FlightTime";
            this.lblL118FlightTime.Size = new System.Drawing.Size(84, 13);
            this.lblL118FlightTime.TabIndex = 2;
            this.lblL118FlightTime.Text = "Flight Time (est):";
            // 
            // lblL118Elevation
            // 
            this.lblL118Elevation.AutoSize = true;
            this.lblL118Elevation.Location = new System.Drawing.Point(6, 64);
            this.lblL118Elevation.Name = "lblL118Elevation";
            this.lblL118Elevation.Size = new System.Drawing.Size(54, 13);
            this.lblL118Elevation.TabIndex = 1;
            this.lblL118Elevation.Text = "Elevation:";
            // 
            // lblL118Charge
            // 
            this.lblL118Charge.AutoSize = true;
            this.lblL118Charge.Location = new System.Drawing.Point(6, 29);
            this.lblL118Charge.Name = "lblL118Charge";
            this.lblL118Charge.Size = new System.Drawing.Size(68, 13);
            this.lblL118Charge.TabIndex = 0;
            this.lblL118Charge.Text = "Charge (CH):";
            // 
            // tabguns
            // 
            this.tabguns.Controls.Add(this.tabPage1);
            this.tabguns.Controls.Add(this.tabPage2);
            this.tabguns.Location = new System.Drawing.Point(274, 27);
            this.tabguns.Name = "tabguns";
            this.tabguns.SelectedIndex = 0;
            this.tabguns.Size = new System.Drawing.Size(240, 270);
            this.tabguns.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstL118Results);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(232, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "L118";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AS90";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabguns);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCalculator";
            this.Text = "Royal Artillery - Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabguns.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDistance;
        private System.Windows.Forms.RadioButton radGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTgtAlt;
        private System.Windows.Forms.TextBox txtBatAlt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artilleryRangeTableToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogImportGun;
        private System.Windows.Forms.ListBox lstL118Results;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblL118FlightTime;
        private System.Windows.Forms.Label lblL118Elevation;
        private System.Windows.Forms.Label lblL118Charge;
        private System.Windows.Forms.TabControl tabguns;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

