namespace DocumentTemplater
{
    partial class MainForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFile_btn = new System.Windows.Forms.ToolStripButton();
            this.SaveFile_btn = new System.Windows.Forms.ToolStripButton();
            this.SendFile_btn = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile_btn,
            this.SaveFile_btn,
            this.SendFile_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(296, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenFile_btn
            // 
            this.OpenFile_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFile_btn.Image = global::DocumentTemplater.Properties.Resources.icons8_open_folder_48;
            this.OpenFile_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFile_btn.Name = "OpenFile_btn";
            this.OpenFile_btn.Size = new System.Drawing.Size(23, 22);
            this.OpenFile_btn.Text = "Открыть файл";
            this.OpenFile_btn.ToolTipText = "Открыть файл";
            this.OpenFile_btn.Click += new System.EventHandler(this.OpenFile_btn_Click);
            // 
            // SaveFile_btn
            // 
            this.SaveFile_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFile_btn.Image = global::DocumentTemplater.Properties.Resources.icons8_save_48;
            this.SaveFile_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFile_btn.Name = "SaveFile_btn";
            this.SaveFile_btn.Size = new System.Drawing.Size(23, 22);
            this.SaveFile_btn.Text = "Сохранить файл";
            this.SaveFile_btn.ToolTipText = "Сохранить файл";
            this.SaveFile_btn.Click += new System.EventHandler(this.SaveFile_btn_Click);
            // 
            // SendFile_btn
            // 
            this.SendFile_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SendFile_btn.Image = global::DocumentTemplater.Properties.Resources.icons8_send_48;
            this.SendFile_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SendFile_btn.Name = "SendFile_btn";
            this.SendFile_btn.Size = new System.Drawing.Size(23, 22);
            this.SendFile_btn.Text = "Отправить файл на почту";
            this.SendFile_btn.ToolTipText = "Отправить файл на почту";
            this.SendFile_btn.Click += new System.EventHandler(this.SendFile_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 483);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 508);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Заполнение шаблонов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenFile_btn;
        private System.Windows.Forms.ToolStripButton SaveFile_btn;
        private System.Windows.Forms.ToolStripButton SendFile_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

