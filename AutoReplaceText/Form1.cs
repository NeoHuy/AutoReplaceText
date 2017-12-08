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
                result = txbResult.Text.Replace(needReplaceText, replaceText);
                txbResult.Text = result;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
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
                    //result += contents;
                    result = contents;
                }
                txbResult.Text = result;
            }

        }
    }
}
