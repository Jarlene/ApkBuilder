using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ApkBuilder
{
    public partial class BuildApk : Form
    {
        private string classPathDir;
        private string jarPathDir;
        private string resPathDir;
        private string mapPath;
        private string resRpath;
        private string outputFile;

        private string signFile;
        private string signFilePw;
        private string AliasName;
        private string AliasPw;

        private const string batPath ="";
        public BuildApk()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        }

        private void classSelectBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Class文件目录";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                classPathDir = dialog.SelectedPath;
                classDir.Text = classPathDir;
                outputText.Text += "选择了Class目录：" + classPathDir + Environment.NewLine;
            }
        }

        private void JarSelectBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Jar文件目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                jarPathDir = dialog.SelectedPath;
                JarDir.Text = jarPathDir;
                outputText.Text += "选择了Jar目录：" + jarPathDir + Environment.NewLine;
            }
        }

        private void ResSelectBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Res文件目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                resPathDir = dialog.SelectedPath;
                ResDir.Text = resPathDir;
                outputText.Text += "选择了Res目录：" + resPathDir + Environment.NewLine;
            }

        }

        private void MapSelectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "请选择混淆mapping文件|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mapPath = dialog.FileName;
                MapFile.Text = mapPath;
                outputText.Text += "选择了mapping文件：" + mapPath + Environment.NewLine;
            }

        }

        private void OutputSelectBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择输出文件目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                outputFile = dialog.SelectedPath;
                output.Text = outputFile + "\\output.apk";
                outputText.Text += "选择了输出文件目录：" + output.Text + Environment.NewLine;
            }
        }

        private void ResTxtBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "请选择资源R文件|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                resRpath = dialog.FileName;
                ResTxt.Text = resRpath;
                outputText.Text += "选择资源R文件：" + resRpath + Environment.NewLine;
            }

        }
    
        private void clearLog_Click(object sender, EventArgs e)
        {
            outputText.Text = "";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("重置");
        }


        private void ApkBuild_Click(object sender, EventArgs e)
        {
            AliasName = keyAliasNameText.Text;
            AliasPw = keyAliasPwText.Text;
            signFilePw = keyStorePwText.Text;

            if (string.IsNullOrWhiteSpace(AliasName) || string.IsNullOrWhiteSpace(AliasPw)
                || string.IsNullOrWhiteSpace(signFilePw) || string.IsNullOrWhiteSpace(signFile))
            {
                MessageBox.Show("签名为空~");
                return;
            }
            if (string.IsNullOrWhiteSpace(outputFile))
            {
                MessageBox.Show("输出文件位置为空~");
                return;
            }
            if (string.IsNullOrWhiteSpace(classPathDir) && string.IsNullOrWhiteSpace(jarPathDir))
            {
                MessageBox.Show("输入的class或者jar至少要包含一个");
                return;
            }

            Process proc = null;
            StreamReader sOut = null;
            try
            {
                ProcessStartInfo pro = new ProcessStartInfo("cmd.exe");
                pro.UseShellExecute = false;
                pro.RedirectStandardOutput = true;
                pro.RedirectStandardError = true;
                pro.CreateNoWindow = true;  
                pro.Arguments = batPath + " -c " + classPathDir
                                        + " -j " + jarPathDir
                                        + " -r " + resPathDir
                                        + " -m " + mapPath
                                        + " -o " + outputFile;
                proc = new Process();
                proc.Start();
                sOut = proc.StandardOutput;
                string results = sOut.ReadToEnd().Trim(); //回显内容  
                outputText.Text += results + Environment.NewLine;
            }
            catch (Exception ex)
            {
                outputText.Text += ex.Message + Environment.NewLine;
            } 
            finally
            {
                if (proc != null && !proc.HasExited)
                {
                    proc.Kill();
                    proc.Close();
                }
                if (sOut != null)
                {
                    sOut.Close();
                }
            }

        }

        private void stroeFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "请选择签名文件|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                signFile = dialog.FileName;
                storeFileText.Text = signFile;
                outputText.Text += "选择签名文件：" + signFile + Environment.NewLine;
            }
        }
    }
}
