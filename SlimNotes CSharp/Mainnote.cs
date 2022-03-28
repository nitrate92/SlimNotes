using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;
//remove unused namespaces when done

namespace SlimNotes_CSharp
{
    public partial class Mainnote : Form
    {
        public Mainnote()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this thing doesn't work, further study is needed
            Trace.TraceInformation("hi mom im on tv");
            Console.WriteLine("Form loaded.");
        }

        private void ClearConsoleOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //sound that plays when the menu is opened
            SoundPlayer audio = new SoundPlayer(SlimNotes_CSharp.Properties.Resources.boopsfx1);
            audio.Play();
            Console.WriteLine("boopsfx1 played.");
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            Console.WriteLine("Cut.");
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            Console.WriteLine("Copy.");
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            Console.WriteLine("Paste.");
        }

        private void YellowDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Yellow;
            Console.WriteLine("Note color changed to yellow.");
        }

        private void OrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Orange;
            Console.WriteLine("Note color changed to orange.");
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.LightBlue;
            Console.WriteLine("Note color changed to blue.");
        }

        private void WhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
            Console.WriteLine("Note color changed to white.");
        }

        private void CustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.BackColor = colorDialog1.Color;
            Console.WriteLine("Note color changed to a custom color.");
        }

        private void FontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the font change dialog and sets it
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.Color = richTextBox1.ForeColor;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
                Console.WriteLine("Font changed.");
            }
        }

        private void NewNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //poor way of handling the creation of a new note because if the first note is closed, ALL OF THEM CLOSE
            new Thread(() => new Mainnote().ShowDialog()).Start();
            Console.WriteLine("New note window created.");
            //update: (4/22/21) finally fixed :DDDDD
         }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            {
                MessageBox.Show("This feature is not availible in this unfinished version of SlimNotes.", "Alert");  
                //i hate my life
                //var fileContent = string.Empty;
                //var filePath = string.Empty;
                //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    richTextBox1.Text = fileContent;
                    
                //}
                
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //imagine having enough of a brain to properly port this code from the old VB .NET version
            MessageBox.Show("This feature is not availible in this unfinished version of SlimNotes.", "Alert");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit? This will close all windows.", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
