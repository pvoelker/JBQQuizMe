using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBQQuizMeApp.Behaviors
{
    public class ImageSparkle : Behavior<Image>
    {
        private Random _rand = new Random();

        protected override void OnAttachedTo(Image control)
        {
            control.BindingContextChanged += Control_BindingContextChanged;

            base.OnAttachedTo(control);
        }

        protected override void OnDetachingFrom(Image control)
        {
            control.BindingContextChanged -= Control_BindingContextChanged;

            base.OnDetachingFrom(control);
        }

        private void Control_BindingContextChanged(object sender, EventArgs e)
        {
            var control = sender as Image;

            var context = control.BindingContext as JBQQuizMe.ViewModel.QuizPage;

            if (context != null)
            {
                context.CandleSparkle = new AsyncRelayCommand(async () =>
                {
                    control.Scale = .25;
                    control.Rotation = _rand.Next(0, 360);

                    control.IsVisible = true;

                    await control.ScaleTo(2, 250);

                    control.IsVisible = false;
                });
            }
        }
    }
}
