using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.Threading.Tasks;
using Xamarin.Essentials;
using App1.FairyTale;
using App1.Languages;

namespace App1.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private static Language language = new English();
        private TheFairyTale fairyTale = new TheFairyTale(language);

        public MainPageViewModel()
        {
            SwedishFairyTale = new Command(() =>
            {
                language = new Swedish();
                ShowFairyTale(language);
                SetButtonVisibilitys();
            });

            EnglishFairyTale = new Command(() =>
            {
                language = new English();
                ShowFairyTale(language);
                SetButtonVisibilitys();
            });

            NewFairyTale = new Command(() =>
            {
                CreateNewFairytale(language);
            });

            ContinueFairyTale = new Command(() =>
            {
                fairyTale.PresentPage.Text = Text;
                fairyTale.ViewNextPage(language);
                Text = fairyTale.PresentPage.Text;
                Image = fairyTale.PresentPage.Emoji;
                Placeholder = fairyTale.PresentPage.Palceholder;
                SetButtonVisibilitys();
            });

            ShareFairyTale = new Command(() =>
            {
                ShareFuction();
            });

            Back = new Command(() =>
            {
                fairyTale.PresentPage.Text = Text;
                if (fairyTale.ViewPreviousPage())
                {
                    Text = fairyTale.PresentPage.Text;
                    Image = fairyTale.PresentPage.Emoji;
                    Placeholder = fairyTale.PresentPage.Palceholder;
                    SetButtonVisibilitys();
                }
                else
                {
                    BackToStartPage(language);
                }
            });

            LinkClickCommand =  new Command<string>((url) =>
            {
                Device.OpenUri(new Uri(url));
            });

        }

        public async Task BackToStartPage(Language language)
        {
            var action = await App.Current.MainPage.DisplayAlert(language.Warning, language.BackToStartPageWarning, language.Yes, language.No);
            if (action)
            {
                StartColumnWidth = new GridLength(1, GridUnitType.Star);
                FairyTaleColumnWidth1 = new GridLength(0);
                FairyTaleColumnWidth2 = new GridLength(0);

                StartButtonVisibility = true;
            }
        }

        public async Task CreateNewFairytale(Language language)
        {
            var action = await App.Current.MainPage.DisplayAlert(language.Warning, language.Deletion, language.Yes, language.No);
            if (action)
            {
                ShowFairyTale(language);
                SetButtonVisibilitys();
            }
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

        private string _image = String.Empty;
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

        private string _placeholder = String.Empty;
        public string Placeholder
        {
            get => _placeholder;
            set
            {
                _placeholder = value;

                var args = new PropertyChangedEventArgs(nameof(Placeholder));
                PropertyChanged?.Invoke(this, args);
            }
        }

        private string _newFairytale = language.NewFairyTale;
        public string NewFairytale
        {
            get => _newFairytale;
            set
            {
                _newFairytale = value;

                var args = new PropertyChangedEventArgs(nameof(NewFairytale));
                PropertyChanged?.Invoke(this, args);
            }
        }

        private string _shareFairytale = language.ShareFairyTale;
        public string ShareFairytale
        {
            get => _shareFairytale;
            set
            {
                _shareFairytale = value;

                var args = new PropertyChangedEventArgs(nameof(ShareFairytale));
                PropertyChanged?.Invoke(this, args);
            }
        }

        private string _backFairytale = language.BackFairyTale;
        public string BackFairytale
        {
            get => _backFairytale;
            set
            {
                _backFairytale = value;

                var args = new PropertyChangedEventArgs(nameof(BackFairytale));
                PropertyChanged?.Invoke(this, args);
            }
        }

        private string _continueFairytale = language.ContinueFairyTale;
        public string ContinueFairytale
        {
            get => _continueFairytale;
            set
            {
                _continueFairytale = value;

                var args = new PropertyChangedEventArgs(nameof(ContinueFairytale));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public string StartImage
        {
            get
            {
                return fairyTale.GetRandomEmojis(language);
            }
        }

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

        private bool _startButtonVisibility = true;
        public bool StartButtonVisibility
        {
            get => _startButtonVisibility;
            set
            {
                _startButtonVisibility = value;

                var args = new PropertyChangedEventArgs(nameof(StartButtonVisibility));
                PropertyChanged?.Invoke(this, args);
            }
        }

        private GridLength _startColumnWidth = new GridLength(1, GridUnitType.Star);
        public GridLength StartColumnWidth
        {
            get => _startColumnWidth;
            set
            {
                _startColumnWidth = value;

                var args = new PropertyChangedEventArgs(nameof(StartColumnWidth));
                PropertyChanged?.Invoke(this, args);
            }
        }

        private GridLength _fairyTaleColumnWidth1 = new GridLength(0);
        public GridLength FairyTaleColumnWidth1
        {
            get => _fairyTaleColumnWidth1;
            set
            {
                _fairyTaleColumnWidth1 = value;

                var args = new PropertyChangedEventArgs(nameof(FairyTaleColumnWidth1));
                PropertyChanged?.Invoke(this, args);
            }
        }

        private GridLength _fairyTaleColumnWidth2 = new GridLength(0);
        public GridLength FairyTaleColumnWidth2
        {
            get => _fairyTaleColumnWidth2;
            set
            {
                _fairyTaleColumnWidth2 = value;

                var args = new PropertyChangedEventArgs(nameof(FairyTaleColumnWidth2));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command SwedishFairyTale { get; }
        public Command EnglishFairyTale { get; }
        public Command NewFairyTale { get; }
        public Command ContinueFairyTale { get; }
        public Command Back { get; }
        public Command ShareFairyTale { get; }
        public Command LinkClickCommand { get; }

    private void ShowFairyTale(Language language)
        {
            fairyTale = new TheFairyTale(language);

            Text = fairyTale.PresentPage.Text;
            Image = fairyTale.PresentPage.Emoji;
            Placeholder = fairyTale.PresentPage.Palceholder;

            StartColumnWidth = new GridLength(0);
            FairyTaleColumnWidth1 = new GridLength(1, GridUnitType.Star);
            FairyTaleColumnWidth2 = new GridLength(1, GridUnitType.Star);

            SetButtonVisibilitys();
        }

        private void SetButtonVisibilitys()
        {
            NewFairytale = language.NewFairyTale;
            ShareFairytale = language.ShareFairyTale;
            BackFairytale = language.BackFairyTale;
            ContinueFairytale = language.ContinueFairyTale;

            StartButtonVisibility = false;
            BackButtonVisibility = true;
        }

        private async void ShareFuction()
        {
            fairyTale.PresentPage.Text = Text;
            await ShareText(fairyTale.GetFairytaleString(language));
        }

        private async Task ShareText(string text)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = text,
                Title = "Fairytale"
            });
        }
    }
}
