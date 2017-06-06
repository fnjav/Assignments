//Filip Andersson Vestman 07/01-2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class MainForm : Form
    {
        private TaskManager _taskManager = new TaskManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initializes GUI
        /// </summary>
        private void InitializeGUI()
        {
            lblDescription.Text = $"{"Date",-40}{"Hour",-15}{"Priority",-15}{"Description",17}";
            cmbPriority.DataSource = Enum.GetNames(typeof(Priorities)).Select(p => p.Replace('_', ' ')).ToList();
            dtpToDo.MinDate = DateTime.Now;
            dtpToDo.MaxDate = DateTime.Now.AddYears(1);
            dtpToDo.Format = DateTimePickerFormat.Custom;
            dtpToDo.CustomFormat = "yyyy-MM-dd    HH:mm";
            AcceptButton = btnAdd;
            tipDateTimePicker.SetToolTip(dtpToDo, "Click to open calendar for date, write time here.");
        }

        /// <summary>
        /// Updates GUI
        /// </summary>
        private void UpdateGUI()
        {
            txtToDo.Text = string.Empty;
            lstToDo.DataSource = _taskManager.ToList();
            lstToDo.SelectedIndex = -1;
        }

        /// <summary>
        /// Toggles change and delete button
        /// </summary>
        /// <param name="enable">Whether or not to enable buttons</param>
        private void ToggleButtons(bool enable)
        {
            btnChange.Enabled = enable;
            btnDelete.Enabled = enable;
        }

        /// <summary>
        /// Creates a new task and returns it
        /// </summary>
        /// <returns>Task from input</returns>
        private Task TaskFromGUI()
        {
            return new Task(dtpToDo.Value.ToString("Den dd MMMM yyyy"), dtpToDo.Value.ToString("HH:mm"), (Priorities)cmbPriority.SelectedIndex, txtToDo.Text);
        }

        /// <summary>
        /// Resets the application
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _taskManager.Clear();
            UpdateGUI();
        }

        /// <summary>
        /// Adds a new entry if the description isn't empty
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtToDo.Text))
                _taskManager.Add(TaskFromGUI());
            UpdateGUI();
        }

        /// <summary>
        /// Updates the timer
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Closes the form to trigger FormClosing event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void tsmiFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Asks if the user wants to exit
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var answer = MessageBox.Show("Would you like to exit?", "Stopp och belägg", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (answer == DialogResult.Cancel)
                e.Cancel = true;
        }

        /// <summary>
        /// Shows the aboutbox
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void tsmiHelpOm_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.Show();
        }

        /// <summary>
        /// Enables or disables buttons
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void lstToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleButtons(lstToDo.SelectedIndex >= 0);
        }

        /// <summary>
        /// Deletes entry
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you want to delete the entry?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (answer == DialogResult.Yes)
                _taskManager.RemoveAt(lstToDo.SelectedIndex);

            UpdateGUI();
        }

        /// <summary>
        /// Changes entry
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtToDo.Text))
                _taskManager.ReplaceAt(TaskFromGUI(), lstToDo.SelectedIndex);
            UpdateGUI();
        }


    }
}
