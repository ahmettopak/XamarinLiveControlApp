using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Rtsp.Models
{
    public class CameraEntry
    {
        //public string Name { get; set; }
        public string Url = "rtsp://192.168.1.10:554/user=admin&password=EXLXEXKX&channel=2&stream=0.sdp?";
        public string Username = "admin";
        public string Password = "EXLXEXKX";

        public bool VideoEnable = true;
        public bool AudioEnable = true;
        //public string Domain
        //{
        //    get
        //    {
        //        if ((Url ?? "") != "")
        //        {
        //            Uri myUri = new Uri(Url);
        //            return myUri.Host;
        //        }
        //        return "";
        //    }
        //}
    }
}
