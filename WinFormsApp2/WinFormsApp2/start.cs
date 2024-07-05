using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace WinFormsApp2
{
    public partial class start : Form
    {
        string ch1 = "";
        string ch2 = "";
        string play1 = "";
        string play2 = "";


        public start(string p1, string p2, string p1_check, string p2_check)
        {
            InitializeComponent();
            la_play1.Text = p1;
            play1 = p1;
            la_play1.ForeColor = Color.Orange;
            lab_play2.Text = p2;
            play2 = p2;
            lab_play2.ForeColor = Color.Orange;
            vs.Text = "VS";
            vs.ForeColor = Color.Red;
            btn_new.ForeColor = Color.Green;
            button10.ForeColor = Color.Green;
            label1.ForeColor = Color.YellowGreen;
            player_two.ForeColor = Color.YellowGreen;
            ch1 = p1_check; ch2 = p2_check;
            btn_save.ForeColor = Color.Green;
            btn_back.ForeColor = Color.White;
            btn_back.BackColor = Color.Green;
            textBox1.Enabled = false;
            textBox2.Enabled = false;

        }

        bool check = true;
        int count1 = 0;
        int count2 = 0;

        private void btns_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (check)
            {
                btn.ForeColor = Color.White; // Change text color
                btn.BackColor = Color.LightGreen;
                btn.Text = ch1;



            }
            else
            {
                btn.ForeColor = Color.White; // Change text color
                btn.BackColor = Color.IndianRed;
                btn.Text = ch2;


            }
            getwinner();



            check = !check;
            btn.Enabled = false;

        }

        public void getwinner()
        {
            // Check for winning combinations in rows
            if ((button1.Text != "") && (button1.Text == button2.Text) && (button1.Text == button3.Text))
            {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.Blue;

                if (button1.Text == ch1)
                {
                    count1++;

                    textBox1.Text = count1.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;

                }
                else
                {
                    count2++;
                    textBox2.Text = count2.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
            }
            else if ((button4.Text != "") && (button4.Text == button5.Text) && (button4.Text == button6.Text))
            {
                button4.BackColor = button5.BackColor = button6.BackColor = Color.Blue;

                if (button4.Text == ch1)
                {
                    count1++;

                    textBox1.Text = count1.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
                else
                {
                    count2++;
                    textBox2.Text = count2.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
            }
            // Check for winning combinations in diagonals
            else if ((button7.Text != "") && (button7.Text == button8.Text) && (button7.Text == button9.Text))
            {

                button7.BackColor = button8.BackColor = button9.BackColor = Color.Blue;
                if (button7.Text == ch1)
                {
                    count1++;

                    textBox1.Text = count1.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
                else
                {
                    count2++;
                    textBox2.Text = count2.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
            }

            else if ((button1.Text != "") && (button1.Text == button4.Text) && (button1.Text == button7.Text))
            {

                button1.BackColor = button4.BackColor = button7.BackColor = Color.Blue;
                if (button1.Text == ch1)
                {
                    count1++;

                    textBox1.Text = count1.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
                else
                {
                    count2++;
                    textBox2.Text = count2.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
            }
            else if ((button2.Text != "") && (button2.Text == button5.Text) && (button2.Text == button8.Text))
            {
                button2.BackColor = button5.BackColor = button8.BackColor = Color.Blue;

                if (button2.Text == ch1)
                {
                    count1++;

                    textBox1.Text = count1.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
                else
                {
                    count2++;
                    textBox2.Text = count2.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
            }
            else if ((button3.Text != "") && (button3.Text == button6.Text) && (button3.Text == button9.Text))
            {
                button3.BackColor = button6.BackColor = button9.BackColor = Color.Blue;

                if (button3.Text == ch1)
                {
                    count1++;

                    textBox1.Text = count1.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
                else
                {
                    count2++;
                    textBox2.Text = count2.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
            }
            else if (button1.Text != "" && (button1.Text == button5.Text) && (button1.Text == button9.Text))
            {
                button1.BackColor = button5.BackColor = button9.BackColor = Color.Blue;
                if (button1.Text == ch1)
                {
                    count1++;

                    textBox1.Text = count1.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
                else
                {
                    count2++;
                    textBox2.Text = count2.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }


            }
            else if (button3.Text != "" && (button3.Text == button5.Text) && (button3.Text == button7.Text))
            {
                button3.BackColor = button5.BackColor = button7.BackColor = Color.Blue;

                if (button3.Text == ch1)
                {
                    count1++;

                    textBox1.Text = count1.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }
                else
                {
                    count2++;
                    textBox2.Text = count2.ToString();
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
                }


            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
            check = true;
            button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
            textBox1.Text = textBox2.Text = "";
            button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;
            count1 = 0;
            count2 = 0;
            check = true;


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-76K89NQ\\MSSQLSERVER01;Database=projectxo;Trusted_Connection=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand($"insert into scores([player1],[score1],[player2],[score2]) values('{play1}',{count1},'{play2}',{count2})", con);
            int rowsEffected = 0;
            try
            {

                con.Open();

                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                con.Close();
            }

            if (rowsEffected > 0)
            {
                MessageBox.Show("score was saved");

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
