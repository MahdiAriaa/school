using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandPassGenerator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string symbols = "@#$%&";
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + symbols;
            Random random = new Random();
            bool continueGenerating = true;

            while (continueGenerating)
            {
                int passwordLength = random.Next(8, 17);
                StringBuilder passwordBuilder = new StringBuilder();
                for (int i = 0; i < passwordLength; i++)
                {
                    int index=random.Next(validChars.Length);
                    passwordBuilder.Append(validChars[index]);

                }
                string password = passwordBuilder.ToString();
                DialogResult result;
                result = MessageBox.Show("generate : " + password, "پسورد پیشنهادی", MessageBoxButtons.RetryCancel,MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    break;
                }
            }

        }
    }
}
