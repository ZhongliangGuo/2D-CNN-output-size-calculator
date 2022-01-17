namespace CNNSizeCalculator
{
    public partial class Form1 : Form
    {
        private int iw, ih, kw, kh, s, p, ow, oh;

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            kw = (int)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            kh = (int)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            s = (int)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            p = (int)numericUpDown6.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            iw = (int)numericUpDown1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            listView1.Items.Clear();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ih = (int)numericUpDown2.Value;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            iw = (int)numericUpDown1.Value;
            ih = (int)numericUpDown2.Value;
            kw = (int)numericUpDown3.Value;
            kh = (int)numericUpDown4.Value;
            s = (int)numericUpDown5.Value;
            p = (int)numericUpDown6.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            ow = conv(iw, kw, s, p);
            oh = conv(ih, kh, s, p);
            ListViewItem temp = new ListViewItem(iw.ToString() + "¡Á" + ih.ToString());
            
            temp.SubItems.Add(kw.ToString() + "¡Á" + kh.ToString());
            temp.SubItems.Add(s.ToString());
            temp.SubItems.Add(p.ToString());
            temp.SubItems.Add(ow.ToString() + "¡Á" + oh.ToString());
            listView1.Items.Add(temp);
            temp = new ListViewItem();
            numericUpDown1.Value = ow;
            numericUpDown2.Value = oh;
            button3.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            ow = conv(iw, kw, s, p);
            oh = conv(ih, kh, s, p);
            ListViewItem temp = new ListViewItem(iw.ToString() + "¡Á" + ih.ToString());

            temp.SubItems.Add(kw.ToString() + "¡Á" + kh.ToString());
            temp.SubItems.Add(s.ToString());
            temp.SubItems.Add("NaN");
            temp.SubItems.Add(ow.ToString() + "¡Á" + oh.ToString());
            listView1.Items.Add(temp);
            temp = new ListViewItem();
            numericUpDown1.Value = ow;
            numericUpDown2.Value = oh;
            button3.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int conv(int length, int kernel_length, int stride, int padding) {
            return (int)Math.Floor((decimal)((length - kernel_length + 2 * padding) / stride + 1));
        }
        private int maxpool(int length, int kernel_length, int stride) {
            return (int)Math.Floor((decimal)((length - kernel_length) / stride + 1));
        }
    }
}