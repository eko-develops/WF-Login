namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = usernameField.Text;
            password = passwordField.Text;


            Console.WriteLine(username + ":" + password);
        }
    }
}