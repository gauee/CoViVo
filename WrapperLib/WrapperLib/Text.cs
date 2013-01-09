using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{
    [Serializable]
    public class Text : Message
    {

        public String text
        { get; set; }

        public Text()
            : base()
        {
            text = "";
        }

    }
}
