using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace SelectaImport
{
    public partial class Form1 : Form
    {

        int RowNumber = 0;
        // StreamWriter sw  = new StreamWriter("D:\\Smarcom.txt");
        StreamWriter sw;
        string code = "";
        List<Selecta> DeviceList = new List<Selecta>();
        Selecta selecta;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void OpenFile(string path)
        {
            string filepath = Path.GetDirectoryName(path);
            string filename = Path.GetFileName(path);
           // MessageBox.Show(filename);
            sw = new StreamWriter(filepath + "\\"+filename+".txt");
            selecta = new Selecta();
            Reader r = new Reader(path, 1);
            
            // MessageBox.Show(r.ReadFirstRow(1,1));
            RowNumber = r.CountRows();
            for (int i = 1; i <= RowNumber; i++)
            {
                selecta.UserName = r.ReadFirstRow(i, 1);
                selecta.PWD = r.ReadFOurthRow(i, 1);
                selecta.IP = r.ReadSeventhRow(i, 1);
                DeviceList.Add(selecta);

                // MessageBox.Show(selecta.UserName + " " + selecta.PWD + " " + selecta.IP);

                code = "                       INSERT INTO `radcheck` (`id`, `username`, `attribute`, `op`, `value`) VALUES(NULL, '" + selecta.UserName + @"@selecta.m2m', 'Cleartext-Password', ':=', '" + selecta.PWD + @"');
                        INSERT INTO `radreply` (`id`, `username`, `attribute`, `op`, `value`) VALUES(NULL, '" + selecta.UserName + @"@selecta.m2m', 'Framed-Protocol', ':=', 'PPP');
                        INSERT INTO `radreply` (`id`, `username`, `attribute`, `op`, `value`) VALUES(NULL, '" + selecta.UserName + @"@selecta.m2m', 'Service-Type', ':=', 'Framed-User');
                        INSERT INTO `radreply` (`id`, `username`, `attribute`, `op`, `value`) VALUES(NULL, '" + selecta.UserName + @"@selecta.m2m', 'Framed-IP-Netmask', ':=', '255.255.255.0');
                        INSERT INTO `radreply` (`id`, `username`, `attribute`, `op`, `value`) VALUES(NULL, '" + selecta.UserName + @"@selecta.m2m', 'Framed-IP-Address', ':=', '" + selecta.IP + @"');
                        INSERT INTO `radreply` (`id`, `username`, `attribute`, `op`, `value`) VALUES(NULL, '" + selecta.UserName + @"@selecta.m2m', 'Idle-Timeout', ':=', '900');";
                // MessageBox.Show(code);
                Write(code);
                code = " ";
            }
            lblNumberOfDevices.Visible = true;

            sw.Close();
            r.Close();
        }

        private void Write(string code) {

            try
            {
                
                //Pass the filepath and filename to the StreamWriter Constructor
                //  StreamWriter sw = new StreamWriter("D:\\Smarcom.txt");
                //Write a line of text
                sw.WriteLine(code);
                sw.WriteLine(" ");
              

                //Write a second line of text
              //  sw.WriteLine("From the StreamWriter class");
                //Close the file
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
           
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Title = "Browse Excel Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "xlsx";
          // openFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
           
                
                try
                {
                   
                    OpenFile(file);

                    selecta = new Selecta();
                    //MessageBox.Show(DeviceList.Count().ToString());
                    lblNumberOfDevices.Text += DeviceList.Count().ToString();
                    string directoryPath = Path.GetDirectoryName(file);
                    

                    string text = File.ReadAllText(file);
                    int size = text.Length;
                   
                }
                catch (IOException)
                {
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
