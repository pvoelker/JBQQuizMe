namespace JBQQuizMeApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void QuizMe_Clicked(object sender, EventArgs e)
	{
		var context = BindingContext as JBQQuizMe.ViewModel.MainPage;

		var errors = context.GetErrors();

		if (errors.Count() > 0)
		{
			await DisplayAlert("Cannot Start Quizzing", string.Join(Environment.NewLine, errors.DistinctBy(x => x.ErrorMessage).Select(x => $"• {x.ErrorMessage}")), "OK");
		}
		else
		{
			await Navigation.PushAsync(new QuizPage(context.StartQuestionNumber, context.EndQuestionNumber));
		}
	}
}

