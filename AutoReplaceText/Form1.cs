using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DemoForm
{
    public partial class Form1 : Form
    {
        private string folderDir = "";
        private string fileType = "*.txt";
        private List<string> files = new List<string>();
        private List<string> results = new List<string>();
        private List<string> filePaths = new List<string>();

        public Form1()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 5000;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (txbReplace.Text == "")
            {
                txbReplace.Text = "Nhập từ để thay thế vào đây!";
            }
            else
            {
                string replaceText = txbReplace.Text;
                string needReplaceText = txbNeedReplace.Text;
                //result = txbResult.Text.Replace(needReplaceText, replaceText);
                //txbResult.Text = result;

                foreach(string file in files.ToArray())
                {
                    results.Add(file.Replace(needReplaceText, replaceText));
                }
                // Hiển thị tạm thời sau khi submitted hiện file đầu tiên thực hiện thay thế
                txbResult.Text = (results.ToArray())[0];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txbPath.Text != "")
            {
                //File.WriteAllText(txbPath.Text + newFile, result);
                // Lưu file mới với tên file cũ + '_test.txt'
                /*
                foreach (string file in filePaths.ToArray())
                {
                    foreach(string _result in results.ToArray())
                    {
                        File.WriteAllText(file + "_test.txt", _result);
                    }
                }
                */
                for (int i = 0; i < (filePaths.ToArray()).Length; i++)
                {
                    File.WriteAllText((filePaths.ToArray())[i] + "_test.txt", (results.ToArray())[i]);
                }
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            // Chỉ nhập vào textbox địa chỉ thư mục để quét tất cả các file txt sau đó hiển thị ra textbox số lượng file.
            /*
            folderDir = txbPath.Text;

            if (folderDir == "")
            {
                txbPath.Text = "Phải nhập địa chỉ thư mục để kiểm tra vào đây!";
            }
            else
            { 
                foreach (string file in Directory.GetFiles(folderDir, fileType))
                {
                    string contents = File.ReadAllText(file);
                    filePaths.Add(folderDir + Path.GetFileNameWithoutExtension(file));
                    files.Add(contents);
                }
                txbResult.Text = "Số lượng file đang đọc: " + (files.ToArray()).Length;
            }
            */

            //Sau khi click chọn thì cứ 5 giây quét file và mở lên 1 lần

            // Khi ngừng click sẽ chạy và ngược lại
            timer1.Enabled = !timer1.Enabled;
            btnAuto.Text = btnAuto.Text == "Tự động" ? "Ngừng tự động" : "Tự động";



        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            txbPath.Text = folderBrowserDialog1.SelectedPath;
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            txbReplace.Text = i.ToString();
               
        }
    }
}
