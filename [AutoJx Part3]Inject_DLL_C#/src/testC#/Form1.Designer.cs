namespace testC_ {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lswGBasic = new System.Windows.Forms.ListView();
            this.colCharName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCharLoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCharServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmGlobal = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddManaTime = new System.Windows.Forms.TextBox();
            this.txtAddManaValue2 = new System.Windows.Forms.TextBox();
            this.txtAddManaValue = new System.Windows.Forms.TextBox();
            this.txtAddLifeTime = new System.Windows.Forms.TextBox();
            this.txtAddLifeValue2 = new System.Windows.Forms.TextBox();
            this.txtAddLifeValue = new System.Windows.Forms.TextBox();
            this.chkAutoAddMana = new System.Windows.Forms.CheckBox();
            this.chkAutoAddLife = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lswGBasic
            // 
            this.lswGBasic.CheckBoxes = true;
            this.lswGBasic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCharName,
            this.colCharLoc,
            this.colCharServer,
            this.colPid});
            this.lswGBasic.FullRowSelect = true;
            this.lswGBasic.GridLines = true;
            this.lswGBasic.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lswGBasic.HideSelection = false;
            this.lswGBasic.Location = new System.Drawing.Point(2, 2);
            this.lswGBasic.Margin = new System.Windows.Forms.Padding(2);
            this.lswGBasic.MultiSelect = false;
            this.lswGBasic.Name = "lswGBasic";
            this.lswGBasic.Size = new System.Drawing.Size(241, 126);
            this.lswGBasic.TabIndex = 2;
            this.lswGBasic.UseCompatibleStateImageBehavior = false;
            this.lswGBasic.View = System.Windows.Forms.View.Details;
            this.lswGBasic.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lswGBasic_ItemChecked);
            // 
            // colCharName
            // 
            this.colCharName.Text = "Nhân vật";
            this.colCharName.Width = 120;
            // 
            // colCharLoc
            // 
            this.colCharLoc.Text = "Bản đồ";
            // 
            // colCharServer
            // 
            this.colCharServer.Text = "Server";
            this.colCharServer.Width = 55;
            // 
            // colPid
            // 
            this.colPid.Text = "Pid";
            // 
            // tmGlobal
            // 
            this.tmGlobal.Enabled = true;
            this.tmGlobal.Interval = 1500;
            this.tmGlobal.Tick += new System.EventHandler(this.tmGlobal_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 133);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(241, 106);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(233, 80);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Luyện Công";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(233, 87);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chiến Đấu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddManaTime);
            this.groupBox1.Controls.Add(this.txtAddManaValue2);
            this.groupBox1.Controls.Add(this.txtAddManaValue);
            this.groupBox1.Controls.Add(this.txtAddLifeTime);
            this.groupBox1.Controls.Add(this.txtAddLifeValue2);
            this.groupBox1.Controls.Add(this.txtAddLifeValue);
            this.groupBox1.Controls.Add(this.chkAutoAddMana);
            this.groupBox1.Controls.Add(this.chkAutoAddLife);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phục hồi";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "ms";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "mức 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "mức 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddManaTime
            // 
            this.txtAddManaTime.Location = new System.Drawing.Point(176, 46);
            this.txtAddManaTime.Name = "txtAddManaTime";
            this.txtAddManaTime.Size = new System.Drawing.Size(50, 20);
            this.txtAddManaTime.TabIndex = 7;
            this.txtAddManaTime.Text = "1500";
            this.txtAddManaTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddManaValue2
            // 
            this.txtAddManaValue2.Location = new System.Drawing.Point(125, 46);
            this.txtAddManaValue2.Name = "txtAddManaValue2";
            this.txtAddManaValue2.Size = new System.Drawing.Size(50, 20);
            this.txtAddManaValue2.TabIndex = 6;
            this.txtAddManaValue2.Text = "2000";
            this.txtAddManaValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddManaValue
            // 
            this.txtAddManaValue.Location = new System.Drawing.Point(74, 46);
            this.txtAddManaValue.Name = "txtAddManaValue";
            this.txtAddManaValue.Size = new System.Drawing.Size(50, 20);
            this.txtAddManaValue.TabIndex = 5;
            this.txtAddManaValue.Text = "300";
            this.txtAddManaValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddLifeTime
            // 
            this.txtAddLifeTime.Location = new System.Drawing.Point(176, 23);
            this.txtAddLifeTime.Name = "txtAddLifeTime";
            this.txtAddLifeTime.Size = new System.Drawing.Size(50, 20);
            this.txtAddLifeTime.TabIndex = 4;
            this.txtAddLifeTime.Text = "1000";
            this.txtAddLifeTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddLifeValue2
            // 
            this.txtAddLifeValue2.Location = new System.Drawing.Point(125, 23);
            this.txtAddLifeValue2.Name = "txtAddLifeValue2";
            this.txtAddLifeValue2.Size = new System.Drawing.Size(50, 20);
            this.txtAddLifeValue2.TabIndex = 3;
            this.txtAddLifeValue2.Text = "1000";
            this.txtAddLifeValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddLifeValue
            // 
            this.txtAddLifeValue.Location = new System.Drawing.Point(74, 23);
            this.txtAddLifeValue.Name = "txtAddLifeValue";
            this.txtAddLifeValue.Size = new System.Drawing.Size(50, 20);
            this.txtAddLifeValue.TabIndex = 2;
            this.txtAddLifeValue.Text = "1000";
            this.txtAddLifeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkAutoAddMana
            // 
            this.chkAutoAddMana.AutoSize = true;
            this.chkAutoAddMana.Location = new System.Drawing.Point(6, 48);
            this.chkAutoAddMana.Name = "chkAutoAddMana";
            this.chkAutoAddMana.Size = new System.Drawing.Size(64, 17);
            this.chkAutoAddMana.TabIndex = 1;
            this.chkAutoAddMana.Text = "Bơm NL";
            this.chkAutoAddMana.UseVisualStyleBackColor = true;
            // 
            // chkAutoAddLife
            // 
            this.chkAutoAddLife.AutoSize = true;
            this.chkAutoAddLife.Location = new System.Drawing.Point(6, 25);
            this.chkAutoAddLife.Name = "chkAutoAddLife";
            this.chkAutoAddLife.Size = new System.Drawing.Size(63, 17);
            this.chkAutoAddLife.TabIndex = 0;
            this.chkAutoAddLife.Text = "Bơm SL";
            this.chkAutoAddLife.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(245, 243);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lswGBasic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Test Auto JX";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lswGBasic;
        private System.Windows.Forms.ColumnHeader colCharName;
        private System.Windows.Forms.ColumnHeader colCharLoc;
        private System.Windows.Forms.ColumnHeader colCharServer;
        private System.Windows.Forms.ColumnHeader colPid;
        private System.Windows.Forms.Timer tmGlobal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddManaTime;
        private System.Windows.Forms.TextBox txtAddManaValue2;
        private System.Windows.Forms.TextBox txtAddManaValue;
        private System.Windows.Forms.TextBox txtAddLifeTime;
        private System.Windows.Forms.TextBox txtAddLifeValue2;
        private System.Windows.Forms.TextBox txtAddLifeValue;
        private System.Windows.Forms.CheckBox chkAutoAddMana;
        private System.Windows.Forms.CheckBox chkAutoAddLife;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

