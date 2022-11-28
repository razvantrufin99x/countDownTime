namespace countDownTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class CountDownTime
        {
            public DateTime actualTime = DateTime.Now;
            public DateTime expectedTime = DateTime.Now;
            public DateTime differenceOfTime = DateTime.Now;

        }

        public void printActualTime(DateTime d) { 
            this.textBox3.Text = d.ToString();
        }

        public void printDifferenceOfTime(DateTime d)
        {
            this.textBox1.Text = d.ToString();
        }


        public CountDownTime cdt = new CountDownTime();

        private void Form1_Load(object sender, EventArgs e)
        {
            cdt.actualTime = DateTime.Now;
            printActualTime(cdt.actualTime);
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cdt.actualTime = DateTime.Now;
            printActualTime(cdt.actualTime);
            calculateTheTimeDifference();

        }

        private void button2_Click(object sender, EventArgs e)
        {
             try {
                cdt.expectedTime = Convert.ToDateTime(this.textBox2.Text);
            }
            catch { }
            timer1.Enabled = true;
        }

        public void calculateTheTimeDifference()
        {
             try
            {

                var diff = cdt.expectedTime.Subtract(cdt.actualTime);
                var res = String.Format("{0}:{1}:{2}", diff.Hours, diff.Minutes, diff.Seconds);
                printDifferenceOfTime(Convert.ToDateTime(res));
           }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            calculateTheTimeDifference();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text;
        }
    }
}