using CardGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CardGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            card.Creature = new Creature()
            {
                Name = "Cat",
                Attack = 0,
                Health = 2
            };
        }
    }
}
