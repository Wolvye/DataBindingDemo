using DataBindingDemo.Models;
using System.ComponentModel;

namespace DataBindingDemo
{
    public partial class MainPage : ContentPage
    {
        Person person = new Person();


        public MainPage()
        {
            InitializeComponent();
            person = new Person
            {
                Name = "Hector",
                Phone = 999,
                Address = "X Address"
            };
            BindingContext = person;
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {

            //person.Name = "Peter";
            //person.Phone = 0000;
            //person.Address = "Some new Address";

            person = new Person
            {
                Name = "Peter",
                Phone = 0000,
                Address = "Some new Address",
            };

            

            //txtName.BindingContext = person;
            //txtName.SetBinding(Label.TextProperty, "Name");

            //Binding personBinding = new Binding();

            //personBinding.Source = person;
            //personBinding.Path = "Name";

            //txtName.SetBinding(Label.TextProperty, personBinding);
        }
    }
}
