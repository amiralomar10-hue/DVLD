using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogEvent
{
    public class clsLogEvent
    {
        public static void LogToEventLog(string message, EventLogEntryType type)
        {
            string sourceName = "DVLDApp"; // اسم برنامجك
            string logName = "Application";    // سجل التطبيقات في ويندوز

            try
            {
                // إنشاء مصدر السجل إذا لم يكن موجوداً (يتطلب صلاحيات مدير النظام Administrator عند أول تشغيل)
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, logName);
                }

                // كتابة الخطأ
                EventLog.WriteEntry(sourceName, message, type);
            }
            catch (Exception ex)
            {
                // في حال عدم توفر صلاحيات الكتابة في Event Log، يمكن كتابة الخطأ في ملف نصي أو تجاهله
                Debug.WriteLine($"Failed to write to Event Log: {ex.Message}");
            }
        }
        private static string SourceName = "DVLD_System";
        private static string LogName = "Application";

        // دالة أساسية لإنشاء الـ Source والكتابة في الـ Event Viewer


        // دالة ذكية للاستخدام السريع داخل الـ Catch (تستخرج اسم الكلاس والميثود تلقائياً)
        public static void LogError(Exception ex, string customMessage = "")
        {
            var stackTrace = new StackTrace(ex, true);
            var frame = stackTrace.GetFrame(0);
            string methodName = frame?.GetMethod()?.Name ?? "UnknownMethod";
            string className = frame?.GetMethod()?.DeclaringType?.Name ?? "UnknownClass";

            string finalMessage = $"Class: {className} | Method: {methodName}\n" +
                                  (!string.IsNullOrEmpty(customMessage) ? $"Info: {customMessage}\n" : "") +
                                  $"Error: {ex.Message}\nStackTrace:\n{ex.StackTrace}";

            LogToEventLog(finalMessage, EventLogEntryType.Error);
        }

        // دالة عامة لتسجيل أي رسالة تحذير أو معلومات (اختيارية)
        public static void LogInformation(string message)
        {
            LogToEventLog(message, EventLogEntryType.Information);
        }
    }
}

