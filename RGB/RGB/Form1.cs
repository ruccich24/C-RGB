namespace RGB
{
    public partial class Form1 : Form
    {
        static int r = 255, g = 255, b = 255, a = 255;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(r, g, b);

            trbR.Value = r; trbG.Value = r; trbB.Value = b; trbA.Value = a;


        }

        private void trbR_Scroll(object sender, EventArgs e)
        {
            if (sender == trbR)
            { tbR.Text = trbR.Value.ToString(); r = trbR.Value; }
            else if (sender == trbG)
            { tbG.Text = trbG.Value.ToString(); g = trbG.Value; }
            else if (sender == trbB)
            { tbB.Text = trbB.Value.ToString(); b = trbB.Value; }
            else if (sender == trbA)
            { tbA.Text = trbA.Value.ToString(); a = trbA.Value; }


            pictureBox1.BackColor = Color.FromArgb(a, r, g, b);

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btCopyRGB_Click(object sender, EventArgs e)
        {
            string raz = cbRaz.Text;
            string rgb = $"{r.ToString()}{raz} {g.ToString()}{raz} {b.ToString()}";

            if (rbIsA.Checked)
            {
                rgb = $"{a.ToString()}{raz} {r.ToString()}{raz} {g.ToString()}{raz} {b.ToString()}";
            }
            
            Clipboard.SetData(DataFormats.Text, (Object)rgb);
            //MessageBox.Show(Clipboard.GetText());
            tsl1.Text = Clipboard.GetText();
        }

       
    }
}
