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
    public partial class NewDocument : Form
    {
      
        public NewDocument()
        {
            InitializeComponent();
           
        }
     
        private void NewDocument_Load(object sender, EventArgs e) //Выгрузка исполнителя в comBox
        {
            SQLiteConnection conn = DBUtils.GetDBConnection();
            SQLiteCommand cmd = new SQLiteCommand();
          
            cmd.CommandText = @"SELECT isp_name FROM worker";
            cmd.Connection = conn;
             conn.Open();
             SQLiteDataReader dr = cmd.ExecuteReader();
             while (dr.Read())
             {
                 comboBox1.Items.Add(dr.GetValue(0));
             }
             conn.Close();
        }
        private void ResetAll()
        {
            textBox1.Clear();
            richTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)//Добавление нового документа
        {
            if (textBox1.Text!=string.Empty)
            {
                SQLiteConnection conn = DBUtils.GetDBConnection();
                SQLiteCommand cmd = new SQLiteCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO docs ('ykaz', 'opis','id_isp','srok_control','nomer_doc','podrazdelenie','status') values ('" +
                     textBox1.Text + "' , '" +
                     richTextBox1.Text + "',(SELECT _id FROM worker WHERE isp_name='" + comboBox1.SelectedItem.ToString() + "'),'" + dateTimePicker1.Value.ToString("dd-MMMM-yyyy") + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox2.SelectedItem.ToString()+ "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                ResetAll();
                MessageBox.Show("Новый документ создан", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Заполните поля", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void NewDocument_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  ResetAll();
            MessageBox.Show(comboBox2.SelectedItem.ToString());
        }

    
        
    }
}
