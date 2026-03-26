using LibVoiture;
namespace winVoiture
{

    public partial class Form1 : Form
    {
        private Reservoir[] tabReservoir;
        private int i = 0;
        public Form1()
        {
            InitializeComponent();
            tabReservoir = new Reservoir[3];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            tabReservoir[i] = new Reservoir(Convert.ToInt16(txtCapacite.Text));
            i++;
            if (i == tabReservoir.Length)
            {
                btnValiderR.Enabled = false;
                MessageBox.Show($"Vous avez créé les {tabReservoir.Length} réservoirs");
            }
            txtCapacite.Clear();
            txtContenu.Clear();
        }

        private void btnValiderV_Click(object sender, EventArgs e)
        {
            Reservoir r = new Reservoir();
            foreach (Reservoir res in tabReservoir)
            {
                if (res.GetCapacite() == Convert.ToInt16(txtCapacite.Text))
                {
                    r = res;
                }
            }
        }
    }
}
    

