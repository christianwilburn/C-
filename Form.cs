using System;
using System.Windows.Forms;

namespace SimpleFormExample
{
    public class MainForm : Form
    {
        private Button submitButton;
        private TextBox nameTextBox;
        private Label resultLabel;

        public MainForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Form settings
            this.Text = "My First C# Form";
            this.Size = new System.Drawing.Size(300, 200);

            // Create and set up the name text box
            nameTextBox = new TextBox();
            nameTextBox.Location = new System.Drawing.Point(20, 20);
            nameTextBox.Size = new System.Drawing.Size(200, 20);

            // Create and set up the submit button
            submitButton = new Button();
            submitButton.Text = "Submit";
            submitButton.Location = new System.Drawing.Point(20, 50);
            submitButton.Click += new EventHandler(SubmitButton_Click);

            // Create and set up the result label
            resultLabel = new Label();
            resultLabel.Location = new System.Drawing.Point(20, 80);
            resultLabel.AutoSize = true;

            // Add controls to the form
            this.Controls.Add(nameTextBox);
            this.Controls.Add(submitButton);
            this.Controls.Add(resultLabel);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            resultLabel.Text = $"Hello, {name}!";
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}