﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Rtsp.Renderers
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
