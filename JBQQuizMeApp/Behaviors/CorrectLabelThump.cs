using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBQQuizMeApp.Behaviors
{
    public class CorrectLabelThump : Behavior<Label>
    {
        protected override void OnAttachedTo(Label control)
        {
            control.BindingContextChanged += Control_BindingContextChanged;

            base.OnAttachedTo(control);
        }

        protected override void OnDetachingFrom(Label control)
        {
            control.BindingContextChanged -= Control_BindingContextChanged;

            base.OnDetachingFrom(control);
        }

        private void Control_BindingContextChanged(object sender, EventArgs e)
        {
            var control = sender as Label;

            if (control != null)
            {
                var context = control.BindingContext as JBQQuizMe.ViewModel.QuizPage;

                if (context != null)
                {
                    context.CorrectAnswerGiven = new AsyncRelayCommand(async () =>
                    {
                        await control.ScaleTo(1.2, 250);
                        await control.ScaleTo(1.0, 250);
                    });
                }
            }
        }
    }
}
