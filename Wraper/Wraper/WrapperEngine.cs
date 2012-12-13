using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wraper
{
    class WrapperEngine
    {
        private String wrappingMsg;

        private String comWrapMsg;
        public CommunicationWrapper comWrap;

        private String errWrapMsg;
        public ErrorWrapper errWrap;

        private String msgWrapMsg;
        public MessageWrapper msgWrap;

        private Util util;

        public WrapperEngine() {
            wrappingMsg = "";
            comWrapMsg = "";
            errWrapMsg = "";
            msgWrapMsg = "";

            util = new Util();
            comWrap = new CommunicationWrapper();
            errWrap = new ErrorWrapper();
            msgWrap = new MessageWrapper();
        }

        public void SetComWrapMsg(string comWrapMsg)
        {
            this.comWrapMsg = comWrapMsg;
        }

        public String GetComWrapMsg()
        {
            return this.comWrapMsg;
        }
         
        public void SetErrWrapMsg(string errWrapMsg)
        {
            this.errWrapMsg = errWrapMsg;
        }

        public String GetErrWrapMsg()
        {
            return this.errWrapMsg;
        }

        public void SetMsgWrapMsg(string msgWrapMsg)
        {
            this.msgWrapMsg = msgWrapMsg;
        }

        public String GetMsgWrapMsg()
        {
            return this.msgWrapMsg;
        }

        public String Wrap()
        {
            comWrapMsg = comWrap.Wrap();
            errWrapMsg = errWrap.Wrap();
            msgWrapMsg = msgWrap.Wrap();
            wrappingMsg = "";
            wrappingMsg += util.WrapWithTag(comWrapMsg, Constants.otCommunicationWrapper, Constants.ctCommunicationWrapper);
            wrappingMsg += util.WrapWithTag(errWrapMsg, Constants.otErrorWrapper, Constants.ctErrorWrapper);
            wrappingMsg += util.WrapWithTag(msgWrapMsg, Constants.otMessageWrapper, Constants.ctMessageWrapper);
            return util.WrapWithTag(wrappingMsg, Constants.otWrapperEngine, Constants.ctWrapperEngine);
        }

        public void Unwrap(String toUnwrap)
        {
            wrappingMsg = util.UnwrapTags(toUnwrap, Constants.otWrapperEngine, Constants.ctWrapperEngine);
            comWrapMsg = util.UnwrapTags(wrappingMsg, Constants.otCommunicationWrapper, Constants.ctCommunicationWrapper);
            errWrapMsg = util.UnwrapTags(wrappingMsg, Constants.otErrorWrapper, Constants.ctErrorWrapper);
            msgWrapMsg = util.UnwrapTags(wrappingMsg, Constants.otMessageWrapper, Constants.ctMessageWrapper);

            comWrap.Unwrap(comWrapMsg);
            errWrap.Unwrap(errWrapMsg);
            msgWrap.Unwrap(msgWrapMsg);
        }
    }
}
