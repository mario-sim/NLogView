namespace NLogView {
    partial class MainView {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		#region Код, автоматически созданный конструктором форм Windows
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			ucView = new UcView();
			notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
			contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
			tsmiExpand = new System.Windows.Forms.ToolStripMenuItem();
			tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			contextMenuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// ucView
			// 
			ucView.AxNLogConfig = "";
			ucView.Dock = System.Windows.Forms.DockStyle.Fill;
			ucView.Location = new System.Drawing.Point(0, 0);
			ucView.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			ucView.Name = "ucView";
			ucView.Size = new System.Drawing.Size(1121, 655);
			ucView.TabIndex = 0;
			// 
			// notifyIcon1
			// 
			notifyIcon1.ContextMenuStrip = contextMenuStrip1;
			notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
			notifyIcon1.Text = "notifyIcon1";
			notifyIcon1.Visible = true;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiExpand, tsmiExit });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
			// 
			// tsmiExpand
			// 
			tsmiExpand.Name = "tsmiExpand";
			tsmiExpand.Size = new System.Drawing.Size(135, 22);
			tsmiExpand.Text = "Развернуть";
			// 
			// tsmiExit
			// 
			tsmiExit.Name = "tsmiExit";
			tsmiExit.Size = new System.Drawing.Size(135, 22);
			tsmiExit.Text = "Выход";
			// 
			// MainView
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1121, 655);
			Controls.Add(ucView);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "MainView";
			Text = "Просмотр сообщений NLog";
			Deactivate += MainView_Deactivate;
			FormClosing += MainView_FormClosing;
			contextMenuStrip1.ResumeLayout(false);
			ResumeLayout(false);
		}
		#endregion
		private UcView ucView;
		public System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		public System.Windows.Forms.ToolStripMenuItem tsmiExpand;
		public System.Windows.Forms.ToolStripMenuItem tsmiExit;
	}
}
