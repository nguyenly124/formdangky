
namespace Font_dang_ky
{
    using System.Text.RegularExpressions;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  
            string email = Email.Text;
            string password = Pass.Text;

            // Kiểm tra thông tin (có thể thêm điều kiện như kiểm tra rỗng)
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) )
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng kiểm tra lại.");
                return;
            }
            if (!IsValidPasword(password))
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Yêu cầu tối thiểu 8 ký tự và phải bao gồm ít nhất 1 ký tự đặc biệt.");
                return;
            }
            // Thêm logic để lưu thông tin vào cơ sở dữ liệu hoặc file
            MessageBox.Show("Đăng ký thành công!");
            }

        private bool IsValidPasword(string password)
        {
            string pattern = @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email,pattern);
        }
    }
}
