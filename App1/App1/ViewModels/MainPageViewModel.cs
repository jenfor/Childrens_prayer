using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using App1.FairyTale;

namespace App1.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private TheFairyTale fairyTale;

        public MainPageViewModel()
        {
            fairyTale = new TheFairyTale();
            Text = fairyTale.presentPage.Text;
            Image = fairyTale.presentPage.Emoji;

            ContinueFaryTale = new Command(() =>
            {
                fairyTale.presentPage.Text = Text;
                fairyTale.TurnThePage();
                Text = fairyTale.presentPage.Text;
                Image = fairyTale.presentPage.Emoji;
            });

            Back = new Command(() =>
            {
                fairyTale.presentPage.Text = Text;
                fairyTale.ViewLastPage();
                Text = fairyTale.presentPage.Text;
                Image = fairyTale.presentPage.Emoji;
            });
        }

    public event PropertyChangedEventHandler PropertyChanged;

        private string _text = String.Empty;
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                var args = new PropertyChangedEventArgs(nameof(Text));

                PropertyChanged?.Invoke(this, args);
            }
        }

        private string _image = "Image";
        public string Image
        {
            get => _image;
            set
            {
                _image = value;
                var args = new PropertyChangedEventArgs(nameof(Image));

                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command ContinueFaryTale { get;  }
        public Command Back { get; }


    }
}
