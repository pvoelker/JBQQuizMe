using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBQQuizMeApp.Behaviors
{
    public class ImageSpinOut : Behavior<Image>
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

            var context = control.BindingContext as JBQQuizMe.ViewModel.QuizPage;

            if (context != null)
            {
                context.Celebration = new AsyncRelayCommand(async () =>
                {
                    await control.ScaleTo(.25, 0);
                    await control.RotateTo(0, 0);

                    control.IsVisible = true;

                    await Task.WhenAny
                    (
                        control.RelRotateTo(360, 1000),
                        control.ScaleTo(1, 1000)
                    );
                    await Task.WhenAny
                    (
                        control.RelRotateTo(360, 1000),
                        control.ScaleTo(4, 1000)
                    );
                    await Task.WhenAny
                    (
                        control.RelRotateTo(360, 1000),
                        control.ScaleTo(1, 1000)
                    );
                    await Task.WhenAny
                    (
                        control.RelRotateTo(360, 1000),
                        control.ScaleTo(.25, 1000)
                    );

                    control.IsVisible = false;

                    await control.ScaleTo(.25, 0);
                    await control.RotateTo(0, 0);
                });
            }
        }
    }
}
