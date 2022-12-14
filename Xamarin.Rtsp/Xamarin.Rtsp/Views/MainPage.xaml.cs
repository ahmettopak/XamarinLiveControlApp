using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Rtsp.Models;
using Xamarin.Rtsp.Renderers;
using Xamarin.Rtsp.Services;
using Xamarin.Rtsp.ViewModels;
using Xamarin.Rtsp.Views;

namespace Xamarin.Rtsp
{
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel => BindingContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel(DependencyService.Get<INavService>());
            Navigation.PushAsync(new CameraViewPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel?.Init();
        }

        void New_Clicked(object sender, EventArgs e)
        {
 //           Navigation.PushAsync(new NewCameraPage());
        }

        private async void cameras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var camera = (CameraEntry)e.CurrentSelection.FirstOrDefault();

            if (camera != null)
            {
                await Navigation.PushAsync(new CameraViewPage());
            }

            //cameras.SelectedItem = null;
        }
    }
}
