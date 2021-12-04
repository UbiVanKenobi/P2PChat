
namespace P2PChat
{
    partial class Form1
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
            this.status = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chatTb = new System.Windows.Forms.TextBox();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПерепискуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.createServerTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.messageTb = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.checkConnectionLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.disconnectTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.status.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkConnectionLbl});
            this.status.Location = new System.Drawing.Point(0, 428);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(800, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.подключениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chatTb
            // 
            this.chatTb.Location = new System.Drawing.Point(12, 27);
            this.chatTb.Multiline = true;
            this.chatTb.Name = "chatTb";
            this.chatTb.ReadOnly = true;
            this.chatTb.Size = new System.Drawing.Size(776, 372);
            this.chatTb.TabIndex = 2;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьПерепискуToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitTsm});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьПерепискуToolStripMenuItem
            // 
            this.сохранитьПерепискуToolStripMenuItem.Name = "сохранитьПерепискуToolStripMenuItem";
            this.сохранитьПерепискуToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.сохранитьПерепискуToolStripMenuItem.Text = "Сохранить переписку";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // exitTsm
            // 
            this.exitTsm.Name = "exitTsm";
            this.exitTsm.Size = new System.Drawing.Size(194, 22);
            this.exitTsm.Text = "Выход";
            // 
            // подключениеToolStripMenuItem
            // 
            this.подключениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToTSM,
            this.createServerTSM,
            this.disconnectTSM});
            this.подключениеToolStripMenuItem.Name = "подключениеToolStripMenuItem";
            this.подключениеToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.подключениеToolStripMenuItem.Text = "Подключение";
            // 
            // connectToTSM
            // 
            this.connectToTSM.Name = "connectToTSM";
            this.connectToTSM.Size = new System.Drawing.Size(212, 22);
            this.connectToTSM.Text = "Подключиться к серверу";
            this.connectToTSM.Click += new System.EventHandler(this.connectToTSM_Click);
            // 
            // createServerTSM
            // 
            this.createServerTSM.Name = "createServerTSM";
            this.createServerTSM.Size = new System.Drawing.Size(212, 22);
            this.createServerTSM.Text = "Создать сервер";
            this.createServerTSM.Click += new System.EventHandler(this.createServerTSM_Click);
            // 
            // messageTb
            // 
            this.messageTb.Location = new System.Drawing.Point(12, 405);
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(695, 20);
            this.messageTb.TabIndex = 3;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(713, 402);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Отправить";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // checkConnectionLbl
            // 
            this.checkConnectionLbl.BackColor = System.Drawing.SystemColors.Control;
            this.checkConnectionLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkConnectionLbl.Name = "checkConnectionLbl";
            this.checkConnectionLbl.Size = new System.Drawing.Size(95, 17);
            this.checkConnectionLbl.Text = "Не подключено";
            // 
            // disconnectTSM
            // 
            this.disconnectTSM.Name = "disconnectTSM";
            this.disconnectTSM.Size = new System.Drawing.Size(212, 22);
            this.disconnectTSM.Text = "Отключиться";
            this.disconnectTSM.Click += new System.EventHandler(this.disconnectTSM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messageTb);
            this.Controls.Add(this.chatTb);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПерепискуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitTsm;
        private System.Windows.Forms.ToolStripMenuItem подключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToTSM;
        private System.Windows.Forms.ToolStripMenuItem createServerTSM;
        private System.Windows.Forms.TextBox chatTb;
        private System.Windows.Forms.TextBox messageTb;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.ToolStripStatusLabel checkConnectionLbl;
        private System.Windows.Forms.ToolStripMenuItem disconnectTSM;
    }
}

