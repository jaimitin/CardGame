using CardGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CardGame.Views
{
    public partial class CardView : ContentView
    {
        public CardView()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public Creature Creature
        {
            get => (Creature)GetValue(CreatureProperty);
            set =>  SetValue(CreatureProperty, value);
        }
        public static BindableProperty CreatureProperty = BindableProperty.Create("Creature", typeof(Creature), typeof(CardView));
    }
}