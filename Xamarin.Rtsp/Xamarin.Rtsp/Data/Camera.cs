using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Rtsp.Data
{
    public class Camera : BaseEntity
    {
        //public string Name { get; set; }
        public string Url = "rtsp://192.168.1.10:554/user=admin&password=EXLXEXKX&channel=2&stream=0.sdp?";
        public string Username = "admin";
        public string Password = "EXLXEXKX";
        public bool VideoEnable = true;
        public bool AudioEnable = true;
    }
}
