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
        private List<string> canNotReplaceTextFile = new List<string>();

        public Form1()
        {
            InitializeComponent();

            timerAuto = new Timer();
            timerAuto.Tick += timerAuto_Tick;
            timerAuto.Interval = 1000;

            //Giá trị mẫu để test
            txbPath.Text = "E:\\";
            //txbNeedReplace.Text = "You";
            //txbReplace.Text = "I";
            txbNeedReplace.Text = "mechanical";
            txbReplace.Text = "mech";

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            OpenFile();
            ReplaceText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
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
            timerAuto.Enabled = !timerAuto.Enabled;
            btnAuto.Text = btnAuto.Text == "Tự động" ? "Ngừng" : "Tự động";



        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            txbPath.Text = folderBrowserDialog1.SelectedPath;
            folderDir = txbPath.Text;
        }

        private void timerAuto_Tick(object sender, EventArgs e)
        {
            if(txbReplace.Text == "" || txbNeedReplace.Text == "" || txbReplace.Text == "" && txbNeedReplace.Text == "" || txbPath.Text == "")
            {
                timerAuto.Enabled = false;
                btnAuto.Text = "Tự động";
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                OpenFile();
                ReplaceText();
                SaveFile();

            }
            
        }

        private void OpenFile()
        {
            if (!HasValue(folderDir))
            {
                folderDir = txbPath.Text;
            }
            foreach (string file in Directory.GetFiles(folderDir, fileType))
            {
                string contents = File.ReadAllText(file);
                filePaths.Add(folderDir + Path.GetFileNameWithoutExtension(file));
                files.Add(contents);
            }
        }

        private void ReplaceText()
        {
            if (HasValue(txbReplace.Text, txbNeedReplace.Text))
            {
                string replaceText = txbReplace.Text;
                string needReplaceText = txbNeedReplace.Text;
                string fileReplaced = "";
                
                //result = txbResult.Text.Replace(needReplaceText, replaceText);
                //txbResult.Text = result;
                //string[] file;

                for (int i = 0; i < files.ToArray().Length; i++)
                {
                    //file[i] = files.ToArray()[i];
                    if (HasContainedTextToReplace(needReplaceText, files.ToArray()[i]))
                    {
                        fileReplaced = files.ToArray()[i].Replace(needReplaceText, replaceText);
                        results.Add(fileReplaced);
                    }
                    else
                    {
                        //filePaths.Remove(filePaths.ToArray()[i]);
                        canNotReplaceTextFile.Add(filePaths[i]);
                    }
                }

                // Hiển thị tạm thời sau khi submitted hiện file đầu tiên thực hiện thay thế
                if(results.ToArray().Length > 0)
                {
                    txbResult.Text = results.ToArray()[0];
                }
                else
                {
                    txbResult.Text = "Không có gì để thay thế!";
                }
                
            }
            else
            {
                MessageBox.Show("Bấm gì mà bấm! Nhập thông tin vào!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveFile()
        {
            if (txbPath.Text != "")
            {
                DestroyAllFilePathCanNotReplace(canNotReplaceTextFile, filePaths);
                
                for (int i = 0; i < (filePaths.ToArray()).Length; i++)
                {
                    File.WriteAllText((filePaths.ToArray())[i] + "_test.txt", (results.ToArray())[i]);
                }
                files.Clear();
                results.Clear();
                filePaths.Clear();
                canNotReplaceTextFile.Clear();
            }
        }

        /**
         * Kiểm tra file có từ cần replace không?
         * Hoặc đã replace chưa?
         */
        private bool HasContainedTextToReplace(string needReplaceText, string discText)
        {
            //Kiểm tra xem có từ cần replace 
            if(discText.Contains(needReplaceText))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool HasValue(string text)
        {
            return text != "" ? true : false;
        }

        private bool HasValue(string text1, string text2)
        {
            return text1 != "" && text2 != "" ? true : false;
        }

        private List<string> DestroyAllFilePathCanNotReplace(List<string> itemPaths, List<string> filePaths)
        {
            foreach(string path in itemPaths)
            {
                filePaths.Remove(path);
            }
            return filePaths;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            folderListView.Items.Add(folderBrowserDialog1.SelectedPath);
            //folderDir = txbPath.Text;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < folderListView.Items.Count; i++)
            {
                if(folderListView.Items[i].Selected)
                {
                    folderListView.Items[i].Remove();
                    i--;
                }
            }
        }
    }
}
