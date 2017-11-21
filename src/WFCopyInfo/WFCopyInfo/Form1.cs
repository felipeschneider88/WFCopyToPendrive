using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;

namespace WFCopyInfo
{
    public partial class frmCopy : Form
    {
        public frmCopy()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtSource.Text = folderBrowserDialog1.SelectedPath;

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            string scriptText = "CopyInfo -Origen " + txtSource.Text + " -Carpeta " + txtFolder.Text;
            txtOutput.Text = RunScript(scriptText);

            //PowerShell ps = PowerShell.Create();
            
            /*
             * ps.Commands.AddScript("Copy-InfoToPendrive");
            ps.Commands.AddParameter("Origen", @"C:\Users\felipe\Desktop\FMP");
            ps.Commands.AddParameter("Carpeta", "Test");
            ps.Invoke();
            */
        }

        private void frmCopy_Load(object sender, EventArgs e)
        {
            /*
            PowerShell pShell = PowerShell.Create();
            pShell.Commands.AddCommand("import-module").AddParameter("Name", @"CopyInfo");
            var results = pShell.Invoke();
            pShell.Commands.Clear();

            */
        }
        private string RunScript(string scriptText)
        {
            InitialSessionState iss = InitialSessionState.CreateDefault();
            //iss.ImportPSModulesFromPath(@"C:\Users\felipe\Desktop\WFCopy-InfoToPendrive.psm1");
            iss.ImportPSModule(new string[] { "CopyInfo" });
            // create Powershell runspace
            Runspace runspace = RunspaceFactory.CreateRunspace(iss);

            // open it
            runspace.Open();

            // create a pipeline and feed it the script text
            Pipeline pipeline = runspace.CreatePipeline();

            //pipeline.Commands.Add(@"Import-Module C:\Users\felipe\Desktop\WFCopy-InfoToPendrive.ps1");
            //pipeline.Invoke();
            //pipeline.Commands.Clear();


            pipeline.Commands.AddScript(scriptText);

            // add an extra command to transform the script output objects into nicely formatted strings
            // remove this line to get the actual objects that the script returns. For example, the script
            // "Get-Process" returns a collection of System.Diagnostics.Process instances.
            pipeline.Commands.Add("Out-String");

            // execute the script
            Collection<PSObject> results = pipeline.Invoke();

            // close the runspace
            runspace.Close();

            // convert the script result into a single string
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject obj in results)
            {
                stringBuilder.AppendLine(obj.ToString());
            }

            return stringBuilder.ToString();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            txtOutput.Text = RunScript(textBoxScript.Text);
        }
    }
}
