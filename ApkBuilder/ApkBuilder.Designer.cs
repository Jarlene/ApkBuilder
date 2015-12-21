namespace ApkBuilder
{
    partial class BuildApk
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildApk));
            this.classDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classSelectBtn = new System.Windows.Forms.Button();
            this.JarSelectBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.JarDir = new System.Windows.Forms.TextBox();
            this.ResSelectBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResDir = new System.Windows.Forms.TextBox();
            this.MapSelectBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MapFile = new System.Windows.Forms.TextBox();
            this.OutputSelectBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.ApkBuild = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.ResTxtBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ResTxt = new System.Windows.Forms.TextBox();
            this.clearLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.storeFileText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.keyStorePwText = new System.Windows.Forms.TextBox();
            this.keyAliasNameText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.keyAliasPwText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.stroeFileBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classDir
            // 
            this.classDir.Location = new System.Drawing.Point(86, 17);
            this.classDir.Name = "classDir";
            this.classDir.ReadOnly = true;
            this.classDir.Size = new System.Drawing.Size(147, 21);
            this.classDir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class目录：";
            // 
            // classSelectBtn
            // 
            this.classSelectBtn.Location = new System.Drawing.Point(239, 14);
            this.classSelectBtn.Name = "classSelectBtn";
            this.classSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.classSelectBtn.TabIndex = 2;
            this.classSelectBtn.Text = "选择";
            this.classSelectBtn.UseVisualStyleBackColor = true;
            this.classSelectBtn.Click += new System.EventHandler(this.classSelectBtn_Click);
            // 
            // JarSelectBtn
            // 
            this.JarSelectBtn.Location = new System.Drawing.Point(239, 54);
            this.JarSelectBtn.Name = "JarSelectBtn";
            this.JarSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.JarSelectBtn.TabIndex = 5;
            this.JarSelectBtn.Text = "选择";
            this.JarSelectBtn.UseVisualStyleBackColor = true;
            this.JarSelectBtn.Click += new System.EventHandler(this.JarSelectBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jar目录：";
            // 
            // JarDir
            // 
            this.JarDir.Location = new System.Drawing.Point(86, 57);
            this.JarDir.Name = "JarDir";
            this.JarDir.ReadOnly = true;
            this.JarDir.Size = new System.Drawing.Size(147, 21);
            this.JarDir.TabIndex = 3;
            // 
            // ResSelectBtn
            // 
            this.ResSelectBtn.Location = new System.Drawing.Point(239, 93);
            this.ResSelectBtn.Name = "ResSelectBtn";
            this.ResSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.ResSelectBtn.TabIndex = 8;
            this.ResSelectBtn.Text = "选择";
            this.ResSelectBtn.UseVisualStyleBackColor = true;
            this.ResSelectBtn.Click += new System.EventHandler(this.ResSelectBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Res目录：";
            // 
            // ResDir
            // 
            this.ResDir.Location = new System.Drawing.Point(86, 96);
            this.ResDir.Name = "ResDir";
            this.ResDir.ReadOnly = true;
            this.ResDir.Size = new System.Drawing.Size(147, 21);
            this.ResDir.TabIndex = 6;
            // 
            // MapSelectBtn
            // 
            this.MapSelectBtn.Location = new System.Drawing.Point(239, 161);
            this.MapSelectBtn.Name = "MapSelectBtn";
            this.MapSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.MapSelectBtn.TabIndex = 11;
            this.MapSelectBtn.Text = "选择";
            this.MapSelectBtn.UseVisualStyleBackColor = true;
            this.MapSelectBtn.Click += new System.EventHandler(this.MapSelectBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "mapping文件：";
            // 
            // MapFile
            // 
            this.MapFile.Location = new System.Drawing.Point(86, 164);
            this.MapFile.Name = "MapFile";
            this.MapFile.ReadOnly = true;
            this.MapFile.Size = new System.Drawing.Size(147, 21);
            this.MapFile.TabIndex = 9;
            // 
            // OutputSelectBtn
            // 
            this.OutputSelectBtn.Location = new System.Drawing.Point(239, 202);
            this.OutputSelectBtn.Name = "OutputSelectBtn";
            this.OutputSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.OutputSelectBtn.TabIndex = 14;
            this.OutputSelectBtn.Text = "选择";
            this.OutputSelectBtn.UseVisualStyleBackColor = true;
            this.OutputSelectBtn.Click += new System.EventHandler(this.OutputSelectBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "输出文件：";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(86, 205);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(147, 21);
            this.output.TabIndex = 12;
            // 
            // ApkBuild
            // 
            this.ApkBuild.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ApkBuild.Location = new System.Drawing.Point(327, 165);
            this.ApkBuild.Name = "ApkBuild";
            this.ApkBuild.Size = new System.Drawing.Size(96, 56);
            this.ApkBuild.TabIndex = 15;
            this.ApkBuild.Text = "打包";
            this.ApkBuild.UseVisualStyleBackColor = true;
            this.ApkBuild.Click += new System.EventHandler(this.ApkBuild_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(7, 246);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(671, 169);
            this.outputText.TabIndex = 16;
            // 
            // ResTxtBtn
            // 
            this.ResTxtBtn.Location = new System.Drawing.Point(239, 127);
            this.ResTxtBtn.Name = "ResTxtBtn";
            this.ResTxtBtn.Size = new System.Drawing.Size(75, 23);
            this.ResTxtBtn.TabIndex = 20;
            this.ResTxtBtn.Text = "选择";
            this.ResTxtBtn.UseVisualStyleBackColor = true;
            this.ResTxtBtn.Click += new System.EventHandler(this.ResTxtBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "R.txt文件：";
            // 
            // ResTxt
            // 
            this.ResTxt.Location = new System.Drawing.Point(86, 130);
            this.ResTxt.Name = "ResTxt";
            this.ResTxt.ReadOnly = true;
            this.ResTxt.Size = new System.Drawing.Size(147, 21);
            this.ResTxt.TabIndex = 18;
            // 
            // clearLog
            // 
            this.clearLog.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearLog.Location = new System.Drawing.Point(464, 164);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(96, 56);
            this.clearLog.TabIndex = 17;
            this.clearLog.Text = "清除日志";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stroeFileBtn);
            this.groupBox1.Controls.Add(this.keyAliasPwText);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.keyAliasNameText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.keyStorePwText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.storeFileText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.clearLog);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ApkBuild);
            this.groupBox1.Controls.Add(this.outputText);
            this.groupBox1.Controls.Add(this.ResTxtBtn);
            this.groupBox1.Controls.Add(this.classDir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ResTxt);
            this.groupBox1.Controls.Add(this.classSelectBtn);
            this.groupBox1.Controls.Add(this.JarDir);
            this.groupBox1.Controls.Add(this.JarSelectBtn);
            this.groupBox1.Controls.Add(this.OutputSelectBtn);
            this.groupBox1.Controls.Add(this.ResDir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.output);
            this.groupBox1.Controls.Add(this.ResSelectBtn);
            this.groupBox1.Controls.Add(this.MapSelectBtn);
            this.groupBox1.Controls.Add(this.MapFile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 430);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打包配置";
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.Location = new System.Drawing.Point(582, 164);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(96, 56);
            this.resetBtn.TabIndex = 21;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "storeFile：";
            // 
            // storeFileText
            // 
            this.storeFileText.Location = new System.Drawing.Point(397, 18);
            this.storeFileText.Name = "storeFileText";
            this.storeFileText.ReadOnly = true;
            this.storeFileText.Size = new System.Drawing.Size(127, 21);
            this.storeFileText.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "passsWord：";
            // 
            // keyStorePwText
            // 
            this.keyStorePwText.Location = new System.Drawing.Point(397, 54);
            this.keyStorePwText.Name = "keyStorePwText";
            this.keyStorePwText.PasswordChar = '*';
            this.keyStorePwText.Size = new System.Drawing.Size(127, 21);
            this.keyStorePwText.TabIndex = 25;
            // 
            // keyAliasNameText
            // 
            this.keyAliasNameText.Location = new System.Drawing.Point(397, 95);
            this.keyAliasNameText.Name = "keyAliasNameText";
            this.keyAliasNameText.Size = new System.Drawing.Size(127, 21);
            this.keyAliasNameText.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "keyAlias：";
            // 
            // keyAliasPwText
            // 
            this.keyAliasPwText.Location = new System.Drawing.Point(397, 131);
            this.keyAliasPwText.Name = "keyAliasPwText";
            this.keyAliasPwText.PasswordChar = '*';
            this.keyAliasPwText.Size = new System.Drawing.Size(127, 21);
            this.keyAliasPwText.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "passsWord：";
            // 
            // stroeFileBtn
            // 
            this.stroeFileBtn.Location = new System.Drawing.Point(530, 18);
            this.stroeFileBtn.Name = "stroeFileBtn";
            this.stroeFileBtn.Size = new System.Drawing.Size(75, 23);
            this.stroeFileBtn.TabIndex = 30;
            this.stroeFileBtn.Text = "选择";
            this.stroeFileBtn.UseVisualStyleBackColor = true;
            this.stroeFileBtn.Click += new System.EventHandler(this.stroeFileBtn_Click);
            // 
            // BuildApk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 448);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuildApk";
            this.Text = "APK打包器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox classDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button classSelectBtn;
        private System.Windows.Forms.Button JarSelectBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox JarDir;
        private System.Windows.Forms.Button ResSelectBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResDir;
        private System.Windows.Forms.Button MapSelectBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MapFile;
        private System.Windows.Forms.Button OutputSelectBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button ApkBuild;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button ResTxtBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ResTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button stroeFileBtn;
        private System.Windows.Forms.TextBox keyAliasPwText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox keyAliasNameText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox keyStorePwText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox storeFileText;
        private System.Windows.Forms.Label label7;
    }
}

