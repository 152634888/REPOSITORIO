using System.ComponentModel;

namespace Situação_de_Aprendizagem
{

    public partial class btnCarregar : Form
    {
        private int timer = 0;
        public btnCarregar()
        {
            InitializeComponent();
            
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Load(object sender, EventArgs e)
        { }


        private void textValor1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Sensores s1 = new Sensores(10201, "Sensor Pt-100", "Temperatura", 0);
            Sensores s2 = new Sensores(10202, "SITRANS P320", "Pressão", 0);
            Sensores s3 = new Sensores(10203, "SHT20", "Umidade", 0);


            textID.Text = s1.id.ToString();
            textName.Text = s1.name;
            textTipo.Text = s1.tipo;
            textValor.Text = s1.valoratual.ToString();

            textIDp.Text = s2.id.ToString();
            textNamep.Text = s2.name;
            textTipop.Text = s2.tipo;
            textValatualp.Text = s2.valoratual.ToString();

            textIDu.Text = s3.id.ToString();
            textNameu.Text = s3.name;
            textTipou.Text = s3.tipo;
            textValatualu.Text = (s3.valoratual / 100.0).ToString("P0");

            timer++;
            texttime.Text = $"Tempo: {timer}s";
            if (timer == 5)
            {
                timer = 0;
            }

            
        }
    }
    class Sensores
    {
        public int id;
        public string name;
        public string tipo{ get; set; }
        public int valoratual;
       
        public Sensores(int id, string name, string tipo, int valoratual)
        {
            this.id = id;
            this.name = name;
            this.tipo = tipo;
            this.valoratual = GerarValoraleatorio(tipo);

        }
        static int GerarValoraleatorio(string tipo) 
        {
            Random random = new Random();
            if (tipo == "Temperatura")
            {
                return random.Next(19, 45);
            } else if (tipo == "Pressão")
            {
                return random.Next(1, 11);
            } else if(tipo == "Umidade")
            {
                return random.Next(40,99);
            }
            return 0;

        }


    }
}
