namespace JBQQuizMeApp;

public partial class QuizPage : ContentPage
{
	public QuizPage(int? startQuestionNumber, int? endQuestionNumber)
	{
        InitializeComponent();

        var context = BindingContext as JBQQuizMe.ViewModel.QuizPage;

        context.StartQuestionNumber = startQuestionNumber;
        context.EndQuestionNumber = endQuestionNumber;

        context.Initialize();
    }
}

