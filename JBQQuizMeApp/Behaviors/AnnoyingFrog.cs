using CommunityToolkit.Mvvm.Input;
using JBQQuizMe.ViewModel.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBQQuizMeApp.Behaviors
{
    public class AnnoyingFrog : Behavior<ImageButton>
    {
        private Random _rand = new Random();

        protected override void OnAttachedTo(ImageButton control)
        {
            control.BindingContextChanged += Control_BindingContextChanged;

            control.Clicked += Control_Clicked;
            
            base.OnAttachedTo(control);
        }

        protected override void OnDetachingFrom(ImageButton control)
        {
            control.BindingContextChanged -= Control_BindingContextChanged;

            control.Clicked -= Control_Clicked;

            base.OnDetachingFrom(control);
        }

        private async void Control_Clicked(object sender, EventArgs e)
        {
            var control = sender as ImageButton;

            control.Scale = 1;

            await control.ScaleTo(1.1, 100);
            await control.ScaleTo(0, 500);

            control.IsVisible = false;
        }

        private void Control_BindingContextChanged(object sender, EventArgs e)
        {
            var control = sender as ImageButton;

            var context = control.BindingContext as JBQQuizMe.ViewModel.QuizPage;

            if (context != null)
            {
                context.ShowFrog = new AsyncRelayCommand(async () =>
                {
                    control.Scale = 0;

                    control.Rotation = _rand.Next(-40, 40);

                    control.IsVisible = true;

                    await control.ScaleTo(_rand.NextDoubleLinear(1.0, 1.5), 250);
                });
            }
        }
    }
}
