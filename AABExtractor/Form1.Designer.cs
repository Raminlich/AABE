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
            this.outputPathText = new System.Windows.Forms.TextBox();
            this.outputLable = new System.Windows.Forms.Label();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.browseInputButton = new System.Windows.Forms.Button();
            this.inputLable = new System.Windows.Forms.Label();
            this.inputPathText = new System.Windows.Forms.TextBox();
            this.passwordFileBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordFilePathText = new System.Windows.Forms.TextBox();
            this.keyStoreBrowseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.keyStorePathText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aliasText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // outputPathText
            // 
            this.outputPathText.Location = new System.Drawing.Point(12, 215);
            this.outputPathText.Name = "outputPathText";
            this.outputPathText.Size = new System.Drawing.Size(482, 23);
            this.outputPathText.TabIndex = 0;
            // 
            // outputLable
            // 
            this.outputLable.AutoSize = true;
            this.outputLable.Location = new System.Drawing.Point(12, 197);
            this.outputLable.Name = "outputLable";
            this.outputLable.Size = new System.Drawing.Size(78, 15);
            this.outputLable.TabIndex = 1;
            this.outputLable.Text = "Output path :";
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Location = new System.Drawing.Point(500, 215);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(45, 23);
            this.browseOutputButton.TabIndex = 2;
            this.browseOutputButton.Text = "...";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.browseOutputButton_Click);
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(12, 250);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(533, 35);
            this.extractButton.TabIndex = 3;
            this.extractButton.Text = "Extract APK";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // browseInputButton
            // 
            this.browseInputButton.Location = new System.Drawing.Point(500, 171);
            this.browseInputButton.Name = "browseInputButton";
            this.browseInputButton.Size = new System.Drawing.Size(45, 23);
            this.browseInputButton.TabIndex = 6;
            this.browseInputButton.Text = "...";
            this.browseInputButton.UseVisualStyleBackColor = true;
            this.browseInputButton.Click += new System.EventHandler(this.browseInputButton_Click);
            // 
            // inputLable
            // 
            this.inputLable.AutoSize = true;
            this.inputLable.Location = new System.Drawing.Point(12, 153);
            this.inputLable.Name = "inputLable";
            this.inputLable.Size = new System.Drawing.Size(68, 15);
            this.inputLable.TabIndex = 5;
            this.inputLable.Text = "Input path :";
            // 
            // inputPathText
            // 
            this.inputPathText.Location = new System.Drawing.Point(12, 171);
            this.inputPathText.Name = "inputPathText";
            this.inputPathText.Size = new System.Drawing.Size(482, 23);
            this.inputPathText.TabIndex = 4;
            // 
            // passwordFileBrowseButton
            // 
            this.passwordFileBrowseButton.Location = new System.Drawing.Point(500, 127);
            this.passwordFileBrowseButton.Name = "passwordFileBrowseButton";
            this.passwordFileBrowseButton.Size = new System.Drawing.Size(45, 23);
            this.passwordFileBrowseButton.TabIndex = 9;
            this.passwordFileBrowseButton.Text = "...";
            this.passwordFileBrowseButton.UseVisualStyleBackColor = true;
            this.passwordFileBrowseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password file :";
            // 
            // passwordFilePathText
            // 
            this.passwordFilePathText.Location = new System.Drawing.Point(12, 127);
            this.passwordFilePathText.Name = "passwordFilePathText";
            this.passwordFilePathText.Size = new System.Drawing.Size(482, 23);
            this.passwordFilePathText.TabIndex = 7;
            // 
            // keyStoreBrowseButton
            // 
            this.keyStoreBrowseButton.Location = new System.Drawing.Point(500, 83);
            this.keyStoreBrowseButton.Name = "keyStoreBrowseButton";
            this.keyStoreBrowseButton.Size = new System.Drawing.Size(45, 23);
            this.keyStoreBrowseButton.TabIndex = 12;
            this.keyStoreBrowseButton.Text = "...";
            this.keyStoreBrowseButton.UseVisualStyleBackColor = true;
            this.keyStoreBrowseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Key store :";
            // 
            // keyStorePathText
            // 
            this.keyStorePathText.Location = new System.Drawing.Point(12, 83);
            this.keyStorePathText.Name = "keyStorePathText";
            this.keyStorePathText.Size = new System.Drawing.Size(482, 23);
            this.keyStorePathText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Alias :";
            // 
            // aliasText
            // 
            this.aliasText.Location = new System.Drawing.Point(12, 39);
            this.aliasText.Name = "aliasText";
            this.aliasText.Size = new System.Drawing.Size(482, 23);
            this.aliasText.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aliasText);
            this.Controls.Add(this.keyStoreBrowseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyStorePathText);
            this.Controls.Add(this.passwordFileBrowseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordFilePathText);
            this.Controls.Add(this.browseInputButton);
            this.Controls.Add(this.inputLable);
            this.Controls.Add(this.inputPathText);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.browseOutputButton);
            this.Controls.Add(this.outputLable);
            this.Controls.Add(this.outputPathText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "MainForm";
            this.Text = "AABE";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}