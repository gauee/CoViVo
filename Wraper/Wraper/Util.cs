using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wraper
{
    class Util
    {
        private String tmp;


        public String WrapWithTag(String msg, String openTag, String closeTag) {
            return openTag + msg + closeTag; 
        }

        public String UnwrapTags(String toUnwrap, String openTag, String closeTag) {
            int i,j;
            Boolean found=false;
            
            int startIndex, endIndex;
            int size = toUnwrap.Length;
            tmp = "";
            i = j = 0;
            if (toUnwrap.Contains(openTag) == false)
            {
                return "";
            }
            for (i = 0, found = false; i < size && !found; i++)
            {
                for (j = 0; i + j < toUnwrap.Length && j< openTag.Length && toUnwrap.ElementAt(i + j) == openTag.ElementAt(j); j++)
                {
                    //Console.Write(toUnwrap.ElementAt(i + j));
                   if (j == (openTag.Length - 1)) 
                    {
                        found = true;
                    }
                }
                
            }
            startIndex = i + j -1;
            //Console.WriteLine();
            for (i = 0, found = false; i < size && !found; i++)
            {
                for (j = 0; i + j < toUnwrap.Length && j < closeTag.Length && toUnwrap.ElementAt(i + j) == closeTag.ElementAt(j); j++)
                {
                    //Console.Write(toUnwrap.ElementAt(i+j));
                    if (j == (closeTag.Length - 1))
                    {
                        found = true;
                    }

                }
                
            }
            //Console.WriteLine();
            endIndex = i-1 ;
            for (i = startIndex; i < endIndex; i++)
            {
                tmp = tmp + toUnwrap.ElementAt(i);
               // Console.WriteLine(tmp);
            }
            //Console.WriteLine();
                return tmp;
        }
    }
}
