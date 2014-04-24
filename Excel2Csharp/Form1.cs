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
using Microsoft.Win32;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
namespace Excel2Csharp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        
       private void bttnbrw_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Excel Worksheets 2003 (*.xls)|*.xls|Excel Worksheets 2007(*.xlsx)|*.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.FileName.ToString();
                pathfile.Text = path;
            }
        }

       private void releaseObject(object obj)
       {
           try
           {
               System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
               obj = null;
           }
           catch (Exception ex)
           {
               obj = null;
               MessageBox.Show("Unable to release the Object " + ex.ToString());
           }
           finally
           {
               GC.Collect();
           }
       }

       private void bttnShow_Click(object sender, EventArgs e)
       {
           Excel.Application xlApp;
           Excel.Workbook xlWorkBook;
           Excel.Worksheet xlWorkSheet;
           Excel.Range range;

           String[,] str = new String[100,100];

           int rCnt = 0;
           int cCnt = 0;

           xlApp = new Excel.Application();
           xlWorkBook = xlApp.Workbooks.Open(pathfile.Text, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
           xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

           range = xlWorkSheet.UsedRange;

           for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
           {

               for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
               {
                   if ((range.Cells[rCnt, cCnt] as Excel.Range).Value2 is Int16 || (range.Cells[rCnt, cCnt] as Excel.Range).Value2 is Int32 ||
                       (range.Cells[rCnt, cCnt] as Excel.Range).Value2 is Int64 || (range.Cells[rCnt, cCnt] as Excel.Range).Value2 is Decimal ||
                       (range.Cells[rCnt, cCnt] as Excel.Range).Value2 is Double)
                   {
                       str[rCnt, cCnt] = ((range.Cells[rCnt, cCnt] as Excel.Range).Formula).ToString();
                   }
                   else
                   {
                       str[rCnt, cCnt] = (range.Cells[rCnt, cCnt] as Excel.Range).Formula;
                   }

               }
           }
          
           for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
           {
            
               for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
               {

                   displayED.AppendText(" " +str[rCnt, cCnt] + " |");
                   if (cCnt == range.Columns.Count)
                   {
                       displayED.AppendText("\n");
                   }

               }

           }


           xlWorkBook.Close(true, null, null);
           xlApp.Quit();

           releaseObject(xlWorkSheet);
           releaseObject(xlWorkBook);
           releaseObject(xlApp);

       }

       private void bttnReset_Click(object sender, EventArgs e)
       {
           displayED.Text = String.Empty;
       }

    }
}






 

       

       

