using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ssuarezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        string user;
        public Resumen(string user, string name, string lastName, string yearOld, string dateNow, string country, string city, string ammountInitial, string ammountMounth)
        {
            InitializeComponent();

            this.user = user;

            lblUserConnect.Text = "Usuario conectado: " + user;

            txtName.Text = name;
            txtLastName.Text = lastName;    
            txtYearOld.Text = yearOld;
            txtDateNow.Text = dateNow;
            txtCountry.Text = country;
            txtCity.Text = city;
            txtAmmountInitial.Text = ammountInitial;
            txtAmmountMonth.Text = ammountMounth;
            txtTotal.Text = (Convert.ToDouble(ammountInitial) + (Convert.ToDouble(ammountMounth)*4)).ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}