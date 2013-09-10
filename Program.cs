using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;

namespace AuditHelper
{
    static class Program
    {
        public static bool is64BitProcess = (IntPtr.Size == 8);
        public static bool is64BitOperatingSystem = is64BitProcess || InternalCheckIsWow64();
        public static bool isReady = true;
        public static int countNearestExpired = 0;
        public static int countExpired = 0;
        
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
            [In] IntPtr hProcess,
            [Out] out bool wow64Process
        );

        public static bool InternalCheckIsWow64()
        {
            if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                Environment.OSVersion.Version.Major >= 6)
            {
                using (Process p = Process.GetCurrentProcess())
                {
                    bool retVal;
                    if (!IsWow64Process(p.Handle, out retVal))
                    {
                        return false;
                    }
                    return retVal;
                }
            }
            else
            {
                return false;
            }
        }

        private static frmTestEnvironment loadWindow = null;

        private static void StartTest() 
        {
            loadWindow = new frmTestEnvironment();
            
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerAsync();
            loadWindow.ShowDialog();
        }

        private static void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0, "Проверка подключения к базе...");
            try
            {
                System.Data.OleDb.OleDbConnection _connection = new System.Data.OleDb.OleDbConnection();
                _connection.ConnectionString = AuditHelper.Properties.Settings.Default.auditHelperConnectionString;
                _connection.Open();
                _connection.Close();

            }
            catch
            {
                isReady = false;
                worker.ReportProgress(0, "");
                worker.ReportProgress(1, "Ошибка подключения к базе");
            }

            //Соединение установлено, загружаем словари
            if (isReady)
            {
                worker.ReportProgress(0, "Загрузка справочников...");
                worker.ReportProgress(0, "Загрузка рисков...");
                List<int> ids = null;
                Classes.Entity tmp = null;

                ids = DB.ApplicationDataMappers.LevelsOfRiskDM.GetAllIDs();

                foreach (int id in ids)
                {
                    tmp = DB.ApplicationMap.LevelsOfRisk[id];
                }

                worker.ReportProgress(0, "Загрузка статусов...");

                ids = DB.ApplicationDataMappers.ContentStatusDM.GetAllIDs();

                foreach (int id in ids)
                {
                    tmp = DB.ApplicationMap.ContentStatus[id];
                }

                worker.ReportProgress(0, "Загрузка организаций...");

                ids = DB.ApplicationDataMappers.OutsideOrgDM.GetAllIDs();

                foreach (int id in ids)
                {
                    tmp = DB.ApplicationMap.OutsideOrg[id];
                }

                worker.ReportProgress(0, "Загрузка сотрудников...");

                ids = DB.ApplicationDataMappers.OutsideEmpDM.GetAllIDs();

                foreach (int id in ids)
                {
                    tmp = DB.ApplicationMap.OutsideEmp[id];
                }

                worker.ReportProgress(0, "Загрузка планов...");

                ids = DB.ApplicationDataMappers.PlanDM.GetAllIDs();

                foreach (int id in ids)
                {
                    tmp = DB.ApplicationMap.Plan[id];
                    if ((tmp as Classes.Plan).NearestDate != DateTime.MaxValue)
                    {
                        if ((tmp as Classes.Plan).NearestDate <= DateTime.Now)
                            ++countExpired;

                        if ((tmp as Classes.Plan).NearestDate <= DateTime.Now.AddDays(4) && (tmp as Classes.Plan).NearestDate > DateTime.Now)
                            ++countNearestExpired;
                    }
                }
            }
        }

        

        private static void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // close loading window
            loadWindow.EndOfLoading = isReady;
            loadWindow.Close();
        }

        private static void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 0:
                    loadWindow.Info = e.UserState.ToString();
                    break;
                case 1:
                    loadWindow.ShowInfoUpdate();
                    break;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartTest();
            
            if (isReady) Application.Run(new frmMain());
        }
    }
}
