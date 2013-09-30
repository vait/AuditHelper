using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;

namespace AuditHelper
{
    public partial class frmTestEnvironment : Form
    {
        private bool _endOfLoading = false;

        public bool EndOfLoading
        {
            set { _endOfLoading = value; }
        }

        public string Info
        {
            set { lbState.Text = value; }
        }

        public frmTestEnvironment()
        {
            InitializeComponent();
            //webInfo.DocumentText = Properties.Resource
        }

        public void ShowInfoUpdate()
        {
            this.panel1.Visible = true;
        }
        
        private void frmTestEnvironment_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !_endOfLoading;
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            
            Process p = new Process();
            
            ProcessStartInfo si = new ProcessStartInfo();
            //si.FileName = Path.Combine(Path.Combine(Path.GetFullPath(Application.StartupPath), "DB"), Program.is64BitOperatingSystem ? "AccessDatabaseEngine_x64.exe" : "AccessDatabaseEngine.exe");
            si.FileName = Path.Combine(Path.Combine(Path.GetFullPath(Application.StartupPath), "DB"), "AccessDatabaseEngine.exe");
            p.StartInfo = si;
            try
            {
                p.Start();
            }
            catch { }

            _endOfLoading = true;
            this.Close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://www.microsoft.com/en-us/download/details.aspx?id=13255");
            }
            catch { }

            _endOfLoading = true;
            this.Close();            
        }

        internal void NotFoundDB()
        {
            this.panel2.BringToFront();
            this.panel2.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _endOfLoading = true;
            this.Close();
        }
    }
}
