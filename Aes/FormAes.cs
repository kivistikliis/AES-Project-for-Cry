using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aes
{
    public partial class FormAes : Form
    {
        private int NrOfRounds;
        public FormAes()
        {
            InitializeComponent();
            NrOfRounds = 0;
            
        }

        private byte[] readHexString(string s)
        {
            int size = s.Length / 2;
            byte[] b = new byte[size];

            if ((size != 16) && (size != 24) && (size != 32))
            {
                //throw new Exception();
                MessageBox.Show("Invalid key. Make sure it has 16, 24 or 32 characters");
            }

            for (int i = 0; i < size; i++)
            {
                b[i] = Convert.ToByte(s.Substring(2 * i, 2), 16);
            }
            return (b);
        }

        private byte[] readAsciiString(string s)
        {
            byte[] b = new byte[s.Length];
            b = System.Text.ASCIIEncoding.ASCII.GetBytes(s);
            return (b);
        }

        
      
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] inputKey = readHexString(tbKey.Text);
            Key key = new Key(inputKey);

            string inputText = tbPlain.Text;
            int inputLength = inputText.Length;
            if (inputText.Length % 16 != 0)
            {
                for (int i = inputLength; i < (inputLength / 16 + 1) * 16; i++)
                {
                    inputText += " ";
                }
            }
            byte[] inputPlain = readAsciiString(inputText);

            State inputState = new State(inputPlain);
            State outputState = EncryptionProgress(inputState, key);
            tbCipher.Text = outputState.ToString();
            tbResult.Text = outputState.ToString();


            //We tried to create array of states, so that it is possible to encrypt a longer text than 16 characters.
            //The code is seen below in comments. Unfortunately we faced some error we did not have time to solve (state had a value of null), so here is the code we did sofar.
            //
            //int NrOfStates = inputPlain.Length / 16; //In the above code (the one currently working) we made sure that the length is always dividable by 16.
            //State[] states = new State[NrOfStates];
            //int ind = 0, start = 0;
            //while (ind <= NrOfStates)
            //{
            //    states[ind] = new State(readAsciiString(inputText.Substring(start, 16)));
            //    start += 16;
            //    ind++;
            //    Console.Out.WriteLine("state:\n" + states[ind].ToMatrixString());
            //}
            //
            //foreach(State s in states)
            //{
            //    State outputState = EncryptionProgress(s, key);
            //    tbCipher.Text = outputState.ToString();
            //    tbResult.Text = outputState.ToString();
            //}

        }

        public State EncryptionProgress(State inputtext,Key inputkey)
        {
            State temp;

            temp = inputtext.addRoundKey(inputkey, 0);

            for(int i=1;i<=NrOfRounds;i++)
            {
                temp = temp.subBytes();
                temp = temp.shiftRows();
                if(i!=NrOfRounds)
                    temp = temp.mixColumns();
                temp = temp.addRoundKey(inputkey, i);
            }

            return temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] inputKey = readHexString(tbKey.Text);
            Key key = new Key(inputKey);

            byte[] inputCypher = readHexString(tbCipher.Text);
            State cyphertext = new State(inputCypher);

            State original = DecryptionProgress(cyphertext, key);

            tbPlain.Text = original.HexToAscii();

            tbResult.Text = original.HexToAscii();
            

          //MessageBox.Show("The original text is:\n" +original.ToString());


        }
        
        public State DecryptionProgress(State inputtext, Key inputkey)
        {
            State temp;

            temp = inputtext.addRoundKey(inputkey, NrOfRounds);

            for (int i = NrOfRounds-1; i >=0; i--)
            {
                temp = temp.shiftRowsInv();
                temp = temp.subBytesInv();
                temp = temp.addRoundKey(inputkey, i);
                if (i != 0)
                    temp = temp.mixColumnsInv();
            }

            return temp;
        }

        private void rbKey128_CheckedChanged(object sender, EventArgs e)
        {
            tbKey.Text = "";
            tbKey.Text = "112233445566778899aabbccddeeff00";
            NrOfRounds = 10;
        }

        private void rbKey192_CheckedChanged(object sender, EventArgs e)
        {
            tbKey.Text = "";
            tbKey.Text = "1122334455667788112233445566778899aabbccddeeff00";
            NrOfRounds = 12;
        }

        private void rbKey256_CheckedChanged(object sender, EventArgs e)
        {
            tbKey.Text = "";
            tbKey.Text = "112233445566778899aabbccddeeff00112233445566778899aabbccddeeff00";
            NrOfRounds = 14;
        }
    }
}
