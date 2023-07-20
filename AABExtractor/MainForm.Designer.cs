namespace AABExtractor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            outputPathText = new TextBox();
            outputLable = new Label();
            browseOutputButton = new Button();
            extractButton = new Button();
            browseInputButton = new Button();
            inputLable = new Label();
            inputPathText = new TextBox();
            passwordFileBrowseButton = new Button();
            label1 = new Label();
            passwordFilePathText = new TextBox();
            keyStoreBrowseButton = new Button();
            label2 = new Label();
            keyStorePathText = new TextBox();
            label3 = new Label();
            aliasText = new TextBox();
            progressBar1 = new ProgressBar();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // outputPathText
            // 
            outputPathText.Location = new Point(12, 231);
            outputPathText.Name = "outputPathText";
            outputPathText.Size = new Size(482, 23);
            outputPathText.TabIndex = 0;
            // 
            // outputLable
            // 
            outputLable.AutoSize = true;
            outputLable.Location = new Point(12, 213);
            outputLable.Name = "outputLable";
            outputLable.Size = new Size(78, 15);
            outputLable.TabIndex = 1;
            outputLable.Text = "Output path :";
            // 
            // browseOutputButton
            // 
            browseOutputButton.Location = new Point(500, 231);
            browseOutputButton.Name = "browseOutputButton";
            browseOutputButton.Size = new Size(45, 23);
            browseOutputButton.TabIndex = 2;
            browseOutputButton.Text = "...";
            browseOutputButton.UseVisualStyleBackColor = true;
            browseOutputButton.Click += browseOutputButton_Click;
            // 
            // extractButton
            // 
            extractButton.Location = new Point(12, 266);
            extractButton.Name = "extractButton";
            extractButton.Size = new Size(533, 35);
            extractButton.TabIndex = 3;
            extractButton.Text = "Extract APK";
            extractButton.UseVisualStyleBackColor = true;
            extractButton.Click += extractButton_Click;
            // 
            // browseInputButton
            // 
            browseInputButton.Location = new Point(500, 187);
            browseInputButton.Name = "browseInputButton";
            browseInputButton.Size = new Size(45, 23);
            browseInputButton.TabIndex = 6;
            browseInputButton.Text = "...";
            browseInputButton.UseVisualStyleBackColor = true;
            browseInputButton.Click += browseInputButton_Click;
            // 
            // inputLable
            // 
            inputLable.AutoSize = true;
            inputLable.Location = new Point(12, 169);
            inputLable.Name = "inputLable";
            inputLable.Size = new Size(68, 15);
            inputLable.TabIndex = 5;
            inputLable.Text = "Input path :";
            // 
            // inputPathText
            // 
            inputPathText.Location = new Point(12, 187);
            inputPathText.Name = "inputPathText";
            inputPathText.Size = new Size(482, 23);
            inputPathText.TabIndex = 4;
            // 
            // passwordFileBrowseButton
            // 
            passwordFileBrowseButton.Location = new Point(500, 143);
            passwordFileBrowseButton.Name = "passwordFileBrowseButton";
            passwordFileBrowseButton.Size = new Size(45, 23);
            passwordFileBrowseButton.TabIndex = 9;
            passwordFileBrowseButton.Text = "...";
            passwordFileBrowseButton.UseVisualStyleBackColor = true;
            passwordFileBrowseButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 125);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 8;
            label1.Text = "Password file :";
            // 
            // passwordFilePathText
            // 
            passwordFilePathText.Location = new Point(12, 143);
            passwordFilePathText.Name = "passwordFilePathText";
            passwordFilePathText.Size = new Size(482, 23);
            passwordFilePathText.TabIndex = 7;
            // 
            // keyStoreBrowseButton
            // 
            keyStoreBrowseButton.Location = new Point(500, 99);
            keyStoreBrowseButton.Name = "keyStoreBrowseButton";
            keyStoreBrowseButton.Size = new Size(45, 23);
            keyStoreBrowseButton.TabIndex = 12;
            keyStoreBrowseButton.Text = "...";
            keyStoreBrowseButton.UseVisualStyleBackColor = true;
            keyStoreBrowseButton.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 11;
            label2.Text = "Key store :";
            // 
            // keyStorePathText
            // 
            keyStorePathText.Location = new Point(12, 99);
            keyStorePathText.Name = "keyStorePathText";
            keyStorePathText.Size = new Size(482, 23);
            keyStorePathText.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 37);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 14;
            label3.Text = "Alias :";
            // 
            // aliasText
            // 
            aliasText.Location = new Point(12, 55);
            aliasText.Name = "aliasText";
            aliasText.Size = new Size(482, 23);
            aliasText.TabIndex = 13;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 307);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(533, 23);
            progressBar1.TabIndex = 15;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, saveToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(557, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(180, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 336);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(aliasText);
            Controls.Add(keyStoreBrowseButton);
            Controls.Add(label2);
            Controls.Add(keyStorePathText);
            Controls.Add(passwordFileBrowseButton);
            Controls.Add(label1);
            Controls.Add(passwordFilePathText);
            Controls.Add(browseInputButton);
            Controls.Add(inputLable);
            Controls.Add(inputPathText);
            Controls.Add(extractButton);
            Controls.Add(browseOutputButton);
            Controls.Add(outputLable);
            Controls.Add(outputPathText);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AABE";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox outputPathText;
        private Label outputLable;
        private Button browseOutputButton;
        private Button extractButton;
        private Button browseInputButton;
        private Label inputLable;
        private TextBox inputPathText;
        private Button passwordFileBrowseButton;
        private Label label1;
        private TextBox passwordFilePathText;
        private Button keyStoreBrowseButton;
        private Label label2;
        private TextBox keyStorePathText;
        private Label label3;
        private TextBox aliasText;
        private ProgressBar progressBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}