using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace SelectaImport
{
    class Reader
    {
        private string path = " ";
        _Application Excell = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Reader(string path, int sheet)
        {
           
            this.path = path;
            wb = Excell.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public string ReadFirstRow(int i, int j)
        
        {
            i++;
           
            if (ws.Cells[i, j].Value2 != null)
            {
              //  MessageBox.Show(i.ToString() + j.ToString());
                return ws.Cells[i, j].Value2;

            }
            else return "Ništa";
        
        }

        public string ReadFOurthRow(int i, int j)

        {
            i++;
            j = 4;

            if (ws.Cells[i, j].Value2 != null)
            {
                return ws.Cells[i, j].Value2;
            }
            else return "Ništa";

        }

        public string ReadSeventhRow(int i, int j)

        {
            i++;
            j = 7;

            if (ws.Cells[i, j].Value2 != null)
            {
                return ws.Cells[i, j].Value2;
            }
            else return "Ništa";

        }
        public int  CountRows() { 
                
            int i = 2,  j = 1;
            int NumberOfRows = 0;
            while (ws.Cells[i, j].Value2 != null) 
            {
                NumberOfRows++;
                i++;
            }

            return NumberOfRows;
        
        }

        public void Close()
        {
            wb.Close(0);
        }

    }
}
