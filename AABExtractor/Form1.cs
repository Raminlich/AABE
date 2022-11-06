using System.Diagnostics;
using System.Configuration;
namespace AABExtractor
{
    public partial class MainForm : Form
    {
        public string javaPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void browseInputButton_Click(object sender, EventArgs e)
        {
            GetFile(inputPathText);
        }

        private void browseOutputButton_Click(object sender, EventArgs e)
        {
            GetFolder(outputPathText);
        }

        private void GetFile(TextBox textBox)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult dialogResult = openFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                textBox.Text = openFile.FileName;
            }
        }

        private void GetFolder(TextBox textBox)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            DialogResult dialogResult = openFolder.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                textBox.Text = openFolder.SelectedPath;
            }
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            string tool = @"""./bundletool.jar""";
            string command = $@"java -jar {tool} build-apks --bundle={inputPathText.Text} --output={outputPathText.Text}/Test.apks --ks={keyStorePathText.Text} --ks-pass=file:{passwordFilePathText.Text} --ks-key-alias={aliasText.Text} --key-pass=file:{passwordFilePathText.Text}";
            command.Replace("\r\n", string.Empty);
            ExecuteCommand(command);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckForJava();
            LoadSavedPaths();
        }

        private void CheckForJava()
        {
            string cmd = $"/c java -version";
            var proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.Arguments = cmd;
            proc.Start();
            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
            if (proc.ExitCode != 0)
            {
                MessageBox.Show("JAVA_HOME not found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private async void ExecuteCommand(string command)
        {
            string cmd = $"/c {command}";
            HandleProgress(40);
            var proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.Arguments = cmd;
            proc.Start();
            await proc.WaitForExitAsync();
            if (proc.ExitCode != 0)
            {
                MessageBox.Show("There was a problem with extracting!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HandleProgress(0);
            }
            else
            {
                HandleProgress(100);
                MessageBox.Show("AAB extracted successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                proc.Kill();
            }
        }

        private async Task HandleProgress(int progress)
        {
            progressBar1.Maximum = 100;
            await Task.Delay(200);
            progressBar1.Value = progress;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetFile(keyStorePathText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetFile(passwordFilePathText);
        }

        private void LoadSavedPaths()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                aliasText.Text = appSettings.Get("alias");
                keyStorePathText.Text = appSettings.Get("keyStore");
                passwordFilePathText.Text = appSettings.Get("password");
                inputPathText.Text = appSettings.Get("input");
                outputPathText.Text = appSettings.Get("output");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,"ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Clear();
                config.AppSettings.Settings.Add("alias", aliasText.Text);
                config.AppSettings.Settings.Add("keyStore", keyStorePathText.Text);
                config.AppSettings.Settings.Add("password", passwordFilePathText.Text);
                config.AppSettings.Settings.Add("input", inputPathText.Text);
                config.AppSettings.Settings.Add("output", outputPathText.Text);
                config.Save();
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
                MessageBox.Show("All paths saved successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}