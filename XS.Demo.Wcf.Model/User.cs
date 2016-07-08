using System;
using System.Runtime.Serialization;

namespace XS.Demo.Wcf.Model
{
    [DataContract]
    [Serializable]
    public class User
    {
        private int userID;

        private string userName;

        [DataMember]
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        [DataMember]
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}