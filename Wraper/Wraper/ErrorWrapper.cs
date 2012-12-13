using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wraper
{
    class ErrorWrapper
    {
        private String error;
        private String wrappingMsg;
        private Util util;

        public ErrorWrapper() {
            util = new Util();
            error = "";
            wrappingMsg = "";
        }

        public void SetError(string error) {
            this.error = error;
        }

        public String GetError () { 
            return this.error;
        }

        public String Wrap() {
                wrappingMsg = util.WrapWithTag(error, Constants.otErr, Constants.ctErr);            
            return wrappingMsg;
        }

        public void Unwrap(String toUnwrap) {
                error = util.UnwrapTags(toUnwrap, Constants.otErr, Constants.ctErr);
        }
        
    }
}
