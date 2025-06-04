using DataBindingDemo.Models;

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
            Name = "John",
            Phone = "999",
            Address = "X Address" 
            };
        }
    }
}
