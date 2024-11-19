namespace alarmapr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            song.CreateControl();
        }

        AxWMPLib.AxWindowsMediaPlayer song = new AxWMPLib.AxWindowsMediaPlayer();
        string ruta = string.Empty;
        string archivo = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbviernes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbsabado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btselcan_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                archivo = ofd.SafeFileName;
                ruta = ofd.FileName;
                song.URL = ruta;
                song.settings.setMode("loop", true);
                //song.Ctlcontrols.stop();
                lbnomcan.Text = archivo;
                lbnomcan.Location = new Point();
            }

        }

        private void cbst_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    if (cbst.Checked)
                        ((CheckBox)c).Checked = true;
                    else
                    {
                        ((CheckBox)c).Checked = false;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dia = Application.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();
            string hora = DateTime.Now.Hour.ToString("00");
            string minutos = DateTime.Now.Minute.ToString("00");

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    if (dia == c.Text.ToLower().ToString() && minutos == tbmin.Text.ToString() && hora == tbhr.Text.ToString())
                    {
                        try
                        {
                            song.Ctlcontrols.play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void lbnomcan_Click(object sender, EventArgs e)
        {

        }
    }
}
