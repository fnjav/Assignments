// Filip Andersson Vestman 	L0002B
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }       

        private void label1_Click(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {  
            Person p = new Person(textBox1.Text, textBox2.Text, textBox3.Text); // Skapar ny person

            if (!p.pnrCheck()) {
                richTextBox1.Clear();   // Tömmer textrutan
                richTextBox1.AppendText("Fel personnummer, försök igen!");
            } else {
                richTextBox1.Clear();                   // richTextBox för att kunna formatera texten på ett fint sätt
                richTextBox1.AppendText(String.Format("Förnamn: {0}\nEfternamn: {1}\nPersonnr: {2}\nKön: {3}\n", p.FName, p.SName, p.Pnr, p.genderCheck()));
            }

            
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            
        }

        private void textBox3_Click(object sender, EventArgs e) {
            //textBox3.Clear();      // Tömmer textrutan, stod format för pnr innan jag generaliserade
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();     // Avslutar program
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void createNewPerson(String fName, String sName, String pnr) {
            Person tmpPerson = new Person(fName, sName, pnr);
            
        }

        
    }
    
}
