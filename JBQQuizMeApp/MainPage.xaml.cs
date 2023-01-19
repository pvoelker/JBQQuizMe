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
			await Navigation.PushAsync(new QuizPage(context.StartQuestionNumber, context.EndQuestionNumber, context.ReadQuestions));
		}
	}

	private async void InfoButton_Clicked(object sender, EventArgs e)
	{
        var context = BindingContext as JBQQuizMe.ViewModel.MainPage;
        
		var builder = new StringBuilder();
        builder.AppendLine("JBQ Quiz Me!");
		if (context.Copyright != null)
		{
			builder.AppendLine(context.Copyright);
		}
		builder.AppendLine("MIT License");
		if (context.Version != null)
		{
			builder.AppendLine($"Version: {context.Version}");
		}

        builder.AppendLine(string.Empty);
		builder.AppendLine("• Questions are based on 10 point questions from the Bible Fact-Pak™ (https://biblefactpak.com/)");
		builder.AppendLine("• Questions are sourced from the New Living Translation (NLT) version of the Bible");
		builder.AppendLine("• Designed and developed by Paul Voelker of Faith Chapel - Overland Park");

        // PEV - 1/18/2023 - Limiting the amount of text due to an issue in MacOS (Catalyst): https://github.com/dotnet/maui/issues/11766
        if (DeviceInfo.Current.Platform != DevicePlatform.MacCatalyst)
        {
            builder.AppendLine("• Questions transcribed by Pastor Michelle Redmon of Faith Chapel - Overland Park");
			builder.AppendLine("• Given to the glory of God");
		}

        await DisplayAlert("About Game", builder.ToString(), "OK");
	}
}

