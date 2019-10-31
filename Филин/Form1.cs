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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void View_Load()
        {
            SQLiteConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            DataTable dTable = new DataTable();
            String sqlQuery;
            cmd.Connection = conn;
            sqlQuery = "SELECT docs._id,ykaz,opis,isp_name,srok_control,nomer_doc,podrazdelenie,status  FROM docs,worker WHERE docs.id_isp=worker._id and status='В работе'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, conn);
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < dTable.Rows.Count; i++)
                    dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                conn.Close();

                foreach (DataGridViewRow row in dataGridView1.Rows) //цикл
                {
                    int days = (DateTime.Parse(row.Cells[4].Value.ToString()) - DateTime.Now).Days; //дней осталось
                    int month = (DateTime.Parse(row.Cells[4].Value.ToString())).Month - DateTime.Now.Month;

                    if (days == 0 & month == 0)
                    {
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = System.Drawing.Color.LightGreen; //красим зеленым
                   
                        }
                        
                        MessageBox.Show("Порядковый номер=> " + row.Cells[0].Value.ToString() + "   " + "Суть документа=> " + row.Cells[2].Value.ToString() + "", "ДОКУМЕНТ ОЖИДАЕТ РЕШЕНИЯ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }

                    if (days < -1 & month < 0)
                    {
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = System.Drawing.Color.Red; //красим красным

                        }
                        MessageBox.Show("Порядковый номер=> " + row.Cells[0].Value.ToString() + "   " + "Суть документа=> " + row.Cells[2].Value.ToString() + "", "ДОКУМЕНТ ПРОСРОЧЕН", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (days < 0 & month == 0)
                    {
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = System.Drawing.Color.Red; //красим красным
                        
                        }
                        MessageBox.Show("Порядковый номер=> " + row.Cells[0].Value.ToString() + "   " + "Суть документа=> " + row.Cells[2].Value.ToString() + "", "ДОКУМЕНТ ПРОСРОЧЕН", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                MessageBox.Show("База данных пустая");
            }
        }

        public void View()
        {
            SQLiteConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            DataTable dTable = new DataTable();
            String sqlQuery;
            cmd.Connection = conn;
            sqlQuery = "SELECT docs._id,ykaz,opis,isp_name,srok_control,nomer_doc,podrazdelenie,status  FROM docs,worker WHERE docs.id_isp=worker._id and status='В работе'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, conn);
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < dTable.Rows.Count; i++)
                    dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                conn.Close();
                foreach (DataGridViewRow row in dataGridView1.Rows) //цикл
                {
                    int days = (DateTime.Parse(row.Cells[4].Value.ToString()) - DateTime.Now).Days; //дней осталось
                    int month = (DateTime.Parse(row.Cells[4].Value.ToString())).Month - DateTime.Now.Month;

                    if (days == 0 & month == 0)
                    {
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = System.Drawing.Color.LightGreen; //красим зеленым

                        }               
                    }

                    if (days < -1 & month < 0)
                    {
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = System.Drawing.Color.Red; //красим красным

                        }
                    }
                    if (days < 0 & month == 0)
                    {
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            row.Cells[i].Style.BackColor = System.Drawing.Color.Red; //красим красным

                        }
                    }
                }

                      }
                      

            else
            {
                MessageBox.Show("База данных пустая");
            }
        }

        public void IspView()
        {

            SQLiteConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            DataTable dTable = new DataTable();
            String sqlQuery;
            cmd.Connection = conn;
            sqlQuery = "SELECT docs._id,ykaz,opis,isp_name,srok_control,nomer_doc,podrazdelenie,status  FROM docs,worker WHERE docs.id_isp=worker._id and status='Исполнен'";
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
            {
                MessageBox.Show("Нет исполненных документов");
                ispView.Checked = false;
            }


        }
        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}


        public void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString("dd MMMM yyyy"); Текущая дата с компа
            View_Load();



        }

        private void addDoc_Click(object sender, EventArgs e)
        {


            NewDocument doc = new NewDocument();
            doc.Show();
            doc.FormClosed += NewDocument_FormClosed;

        }
        private void NewDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            View();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
            s.FormClosed += Settings_FormClosed;

        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            View();
           
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            View();
            workView.Checked = false;
            ispView.Checked = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DBUtils.GetDBConnection();
            SQLiteCommand cmd = new SQLiteCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM docs WHERE _id='" + DeleteBox.Text + "';";

            cmd.ExecuteNonQuery();
            conn.Close();
           
            MessageBox.Show("Документ удален из БД", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            View();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit e1 = new Edit();
            e1.poryadokText.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            e1.raspor.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            e1.little_opis.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            e1.oldIsp.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            e1.dateTimePicker1.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[4].Value.ToString());
            //this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            e1.number_doc.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            e1.podrazdelText.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            e1.oldStatus.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            e1.Show();
            e1.FormClosed += Edit_FormClosed;
        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {

            Export exp = new Export();
            exp.ShowDialog();


        }

        private void DocView_Click(object sender, EventArgs e)
        {
            //if (!workView.Checked || !ispView.Checked)
            //{
            //    MessageBox.Show("Не выбрано условие отбора", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            if (workView.Checked)
            {
                View();
            }
            if (ispView.Checked)
            {
                IspView();
            }
            // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows) //цикл
            {
                int days = (DateTime.Parse(row.Cells[4].Value.ToString()) - DateTime.Now).Days; //дней осталось
                int month = (DateTime.Parse(row.Cells[4].Value.ToString())).Month - DateTime.Now.Month;

                if (days == 0 & month == 0)
                {
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = System.Drawing.Color.LightGreen; //красим зеленым

                    }

                    MessageBox.Show("Порядковый номер=> " + row.Cells[0].Value.ToString() + "   " + "Суть документа=> " + row.Cells[2].Value.ToString() + "", "ДОКУМЕНТ ОЖИДАЕТ РЕШЕНИЯ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (days < -1 & month < 0)
                {
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = System.Drawing.Color.Red; //красим красным

                    }
                    MessageBox.Show("Порядковый номер=> " + row.Cells[0].Value.ToString() + "   " + "Суть документа=> " + row.Cells[2].Value.ToString() + "", "ДОКУМЕНТ ПРОСРОЧЕН", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (days < 0 & month == 0)
                {
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = System.Drawing.Color.Red; //красим красным

                    }
                    MessageBox.Show("Порядковый номер=> " + row.Cells[0].Value.ToString() + "   " + "Суть документа=> " + row.Cells[2].Value.ToString() + "", "ДОКУМЕНТ ПРОСРОЧЕН", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void open_info_Click(object sender, EventArgs e)
        {
           
            Info inf = new Info();
            inf.ShowDialog();
        }
        }
    }
