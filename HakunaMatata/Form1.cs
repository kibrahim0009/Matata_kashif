using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel= Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace HakunaMatata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            readExcel();
        }
        private void readExcel()
        {
            string filepath = "C:\\Users\\IBRAHIM\\Downloads\\Hackathon Timesheet.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;
            wb = excel.Workbooks.Open(filepath);
            ws = wb.Worksheets[1];
            Range cell = ws.Range["A1:A2"];
            foreach(string Result in cell.Value)
            {
                MessageBox.Show(Result);
            }
            

        }
    }
}
