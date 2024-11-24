using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CONVERTOR.VISTAS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Convertir : ContentPage
	{

		double cm;
		double m;

		public Convertir ()
		{
			InitializeComponent ();
		}

		private void ccalcular()
		{
		cm= Convert.ToDouble( txtcm.Text);
			m = cm / 100;
            lblresultado.Text = m.ToString() + " m";

		}

		private void Validar()
		{
			if (!string.IsNullOrEmpty(txtcm.Text))
			{
				ccalcular();
			}
			else {
				DisplayAlert("ERROR", "Ingrese una canntidad", "ok");
					
					}

		}

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void btncalcular_Clicked(object sender, EventArgs e)
        {
          Validar();
        }
        
    }
}