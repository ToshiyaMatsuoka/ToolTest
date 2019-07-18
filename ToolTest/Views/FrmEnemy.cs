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
using ToolTest.Models.Entity;
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
            this.DataGridViewEnemy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var connection = Conection.ConnectDB();
            var cmd = new MySqlCommand("select * from enemy;", connection);
            var reader = cmd.ExecuteReader();
            list.Clear();
            while (reader.Read())
            {
                var enemy = new EnemyParam();
                enemy.Id = DBNull.Value != reader["Id"] ? Convert.ToInt32(reader.GetString("Id")) : 0;
                enemy.Name = DBNull.Value != reader["name"] ? reader.GetString("name") : "";
                enemy.IsBoss = DBNull.Value != reader["isBoss"] ? Convert.ToBoolean(reader.GetString("isBoss")) : false;
                enemy.Hp = DBNull.Value != reader["Hp"] ? Convert.ToInt32(reader.GetString("Hp")) : 0;
                enemy.Mp = DBNull.Value != reader["Mp"] ? Convert.ToInt32(reader.GetString("Mp")) : 0;
                enemy.Atk = DBNull.Value != reader["Atk"] ? Convert.ToInt32(reader.GetString("Atk")) : 0;
                enemy.Def = DBNull.Value != reader["Def"] ? Convert.ToInt32(reader.GetString("Def")) : 0;
                enemy.Int = DBNull.Value != reader["Int"] ? Convert.ToInt32(reader.GetString("Int")) : 0;
                enemy.Mnd = DBNull.Value != reader["Mnd"] ? Convert.ToInt32(reader.GetString("Mnd")) : 0;
                enemy.Spd = DBNull.Value != reader["Spd"] ? Convert.ToInt32(reader.GetString("Spd")) : 0;
                enemy.Lvl = DBNull.Value != reader["Lvl"] ? Convert.ToInt32(reader.GetString("Lvl")) : 0;
                enemy.Exp = DBNull.Value != reader["Exp"] ? Convert.ToInt32(reader.GetString("Exp")) : 0;
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
                    command.Append($",Atk = { row.Atk }");
                    command.Append($",Def = { row.Def }");
                    command.Append($",`Int` = { row.Int }");
                    command.Append($",Mnd = { row.Mnd }");
                    command.Append($",Spd = { row.Spd }");
                    command.Append($",Lvl = { row.Lvl }");
                    command.Append($",Exp = { row.Exp }");
                    command.Append($" where id = { row.Id };");
                    MySqlCommand cmd = new MySqlCommand(command.ToString(), con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    command.Append("insert into enemy values ( @id, @name, @isBoss, @Hp, @Mp, @Atk, @Def, @`Int`, @Mnd, @Spd, @Lvl, @Exp )");
                    MySqlCommand cmd =
                        new MySqlCommand(command.ToString(), con);
                    cmd.Parameters.Add(new MySqlParameter("@id", row.Id));
                    cmd.Parameters.Add(new MySqlParameter("@name", row.Name));
                    cmd.Parameters.Add(new MySqlParameter("@isBoss", Convert.ToByte(row.IsBoss)));
                    cmd.Parameters.Add(new MySqlParameter("@Hp", row.Hp));
                    cmd.Parameters.Add(new MySqlParameter("@Mp", row.Mp));
                    cmd.Parameters.Add(new MySqlParameter("@Atk", row.Atk));
                    cmd.Parameters.Add(new MySqlParameter("@Def", row.Def));
                    cmd.Parameters.Add(new MySqlParameter("@`Int`", row.Int));
                    cmd.Parameters.Add(new MySqlParameter("@Mnd", row.Mnd));
                    cmd.Parameters.Add(new MySqlParameter("@Spd", row.Spd));
                    cmd.Parameters.Add(new MySqlParameter("@Lvl", row.Lvl));
                    cmd.Parameters.Add(new MySqlParameter("@Exp", row.Exp));
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

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("テーブルの中身がNULLだった場合のNULLチェック" +
                "、\nPKがすでにあるかないか検索してINSERTとUPDATEを切り替えるようにしました。", "このアプリについて");
        }
    }
}
