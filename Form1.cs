using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                        
            Data.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();

        }
        private string fileName = "Untitled";
        public class StreamReader : System.IO.TextReader { }
                          

        private void New_Click(object sender, EventArgs e)
        {
            fileName = "Untitled";
            richTB.Clear();
        }

        public void Open_Click(object sender, EventArgs e)
        {
            using (openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "Text Documents (*.txt)|*.txt| SE Documents (*.setxt) |*.setxt | All Files |*.*";
                openFileDialog1.FilterIndex = 2;
            
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    fileName = openFileDialog1.FileName;
                try
                {
                    string fileText = System.IO.File.ReadAllText(fileName);
                    richTB.Text = fileText;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)   
        {
            if (MessageBox.Show("Сохранить изменения?", "Сохранить?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Save_as_Click(this, null);
                richTB.Text = "";
            }

            richTB.Text = "";
        }

        public void Save_as_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlgSave = new SaveFileDialog())
            {
                dlgSave.Filter = "Text Documents (*.txt)|*.txt| SE Documents (*.setxt) |*.setxt";
                dlgSave.FilterIndex = 2;

                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlgSave.FileName;
                    try
                    {
                        string fileText = richTB.Text;
                        System.IO.File.WriteAllText(fileName,fileText);

                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Simple Editor",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }

        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (richTB.CanUndo == true)
            {
                richTB.Undo();
                richTB.ClearUndo();
            }
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            if (richTB.SelectedText != "")
            {
                richTB.Cut();
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (richTB.SelectionLength > 0)
            {
                richTB.Copy();
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)  // Есть ли в буфере обмена текст
            {
                if (richTB.SelectionLength > 0)
                {
                    richTB.SelectionStart = richTB.SelectionStart + richTB.SelectionLength;
                }
                richTB.Paste();
            }
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(richTB.SelectionFont,  //1
             (richTB.SelectionFont.Bold ?              //2
             richTB.SelectionFont.Style & ~FontStyle.Bold :    //3
             richTB.SelectionFont.Style | FontStyle.Bold));  //4
            richTB.SelectionFont = newFont;
        }

        private void Italics_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(richTB.SelectionFont,	//1
           (richTB.SelectionFont.Italic ?				//2
           richTB.SelectionFont.Style & ~FontStyle.Italic :	//3
           richTB.SelectionFont.Style | FontStyle.Italic));  //4
            richTB.SelectionFont = newFont;
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(richTB.SelectionFont,	//1
           (richTB.SelectionFont.Underline ?				//2
           richTB.SelectionFont.Style & ~FontStyle.Underline :	//3
           richTB.SelectionFont.Style | FontStyle.Underline));  //4
            richTB.SelectionFont = newFont;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTB.Clear();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog1 = new ColorDialog())
            {
                colorDialog1.Color = this.BackColor;
                if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
               
                richTB.SelectionColor = colorDialog1.Color;
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            using (FontDialog FontDialog1 = new FontDialog())
            {
               if (FontDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                richTB.SelectionFont = FontDialog1.Font;
            }
        }

        private void Center_Click(object sender, EventArgs e)
        {
            richTB.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Right_Click(object sender, EventArgs e)
        {
            richTB.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Left_Click(object sender, EventArgs e)
        {
            richTB.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void Undo1_Click(object sender, EventArgs e)
        {
            if (richTB.CanUndo == true)
            {
                richTB.Undo();
                richTB.ClearUndo();
            }
        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            richTB.Clear();
        }

        private void Cut1_Click(object sender, EventArgs e)
        {
            if (richTB.SelectedText != "")
            {
                richTB.Cut();
            }
        }

        private void Copy1_Click(object sender, EventArgs e)
        {
            if (richTB.SelectionLength > 0)
            {
                richTB.Copy();
            }
        }

        private void Paste1_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)  // Есть ли в буфере обмена текст
            {
                if (richTB.SelectionLength > 0)
                {
                    richTB.SelectionStart = richTB.SelectionStart + richTB.SelectionLength;
                }
                richTB.Paste();
            }
        }

        private void Color2_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog1 = new ColorDialog())
            {
                colorDialog1.Color = this.BackColor;
                if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                richTB.SelectionColor = colorDialog1.Color;
            }
        }

        private void Font2_Click(object sender, EventArgs e)
        {
            using (FontDialog FontDialog1 = new FontDialog())
            {
                if (FontDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                richTB.SelectionFont = FontDialog1.Font;
            }
        }

        private void Left2_Click(object sender, EventArgs e)
        {
            richTB.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void Center2_Click(object sender, EventArgs e)
        {
            richTB.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void Right2_Click(object sender, EventArgs e)
        {
            richTB.SelectionAlignment = HorizontalAlignment.Right;
        }

       
    }
}

    

