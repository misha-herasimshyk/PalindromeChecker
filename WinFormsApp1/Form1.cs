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
                    resultLabel.Text = "Введене слово є паліндромом.";
                }
                else
                {
                    resultLabel.Text = "Введене слово не є паліндромом.";
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                throw new ArgumentException("Заповніть рядок для введеня.");
            }

            
            string processedInput = System.Text.RegularExpressions.Regex.Replace(input, @"[^а-яА-Яa-zA-Z]", "").ToLower();

            
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