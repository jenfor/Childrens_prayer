﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using App1.FairyTale;
using App1.Languages;

namespace App1.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private TheFairyTale fairyTale;
        private Language language;

        public MainPageViewModel()
        {
            SwedishFairyTale = new Command(() =>
            {
                language = new Swedish();
                ShowFairyTale(language);
            });

            EnglishFairyTale = new Command(() =>
            {
                language = new English();
                ShowFairyTale(language);
            });

            NewFairyTale = new Command(() =>
            {
                ShowFairyTale(language);
            });

            ContinueFairyTale = new Command(() =>
            {
                fairyTale.PresentPage.Text = Text;
                fairyTale.TurnThePage(language);
                Text = fairyTale.PresentPage.Text;
                Image = fairyTale.PresentPage.Emoji;
                SetButtonVisibilitys();
            });

            Back = new Command(() =>
            {
                fairyTale.PresentPage.Text = Text;
                fairyTale.ViewPreviousPage();
                Text = fairyTale.PresentPage.Text;
                Image = fairyTale.PresentPage.Emoji;
                SetButtonVisibilitys();
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

        private void ShowFairyTale(Language language)
        {
            fairyTale = new TheFairyTale(language);

            Text = fairyTale.PresentPage.Text;
            Image = fairyTale.PresentPage.Emoji;

            StartColumnWidth = new GridLength(1);
            FairyTaleColumnWidth1 = new GridLength(1, GridUnitType.Star);
            FairyTaleColumnWidth2 = new GridLength(1, GridUnitType.Star);

            SetButtonVisibilitys();
        }

        private void SetButtonVisibilitys()
        {
            if (fairyTale.PageNr > 1)
            {
                BackButtonVisibility = true;
            }
            else
            {
                BackButtonVisibility = false;
            }
        }
    }
}
