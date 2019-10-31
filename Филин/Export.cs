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
using System.IO;

namespace Филин
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }
        private void Export_Load(object sender, EventArgs e)
        {
            pathSaveXcel.Text = Properties.Settings.Default.excelPathsave.ToString();

        }
        private void Export_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.excelPathsave = this.pathSaveXcel.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {

                pathSaveXcel.Text = FBD.SelectedPath;
            }
        }

        private void StartExport_Click(object sender, EventArgs e)
        {
           

            System.IO.StreamWriter fileWriter = new StreamWriter(pathSaveXcel.Text + @"\" + fileName.Text + ".xls", false, Encoding.GetEncoding(1251));
            SQLiteConnection conn = DBUtils.GetDBConnection();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = @"SELECT _id,ykaz,opis,(SELECT isp_name FROM worker WHERE id_isp=_id),srok_control,nomer_doc,podrazdelenie,status FROM docs";
            cmd.Connection = conn;
            conn.Open();
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string dataFromGrid = "";
               // dataFromGrid = dr.GetValue(0).ToString() + "@" + reader.GetValue(1).ToString() + "@" + reader.GetString(2) + "@" + reader.GetValue(3) + "@" + reader.GetValue(4) + "@" + reader.GetValue(6) + "@" + reader.GetValue(7) + "@" + reader.GetValue(9) + "@" + reader.GetValue(10) + "@";
            
                dataFromGrid = dr.GetValue(0).ToString()+"@"+dr.GetValue(1).ToString()+"@"+dr.GetValue(2).ToString()+"@"+dr.GetValue(3).ToString()+"@"+dr.GetValue(4).ToString()+"@"+dr.GetValue(5).ToString()+"@"+dr.GetValue(6).ToString()+"@"+dr.GetValue(7).ToString();
                fileWriter.WriteLine(dataFromGrid);
                
            }
            fileWriter.Flush();
            fileWriter.Close();
            conn.Close();
            MessageBox.Show("Экспорт успешно завершен файл с именем '"+fileName.Text+"' создан", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

    
    }
}
