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

            string result = $"[{DateTime.Now:HH:mm:ss}] {typed_msg. Trim()}";
            mylistBox.Items.Add(result);
            // ListBox에 현재 시간과 입력된 메시지를 추가, 메시지 양쪽의 공백 제거d

            myTextBox.Clear();
            // TextBox의 내용을 지움

            myTextBox.Focus();
            // TextBox에 포커스 설정

            lblCount.Text = $"현재대화: {mylistBox.Items.Count}개";
            // ListBox에 있는 아이템의 개수를 lblCount에 표시
        }   

        private void btnTransmit_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void myTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}
