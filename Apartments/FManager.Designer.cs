namespace Apartments
{
    partial class FManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FManager));
            this.BManagerAdd = new System.Windows.Forms.Button();
            this.PManagerMain = new System.Windows.Forms.Panel();
            this.BManagerEdit = new System.Windows.Forms.Button();
            this.BManagerChngPic = new System.Windows.Forms.Button();
            this.BManagerChngDesc = new System.Windows.Forms.Button();
            this.BManagerChngName = new System.Windows.Forms.Button();
            this.LClientApInfo1 = new System.Windows.Forms.Label();
            this.LClientApInfo = new System.Windows.Forms.Label();
            this.LClientApName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DTClients = new System.Windows.Forms.DataGridView();
            this.CTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTPNumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PClientMainApsCtrl = new System.Windows.Forms.Panel();
            this.BManagerNext = new System.Windows.Forms.Button();
            this.BManagerPrev = new System.Windows.Forms.Button();
            this.BManagerUpdtTable = new System.Windows.Forms.Button();
            this.BManagerUpEdit = new System.Windows.Forms.Button();
            this.BManagerUpAdd = new System.Windows.Forms.Button();
            this.BManagerClients = new System.Windows.Forms.Button();
            this.PManagerClients = new System.Windows.Forms.Panel();
            this.BManagerDelUser = new System.Windows.Forms.Button();
            this.PManagerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTClients)).BeginInit();
            this.PClientMainApsCtrl.SuspendLayout();
            this.PManagerClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // BManagerAdd
            // 
            this.BManagerAdd.BackColor = System.Drawing.Color.Gray;
            this.BManagerAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BManagerAdd.FlatAppearance.BorderSize = 0;
            this.BManagerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerAdd.ForeColor = System.Drawing.Color.White;
            this.BManagerAdd.Location = new System.Drawing.Point(655, 360);
            this.BManagerAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerAdd.Name = "BManagerAdd";
            this.BManagerAdd.Size = new System.Drawing.Size(79, 45);
            this.BManagerAdd.TabIndex = 0;
            this.BManagerAdd.Text = "Добавить квартиру";
            this.BManagerAdd.UseVisualStyleBackColor = false;
            this.BManagerAdd.Click += new System.EventHandler(this.BManagerAdd_Click);
            // 
            // PManagerMain
            // 
            this.PManagerMain.Controls.Add(this.BManagerEdit);
            this.PManagerMain.Controls.Add(this.BManagerChngPic);
            this.PManagerMain.Controls.Add(this.BManagerChngDesc);
            this.PManagerMain.Controls.Add(this.BManagerChngName);
            this.PManagerMain.Controls.Add(this.BManagerAdd);
            this.PManagerMain.Controls.Add(this.LClientApInfo1);
            this.PManagerMain.Controls.Add(this.LClientApInfo);
            this.PManagerMain.Controls.Add(this.LClientApName);
            this.PManagerMain.Controls.Add(this.pictureBox1);
            this.PManagerMain.Location = new System.Drawing.Point(8, 59);
            this.PManagerMain.Margin = new System.Windows.Forms.Padding(2);
            this.PManagerMain.Name = "PManagerMain";
            this.PManagerMain.Size = new System.Drawing.Size(824, 411);
            this.PManagerMain.TabIndex = 7;
            this.PManagerMain.Visible = false;
            // 
            // BManagerEdit
            // 
            this.BManagerEdit.BackColor = System.Drawing.Color.Gray;
            this.BManagerEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BManagerEdit.FlatAppearance.BorderSize = 0;
            this.BManagerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerEdit.ForeColor = System.Drawing.Color.White;
            this.BManagerEdit.Location = new System.Drawing.Point(655, 360);
            this.BManagerEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerEdit.Name = "BManagerEdit";
            this.BManagerEdit.Size = new System.Drawing.Size(79, 45);
            this.BManagerEdit.TabIndex = 16;
            this.BManagerEdit.Text = "Изменить квартиру";
            this.BManagerEdit.UseVisualStyleBackColor = false;
            this.BManagerEdit.Visible = false;
            this.BManagerEdit.Click += new System.EventHandler(this.BManagerEdit_Click);
            // 
            // BManagerChngPic
            // 
            this.BManagerChngPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BManagerChngPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BManagerChngPic.FlatAppearance.BorderSize = 0;
            this.BManagerChngPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerChngPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BManagerChngPic.Location = new System.Drawing.Point(234, 284);
            this.BManagerChngPic.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerChngPic.Name = "BManagerChngPic";
            this.BManagerChngPic.Size = new System.Drawing.Size(93, 24);
            this.BManagerChngPic.TabIndex = 15;
            this.BManagerChngPic.Text = "сменить фото";
            this.BManagerChngPic.UseVisualStyleBackColor = false;
            this.BManagerChngPic.Click += new System.EventHandler(this.BManagerChngPic_Click);
            // 
            // BManagerChngDesc
            // 
            this.BManagerChngDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BManagerChngDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BManagerChngDesc.FlatAppearance.BorderSize = 0;
            this.BManagerChngDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerChngDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BManagerChngDesc.Location = new System.Drawing.Point(488, 38);
            this.BManagerChngDesc.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerChngDesc.Name = "BManagerChngDesc";
            this.BManagerChngDesc.Size = new System.Drawing.Size(106, 24);
            this.BManagerChngDesc.TabIndex = 14;
            this.BManagerChngDesc.Text = "сменить  описание";
            this.BManagerChngDesc.UseVisualStyleBackColor = false;
            this.BManagerChngDesc.Click += new System.EventHandler(this.BManagerChngDesc_Click);
            // 
            // BManagerChngName
            // 
            this.BManagerChngName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BManagerChngName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BManagerChngName.FlatAppearance.BorderSize = 0;
            this.BManagerChngName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerChngName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BManagerChngName.Location = new System.Drawing.Point(162, 12);
            this.BManagerChngName.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerChngName.Name = "BManagerChngName";
            this.BManagerChngName.Size = new System.Drawing.Size(105, 24);
            this.BManagerChngName.TabIndex = 13;
            this.BManagerChngName.Text = "сменить  название";
            this.BManagerChngName.UseVisualStyleBackColor = false;
            this.BManagerChngName.Click += new System.EventHandler(this.BManagerChngName_Click);
            // 
            // LClientApInfo1
            // 
            this.LClientApInfo1.AutoSize = true;
            this.LClientApInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LClientApInfo1.Location = new System.Drawing.Point(340, 67);
            this.LClientApInfo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LClientApInfo1.MaximumSize = new System.Drawing.Size(375, 0);
            this.LClientApInfo1.Name = "LClientApInfo1";
            this.LClientApInfo1.Size = new System.Drawing.Size(374, 156);
            this.LClientApInfo1.TabIndex = 9;
            this.LClientApInfo1.Text = resources.GetString("LClientApInfo1.Text");
            this.LClientApInfo1.Click += new System.EventHandler(this.LClientApInfo1_Click);
            // 
            // LClientApInfo
            // 
            this.LClientApInfo.AutoSize = true;
            this.LClientApInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LClientApInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LClientApInfo.ForeColor = System.Drawing.Color.White;
            this.LClientApInfo.Location = new System.Drawing.Point(332, 38);
            this.LClientApInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LClientApInfo.Name = "LClientApInfo";
            this.LClientApInfo.Size = new System.Drawing.Size(164, 20);
            this.LClientApInfo.TabIndex = 8;
            this.LClientApInfo.Text = "Описание квартиры:";
            // 
            // LClientApName
            // 
            this.LClientApName.AutoSize = true;
            this.LClientApName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LClientApName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LClientApName.ForeColor = System.Drawing.Color.White;
            this.LClientApName.Location = new System.Drawing.Point(7, 12);
            this.LClientApName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LClientApName.Name = "LClientApName";
            this.LClientApName.Size = new System.Drawing.Size(160, 20);
            this.LClientApName.TabIndex = 7;
            this.LClientApName.Text = "Название квартиры";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(7, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DTClients
            // 
            this.DTClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DTClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CTName,
            this.CTSName,
            this.CTTName,
            this.CTDate,
            this.CTPNumb});
            this.DTClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DTClients.Location = new System.Drawing.Point(4, 4);
            this.DTClients.Margin = new System.Windows.Forms.Padding(2);
            this.DTClients.Name = "DTClients";
            this.DTClients.RowHeadersWidth = 51;
            this.DTClients.RowTemplate.Height = 24;
            this.DTClients.Size = new System.Drawing.Size(820, 411);
            this.DTClients.TabIndex = 19;
            // 
            // CTName
            // 
            this.CTName.HeaderText = "Имя";
            this.CTName.MinimumWidth = 6;
            this.CTName.Name = "CTName";
            this.CTName.Width = 150;
            // 
            // CTSName
            // 
            this.CTSName.HeaderText = "Фамилия";
            this.CTSName.MinimumWidth = 6;
            this.CTSName.Name = "CTSName";
            this.CTSName.Width = 150;
            // 
            // CTTName
            // 
            this.CTTName.HeaderText = "Отчество";
            this.CTTName.MinimumWidth = 6;
            this.CTTName.Name = "CTTName";
            this.CTTName.Width = 150;
            // 
            // CTDate
            // 
            this.CTDate.HeaderText = "Датарождения";
            this.CTDate.MinimumWidth = 6;
            this.CTDate.Name = "CTDate";
            this.CTDate.Width = 150;
            // 
            // CTPNumb
            // 
            this.CTPNumb.HeaderText = "Телефон";
            this.CTPNumb.MinimumWidth = 6;
            this.CTPNumb.Name = "CTPNumb";
            this.CTPNumb.Width = 150;
            // 
            // PClientMainApsCtrl
            // 
            this.PClientMainApsCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PClientMainApsCtrl.Controls.Add(this.BManagerNext);
            this.PClientMainApsCtrl.Controls.Add(this.BManagerPrev);
            this.PClientMainApsCtrl.Location = new System.Drawing.Point(3, 478);
            this.PClientMainApsCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.PClientMainApsCtrl.Name = "PClientMainApsCtrl";
            this.PClientMainApsCtrl.Size = new System.Drawing.Size(824, 58);
            this.PClientMainApsCtrl.TabIndex = 16;
            this.PClientMainApsCtrl.Visible = false;
            // 
            // BManagerNext
            // 
            this.BManagerNext.BackColor = System.Drawing.Color.Gray;
            this.BManagerNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BManagerNext.FlatAppearance.BorderSize = 0;
            this.BManagerNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerNext.ForeColor = System.Drawing.Color.White;
            this.BManagerNext.Location = new System.Drawing.Point(743, 4);
            this.BManagerNext.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerNext.Name = "BManagerNext";
            this.BManagerNext.Size = new System.Drawing.Size(79, 46);
            this.BManagerNext.TabIndex = 0;
            this.BManagerNext.Text = "Следующая";
            this.BManagerNext.UseVisualStyleBackColor = false;
            // 
            // BManagerPrev
            // 
            this.BManagerPrev.BackColor = System.Drawing.Color.Gray;
            this.BManagerPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BManagerPrev.FlatAppearance.BorderSize = 0;
            this.BManagerPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerPrev.ForeColor = System.Drawing.Color.White;
            this.BManagerPrev.Location = new System.Drawing.Point(660, 4);
            this.BManagerPrev.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerPrev.Name = "BManagerPrev";
            this.BManagerPrev.Size = new System.Drawing.Size(79, 46);
            this.BManagerPrev.TabIndex = 1;
            this.BManagerPrev.Text = "Предыдущая";
            this.BManagerPrev.UseVisualStyleBackColor = false;
            // 
            // BManagerUpdtTable
            // 
            this.BManagerUpdtTable.BackColor = System.Drawing.Color.Gray;
            this.BManagerUpdtTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BManagerUpdtTable.FlatAppearance.BorderSize = 0;
            this.BManagerUpdtTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerUpdtTable.ForeColor = System.Drawing.Color.White;
            this.BManagerUpdtTable.Location = new System.Drawing.Point(8, 478);
            this.BManagerUpdtTable.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerUpdtTable.Name = "BManagerUpdtTable";
            this.BManagerUpdtTable.Size = new System.Drawing.Size(79, 50);
            this.BManagerUpdtTable.TabIndex = 2;
            this.BManagerUpdtTable.Text = "Обновить таблицу";
            this.BManagerUpdtTable.UseVisualStyleBackColor = false;
            this.BManagerUpdtTable.Click += new System.EventHandler(this.BManagerUpdtTable_Click);
            // 
            // BManagerUpEdit
            // 
            this.BManagerUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BManagerUpEdit.BackColor = System.Drawing.Color.Gray;
            this.BManagerUpEdit.FlatAppearance.BorderSize = 0;
            this.BManagerUpEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerUpEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BManagerUpEdit.ForeColor = System.Drawing.Color.White;
            this.BManagerUpEdit.Location = new System.Drawing.Point(111, 11);
            this.BManagerUpEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerUpEdit.Name = "BManagerUpEdit";
            this.BManagerUpEdit.Size = new System.Drawing.Size(93, 44);
            this.BManagerUpEdit.TabIndex = 17;
            this.BManagerUpEdit.TabStop = false;
            this.BManagerUpEdit.Text = "Изменить квартиру";
            this.BManagerUpEdit.UseVisualStyleBackColor = false;
            this.BManagerUpEdit.Click += new System.EventHandler(this.BManagerUpEdit_Click);
            // 
            // BManagerUpAdd
            // 
            this.BManagerUpAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BManagerUpAdd.BackColor = System.Drawing.Color.Gray;
            this.BManagerUpAdd.FlatAppearance.BorderSize = 0;
            this.BManagerUpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerUpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BManagerUpAdd.ForeColor = System.Drawing.Color.White;
            this.BManagerUpAdd.Location = new System.Drawing.Point(14, 11);
            this.BManagerUpAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerUpAdd.Name = "BManagerUpAdd";
            this.BManagerUpAdd.Size = new System.Drawing.Size(93, 44);
            this.BManagerUpAdd.TabIndex = 16;
            this.BManagerUpAdd.TabStop = false;
            this.BManagerUpAdd.Text = "Добавить квартиру";
            this.BManagerUpAdd.UseVisualStyleBackColor = false;
            this.BManagerUpAdd.Click += new System.EventHandler(this.BManagerUpAdd_Click);
            // 
            // BManagerClients
            // 
            this.BManagerClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BManagerClients.BackColor = System.Drawing.Color.Gray;
            this.BManagerClients.FlatAppearance.BorderSize = 0;
            this.BManagerClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BManagerClients.ForeColor = System.Drawing.Color.White;
            this.BManagerClients.Location = new System.Drawing.Point(734, 11);
            this.BManagerClients.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerClients.Name = "BManagerClients";
            this.BManagerClients.Size = new System.Drawing.Size(93, 44);
            this.BManagerClients.TabIndex = 18;
            this.BManagerClients.TabStop = false;
            this.BManagerClients.Text = "Список клиентов";
            this.BManagerClients.UseVisualStyleBackColor = false;
            this.BManagerClients.Click += new System.EventHandler(this.BManagerClients_Click_1);
            // 
            // PManagerClients
            // 
            this.PManagerClients.Controls.Add(this.DTClients);
            this.PManagerClients.Location = new System.Drawing.Point(8, 63);
            this.PManagerClients.Margin = new System.Windows.Forms.Padding(2);
            this.PManagerClients.Name = "PManagerClients";
            this.PManagerClients.Size = new System.Drawing.Size(824, 411);
            this.PManagerClients.TabIndex = 17;
            this.PManagerClients.Visible = false;
            // 
            // BManagerDelUser
            // 
            this.BManagerDelUser.BackColor = System.Drawing.Color.Gray;
            this.BManagerDelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BManagerDelUser.FlatAppearance.BorderSize = 0;
            this.BManagerDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BManagerDelUser.ForeColor = System.Drawing.Color.White;
            this.BManagerDelUser.Location = new System.Drawing.Point(91, 478);
            this.BManagerDelUser.Margin = new System.Windows.Forms.Padding(2);
            this.BManagerDelUser.Name = "BManagerDelUser";
            this.BManagerDelUser.Size = new System.Drawing.Size(95, 50);
            this.BManagerDelUser.TabIndex = 19;
            this.BManagerDelUser.Text = "Удалить пользователя";
            this.BManagerDelUser.UseVisualStyleBackColor = false;
            this.BManagerDelUser.Click += new System.EventHandler(this.BManagerDelUser_Click);
            // 
            // FManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(838, 537);
            this.Controls.Add(this.BManagerDelUser);
            this.Controls.Add(this.PManagerMain);
            this.Controls.Add(this.BManagerUpdtTable);
            this.Controls.Add(this.PManagerClients);
            this.Controls.Add(this.PClientMainApsCtrl);
            this.Controls.Add(this.BManagerClients);
            this.Controls.Add(this.BManagerUpAdd);
            this.Controls.Add(this.BManagerUpEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(854, 576);
            this.MinimumSize = new System.Drawing.Size(854, 576);
            this.Name = "FManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FManager_FormClosed);
            this.Load += new System.EventHandler(this.FManager_Load);
            this.PManagerMain.ResumeLayout(false);
            this.PManagerMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTClients)).EndInit();
            this.PClientMainApsCtrl.ResumeLayout(false);
            this.PManagerClients.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BManagerAdd;
        public System.Windows.Forms.Panel PManagerMain;
        private System.Windows.Forms.Label LClientApInfo1;
        private System.Windows.Forms.Label LClientApInfo;
        private System.Windows.Forms.Label LClientApName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BManagerChngPic;
        private System.Windows.Forms.Button BManagerChngDesc;
        private System.Windows.Forms.Button BManagerChngName;
        public System.Windows.Forms.Panel PClientMainApsCtrl;
        private System.Windows.Forms.Button BManagerNext;
        private System.Windows.Forms.Button BManagerPrev;
        private System.Windows.Forms.Button BManagerEdit;
        private System.Windows.Forms.Button BManagerUpEdit;
        private System.Windows.Forms.Button BManagerUpAdd;
        public System.Windows.Forms.Panel PManagerClients;
        private System.Windows.Forms.Button BManagerClients;
        private System.Windows.Forms.Button BManagerUpdtTable;
        public System.Windows.Forms.DataGridView DTClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTTName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTPNumb;
        private System.Windows.Forms.Button BManagerDelUser;
    }
}