using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Филин
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
          
           
        public void View()
        {
            SQLiteConnection conn = DBUtils.GetDBConnection();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;

            conn.Open();
            DataTable dTable = new DataTable();
            String sqlQuery;
            cmd.Connection = conn;

            sqlQuery = "SELECT * FROM worker";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, conn);
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < dTable.Rows.Count; i++)
                    dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                conn.Close();
            }
            else
                MessageBox.Show("Список исполнителей пуст", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            View();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DBUtils.GetDBConnection();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText="INSERT INTO worker ('isp_name') values ('" + textBox1.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Новый исполнитель добавлен в БД", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            View();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DBUtils.GetDBConnection();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn; ;
            conn.Open();
            cmd.CommandText = "DELETE FROM worker WHERE _id='" + textBox2.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Исполнитель с заданным ID удален", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            View();
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DBUtils.GetDBConnection();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "DELETE FROM worker";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM sqlite_sequence WHERE name='worker'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Все исполнители удаленны из БД", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            View();

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DBUtils.GetDBConnection();
            SQLiteCommand cmd = new SQLiteCommand();
       
            DialogResult result = MessageBox.Show("Удаление приведет к потере всех данных, точно удалить?", "Проверка действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "DELETE FROM docs";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM sqlite_sequence WHERE name='docs'";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("База данных полностью очищена", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Вы отменили действие на удаление", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
