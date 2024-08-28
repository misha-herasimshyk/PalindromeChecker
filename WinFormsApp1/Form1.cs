namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private PalindromeChecker palindromeChecker;

        public Form1()
        {
            InitializeComponent();
            palindromeChecker = new PalindromeChecker();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;

            try
            {
                if (palindromeChecker.IsPalindrome(input))
                {
                    resultLabel.Text = "������� ����� � ����������.";
                }
                else
                {
                    resultLabel.Text = "������� ����� �� � ����������.";
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


    public class PalindromeChecker
    {
        
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("�������� ����� ��� �������.");
            }

            
            string processedInput = System.Text.RegularExpressions.Regex.Replace(input, @"[^�-��-�a-zA-Z]", "").ToLower();

            
            return processedInput == ReverseString(processedInput);
        }

       
        private string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}