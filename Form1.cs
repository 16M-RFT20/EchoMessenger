namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTransmit_Click(object sender, EventArgs e)
        {
            string typed_msg;
            typed_msg = myTextBox.Text;
            mylistBox.Items.Add(typed_msg);
            // TextBox에 입력된 내용을 ListBox에 추가

            myTextBox.Clear();
            // TextBox의 내용을 지움
        }
    }
}
