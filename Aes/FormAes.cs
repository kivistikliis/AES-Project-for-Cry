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
        public FormAes()
        {
            InitializeComponent();
        }

        private byte[] readHexString(string s)
        {
            int size = s.Length / 2;
            byte[] b = new byte[size];

            if ((size != 16) && (size != 24) && (size != 32))
            {
                throw new Exception();
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            byte[] inputKey = readHexString(tbKey.Text);
            Key key = new Key(inputKey);
            Console.Out.WriteLine("\nkey:\n" + key);

            byte[] inputPlain = readAsciiString(tbPlain.Text);
            State inputState = new State(inputPlain);
            Console.Out.WriteLine("state:\n" + inputState.ToMatrixString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] inputKey = readHexString(tbKey.Text);
            Key key = new Key(inputKey);

            byte[] inputPlain = readAsciiString(tbPlain.Text);
            State inputState = new State(inputPlain);

            State outputState=EncryptionProgress(inputState,key);

            MessageBox.Show("The cyphertext is:\n"+outputState.ToMatrixString());
        }

        public State EncryptionProgress(State inputtext,Key inputkey)
        {
            State temp;

            temp = inputtext.addRoundKey(inputkey, 0);

            for(int i=1;i<=10;i++)
            {
                temp = temp.subBytes();
                temp = temp.shiftRows();
                if(i!=10)
                    temp = temp.mixColumns();
                temp = temp.addRoundKey(inputkey, i);
            }

            return temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] inputKey = readHexString(tbKey.Text);
            Key key = new Key(inputKey);

            byte[] inputCypher = readHexString(tbPlain.Text);
            State cyphertext = new State(inputCypher);

            State original = DecryptionProgress(cyphertext, key);

            MessageBox.Show("The original text is:\n" +original.ToString());

        }

        public State DecryptionProgress(State inputtext, Key inputkey)
        {
            State temp;

            temp = inputtext.addRoundKey(inputkey, 0);

            for (int i = 1; i <= 10; i++)
            {
                temp = temp.shiftRowsInv();
                temp = temp.subBytesInv();
                temp = temp.addRoundKey(inputkey, i);
                if (i != 10)
                    temp = temp.mixColumnsInv();
            }

            return temp;
        }
    }
}
