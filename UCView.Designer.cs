namespace NLogView {
    partial class UcView {
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.lb_Config = new System.Windows.Forms.ListBox();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.dlg_OpenFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.de_TimePoint.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_TimePoint.Properties)).BeginInit();
            this.p_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // de_TimePoint
            // 
            this.de_TimePoint.EditValue = new System.DateTime(2020, 10, 28, 9, 20, 12, 338);
            this.de_TimePoint.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "HH:mm dd.MM.yyyy";
            this.de_TimePoint.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_TimePoint.Properties.DisplayFormat.FormatString = "HH:mm dd.MM.yyyy";
            this.de_TimePoint.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_TimePoint.Properties.EditFormat.FormatString = "HH:mm dd.MM.yyyy";
            this.de_TimePoint.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_TimePoint.Properties.Mask.EditMask = "HH:mm dd.MM.yyyy";
            // 
            // p_Top
            // 
            this.p_Top.Controls.Add(this.lb_Config);
            this.p_Top.Controls.Add(this.bt_Remove);
            this.p_Top.Controls.Add(this.bt_Add);
            this.p_Top.Size = new System.Drawing.Size(992, 66);
            this.p_Top.Controls.SetChildIndex(this.bt_Add, 0);
            this.p_Top.Controls.SetChildIndex(this.bt_Remove, 0);
            this.p_Top.Controls.SetChildIndex(this.lb_Config, 0);
            this.p_Top.Controls.SetChildIndex(this.de_TimePoint, 0);
            this.p_Top.Controls.SetChildIndex(this.l_LastTime, 0);
            // 
            // lb_Config
            // 
            this.lb_Config.FormattingEnabled = true;
            this.lb_Config.Location = new System.Drawing.Point(516, 3);
            this.lb_Config.Name = "lb_Config";
            this.lb_Config.Size = new System.Drawing.Size(225, 56);
            this.lb_Config.TabIndex = 20;
            // 
            // bt_Remove
            // 
            this.bt_Remove.Location = new System.Drawing.Point(747, 34);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(31, 23);
            this.bt_Remove.TabIndex = 18;
            this.bt_Remove.Text = "-";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.PrivBtRemoveClick);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(747, 5);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(31, 23);
            this.bt_Add.TabIndex = 19;
            this.bt_Add.Text = "+";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.PrivBtAddClick);
            // 
            // dlg_OpenFile
            // 
            this.dlg_OpenFile.DefaultExt = "*.config";
            // 
            // UCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UcView";
            ((System.ComponentModel.ISupportInitialize)(this.de_TimePoint.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_TimePoint.Properties)).EndInit();
            this.p_Top.ResumeLayout(false);
            this.p_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Config;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.OpenFileDialog dlg_OpenFile;
    }
}
