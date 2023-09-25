using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace CaptchaApp
{
    public partial class Login : Form
    {
        public static string connectionString = "Data Source=ADCLG1;Initial Catalog=stepanov2zadanie;Integrated Security=True";
        SqlDataAdapter adapter;
        DataSet ds;
        SqlConnection connection = new SqlConnection(connectionString);
        int how;
        public Login()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            var password = (textBoxPassword.Text);
            string querystring = $"select [Роль], [Пароль] from [Клиенты] where [Роль] ='{textBox1.Text}' and [Пароль] = '{password}'";
            SqlCommand command = new SqlCommand(querystring, connection);
            how = how + 1;
            if (command.ExecuteScalar() != null)
            {
                if (command.ExecuteScalar().ToString() == "Администратор")
                {
                    
                    MessageBox.Show("Добро Пожаловать Администратор!");
                    Admin administrator = new Admin();
                    this.Hide();
                    administrator.ShowDialog();

                }
                else if (command.ExecuteScalar().ToString() == "Клиент")
                {
                   
                    MessageBox.Show("Добро пожаловать Дух!");
                    Form1 menuForClient = new Form1();
                    this.Hide();
                    menuForClient.ShowDialog();

                }

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (how == 3)
                {
                    Capcha kapcha = new Capcha();
                    this.Hide();
                    kapcha.ShowDialog();
                }
            }
            connection.Close();
        }
    } 
}
