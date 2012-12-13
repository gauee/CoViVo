using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wraper
{
    class MessageWrapper
    {
        private String audioMsg;
        private String videoMsg;
        private String chatMsg;
        private String wrappingMsg;
        private Util util;

        public MessageWrapper() {
            util = new Util();
            wrappingMsg = "";
            audioMsg = "";
            videoMsg = "";
            chatMsg = "";
        }

        public void SetAudioMsg(string audio) {
            this.audioMsg = audio;
        }

        public String GetAudioMsg () { 
            return this.audioMsg;
        }

        public void SetVideoMsg(string video)
        {
            this.videoMsg = video;
        }

        public String GetVideoMsg()
        {
            return this.videoMsg;
        }
        public void SetChatMsg(string chat)
        {
            this.chatMsg = chat;
        }

        public String GetChatMsg()
        {
            return this.chatMsg;
        }

        public String Wrap() {
            wrappingMsg = "";
            wrappingMsg += util.WrapWithTag(audioMsg, Constants.otAudioMsg, Constants.ctAudioMsg);
            wrappingMsg += util.WrapWithTag(videoMsg, Constants.otVideoMsg, Constants.ctVideoMsg);
            wrappingMsg += util.WrapWithTag(chatMsg, Constants.otChatMsg, Constants.ctChatMsg);
            return wrappingMsg;
        }

        public void Unwrap(String toUnwrap)
        {
            audioMsg = util.UnwrapTags(toUnwrap, Constants.otAudioMsg, Constants.ctAudioMsg);
            videoMsg = util.UnwrapTags(toUnwrap, Constants.otVideoMsg, Constants.ctVideoMsg);
            chatMsg = util.UnwrapTags(toUnwrap, Constants.otChatMsg, Constants.ctChatMsg);
        }
        
    }
}
