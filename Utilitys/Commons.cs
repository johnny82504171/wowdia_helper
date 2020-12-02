using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Withus.Utilitys
{
    class Commons
    {   
        public string GetDateTime() => DateTime.Now.ToString("yy.MM.dd HH:mm:ss");


        //TODO : 코드 다이어트 해야 함, 샘플용으로 냅둬야 함.
        public void WerkerValidation()
        {
            string path = $"{Environment.CurrentDirectory}\\worker.txt";

            try
            {
                if (File.Exists(path))
                {
                    if (File.ReadAllLines(path, Encoding.UTF8).Length == 0)
                    {
                        MessageBox.Show("Data Is Empty\n" +
                        "Please Fill In The Information And Program Restart\n");
                        Process.GetCurrentProcess().Kill();                        
                    }
                    else
                    {
                        string[] rowData = File.ReadAllLines(path, Encoding.UTF8);
                        for (int i = 0; i <= rowData.Length - 1; i++)
                        {
                            if (!rowData[i].Contains(':'))
                            {
                                MessageBox.Show("Data Format Validation Failed\n" +
                                                "Format => account:password" +
                                                "Please Fill In The Information And Program Restart\n");
                                Process.GetCurrentProcess().Kill();                                
                            }
                            if (rowData[i].Split(':')[0] == string.Empty)
                            {
                                MessageBox.Show("Data Format Validation Failed(account)\n" +
                                                "Format => account:password" +
                                                "Please Fill In The Information And Program Restart\n");
                                Process.GetCurrentProcess().Kill();                                
                            }
                            if (rowData[i].Split(':')[1] == string.Empty)
                            {
                                MessageBox.Show("Data Format Validation Failed(password)\n" +
                                                "Format => account:password" +
                                                "Please Fill In The Information And Program Restart\n");
                                Process.GetCurrentProcess().Kill();
                            }                            
                        }
                    }
                }
                else
                {                    
                    File.Create(path);
                    MessageBox.Show("worker.txt Has Been Created.\n" +
                                    "Please Fill In The Information And Program Restart\n");
                    Process.GetCurrentProcess().Kill();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}");
            }
        }
              
    }
}
