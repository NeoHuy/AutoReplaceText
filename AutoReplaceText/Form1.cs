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
        private string result = "";
        private string newFile = "test.txt";
        private List<string> files = new List<string>();
        private List<string> results = new List<string>();
        private List<string> filePaths = new List<string>();

        public Form1()
        {
            InitializeComponent();
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Chỉ nhập vào textbox địa chỉ thư mục để quét tất cả các file txt sau đó hiển thị ra textbox số lượng file.
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

        }
    }
}
