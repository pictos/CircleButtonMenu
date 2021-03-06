﻿using CircleButtonMenu.Abstractions;
using System;
using Xamarin.Forms;

namespace CircleButtonMenuSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new
            {
                Controls = new[] { "waves", "save", "sound" },
                ChangeDirection = new Command<Direction>(OnChangeDirection)
            };
        }

        private void OnChangeDirection(Direction direction)
        {
            Menu.Direction = direction;
        }
    }
}
