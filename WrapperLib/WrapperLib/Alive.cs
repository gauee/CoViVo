using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{
    [Serializable]
    public class Alive : ServerMsg
    {
        public int token
        { get; set; }
        public Alive() : base() { int token = 0; }
    }
}
