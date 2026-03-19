namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnTransmit;
            // Enter 키를 누르면 btnTransmit 버튼이 클릭되도록 설정
        }

        private void btnTransmit_Click(object sender, EventArgs e)
        {
            string typed_msg = myTextBox.Text;

            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                myTextBox.Clear();
                myTextBox.Focus();
                return;
            }
            // 내용이 빈 문자열이거나 공백만 있을 경우 전송하지 않음

            mylistBox.Items.Add(typed_msg);
            // TextBox에 입력된 내용을 ListBox에 추가

            myTextBox.Clear();
            // TextBox의 내용을 지움

            myTextBox.Focus();
            // TextBox에 포커스 설정
        }

        private void btnTransmit_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
