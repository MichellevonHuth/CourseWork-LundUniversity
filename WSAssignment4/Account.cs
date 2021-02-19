using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSAssignment4
{
    [Serializable]
    public class Account
    {

        private string username;
        private string name;
        private string surename;

        public string Username
        {
            get => username;
            set => username = value; 
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surename
        {
            get => surename;
            set => surename = value;
        }


    }
}