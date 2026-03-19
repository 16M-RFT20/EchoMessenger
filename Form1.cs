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

            if (typed_msg.Length > 50)
            {
                MessageBox.Show("메시지는 50자 이내로 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 메시지가 50자를 초과할 경우 경고 메시지 표시

            string result = $"[{DateTime.Now:HH:mm:ss}] {typed_msg.Trim()}";
            mylistBox.Items.Add(result);
            // ListBox에 현재 시간과 입력된 메시지를 추가, 메시지 양쪽의 공백 제거

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
            int length = myTextBox.Text.Length;
            // TextBox에 입력된 텍스트의 길이를 계산

            lblTextLength.Text = $"{length} / 50";
            // lblTextLength 라벨에 현재 입력된 텍스트의 길이와 최대 길이(50)를 표시
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mylistBox.SelectedIndex != -1)
            // ListBox에서 선택된 항목이 있지 확인
            {
                mylistBox.Items.RemoveAt(mylistBox.SelectedIndex);
                // 선택된 항목을 ListBox에서 제거

                lblCount.Text = $"현재대화: {mylistBox.Items.Count}개";
                // 삭제 후 개수 표시 업데이트

                myTextBox.Focus();
            }  
        }

        private void btnAllDelete_Click(object sender, EventArgs e)
        {
            mylistBox.Items.Clear();
            // ListBox의 모든 항목을 제거

            lblCount.Text = $"현재대화: {mylistBox.Items.Count}개";
            // 삭제 후 개수 표시 업데이트

            myTextBox.Focus();
        }
    }
}
