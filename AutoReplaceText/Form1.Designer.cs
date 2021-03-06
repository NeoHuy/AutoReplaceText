﻿namespace DemoForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbReplace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txbNeedReplace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.timerAuto = new System.Windows.Forms.Timer(this.components);
            this.folderListView = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn";
            // 
            // txbPath
            // 
            this.txbPath.Location = new System.Drawing.Point(138, 13);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(250, 20);
            this.txbPath.TabIndex = 1;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(458, 110);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(89, 23);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "Tự động";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(138, 298);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.Size = new System.Drawing.Size(250, 89);
            this.txbResult.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(458, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbReplace
            // 
            this.txbReplace.Location = new System.Drawing.Point(138, 39);
            this.txbReplace.Name = "txbReplace";
            this.txbReplace.Size = new System.Drawing.Size(250, 20);
            this.txbReplace.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ thay thế";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(458, 52);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(89, 23);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "Thay thế";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txbNeedReplace
            // 
            this.txbNeedReplace.Location = new System.Drawing.Point(138, 65);
            this.txbNeedReplace.Name = "txbNeedReplace";
            this.txbNeedReplace.Size = new System.Drawing.Size(250, 20);
            this.txbNeedReplace.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ cần thay thế";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(458, 23);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(89, 23);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.Text = "Mở";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // timerAuto
            // 
            this.timerAuto.Interval = 1000;
            this.timerAuto.Tick += new System.EventHandler(this.timerAuto_Tick);
            // 
            // folderListView
            // 
            this.folderListView.Location = new System.Drawing.Point(138, 91);
            this.folderListView.Name = "folderListView";
            this.folderListView.Size = new System.Drawing.Size(250, 201);
            this.folderListView.TabIndex = 4;
            this.folderListView.UseCompatibleStateImageBehavior = false;
            this.folderListView.View = System.Windows.Forms.View.List;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(57, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(57, 211);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 425);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.folderListView);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.txbNeedReplace);
            this.Controls.Add(this.txbReplace);
            this.Controls.Add(this.txbPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tự động thay thế hàng loạt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txbNeedReplace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Timer timerAuto;
        private System.Windows.Forms.ListView folderListView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}

