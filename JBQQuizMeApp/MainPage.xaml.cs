using System.Text;

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

	private async void InfoButton_Clicked(object sender, EventArgs e)
	{
        var context = BindingContext as JBQQuizMe.ViewModel.MainPage;
        
		var builder = new StringBuilder();
        builder.AppendLine("JBQ Quiz Me❗");
		builder.AppendLine(context.Copyright);
		builder.AppendLine("MIT License");
        builder.AppendLine($"Version: {context.Version}");
		builder.AppendLine(string.Empty);
		builder.AppendLine("• Questions are based on 10 point questions from the Bible Fact-Pak™ (https://biblefactpak.com/)");
		builder.AppendLine("• Designed and developed by Paul Voelker of Faith Chapel - Overland Park");
        builder.AppendLine("• Questions transcribed by Pastor Michelle Redmon of Faith Chapel - Overland Park");
        builder.AppendLine("• Given to the glory of God");

        await DisplayAlert("Information", builder.ToString(), "OK");
	}
}

