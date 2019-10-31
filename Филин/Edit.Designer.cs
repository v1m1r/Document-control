namespace Филин
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusDoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oldStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.poryadok = new System.Windows.Forms.Label();
            this.oldIsp = new System.Windows.Forms.TextBox();
            this.poryadokText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.podrazdelText = new System.Windows.Forms.TextBox();
            this.number_doc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.little_opis = new System.Windows.Forms.RichTextBox();
            this.worker = new System.Windows.Forms.ComboBox();
            this.raspor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.statusDoc);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.podrazdelText);
            this.panel1.Controls.Add(this.number_doc);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.little_opis);
            this.panel1.Controls.Add(this.worker);
            this.panel1.Controls.Add(this.raspor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 563);
            this.panel1.TabIndex = 1;
            // 
            // statusDoc
            // 
            this.statusDoc.FormattingEnabled = true;
            this.statusDoc.Items.AddRange(new object[] {
            "В работе",
            "Исполнен"});
            this.statusDoc.Location = new System.Drawing.Point(386, 464);
            this.statusDoc.Name = "statusDoc";
            this.statusDoc.Size = new System.Drawing.Size(143, 21);
            this.statusDoc.TabIndex = 21;
            this.statusDoc.Text = "Выбрать";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(186, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Статус документа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oldStatus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.poryadok);
            this.groupBox1.Controls.Add(this.oldIsp);
            this.groupBox1.Controls.Add(this.poryadokText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 59);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Промежуточная информация (необходимо обновить)";
            // 
            // oldStatus
            // 
            this.oldStatus.Enabled = false;
            this.oldStatus.Location = new System.Drawing.Point(777, 18);
            this.oldStatus.Name = "oldStatus";
            this.oldStatus.Size = new System.Drawing.Size(197, 26);
            this.oldStatus.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(620, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Статус документа";
            // 
            // poryadok
            // 
            this.poryadok.AutoSize = true;
            this.poryadok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poryadok.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.poryadok.Location = new System.Drawing.Point(6, 23);
            this.poryadok.Name = "poryadok";
            this.poryadok.Size = new System.Drawing.Size(85, 20);
            this.poryadok.TabIndex = 15;
            this.poryadok.Text = "Номер п/п";
            // 
            // oldIsp
            // 
            this.oldIsp.Enabled = false;
            this.oldIsp.ForeColor = System.Drawing.Color.Red;
            this.oldIsp.Location = new System.Drawing.Point(365, 20);
            this.oldIsp.Name = "oldIsp";
            this.oldIsp.Size = new System.Drawing.Size(227, 26);
            this.oldIsp.TabIndex = 18;
            // 
            // poryadokText
            // 
            this.poryadokText.Enabled = false;
            this.poryadokText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poryadokText.ForeColor = System.Drawing.Color.Red;
            this.poryadokText.Location = new System.Drawing.Point(97, 22);
            this.poryadokText.Name = "poryadokText";
            this.poryadokText.ShortcutsEnabled = false;
            this.poryadokText.Size = new System.Drawing.Size(145, 21);
            this.poryadokText.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(248, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Исполнитель";
            // 
            // podrazdelText
            // 
            this.podrazdelText.Location = new System.Drawing.Point(386, 410);
            this.podrazdelText.Name = "podrazdelText";
            this.podrazdelText.Size = new System.Drawing.Size(529, 20);
            this.podrazdelText.TabIndex = 14;
            // 
            // number_doc
            // 
            this.number_doc.Location = new System.Drawing.Point(386, 362);
            this.number_doc.Name = "number_doc";
            this.number_doc.Size = new System.Drawing.Size(529, 20);
            this.number_doc.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(470, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(386, 318);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // little_opis
            // 
            this.little_opis.Location = new System.Drawing.Point(386, 126);
            this.little_opis.Name = "little_opis";
            this.little_opis.Size = new System.Drawing.Size(529, 131);
            this.little_opis.TabIndex = 10;
            this.little_opis.Text = "";
            // 
            // worker
            // 
            this.worker.FormattingEnabled = true;
            this.worker.Location = new System.Drawing.Point(386, 276);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(276, 21);
            this.worker.TabIndex = 8;
            this.worker.Text = "Выбрать";
            // 
            // raspor
            // 
            this.raspor.Location = new System.Drawing.Point(386, 91);
            this.raspor.Name = "raspor";
            this.raspor.Size = new System.Drawing.Size(529, 20);
            this.raspor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(40, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Подразделение исполнитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(40, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "№ отработанного документа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Срок контроля (промежуточный)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(40, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ответственное лицо подразделения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Суть документа (кратко)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Указание распоряжения (от какого числа)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(677, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "когда оповестить";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 578);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование документа";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox number_doc;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.RichTextBox little_opis;
        public System.Windows.Forms.ComboBox worker;
        public System.Windows.Forms.TextBox raspor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox poryadokText;
        private System.Windows.Forms.Label poryadok;
        public System.Windows.Forms.TextBox podrazdelText;
        public System.Windows.Forms.TextBox oldIsp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox oldStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox statusDoc;
        private System.Windows.Forms.Label label10;
    }
}