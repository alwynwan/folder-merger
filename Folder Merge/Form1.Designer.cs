namespace Folder_Merge
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
            this.label1 = new System.Windows.Forms.Label();
            this.dstFolder = new System.Windows.Forms.TextBox();
            this.addFolder = new System.Windows.Forms.Button();
            this.srcFolders = new System.Windows.Forms.ListBox();
            this.findDstFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.delFolder = new System.Windows.Forms.Button();
            this.clrFolders = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customSrc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination Folder";
            // 
            // dstFolder
            // 
            this.dstFolder.Location = new System.Drawing.Point(15, 25);
            this.dstFolder.Name = "dstFolder";
            this.dstFolder.Size = new System.Drawing.Size(237, 20);
            this.dstFolder.TabIndex = 1;
            // 
            // addFolder
            // 
            this.addFolder.Location = new System.Drawing.Point(15, 237);
            this.addFolder.Name = "addFolder";
            this.addFolder.Size = new System.Drawing.Size(75, 23);
            this.addFolder.TabIndex = 2;
            this.addFolder.Text = "Add";
            this.addFolder.UseVisualStyleBackColor = true;
            this.addFolder.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // srcFolders
            // 
            this.srcFolders.FormattingEnabled = true;
            this.srcFolders.Location = new System.Drawing.Point(15, 91);
            this.srcFolders.Name = "srcFolders";
            this.srcFolders.Size = new System.Drawing.Size(237, 134);
            this.srcFolders.TabIndex = 3;
            // 
            // findDstFolder
            // 
            this.findDstFolder.Location = new System.Drawing.Point(15, 51);
            this.findDstFolder.Name = "findDstFolder";
            this.findDstFolder.Size = new System.Drawing.Size(37, 21);
            this.findDstFolder.TabIndex = 4;
            this.findDstFolder.Text = "...";
            this.findDstFolder.UseVisualStyleBackColor = true;
            this.findDstFolder.Click += new System.EventHandler(this.findDstFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source Folders";
            // 
            // delFolder
            // 
            this.delFolder.Location = new System.Drawing.Point(96, 237);
            this.delFolder.Name = "delFolder";
            this.delFolder.Size = new System.Drawing.Size(75, 23);
            this.delFolder.TabIndex = 6;
            this.delFolder.Text = "Delete";
            this.delFolder.UseVisualStyleBackColor = true;
            this.delFolder.Click += new System.EventHandler(this.delFolder_Click);
            // 
            // clrFolders
            // 
            this.clrFolders.Location = new System.Drawing.Point(177, 237);
            this.clrFolders.Name = "clrFolders";
            this.clrFolders.Size = new System.Drawing.Size(75, 23);
            this.clrFolders.TabIndex = 7;
            this.clrFolders.Text = "Clear";
            this.clrFolders.UseVisualStyleBackColor = true;
            this.clrFolders.Click += new System.EventHandler(this.clrFolders_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Merge";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Overwrite";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(162, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Skip";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(15, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 39);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duplicate File Action";
            // 
            // customSrc
            // 
            this.customSrc.Location = new System.Drawing.Point(15, 288);
            this.customSrc.Name = "customSrc";
            this.customSrc.Size = new System.Drawing.Size(237, 20);
            this.customSrc.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Add Folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customSrc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clrFolders);
            this.Controls.Add(this.delFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findDstFolder);
            this.Controls.Add(this.srcFolders);
            this.Controls.Add(this.addFolder);
            this.Controls.Add(this.dstFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Folder Merger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dstFolder;
        private System.Windows.Forms.Button addFolder;
        private System.Windows.Forms.ListBox srcFolders;
        private System.Windows.Forms.Button findDstFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delFolder;
        private System.Windows.Forms.Button clrFolders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox customSrc;
        private System.Windows.Forms.Label label3;
    }
}

