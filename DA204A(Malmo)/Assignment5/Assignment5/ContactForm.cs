using Assignment5.ContactFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Filip Andersson Vestman  11/12-17
namespace Assignment5
{
    public partial class ContactForm : Form
    {
        public Contact Contact { get; set; }

        /// <summary>
        /// Constructor, initializes stuff
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            InitializeGUI();            
        }

        /// <summary>
        /// Constructor for editing contacts
        /// </summary>
        /// <param name="contact"></param>
        public ContactForm(Contact contact)
            : this()
        {
            Contact = contact;
            ContactToGUI();
        }

        /// <summary>
        /// Initializes GUI
        /// </summary>
        private void InitializeGUI()
        {
            AcceptButton = btnOK;

            cmbCountry.DataSource = Enum.GetNames(typeof(Countries)).Select(c => c.Replace('_', ' ')).ToList();
            cmbCountry.SelectedIndex = 0;
        }

        /// <summary>
        /// Updates GUI with currenct contact data, ugly but works
        /// </summary>
        private void ContactToGUI()
        {
            txtFirstName.Text = Contact.FirstName;
            txtLastName.Text = Contact.LastName;
            txtHomePhone.Text = Contact.Phone.Personal;
            txtCellPhone.Text = Contact.Phone.Work;
            txtEmailBusiness.Text = Contact.Email.Work;
            txtEmailPrivate.Text = Contact.Email.Personal;
            txtStreet.Text = Contact.Address.Street;
            txtCity.Text = Contact.Address.City;
            txtZipCode.Text = Contact.Address.Zip;
            cmbCountry.SelectedIndex = (int)Contact.Address.Country;


        }

        /// <summary>
        /// Creates a new contact and displays info if input is valid
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Contact = CreateContact();
                MessageBox.Show(Contact.ToString(), "Info", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Creates and returns a new contact from the GUI
        /// </summary>
        /// <returns>New Contact</returns>
        private Contact CreateContact()
        {
            var phone = new Phone() { Personal = txtHomePhone.Text, Work = txtCellPhone.Text };
            var email = new Email() { Personal = txtEmailPrivate.Text, Work = txtEmailBusiness.Text };
            var address = new Address(txtStreet.Text, txtCity.Text, txtZipCode.Text, (Countries)cmbCountry.SelectedIndex);

            return new Contact(address, phone, email) { FirstName = txtFirstName.Text, LastName = txtLastName.Text };
        }

        /// <summary>
        /// Checks for valid input, has to be either (first name or last name) and city. Country is always selected.
        /// </summary>
        /// <returns>True if valid input, false otherwise</returns>
        private bool CheckData()
        {
            if (Contact.CheckName(txtFirstName.Text, txtLastName.Text) && Address.CheckCity(txtCity.Text))
                return true;

            MessageBox.Show("Please provide Name and City", "Error", MessageBoxButtons.OK);
            return false;
        }

        /// <summary>
        /// Closes the form is answer is OK from the MessageBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you wish to close the form?", "Oy", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
                Close();
        }
    }
}
