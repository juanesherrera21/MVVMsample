using MVVMsample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace MVVMsample
{
    public partial class MainPage : ContentPage
    {

        public Persona currentPersona { get; set; }
        public MainPage()
        {
            InitializeComponent();
            loadData();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Saving","Saving Data","Ok");

        }

        public void loadData() {
            //connection  to web services

            currentPersona = new Persona()
            {
                Name="Hector",Phone="000999",Addres="XXX"

            };

            txtName.Text = currentPersona.Name;

            txtPhone.Text = currentPersona.Phone;

            txtAddres.Text = currentPersona.Addres;
        
        }
    }
}
