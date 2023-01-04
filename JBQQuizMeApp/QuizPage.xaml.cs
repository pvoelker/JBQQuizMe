namespace JBQQuizMeApp;

public partial class QuizPage : ContentPage
{
	public QuizPage(int? startQuestionNumber, int? endQuestionNumber, bool readQuestions)
	{
        InitializeComponent();

        this.Disappearing += QuizPage_Disappearing;

        var context = BindingContext as JBQQuizMe.ViewModel.QuizPage;

        context.StartQuestionNumber = startQuestionNumber;
        context.EndQuestionNumber = endQuestionNumber;
        context.ReadQuestions = readQuestions;

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        context.InitializeAsync();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
    }

    private void QuizPage_Disappearing(object sender, EventArgs e)
    {
        var context = BindingContext as JBQQuizMe.ViewModel.QuizPage;

        if (context != null)
        {
            context.StopQuestion();
        }
    }
}

