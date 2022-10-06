using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Rtsp.Models;
using UDP_Control;
namespace Xamarin.Rtsp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraViewPage : ContentPage
    {
        
        public CameraViewPage()
        {
            string RobotIp = "192.168.1.3";
            string PanelIp = "192.168.1.2";
            int PanelPort = 10006;
            int RobotPort = 10006;
            InitializeComponent();

            UdpControl server = new UdpControl(PanelIp, PanelPort);
            string receivedMessage = server.Echo();



        }
    }
}