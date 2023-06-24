using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ssuarezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string user;

        public Registro(string user)
        {
            InitializeComponent();

            this.user = user;

            lblUserConnect.Text = "Usuario conectado: " + user;
        }

        private void txtAmmountInitial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtAmmountInitial.Text))
                {
                    double ammount = Convert.ToDouble(txtAmmountInitial.Text);

                    if (ammount > 1500)
                    {
                        DisplayAlert("Error", "El valor inicial no puede ser mayor a $1500", "Cerrar");
                    }
                }
            }
            catch (Exception)
            {

            }
             
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double ammountInitial = 1500;
            double ammount = Convert.ToDouble(txtAmmountInitial.Text);
            double tax = ammountInitial * 0.04;

            double subtotal = (ammountInitial - ammount) / 4;

            double total = subtotal + tax;

            txtAmmountMounth.Text = total.ToString();

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text;
            string yearOld = txtYearOld.Text;
            string dateNow = dpkDate.Date.ToString();
            string country = pkCountry.Items[pkCountry.SelectedIndex];
            string city = pkCity.Items[pkCity.SelectedIndex];
            string ammountInitial = txtAmmountInitial.Text;
            string ammountMounth = txtAmmountMounth.Text;

            Navigation.PushAsync(new Resumen(this.user, name, lastName, yearOld, dateNow, country, city, ammountInitial, ammountMounth));
        }
    }
}