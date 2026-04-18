using Lib.LoggerViewer;

namespace NLogView {
	public partial class UcView : UCViewGrid {
		public UcView() {
			InitializeComponent();
		}
		private void PrivBtAddClick(object sender, System.EventArgs e) {
			dlg_OpenFile.FileName = "*.config";
			if (dlg_OpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				if (System.IO.File.Exists(dlg_OpenFile.FileName)) {
					if (LoggerList.Add(dlg_OpenFile.FileName)) {
						lb_Config.Items.Add(dlg_OpenFile.FileName);
						/*                        _loggerList.CheckLastTime();
												de_TimePoint.DateTime = _loggerList.LastTime;
												l_LastTime.Text = "Последняя запись " + _loggerList.LastTime;*/
					}
				}
				PrivSelectedGapChanged(null, null);
			}
		}

		private void PrivBtRemoveClick(object sender, System.EventArgs e) {
			if (lb_Config.SelectedItem != null) {
				string s = lb_Config.SelectedItem.ToString();
				if (s != null) {
					LoggerList.Remove(s);
					lb_Config.Items.RemoveAt(lb_Config.SelectedIndex);
				}
			}
		}
	}
}
