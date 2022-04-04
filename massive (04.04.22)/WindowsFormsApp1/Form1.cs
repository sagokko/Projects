using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbconn db = new dbconn();

            try
            {
                db.OpenConnection();
                MessageBox.Show("База данных подключена");
            }
            catch
            {
                MessageBox.Show("Ошибка подключение к базе данных");
                Application.Exit();
            }

            db.CloseConnection();
        }
    }
}
