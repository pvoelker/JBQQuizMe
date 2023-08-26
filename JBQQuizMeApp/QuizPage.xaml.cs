using JBQQuizMe.ViewModel;

namespace JBQQuizMeApp;

public partial class QuizPage : ContentPage
{
	public QuizPage(int? startQuestionNumber, int? endQuestionNumber, bool readQuestions)
	{
        InitializeComponent();

        this.Disappearing += QuizPage_Disappearing;

        var context = BindingContext as JBQQuizMe.ViewModel.QuizPage;

        if (context != null)
        {
            context.StartQuestionNumber = startQuestionNumber;
            context.EndQuestionNumber = endQuestionNumber;
            context.ReadQuestions = readQuestions;

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            context.InitializeAsync();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }
        else
        {
            throw new NullReferenceException("Context cannot be null");
        }
    }

    private void QuizPage_Disappearing(object sender, EventArgs e)
    {
        var context = BindingContext as JBQQuizMe.ViewModel.QuizPage;

        if (context != null)
        {
            context.StopQuestion();
        }
        else
        {
            throw new NullReferenceException("Context cannot be null");
        }
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        try
        {
            var selectedQuestion = e.CurrentSelection.FirstOrDefault() as Answer;

            var collView = sender as CollectionView;

            if (collView != null)
            {
                if (selectedQuestion != null)
                {
                    collView.ScrollTo(selectedQuestion);
                }
            }
        }
        catch(Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"An error occurred while changing selection: { ex }");
        }
    }
}