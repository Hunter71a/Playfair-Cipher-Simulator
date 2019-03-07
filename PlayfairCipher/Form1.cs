using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayfairCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare class variables 
        private static string passPhrase;
        private string message;
        private string codedMessage;
        Regex keySpecifications = new Regex(@"^[a-zA-Z]+$");
        Regex textFieldSpecifications = new Regex(@"^[a-zA-Z ]+$");
       // ControlCollection textInputBoxes;
        


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {   
            // textInputBoxes.Add(tbxKey);
            //textInputBoxes.Add(tbxInput);
            //validate textbox input for "key word" and  message to translate
            //Help from Paul Deitel video on making LINQ query
            //Added in order to practice cool LINQ feature in C#                 
            var notValid =
                from Control inputStatus in Controls
                where inputStatus is TextBox
                let tbox = inputStatus as TextBox
                where String.IsNullOrEmpty(tbox.Text)
                orderby tbox.TabIndex
                select tbox;
                                 
            if (notValid.Any())
            {
                MessageBox.Show("Please fill in the missing fields", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                notValid.First().Select();
            }
            else
            {
                passPhrase = tbxKey.Text;
                message = tbxInput.Text;
                if (!Regex.IsMatch(passPhrase, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("The key phrase must consist of only letters with no spaces, numbers, or punctuation", "Incorrect Information",
                                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tbxKey.Focus();
                }

                else if (!Regex.IsMatch(message, @"^[a-zA-Z ]+$"))
                {
                    MessageBox.Show("The message must consist of only letters and spaces\nwith no numbers or punctuation", "Incorrect Information",
                                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tbxInput.Focus();
                }

                else
                {
                    passPhrase = tbxKey.Text.ToUpper();
                    CodeMatrix playFair = new CodeMatrix(passPhrase);
                  //  codedMessage = playFair.EncodeMessage(message);
                    tbxOutput.Text = playFair.EncodeMessage(message);
                    tbxMatrix.Text = playFair.ToString();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxKey.Text = "";
            tbxInput.Text = "";
            tbxOutput.Text = "Coded message will appear here";
            tbxMatrix.Text = "Code Matrix";
            

        }
    }
    }
