﻿using DataBindingDemo.Models;

namespace DataBindingDemo
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage()
        {
            InitializeComponent();
         
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            var person = new Person
            {
                Name = "Hector",
                Phone = 999,
                Address = "X Address"
            };


            BindingContext = person;

            //txtName.BindingContext = person;
            //txtName.SetBinding(Label.TextProperty, "Name");

            //Binding personBinding = new Binding();

            //personBinding.Source = person;
            //personBinding.Path = "Name";

            //txtName.SetBinding(Label.TextProperty, personBinding);
        }
    }
}
