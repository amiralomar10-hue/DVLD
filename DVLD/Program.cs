using DVLD_Interface;
using LogEvent;
using System;
using System.Windows.Forms;
using ValidationAttributes.Global_Classes;

namespace DVLD
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. التقاط الأخطاء غير المتوقعة في واجهات المستخدم (UI Threads)
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            // 2. التقاط الأخطاء العامة الأخرى (Background Threads)
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.Run(new frmLogin()); // أو الشاشة الرئيسية لديك
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // تسجيل الخطأ تلقائياً في الـ Event Viewer
            clsLogEvent.LogError(e.Exception, "Unhandled UI Thread Exception");

            MessageBox.Show("log Error To Event Log", "Event Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;

            // تسجيل الخطأ الفادح تلقائياً في الـ Event Viewer
            clsLogEvent.LogError(ex, "Fatal Unhandled AppDomain Exception");
        }
    }
}