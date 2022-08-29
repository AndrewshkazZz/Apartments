namespace Apartments
{
    partial class F1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.F1BM = new System.Windows.Forms.Button();
            this.F1L = new System.Windows.Forms.Label();
            this.F1BC = new System.Windows.Forms.Button();
            this.PanelF1 = new System.Windows.Forms.Panel();
            this.NoBF1 = new System.Windows.Forms.Button();
            this.YesBF1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelF1.SuspendLayout();
            this.SuspendLayout();
            // 
            // F1BM
            // 
            this.F1BM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.F1BM.BackColor = System.Drawing.Color.Gray;
            this.F1BM.FlatAppearance.BorderSize = 0;
            this.F1BM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.F1BM.Location = new System.Drawing.Point(156, 113);
            this.F1BM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.F1BM.Name = "F1BM";
            this.F1BM.Size = new System.Drawing.Size(118, 38);
            this.F1BM.TabIndex = 0;
            this.F1BM.TabStop = false;
            this.F1BM.Text = "Менеджер";
            this.F1BM.UseVisualStyleBackColor = false;
            this.F1BM.Click += new System.EventHandler(this.F1BM_Click);
            // 
            // F1L
            // 
            this.F1L.AutoSize = true;
            this.F1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.F1L.Location = new System.Drawing.Point(37, 25);
            this.F1L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.F1L.Name = "F1L";
            this.F1L.Size = new System.Drawing.Size(218, 17);
            this.F1L.TabIndex = 1;
            this.F1L.Text = "Выберите то, кем вы являетесь";
            // 
            // F1BC
            // 
            this.F1BC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.F1BC.BackColor = System.Drawing.Color.Gray;
            this.F1BC.FlatAppearance.BorderSize = 0;
            this.F1BC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.F1BC.Location = new System.Drawing.Point(9, 113);
            this.F1BC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.F1BC.Name = "F1BC";
            this.F1BC.Size = new System.Drawing.Size(118, 38);
            this.F1BC.TabIndex = 2;
            this.F1BC.TabStop = false;
            this.F1BC.Text = "Клиент";
            this.F1BC.UseVisualStyleBackColor = false;
            this.F1BC.Click += new System.EventHandler(this.F1BC_Click);
            // 
            // PanelF1
            // 
            this.PanelF1.CausesValidation = false;
            this.PanelF1.Controls.Add(this.NoBF1);
            this.PanelF1.Controls.Add(this.YesBF1);
            this.PanelF1.Controls.Add(this.label1);
            this.PanelF1.Location = new System.Drawing.Point(9, 11);
            this.PanelF1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelF1.Name = "PanelF1";
            this.PanelF1.Size = new System.Drawing.Size(265, 141);
            this.PanelF1.TabIndex = 3;
            this.PanelF1.Visible = false;
            // 
            // NoBF1
            // 
            this.NoBF1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NoBF1.BackColor = System.Drawing.Color.Gray;
            this.NoBF1.FlatAppearance.BorderSize = 0;
            this.NoBF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoBF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NoBF1.Location = new System.Drawing.Point(162, 83);
            this.NoBF1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoBF1.Name = "NoBF1";
            this.NoBF1.Size = new System.Drawing.Size(75, 41);
            this.NoBF1.TabIndex = 4;
            this.NoBF1.TabStop = false;
            this.NoBF1.Text = "Нет";
            this.NoBF1.UseVisualStyleBackColor = false;
            this.NoBF1.Click += new System.EventHandler(this.NoBF1_Click);
            // 
            // YesBF1
            // 
            this.YesBF1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YesBF1.BackColor = System.Drawing.Color.Gray;
            this.YesBF1.FlatAppearance.BorderSize = 0;
            this.YesBF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesBF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.YesBF1.Location = new System.Drawing.Point(31, 83);
            this.YesBF1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YesBF1.Name = "YesBF1";
            this.YesBF1.Size = new System.Drawing.Size(75, 41);
            this.YesBF1.TabIndex = 3;
            this.YesBF1.TabStop = false;
            this.YesBF1.Text = "Да";
            this.YesBF1.UseVisualStyleBackColor = false;
            this.YesBF1.Click += new System.EventHandler(this.YesBF1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подтвердить выбор?";
            // 
            // F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(283, 161);
            this.Controls.Add(this.PanelF1);
            this.Controls.Add(this.F1BC);
            this.Controls.Add(this.F1L);
            this.Controls.Add(this.F1BM);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "F1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartments";
            this.PanelF1.ResumeLayout(false);
            this.PanelF1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F1BM;
        private System.Windows.Forms.Label F1L;
        private System.Windows.Forms.Button F1BC;
        private System.Windows.Forms.Panel PanelF1;
        private System.Windows.Forms.Button NoBF1;
        private System.Windows.Forms.Button YesBF1;
        private System.Windows.Forms.Label label1;
    }
}

