using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBQQuizMeApp.Behaviors
{
    public class ImageJiggle : Behavior<Image>
    {
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

            if (control != null)
            {
                var context = control.BindingContext as JBQQuizMe.ViewModel.QuizPage;

                if (context != null)
                {
                    context.CandleJiggle = new AsyncRelayCommand(async () =>
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            await control.RotateTo(2, 50);
                            await control.RotateTo(-2, 50);
                        }
                        await control.RotateTo(0);
                    });
                }
            }
        }
    }
}
