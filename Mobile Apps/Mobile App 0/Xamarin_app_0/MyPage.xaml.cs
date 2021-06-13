using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin_app_0
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }

        void Slider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value is {0:F2}", e.NewValue); // Выводим ток 2 числа после запятой

        } 

    }
}
