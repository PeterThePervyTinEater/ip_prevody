using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ip_prevody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool kontrolaHex(string hex)
        {
            string[] arr = hex.Split(':');            
            foreach(string s in arr)
            {
                foreach(char c in s)
                {
                    if (!(c >= '0' && c <= '9' || c >= 'A' && c <= 'F' || c >= 'a' && c <= 'f')) return false;
                }
            }
            return true;
        }

        bool kontrolaBin(string bin)
        {
            string[] arr = bin.Split('.');            
            foreach (string s in arr)
            {
                foreach (char c in s)
                {
                    if (!(c >= '0' && c <= '1')) return false;
                }
            }
            return true;
        }

        bool kontrolaDec(string dec)
        {
            string[] arr = dec.Split('.');
            foreach (string s in arr)
            {
                foreach (char c in s)
                {
                    if (!(c >= '0' && c <= '9')) return false;
                }
            }
            return true;
        }

        string binToDec(string bin)
        {
            string[] arr = bin.Split('.');
            string res = "";
            for (int i = 0; i < arr.Count(); i++)
            {
                if (i != arr.Count() - 1) res += Convert.ToInt32(arr[i], 2).ToString() + ".";
                else res += Convert.ToInt32(arr[i], 2).ToString();
            }
            return res;
        }

        string hexToDec(string hex)
        {
            string[] arr = hex.Split(':');
            string res = "";
            for (int i = 0; i < arr.Count(); i++)
            {
                if (i != arr.Count() - 1) res += Convert.ToInt32(arr[i], 16).ToString() + ".";
                else res += Convert.ToInt32(arr[i], 16).ToString();
            }
            return res;
        }

        string  binToHex(string bin)
        {
            string[] arr = bin.Split('.');
            string res = "";
            for (int i = 0; i < arr.Count(); i++)
            {
                string pom = Convert.ToInt32(arr[i],2).ToString("X");
                if (pom.Length < 2) pom = "0" + pom;
                if (i != arr.Count() - 1) res += pom + ":";
                else res += pom;
            }
            return res;
        }

        string decToHex(string dec)
        {
            string[] arr = dec.Split('.');
            string res = "";
            for (int i = 0; i < arr.Count(); i++)
            {
                string pom = Convert.ToInt32(arr[i]).ToString("X");
                if (pom.Length < 2) pom = "0" + pom;
                if (i != arr.Count() - 1) res += pom + ":";
                else res += pom;
            }
            return res;
        }

        string decToBin(string dec)
        {
            string[] arr = dec.Split('.');
            string res = "";
            for (int i = 0; i < arr.Count(); i++)
            {
                string pom = Convert.ToString(Convert.ToInt32(arr[i]), 2);
                while (pom.Length < 8) pom = "0" + pom;
                if (i != arr.Count() - 1) res += pom + ".";
                else res += pom;
            }
            return res;
        }

        string hexToBin(string hex)
        {
            string[] arr = hex.Split(':');
            string res = "";
            for (int i = 0; i < arr.Count(); i++)
            {
                string pom = Convert.ToString(Convert.ToInt64(arr[i], 16), 2);
                while (pom.Length<8) pom = "0" + pom;
                if (i != arr.Count() - 1) res += pom + ".";
                else res += pom;
            }
            return res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = maskedTextBox1.Text;

            //Converting from dec

            if(inDec.Checked)
            {
                if (kontrolaDec(value))
                { 
                    if(outDec.Checked)
                    {
                        labVysNadpis.Text = "Výsledek v decimální: ";
                        labVys.Text = value;
                    }
                    else if(outBin.Checked)
                    {
                        labVysNadpis.Text = "Výsledek v binární: ";
                        labVys.Text = decToBin(value);
                    }
                    else if(outHex.Checked)
                    {
                        labVysNadpis.Text = "Výsledek v hexadecimální: ";
                        labVys.Text = decToHex(value);
                    }
                }
                else MessageBox.Show("Znaky v decimální soustavì musí být v rozsahu <0,9>", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Alerting user for wrong formating
            }

            //Converting from bin

            else if(inBin.Checked)
            {
                if(kontrolaBin(value))  //checking if the bin value is valid
                { 
                    if (outBin.Checked)
                    {
                        labVysNadpis.Text = "Výsledek v binární: ";
                        labVys.Text = value;
                    }
                    else if (outDec.Checked)
                    {
                        labVysNadpis.Text = "Výsledek v decimální: ";
                        labVys.Text = binToDec(value);
                    }
                    else if (outHex.Checked)
                    {
                        labVysNadpis.Text = "Výsledek v hexadecimální: ";
                        labVys.Text = binToHex(value);
                    }
                }
                else MessageBox.Show("Znaky v binární soustavì musí být v rozsahu <0,1>", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Alerting user for wrong formating
            }

            //Converting from hex

            else if (inHex.Checked)
            {
                if (kontrolaHex(value))  //checking if the hex value is valid
                {
                    if (outHex.Checked)
                    {
                        labVysNadpis.Text = "Výsledek v hexadecimální: ";
                        labVys.Text = value;
                    }
                    else if (outDec.Checked)
                    {
                        labVysNadpis.Text = "Výsledek v decimální: ";
                        labVys.Text = hexToDec(value);
                    }
                    else if (outBin.Checked)
                    {
                        labVysNadpis.Text = "Výsledek v binární: ";
                        labVys.Text = hexToBin(value);
                    }
                }
                else MessageBox.Show("Znaky v hexadecimální soustavì musí být v rozsahu <0,9> a <A,F>", "Varování",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); //Alerting user for wrong formating
            }

        }

        private void inBin_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "00000000.00000000.00000000.00000000";
        }

        private void inHex_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "aa:aa:aa:aa";
        }

        private void inDec_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "000.000.000.000";
        }
    }
}