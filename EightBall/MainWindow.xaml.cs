using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace EightBall
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAnswerClick(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            Thread.Sleep(1000);
            var answerGenerator = new AnswerGenerator();
            TextBoxAnswer.Text = answerGenerator.GetRandomAnswer(TextBoxQuestions.Text);
            Cursor = null;
        }
    }
}
