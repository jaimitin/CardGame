using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace CardGame.Models
{
    public class Creature : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        private Image _image;
        public Image Image
        {
            get => _image;
            set
            {
                _image = value;
                NotifyPropertyChanged();
            }
        }

        private int _attack;
        public int Attack
        {
            get => _attack;
            set
            {
                _attack = value;
                NotifyPropertyChanged();
            }
        }

        private int _health;
        public int Health
        {
            get => _health;
            set
            {
                _health = value;
                NotifyPropertyChanged();
            }
        }
    }
}
