using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDotNet.Models
{
    public class Authentifiction
    {
        private string _password;
        private string _telephone;
        private string _email;
        private int _id;

        

        public Authentifiction(string password, string telephone, string email,int id)
        {
            _password = password;
            _telephone = telephone;
            _email = email;
            _id = id;
        }

        public Authentifiction(string password, string telephone, string email)
        {
            _password = password;
            _telephone = telephone;
            _email = email;
        }

        public Authentifiction()
        {
        }
        

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }




        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public override bool Equals(object obj)
        {
            return obj is Authentifiction authentifiction &&
                   _password == authentifiction._password &&
                   _telephone == authentifiction._telephone &&
                   _email == authentifiction._email &&
                   _id == authentifiction._id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_password, _telephone, _email, _id);
        }
    }
}