using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XSampleButton
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void Button_Clicked(object sender, System.EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Button Clicked");
            DisplayAlert("これはタイトルです", "これは表示するメッセージです", "はい");
        }
    }
}
