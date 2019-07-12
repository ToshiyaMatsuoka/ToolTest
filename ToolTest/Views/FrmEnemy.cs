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
using ToolTest.Models.ValueObjects;
using ToolTest.Models.Services;
using MySql.Data.MySqlClient;

namespace ToolTest.Views
{
    public partial class FrmEnemy : Form
    {
        private BindingList<EnemyParam> list = new BindingList<EnemyParam>();
        public FrmEnemy()
        {
            InitializeComponent();
        }
        private void FrmEnemy_Load(object sender, EventArgs e)
        {
            this.DataGridViewEnemy.DataSource = list;
            var connection = Conection.ConnectDB();
            var cmd = new MySqlCommand("select * from enemy;", connection);
            var reader = cmd.ExecuteReader();
            list.Clear();
            while (reader.Read())
            {
                var enemy = new EnemyParam();
                enemy.Id = Convert.ToInt32(reader.GetString("Id"));
                enemy.Name = reader.GetString("name");
                enemy.IsBoss = Convert.ToBoolean(reader.GetString("isBoss"));
                enemy.Hp = Convert.ToInt32(reader.GetString("Hp"));
                enemy.Mp = Convert.ToInt32(reader.GetString("Mp"));
                list.Add(enemy);
            }
            Conection.DisConnectDB();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var con = Conection.ConnectDB();
            foreach (var row in this.list)
            {
                var command = new StringBuilder();
                if (SarchPrimalKey(row.Id))
                {
                    command.Append("update enemy set ");
                    command.Append($"name = '{row.Name}'");
                    command.Append($",isBoss = { row.IsBoss }");
                    command.Append($",Hp = { row.Hp }");
                    command.Append($",Mp = { row.Mp }");
                    command.Append($" where id = { row.Id };");
                    MySqlCommand cmd = new MySqlCommand(command.ToString(), con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    command.Append("insert into enemy values ( @id, @name, @isBoss, @Hp, @Mp )");
                    MySqlCommand cmd =
                        new MySqlCommand(command.ToString(), con);
                    cmd.Parameters.Add(new MySqlParameter("@id", row.Id));
                    cmd.Parameters.Add(new MySqlParameter("@name", row.Name));
                    cmd.Parameters.Add(new MySqlParameter("@isBoss", Convert.ToByte(row.IsBoss)));
                    cmd.Parameters.Add(new MySqlParameter("@Hp", row.Hp));
                    cmd.Parameters.Add(new MySqlParameter("@Mp", row.Mp));
                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();

        }
        private bool SarchPrimalKey(int id)
        {
            var connection = Conection.ConnectDB();
            var cmd = new MySqlCommand("select * from enemy;", connection);
            var reader = cmd.ExecuteReader();
            int enemyId;
            for (var i = 0; reader.Read();i++)
            {
                enemyId=Convert.ToInt32(reader.GetString("Id"));
                if (id == enemyId)
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            FrmEnemy_Load(sender, e);
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var con = Conection.ConnectDB();
                var command = new StringBuilder();
                foreach (DataGridViewRow row in DataGridViewEnemy.SelectedRows)
                {
                    command.Append("delete from enemy where ");
                    command.Append($"id ={list[row.Index].Id}");
                    MySqlCommand cmd =
                        new MySqlCommand(command.ToString(), con);
                    cmd.ExecuteNonQuery();
                    command.Clear();
                }
                //MessageBox.Show("delete", "");
                con.Close();
            }
        }
    }
}
