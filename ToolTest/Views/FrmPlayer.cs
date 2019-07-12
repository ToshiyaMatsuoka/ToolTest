using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
using ToolTest.Models.ValueObjects;


namespace ToolTest.Views
{
    public partial class FrmPlayer : Form
    {
        public FrmPlayer()
        {
            InitializeComponent();
        }
        private void HptextBox_Load(object sender, EventArgs e)
        {
            HptextBox.ImeMode = ImeMode.Disable;
        }

        private void HptextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' || !Char.IsDigit(e.KeyChar)) return;

                e.Handled = true;
        }

        private void HptextBox_Leave(object sender, EventArgs e)
        {
            if (HptextBox.Text.All(char.IsDigit)) return;
            MessageBox.Show("HPには数値を入れてください。","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.Empty != errorProvider1.GetError(HptextBox)) return;
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = dialog.FileName;
                //var serializer = new XmlSerializer(typeof(PlayerParam));
                var serializer = new JavaScriptSerializer();
                var player = new PlayerParam();
                player.Name = this.TxtbPlayerName.Text;
                player.isMale = this.RbtnMale.Checked;
                player.IsBraver = this.CbxBraver.Checked;
                player.ParameterType = this.CmbType.SelectedItem.ToString();
                player.Job = this.RbtnSword.Checked;
                player.Age = 17;
                player.HP = int.Parse(this.HptextBox.Text);

                var json = serializer.Serialize(player);

                using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    //serializer.Serialize(writer, player);
                    //writer.Flush();
                    writer.Write(json);
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = dialog.FileName;
                //var serializer = new XmlSerializer(typeof(PlayerParam));
                var serializer = new JavaScriptSerializer();
                //using (var reader = new StreamReader(filePath))
                using (var reader = new StreamReader(filePath))
                {
                    var json = reader.ReadToEnd();
                    //var player = serializer.Deserialize(reader) as PlayerParam;
                    var player = serializer.Deserialize<PlayerParam>(json) as PlayerParam;
                    this.TxtbPlayerName.Text=player.Name;
                    this.RbtnMale.Checked = player.isMale;
                    this.CbxBraver.Checked = player.IsBraver;
                    this.CmbType.SelectedText = player.ParameterType;
                    this.RbtnSword.Checked = player.Job;
                    this.HptextBox.Text = player.HP.ToString();
                }
            }
        }

        private void HptextBox_Validating(object sender, CancelEventArgs e)
        {
            if (HptextBox.Text.All(char.IsDigit))
            {
                this.errorProvider1.SetError(HptextBox, string.Empty);
                BtnSave.Enabled = true;
            }
            else
            {
                this.errorProvider1.SetError(HptextBox, "数字を入れてください。");
                BtnSave.Enabled = false;
            }
        }
    }

}
