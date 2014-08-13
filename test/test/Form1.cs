using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Image". При необходимости она может быть перемещена или удалена.
            this.imageTableAdapter.Fill(this.dataSet1.Image);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            FD.Filter = " Images only.|*.jpg;*.jpeg;*.png;*.gif;";

            DialogResult DR = FD.ShowDialog();
            imgPictureBox.Image = Image.FromFile(FD.FileName);
            pathLabel1.Text = FD.FileName;

        }

        private void dataDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            dataMaskedTextBox.Text = dataDateTimePicker.Value.ToString();

        }
    }
}
