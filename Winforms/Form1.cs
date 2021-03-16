using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;

namespace Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntAction1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in gbNumbers.Controls)
            {
                if (ctrl is TextBox && ctrl.Text != "")
                {
                    MessageBox.Show(ctrl.Text);
                }
            }

        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    SetText(sr.ReadToEnd());
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"File not found.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                catch(SecurityException ex)
                {                
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void SetText(string text)
        {
            txtText.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
