namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            this.BackgroundImage = Properties.Resources.bakududa;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.bakududa;
            this.label1.Text = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.londondu;
            this.label1.Text = $"{DateTime.Now.Hour - 3}:{DateTime.Now.Minute}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
 
