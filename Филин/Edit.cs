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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = DBUtils.GetDBConnection();
            SQLiteCommand cmd = new SQLiteCommand();

            cmd.CommandText = @"SELECT isp_name FROM worker";
            cmd.Connection = conn;
            conn.Open();
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                worker.Items.Add(dr.GetValue(0));
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(worker.SelectedItem.ToString());
            if (statusDoc.SelectedIndex > -1 && worker.SelectedIndex>-1)
            {
                
                SQLiteConnection conn = DBUtils.GetDBConnection();
                SQLiteCommand cmd = new SQLiteCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE docs SET ykaz='" + raspor.Text + "',opis='" + little_opis.Text + "',id_isp=(SELECT _id FROM worker WHERE isp_name='" + worker.SelectedItem.ToString() + "'),srok_control='" + dateTimePicker1.Value.ToString("dd-MMMM-yyyy") + "',nomer_doc='" + number_doc.Text + "',podrazdelenie='" + podrazdelText.Text +"',status='"+statusDoc.SelectedItem.ToString()+"' WHERE _id='" + Convert.ToInt32(poryadokText.Text) + "'";

                cmd.ExecuteNonQuery();
                //conn.Close();

                MessageBox.Show("Данные упешно обновлены", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Проверьте поля ответственное лицо или статус документа", "ОШБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
