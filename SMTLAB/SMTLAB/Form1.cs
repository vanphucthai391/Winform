using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTLAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string logerror = @"C:\PQM_CLR\log.txt";
        string folderBK = @"D:\ncvcpqm\ncvc01\ftpin\SMT\ERP_CLR\Backup";
        string barcode = "";
        string tool_station = "";
        string tool_check = "";
        string creator = "";
        string create_time = "";

        private void btn_autoget_Click(object sender, EventArgs e)
        {
            if (btn_autoget.Text == "Autorun")
            {
                ConvertandMovefile(txt_browserin.Text, folderBK);
            }
        }
        private void ConvertandMovefile(string pathfolderin, string pathfolderbackup)
        {
            System.IO.DirectoryInfo d = new DirectoryInfo(pathfolderin);
            FileInfo[] Files = d.GetFiles("*.csv");
            foreach (FileInfo file in Files)
            {
                try
                {
                    string[] datarow = File.ReadAllLines(pathfolderin + "\\" + file);
                    string[] arrListStr = datarow[0].ToString().Split(',');
                    barcode = arrListStr[0].ToString();
                    tool_station = arrListStr[1].ToString();
                    tool_check = arrListStr[2].ToString();
                    creator = arrListStr[3].ToString();
                }
                catch (Exception ex)
                {
                    writelogfile(" Convert and Move File Error", ex.ToString(), logerror);
                }
            }
        }
        private void writelogfile(string header, string contents, string linklogfile)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Error: " + header);
                sb.Append("\n");
                sb.Append("Detail: " + contents);
                sb.Append("\n");
                sb.Append("DateTime: " + DateTime.Now.ToString("yyyyMMdd HHmmss"));
                sb.Append("\n");
                sb.Append("--------------------------------------------------------");
                sb.Append("\n");
                File.AppendAllText(linklogfile, sb.ToString());
                sb.Clear();
            }
            catch
            {
            }
        }
    }

}
