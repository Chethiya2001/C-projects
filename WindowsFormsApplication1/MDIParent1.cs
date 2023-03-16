using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            f1.MdiParent = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            f3.MdiParent = this;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.MdiParent = this;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.MdiParent = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            f5.MdiParent = this;

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dayTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void longTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void vehicleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            f1.MdiParent = this;
        }

        private void packagesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            f3.MdiParent = this;
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.MdiParent = this;
        }

        private void dayTourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.Show();
            f4.MdiParent = this;
        }

        private void longTourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            f5.MdiParent = this;
        }
    }
}
