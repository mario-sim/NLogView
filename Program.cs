using Lib.Logger;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
namespace NLogView {
	internal static class Program {
		static MainView mainView;
		private static Mutex s_Mutex;
		[DllImport("user32.dll")]
		static extern bool SetForegroundWindow(IntPtr hWnd);
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			TLoggerContainer.VerbousLevel = EVerbousLevel.Trace;
			TLoggerContainer.Init(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\NLogNLogView.config");
			s_Mutex = new Mutex(true, "NLogView");
			if (s_Mutex.WaitOne(0, false)) {
				TLoggerContainer.NLogger?.Log(TLoggerContainer.Trace("Program", "Main", "Первый запуск"));
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				TLoggerContainer.NLogger?.Log(TLoggerContainer.Trace("Program", "Main", "Первый запуск. Создание главной формы"));
				mainView = new MainView();
				mainView.tsmiExit.Click += Exit;
				mainView.tsmiExpand.Click += Expand;
				TLoggerContainer.NLogger?.Log(TLoggerContainer.Trace("Program", "Main", "Первый запуск. Успешно"));
				Application.Run(mainView);//			Application.Run(new MainView());
			}
			else {
				TLoggerContainer.NLogger?.Log(TLoggerContainer.Trace("Program", "Main", "Повторный запуск"));
				Process current = Process.GetCurrentProcess();
				Process[] processes = Process.GetProcessesByName (current.ProcessName);
				foreach (Process process in processes) {
					if (process.Id != current.Id) {
						if (current.MainModule != null) {
							string ss = current.MainModule.FileName;//Assembly.GetExecutingAssembly().Location.Replace("/", "\\");
							if (ss == current.MainModule.FileName) {
								TLoggerContainer.NLogger?.Log(TLoggerContainer.Trace("Program", "Main", "Повторный запуск. Программа уже запущена"));
								SetForegroundWindow(process.MainWindowHandle);
								TLoggerContainer.NLogger?.Log(TLoggerContainer.Trace("Program", "Main", "Повторный запуск. На передний план"));
							}
						}
					}
				}
			}
		}
		static void Exit(object sender, EventArgs e) {
			if (mainView != null)
				mainView.close = true;
			Application.Exit();
		}
		static void Expand(object sender, EventArgs e) {
			if (mainView != null) {
				mainView.WindowState = FormWindowState.Normal;
				mainView.BringToFront();
			}
		}
	}
}