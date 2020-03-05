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
                SetButtonVisibilitys();
            });

            Back = new Command(() =>
            {
                fairyTale.presentPage.Text = Text;
                fairyTale.ViewPreviousPage();
                Text = fairyTale.presentPage.Text;
                Image = fairyTale.presentPage.Emoji;
                SetButtonVisibilitys();
            });
        }

    public event PropertyChangedEventHandler PropertyChanged;

        private bool _backButtonVisibility = false;
        public bool BackButtonVisibility
        {
            get => _backButtonVisibility;
            set
            {
                _backButtonVisibility = value;

                var args = new PropertyChangedEventArgs(nameof(BackButtonVisibility));
                PropertyChanged?.Invoke(this, args);
            }
        }

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

        public void SetButtonVisibilitys()
        {
            if(fairyTale.pageNr>1)
            {
                BackButtonVisibility = true;
            }
            else
            {
                BackButtonVisibility = false;
            }
        }

        public Command ContinueFaryTale { get;  }
        public Command Back { get; }
    }
}
