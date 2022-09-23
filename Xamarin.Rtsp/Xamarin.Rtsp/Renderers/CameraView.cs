using Xamarin.Forms;

namespace Xamarin.Rtsp.Renderers
{
    public class CameraView : View
    {
        public string Url = "rtsp://192.168.1.10:554/user=admin&password=EXLXEXKX&channel=2&stream=0.sdp?";
        public string User = "admin";
        public string Password = "EXLXEXKX";

        public CameraView()
        { 
        }
    }
}
