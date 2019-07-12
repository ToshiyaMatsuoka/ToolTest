using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTest.Views
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnPlayer_Click(object sender, EventArgs e)
        {
            var frmPlayer = new FrmPlayer();
            frmPlayer.Show();
        }

        private void BtnEnemy_Click(object sender, EventArgs e)
        {
            var frmPlayer = new FrmEnemy();
            frmPlayer.ShowDialog();

        }
    }
}
