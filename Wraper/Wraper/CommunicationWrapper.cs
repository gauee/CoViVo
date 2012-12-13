using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wraper
{
    class CommunicationWrapper
    {
        private String userList;
        private String channelList;
        private String recipient;
        private String password;
        private String joinChannel;
        private String user;
        private String deleteChannel;
        private String addChannel;
        private String wrappingMsg;

        private Util util;

        public CommunicationWrapper()
        {
            util = new Util();
            wrappingMsg = "";
            userList = "";
            channelList = "";
            recipient = "";
            password = "";
            joinChannel = "";
            user = "";
            deleteChannel = "";
            addChannel = "";
        }

        public void SetUserList(string userList)
        {
            this.userList = userList;
        }

        public String GetUserList()
        {
            return this.userList;
        }

        public void SetChannelList(string channelList)
        {
            this.channelList = channelList;
        }

        public String GetChannelList()
        {
            return this.channelList;
        }

        public void SetRecipient(string recipient)
        {
            this.recipient = recipient;
        }

        public String GetRecipient()
        {
            return this.recipient;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public String GetPassword()
        {
            return this.password;
        }

        public void SetJoinChannel(string joinChannel)
        {
            this.joinChannel = joinChannel;
        }

        public String GetJoinChannel()
        {
            return this.joinChannel;
        }

        public void SetUser(string user)
        {
            this.user = user;
        }

        public String GetUser()
        {
            return this.user;
        }

        public void SetDeleteChannel(string deleteChannel)
        {
            this.deleteChannel = deleteChannel;
        }

        public String GetDeleteChannel()
        {
            return this.deleteChannel;
        }

        public void SetAddChannel(string addChannel)
        {
            this.addChannel = addChannel;
        }

        public String GetAddChannel()
        {
            return this.addChannel;
        }

        public String Wrap()
        {
            wrappingMsg = "";
            wrappingMsg += util.WrapWithTag(userList, Constants.otUserList, Constants.ctUserList);
            wrappingMsg += util.WrapWithTag(channelList, Constants.otChannelList, Constants.ctChannelList);
            wrappingMsg += util.WrapWithTag(recipient, Constants.otRecipient, Constants.ctRecipient);
            wrappingMsg += util.WrapWithTag(password, Constants.otPassword, Constants.ctPassword);
            wrappingMsg += util.WrapWithTag(joinChannel, Constants.otJoinChannel, Constants.ctJoinChannel);
            wrappingMsg += util.WrapWithTag(user, Constants.otUser, Constants.ctUser);
            wrappingMsg += util.WrapWithTag(deleteChannel, Constants.otDelChannel, Constants.ctDelChannel);
            wrappingMsg += util.WrapWithTag(addChannel, Constants.otAddChannel, Constants.ctAddChannel);
            return wrappingMsg;
        }

        public void Unwrap(String toUnwrap)
        {
            userList = util.UnwrapTags(toUnwrap, Constants.otUserList, Constants.ctUserList);
            channelList = util.UnwrapTags(toUnwrap, Constants.otChannelList, Constants.ctChannelList);
            recipient = util.UnwrapTags(toUnwrap, Constants.otRecipient, Constants.ctRecipient);
            password = util.UnwrapTags(toUnwrap, Constants.otPassword, Constants.ctPassword);
            joinChannel = util.UnwrapTags(toUnwrap, Constants.otJoinChannel, Constants.ctJoinChannel);
            user = util.UnwrapTags(toUnwrap, Constants.otUser, Constants.ctUser);
            deleteChannel = util.UnwrapTags(toUnwrap, Constants.otDelChannel, Constants.ctDelChannel);
            addChannel = util.UnwrapTags(toUnwrap, Constants.otAddChannel, Constants.ctAddChannel);
        }

    }
}

