using Lib.Logger;
using Lib.LoggerViewer;
using Lib.LoggerWG;
using System;
using System.IO;
using System.Windows.Forms;
namespace NLogView {
	public partial class MainView : Form {
		TLoggerList _loggerList = null;
		public MainView() {
			InitializeComponent();
			ucView.AxNLogConfig = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\NLog.config";
		}
		void PrivSaveToFile(string fileName) {
			try {
				bool pw_start = Lib.WF.ProgressWindow.TControl.ProgressWindowCheckStart(1);
				bool header = true;
				using (StreamWriter sw = new StreamWriter(File.Open(fileName, FileMode.Create))) {
					/*
					gridView1.GetNextVisibleRow;
					pg.SetRange(0, gridView1.RowCount);
					foreach (var item in gridView1.SelectRows) {
					}
					*/
					if (_loggerList != null) {
						foreach (var item in _loggerList) {
							if (header) {
								sw.WriteLine(item.GetHeader());
								header = false;
							}
							sw.WriteLine(item);
							Lib.WF.ProgressWindow.TControl.ProgressWindowIncrement(1);
						}
					}
				}
				Lib.WF.ProgressWindow.TControl.ProgressWindowCheckEnd(pw_start);
			}
			catch (Exception e) {
				TLoggerContainer.NLogger?.Log(TLoggerGrid.Fatal("PLC.Tools", "SaveToFileTags", fileName, e));
			}
		}
		private void PrivUcViewLoad(object sender, EventArgs e) {
		}
		public bool close = false;
		private void MainView_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = !close;
			if (e.Cancel) {
				//this.ShowInTaskbar = false;
				notifyIcon1.Visible = true;
				this.WindowState = FormWindowState.Minimized;
			}
		}
		private void MainView_Deactivate(object sender, EventArgs e) {
			if (this.WindowState == FormWindowState.Minimized) {
				//				this.ShowInTaskbar = false;
				notifyIcon1.Visible = true;
			}
		}
	}
}
