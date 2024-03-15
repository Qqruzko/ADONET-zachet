using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace JKH
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
            
        }
        public string login;
        public string password;
        public string connectionString;
        private void Connect_btn_Click(object sender, EventArgs e)
        {
            if (tb_login.Text == "")
            {
                MessageBox.Show("No login");
            }
            if (tb_password.Text == "")
            {
                MessageBox.Show("No password");
            }
            else
            {
                connectionString = $"Server=localhost;Port=5432;User Id={login};Password={password};Database=GKH;";
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                try
                {
                    conn.Open();
                    MessageBox.Show("Connected");
                    Action_box.Visible = true;
                }
                catch (Exception b)
                {
                    //throw new Exception("Error connecting to the database", b);
                    MessageBox.Show("Login or password incorrect");
                }
            }
           

        }

        private void tb_login_TextChanged(object sender, EventArgs e)
        {
            login = tb_login.Text.ToString();
            
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            password = tb_password.Text.ToString();
        }
       public Alterator alt1 = null;
       public Selecter sel1 = null;
        private void Alter_start_btn_Click(object sender, EventArgs e)
        {
            if (alt1 == null)
            {
                alt1 = new Alterator(this);
                
                alt1.Show();
                
            }
            
            
        }

        private void select_start_btn_Click(object sender, EventArgs e)
        {
            if (sel1 == null)
            {
                sel1 = new Selecter(this);

                sel1.Show();

            }
        }
    }
}
