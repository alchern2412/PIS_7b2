using lab7b_forms.DictionaryService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7b_forms
{
    public partial class Form1 : Form
    {
        DictionaryService.DictionarySoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new DictionaryService.DictionarySoapClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button1_Click(null, null);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Record> records = client.GetDict().ToList();
                StringBuilder result = new StringBuilder();
                records.ForEach(record =>
                {
                    result.AppendLine($"{record.Id}: {record.Name} - {record.Number}");
                });
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                Record record = new Record();
                record.Name = textBoxAddRecordName.Text;
                record.Number = textBoxAddRecordNumber.Text;

                client.AddDict(record.Name, record.Number);
                textBoxAddRecordName.Text = "";
                textBoxAddRecordNumber.Text = "";
                Button1_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Record record = new Record();
                record.Id = int.Parse(textBoxUpdateId.Text);
                record.Name = textBoxUpdateName.Text;
                record.Number = textBoxUpdateNumber.Text;

                client.UpdDict(record.Id, record.Name, record.Number);
                textBoxUpdateName.Text = "";
                textBoxUpdateNumber.Text = "";
                textBoxUpdateId.Text = "";
                Button1_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Record record = new Record();
                record.Id = int.Parse(textBoxDeleteId.Text);

                client.DelDict(record.Id);
                textBoxDeleteId.Text = "";
                Button1_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
