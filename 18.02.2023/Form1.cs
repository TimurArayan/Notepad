using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace _18._02._2023
{
    public partial class Form1 : Form
    {
        
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;


        public Form1()
        {
            InitializeComponent();
            this.Text = "Блокнот";
        }

        ///Создать новый файл
        private void NewFile()
        {
            try
            {
                this.richTextBox1.Text = string.Empty;
            }
            catch
            {

            }
            finally
            {

            }
        }

        //Сохранить файл
        private void SaveFile()
        {
            try
            {
                saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстоывй файл (*.txt) | *.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, this.richTextBox1.Text);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        //Открыть файл
        private void OpenFile()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("No file");
            }
            finally
            {
                openFileDialog = null;
            }
        }

        float x = 16;
        FontStyle z = FontStyle.Regular;

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void сохрнаитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.richTextBox1.SelectionColor = Color.Red;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionColor = Color.Green;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionColor = Color.Blue;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, 12, z);
            x = 12;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, 14, z);
            x = 14;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, 16, z);
            x = 16;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, 18, z);
            x = 18;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, 20, z);
            x = 20;
        }

        private void курсивToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, x, FontStyle.Italic);
            z = FontStyle.Italic;
        }

        private void нормальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, x, FontStyle.Regular);
            z = FontStyle.Regular;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 q = new Form2();
            q.ShowDialog();

        }


    }
}
