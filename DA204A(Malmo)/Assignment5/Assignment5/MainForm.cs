using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Filip Andersson Vestman  21/12-17
namespace Assignment5
{
    public partial class MainForm : Form
    {
        private CustomerManager _customerManager = new CustomerManager();

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initializes the description label
        /// </summary>
        private void InitializeGUI()
        {
            lblDescription.Text = String.Format("{0, -10}{1, -40}{2, -70}{3, -70}{4, -20}", "ID", "Name (Surname, first name)", "Street, zip code, city, country", "Office and home phones", "E-mail");
        }

        /// <summary>
        /// Add new customer
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var contactForm = new ContactForm();

            var answer = contactForm.ShowDialog();
            if (answer == DialogResult.OK)
                _customerManager.Add(new Customer(contactForm.Contact));

            UpdateGUI();
        }

        /// <summary>
        /// Updates the list box
        /// </summary>
        private void UpdateGUI()
        {
            lstCustomerRegistry.DataSource = _customerManager.ToList();
            lstCustomerRegistry.SelectedIndex = -1;
        }

        /// <summary>
        /// Delete contact
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = lstCustomerRegistry.SelectedIndex;

            if (_customerManager.CheckIndex(index))
            {
                _customerManager.RemoveAt(index);
                UpdateGUI();
            }


        }

        /// <summary>
        /// Edit contact
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            var index = lstCustomerRegistry.SelectedIndex;

            if (_customerManager.CheckIndex(index))
            {
                var contactForm = new ContactForm(_customerManager.GetAt(index).Contact);

                var answer = contactForm.ShowDialog();
                if (answer == DialogResult.OK)
                    _customerManager.ReplaceAt(index, contactForm.Contact);
                UpdateGUI();
            }


        }

        /// <summary>
        /// Confirms if user wants to close the application
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var answer = MessageBox.Show("Do you wish to close the application?", "Warning", MessageBoxButtons.YesNo);

            e.Cancel = (answer == DialogResult.No);
        }
    }
}
