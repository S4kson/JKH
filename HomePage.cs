using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKH
{
    public partial class HomePage : Form
    {
        public void ShowForm()
        {
            Show();
            Activate();
        }

        public HomePage()
        {
            InitializeComponent();
        }

       private static HomePage f;
        public static HomePage hp
        {
            get
            {
                if (f == null || f.IsDisposed) f = new HomePage();
                return f;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, каф.КСУП \n Денисова Полина Витальевна, группа 522 \n 2025 год", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void контактнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ООО ЖКХ \n тел. 800-700", "Контактная информация",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Жилец_Click(object sender, EventArgs e)
        {
            var loginForm = new FormLogin("Жилец");
            loginForm.Show();
            this.Hide();

        }

        private void button_Админ_Click(object sender, EventArgs e)
        {
            var loginForm = new FormLogin("Администратор");
            loginForm.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
