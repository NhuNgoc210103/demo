namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private object txtName;
        private object dtpBirthday;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Dob = dtpBirthday.Text;
            string Level = cboLevel.Text;
            string Sex = "";
            if (rdoMale.Checked == true)
                Sex = "Nam";
            else Sex = "Nữ";
            string Accept = "";
            if (chkregister.Checked == true) Accept = "Đồng ý";
            else Accept = "Không đồng ý";
            string Result = "Thí sinh" + Name + "sinh ngày" + Dob + "Giới tính" + Sex + "Trình độ" + Level + "Đăng ký học" + Accept;
            MessageBox.Show(Result);
        }
    }
}