using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace covid19Project
{
    [DesignerCategory("Form")]
    public partial class covidpatientNames : Form
    {
        public covidpatientNames()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            newToolStripButton.Click += NewToolStripButton_Click;
            saveToolStripButton.Click += SaveToolStripButton_Click;
            helpToolStripButton.Click += HelpToolStripButton_Click;
        }

        private void NewToolStripButton_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void SaveToolStripButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Logic to save data would go here
            MessageBox.Show($"Patient '{textBox1.Text}' saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void HelpToolStripButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Covid Patient Management System\nFill in the details and click Save.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            isActive.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Set focus to name textbox
            textBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic for when gender selection changes
        }
    }
}
