namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnstart.ForeColor = Color.Green;
            lab_p1.ForeColor = Color.GreenYellow;
            lab_p2.ForeColor = Color.GreenYellow;
            rad_p1_x.ForeColor = Color.Red;
            rad_p2_x.ForeColor = Color.Red;
            rad_p1_o.ForeColor = Color.Blue;
            rad_p2_o.ForeColor = Color.Blue;
            btn_score.ForeColor = Color.Orange;
        }






        private void strat_play(object sender, EventArgs e)
        {
            if (txt_p1.Text != "" && txt_p2.Text != "")
            {

                string p1 = txt_p1.Text;
                string p2 = txt_p2.Text;
                this.Hide();
                start start = new start(p1, p2, p1_check, p2_check);

                start.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("enter name of players");
            }

        }

        private void rad_p1_x_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_p1_x.Checked)
            {
                rad_p2_o.Checked = true;
                p1_check = rad_p1_x.Text;
                p2_check = rad_p2_o.Text;
            }
            else if (rad_p1_o.Checked)
            {
                rad_p2_x.Checked = true;
                p1_check = rad_p1_o.Text;
                p2_check = rad_p2_x.Text;
            }
        }
        string p1_check = "";
        string p2_check = "";
        private void rad_p2_x_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_p2_x.Checked)
            {

                rad_p1_o.Checked = true;
                p1_check = rad_p1_o.Text;
                p2_check = rad_p2_x.Text;
            }
            else if (rad_p2_o.Checked)
            {
                p1_check = rad_p1_x.Text;
                p2_check = rad_p2_o.Text;
                rad_p1_x.Checked = true;
            }
        }

        private void rad_p1_o_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_p1_x.Checked)
            {
                rad_p2_o.Checked = true;
                p1_check = rad_p1_x.Text;
                p2_check = rad_p2_o.Text;
            }
            else if (rad_p1_o.Checked)
            {
                rad_p2_x.Checked = true;
                p1_check = rad_p1_o.Text;
                p2_check = rad_p2_x.Text;
            }

        }

        private void rad_p2_o_CheckedChanged(object sender, EventArgs e)
        {

            if (rad_p2_x.Checked)
            {

                rad_p1_o.Checked = true;
                p1_check = rad_p1_o.Text;
                p2_check = rad_p2_x.Text;
            }
            else if (rad_p2_o.Checked)
            {
                p1_check = rad_p1_x.Text;
                p2_check = rad_p2_o.Text;
                rad_p1_x.Checked = true;
            }

        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            this.Hide();
            scores scores = new scores();
            scores.ShowDialog();
            this.Close();
        }
    }
}
