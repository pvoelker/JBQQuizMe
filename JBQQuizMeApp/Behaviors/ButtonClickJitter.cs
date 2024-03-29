﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBQQuizMeApp.Behaviors
{
    public class ButtonClickJitter : Behavior<BetterButton>
    {
        protected override void OnAttachedTo(BetterButton control)
        {
            control.Clicked += Control_Clicked;
            base.OnAttachedTo(control);
        }

        protected override void OnDetachingFrom(BetterButton control)
        {
            control.Clicked -= Control_Clicked;
            base.OnDetachingFrom(control);
        }

        private async void Control_Clicked(object sender, EventArgs e)
        {
            var control = sender as BetterButton;

            if (control != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    await control.RotateTo(1, 50);
                    await control.RotateTo(-1, 50);
                }
                await control.RotateTo(0, 50);
            }
        }
    }
}
