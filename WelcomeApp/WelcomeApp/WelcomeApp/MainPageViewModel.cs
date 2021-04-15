using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace WelcomeApp.ViewModels
{
    public class MainPageViewModel:INotifyPropertyChanged

    {
        public MainPageViewModel()
        {
            EraseCommand = new Command(() =>
            {
                TheNote = string.Empty;
            });

            SaveCommand = new Command(() =>
            {
                AllNotes.Add(TheNote);
                TheNote = string.Empty;
            });
            
        }

        public ObservableCollection<string> AllNotes { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        string theNote;
        public string TheNote
        {
            get => theNote;
            set
            {
                theNote = value;
                var args = new PropertyChangedEventArgs(nameof(TheNote));
                PropertyChanged?.Invoke(this, args);
            }
        }

        Command SaveCommand { get; }
        Command EraseCommand { get; }

    }
}
