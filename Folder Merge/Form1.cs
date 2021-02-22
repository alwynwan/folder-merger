using System;
using System.IO;
using System.Windows.Forms;

namespace Folder_Merge
{
    public partial class Form1 : Form
    {
        int file_count, overwrite_count, skip_count;
        public Form1()
        {
            InitializeComponent();
        }

        private void findDstFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select destination folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                    dstFolder.Text = fbd.SelectedPath;
            }
        }

        private void addFolder_Click(object sender, EventArgs e)
        {
            if(customSrc.Text != "")
            {
                srcFolders.Items.Add(customSrc.Text);
            }
            else
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Select destination folder";
                    if (fbd.ShowDialog() == DialogResult.OK)
                        srcFolders.Items.Add(fbd.SelectedPath);
                }
            }
        }

        private void delFolder_Click(object sender, EventArgs e)
        {
            srcFolders.Items.RemoveAt(srcFolders.SelectedIndex);
        }

        private void clrFolders_Click(object sender, EventArgs e)
        {
            srcFolders.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            file_count = skip_count = overwrite_count = 0;
            foreach (string path in srcFolders.Items)
            {
                if (!Directory.Exists(path))
                    continue;

                foreach (string dirPath in Directory.GetDirectories(path, "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(path, dstFolder.Text));

                foreach (string newPath in Directory.GetFiles(path, "*.*", SearchOption.AllDirectories))
                {
                    if (File.Exists(newPath.Replace(path, dstFolder.Text)))
                    {
                        if (radioButton2.Checked)
                        {
                            skip_count++;
                            continue;
                        }
                        else
                            overwrite_count++;
                    }
                    
                    File.Copy(newPath, newPath.Replace(path, dstFolder.Text), radioButton1.Checked);
                    file_count++;
                }
                   
            }

            MessageBox.Show(string.Format("Merge completed!\r\n\r\nCopied {0} files\r\nOverwrote {1} files\r\nSkipped {2} files", file_count, overwrite_count, skip_count));
        }
    }
}
