using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers_to_words
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertbutton_Click(object sender, EventArgs e)
        {
            //Input number.
            ulong num = Convert.ToUInt64(number.Text);
            string trillion = "", billion = "", million = "", thousand = "", hundred = "", tens = ""; //numbers type
            if (num == 0)
            {
                wordsBox.Text = "զրո";

            }
            else
            {
                if (num >= 1000000000000)
                {
                    int cutNumber = Convert.ToInt32(num / 1000000000000);
                    trillion = GetDigit(cutNumber.ToString(), "տրիլիոն") + " ";
                    num = num % 1000000000000;
                }
                if (num >= 1000000000)
                {
                    int cutNumber = Convert.ToInt32(num / 1000000000);
                    billion = GetDigit(cutNumber.ToString(), "միլիարդ") + " ";
                    num = num % 1000000000;
                }
                if (num >= 1000000)
                {
                    int cutNumber = Convert.ToInt32(num / 1000000);
                    million = GetDigit(cutNumber.ToString(), "միլիոն") + " ";
                    num = num % 1000000;
                }
                if (num >= 1000)
                {
                    int cutNumber = Convert.ToInt32(num / 1000);
                    thousand = GetDigit(cutNumber.ToString(), "հազար") + " ";
                    num = num % 1000;
                }
                if (num >= 100)
                {
                    int cutNumber = Convert.ToInt32(num / 100);
                    hundred = GetDigit(cutNumber.ToString(), "հարյուր") + " ";
                    num = num % 100;
                }
                if (num >= 10)
                {
                    tens = GetDigit(num.ToString(), "");
                    
                }
                else
                {
                    tens = word(num.ToString());
                }
                wordsBox.Text = trillion + billion + million + thousand + hundred + tens;  //Get number to word
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void number_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void wordsBox_TextChanged(object sender, EventArgs e)
        {

        }
        static string GetDigit(string number, string type)
        {
            string numword;
            if (number.Length == 3)
            {
                string a;
                string b;
                string c = word(number[2].ToString());
                if (number[0] == '1')
                {
                    a = "հարյուր";
                }
                else
                {
                    a = word(number[0].ToString()) + " հարյուր";
                }
                if (number[1] == '1' && number[2] != '0')
                {
                    b = "տասն";
                }
                else
                {
                    b = word(number[1].ToString() + "0");
                }
                numword = a + " " + b + c + " " + type;
            }
            else if (number.Length == 2)
            {
                string a;
                string b = word(number[1].ToString());
                if (number[0] == '1' && number[1] != '0')
                {
                    a = "տասն";
                }
                else
                {
                    a = word(number[0].ToString() + "0");
                }
                numword = a + b + " " + type;
            }
            else
            {
                String a;
                if (number[0] == '1' && (type == "հարյուր" || type == "հազար"))
                {
                    a = type;
                }
                else
                {
                    a = word(number[0].ToString()) + " " + type;
                }
                numword = a + " ";
            }
            return numword;
        }

        //Numbers convert to string.
        static String word(string digi)
        {
            switch (digi)
            {
                case "1": { return "մեկ"; } break;
                case "2": { return "երկու"; } break;
                case "3": { return "երեք"; } break;
                case "4": { return "չորս"; } break;
                case "5": { return "հինգ"; } break;
                case "6": { return "վեց"; } break;
                case "7": { return "յոթ"; } break;
                case "8": { return "ութ"; } break;
                case "9": { return "ինը"; } break;
                case "10": { return "տաս"; } break;
                case "20": { return "քսան"; } break;
                case "30": { return "երեսուն"; } break;
                case "40": { return "քառասուն"; } break;
                case "50": { return "հիսուն"; } break;
                case "60": { return "վաթսուն"; } break;
                case "70": { return "յոթանասուն"; } break;
                case "80": { return "ութսուն"; } break;
                case "90": { return "իննսուն"; } break;
                default:
                    {
                        return "";
                    }
                    break;
            }
        }
    }
}
