using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Lab4
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовые файлы|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                //хмммммммм
                list.Clear();

                Stopwatch t = new Stopwatch();
                t.Start();
                
                //У меня на Windows очень странно читаются файлы. Нормально работает только с юникодом
                string text = File.ReadAllText(fd.FileName, Encoding.Unicode);

                char[] separators = new char[] { ' ', '.', ',', '!', '/', '\t', '\n' };

                string[] textArray = text.Split(separators);
                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();

                    if (!list.Contains(str))
                        list.Add(str);
                }

                t.Stop();
                this.labelReadTime.Text = t.Elapsed.ToString();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл");
            }
        }

        private void buttonStrictSearch_Click(object sender, EventArgs e)
        {
            string word = this.textBoxSearchWord.Text.Trim();

            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();

                List<string> tempList = new List<string>();

                Stopwatch t = new Stopwatch();
                t.Start();

                foreach (string str in list)
                {
                    if(str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }

                t.Stop();
                this.labelStrictSearchTime.Text = t.Elapsed.ToString();

                this.listBoxSearchResult.BeginUpdate();

                this.listBoxSearchResult.Items.Clear();

                foreach (string str in tempList)
                {
                    this.listBoxSearchResult.Items.Add(str);
                }

                this.listBoxSearchResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл или ввести слово для поиска");
            }
        }
    }
}
