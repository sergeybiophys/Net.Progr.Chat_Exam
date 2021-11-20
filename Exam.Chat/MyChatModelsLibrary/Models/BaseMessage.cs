using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatModelsLibrary.Models
{
    public class BaseMessage
    {
        public string Text { get; set; }
        public string From { get; set; }
        public string RemoteIP { get; set; }

    }
}
