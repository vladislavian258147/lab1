namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load("../../../../Pictures/" + imgList[0]);
            pictureBox2.Load("../../../../Pictures/" + imgList[1]);
            pictureBox3.Load("../../../../Pictures/" + imgList[2]);
        }

        String[] imgList = new string[] { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "1.jpg", "2.jpg", };

        int index = 0;


        private void PhotoRightArrow_Click(object sender, EventArgs e)
        {
            index++;
            if (index == 8) index = 0;
            pictureBox1.Load("../../../../Pictures/" + imgList[index]);
            pictureBox2.Load("../../../../Pictures/" + imgList[index + 1]);
            pictureBox3.Load("../../../../Pictures/" + imgList[index + 2]);
        }

        private void PhotoLeftArrow_Click(object sender, EventArgs e)
        {
            index--;
            if (index == 0) index = 7;
            pictureBox1.Load("../../../../Pictures/" + imgList[index]);
            pictureBox2.Load("../../../../Pictures/" + imgList[index + 1]);
            pictureBox3.Load("../../../../Pictures/" + imgList[index + 2]);
        }
    }
}