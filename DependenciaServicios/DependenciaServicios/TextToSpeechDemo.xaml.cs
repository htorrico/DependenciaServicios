using DependenciaServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DependenciaServicios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextToSpeechDemo : ContentPage
    {
        public TextToSpeechDemo()
        {
            InitializeComponent();
            //var stack = new StackLayout();            
            //var speak = new Button
            //{
            //    Text = "Hello, Forms !",
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    HorizontalOptions = LayoutOptions.CenterAndExpand,
            //};
            //speak.Clicked += (sender, e) =>
            //{
            //    DependencyService.Get<ITextToSpeech>().Speak("Hello from Xamarin Forms");
            //};
            //stack.Children.Add(speak);

            //Content = speak;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<ITextToSpeech>().Speak(txtText.Text);            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DependencyService.Get<ITextToSpeech>().GoodMorning();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {             
            DisplayAlert("Alert", DependencyService.Get<IBattery>().Status.ToString(), "OK");
            DisplayAlert("Alert", DependencyService.Get<IBattery>().PowerSource.ToString(), "OK");
        }
    }
}