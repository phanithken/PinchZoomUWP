using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinchZoomUWP
{
    public class MyImage
    {
        public MyImage()
        {
        }

        public MyImage(string uri)
        {
            this.Path = uri;
        }

        public string Path { get; set; }
    }
}
