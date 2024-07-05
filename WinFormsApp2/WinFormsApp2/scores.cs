using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace WinFormsApp2
{
    public partial class scores : Form
    {
        SqlConnection con;
        public scores()
        {
            InitializeComponent();
            pla1.ForeColor = Color.Blue;
            lab_sco1.ForeColor = Color.Blue;
            pal2.ForeColor = Color.Orange;
            lab_sco2.ForeColor = Color.Orange;
            btn_edit.ForeColor = Color.Green;
            button1.ForeColor = Color.IndianRed;
            btn_backto.ForeColor = Color.White;
            btn_backto.BackColor = Color.Green;
            con = new SqlConnection("Server=DESKTOP-76K89NQ\\MSSQLSERVER01;Database=projectxo;Trusted_Connection=True;TrustServerCertificate=True");
            


        }

        private void scores_Load(object sender, EventArgs e)
        {
            getscores();
        }

        void getscores()
        {
            SqlCommand cmd = new SqlCommand($"SELECT  [id],[player1],[score1],[player2],[score2] FROM [projectxo].[dbo].[scores]", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);


            con.Close();


            dataGridView1.DataSource = dt;
        }
        int currentid = 0;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            currentid = (int)row.Cells["id"].Value;
            text_p1.Text = row.Cells["player1"].Value.ToString();
            text_s1.Text = row.Cells["score1"].Value.ToString();
            text_p2.Text = row.Cells["player2"].Value.ToString();
            text_s2.Text = row.Cells["score2"].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"update scores set [player1]=@play1,[score1]=@score1,[player2]=@play2,[score2]=@score2 where [id] = @id", con);
            cmd.Parameters.AddWithValue("id", currentid);
            cmd.Parameters.AddWithValue("play1", text_p1.Text);
            cmd.Parameters.AddWithValue("score1", text_s1.Text);
            cmd.Parameters.AddWithValue("play2", text_p2.Text);
            cmd.Parameters.AddWithValue("score2", text_s2.Text);
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
                MessageBox.Show("scores was updated");
                getscores();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"delete from scores where [id] = @id", con);
            cmd.Parameters.AddWithValue("id", currentid);
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
                MessageBox.Show("scores was deleted");
                getscores();

            }
        }

        private void btn_backto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
