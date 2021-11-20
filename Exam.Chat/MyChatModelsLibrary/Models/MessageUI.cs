using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyChatModelsLibrary.Models
{
    public class MessageUI
    {
        public string Message { set; get; }
        public string Sender { set; get; }
        public string Color { set; get; }
        public FontStyle FontStyle { set; get; }
        public string Align { set; get; }
    }
}
