using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenGameEngine
{
    public partial class EngineStart : Form
    {
        public EngineStart()
        {
            InitializeComponent();
        }

        private void VerDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zen Game Engine Beta\nVersion 1.0.0_rb\nSource code freely available at GitHub.\nCopyright (C) 2017 Zen Software, Ltd.");
        }

        private void EngineStart_Load(object sender, EventArgs e)
        {

        }

        private void LoadProj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Zen Game Engine Project Files|*.zpf";
            openFileDialog1.Title = "Select a project to open.";
        }

        private void NewProj_Click(object sender, EventArgs e)
        {
            EngineWorkspace f2 = new EngineWorkspace();
            f2.ShowDialog(this);
            //LinkVisited = true;
            this.Hide();
        }
    }
}
