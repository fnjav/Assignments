using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allt
{
    public partial class startMenu : Form
    {
        public startMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.Show();
        }

        private void OddOrEven_Click(object sender, EventArgs e)
        {
            OddOrEven oddOrEven = new OddOrEven();
            oddOrEven.Show();
        }

        private void InvoiceTest_Click(object sender, EventArgs e)
        {
            InvoiceTest invoiceTest = new InvoiceTest();
            invoiceTest.Show();
        }

        private void CreditLimit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\..\..\..\CreditLimitCalculator\bin\Debug\CreditLimitCalculator.exe");
        }

        private void RoundNumbers_Click(object sender, EventArgs e)
        {
            RoundNumbers roundNumbersForm = new RoundNumbers();
            roundNumbersForm.Show();
        }

        private void RecursionForm_Click(object sender, EventArgs e)
        {
            RecursionForm recForm = new RecursionForm();
            recForm.Show();
        }

        private void DiceRolling_Click(object sender, EventArgs e)
        {
            DiceRolling diceForm = new DiceRolling();
            diceForm.Show();
        }

        private void TotalSales_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\..\..\..\TotalSales\bin\Debug\TotalSales.exe");
        }

        private void DuplicateWordRemoval_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\..\..\..\DuplicateWordRemoval\bin\Debug\DuplicateWordRemoval.exe");
        }

        private void RectangleClass_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\..\..\..\RectangleTest\bin\Debug\RectangleTest.exe");
        }

        private void ExceptionThrower_Click(object sender, EventArgs e)
        {
            ExceptionThrower et = new ExceptionThrower();
            et.Show();
        }

        private void CheckBoxTestForm_Click(object sender, EventArgs e)
        {
            CheckBoxTestForm cb = new CheckBoxTestForm();
            cb.Show();
        }

        private void PrinterGUI_Click(object sender, EventArgs e)
        {
            PrinterGUI pGUI = new PrinterGUI();
            pGUI.Show();
        }

        private void TemperatureConversion_Click(object sender, EventArgs e)
        {
            TemperatureConversion tc = new TemperatureConversion();
            tc.Show();
        }

        private void GuessingGame_Click(object sender, EventArgs e)
        {
            GuessingGame gg = new GuessingGame();
            gg.Show();
        }

        private void States_Click(object sender, EventArgs e)
        {
            StatesForm sf = new StatesForm();
            sf.Show();
        }

        private void LoginPassword_Click(object sender, EventArgs e)
        {
            UserControlTestForm uc = new UserControlTestForm();
            uc.Show();
        }

        private void CompareWords_Click(object sender, EventArgs e)
        {
            CompareWords cw = new CompareWords();
            cw.Show();
        }

        private void PigLatin_Click(object sender, EventArgs e)
        {
            PigLatin pl = new PigLatin();
            pl.Show();
        }

        private void StudentGrades_Click(object sender, EventArgs e)
        {
            StudentGrades sg = new StudentGrades();
            sg.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\..\..\..\BaseballDatabaseApplication\bin\Debug\BaseballDatabaseApplication.exe");
        }
    }
}
