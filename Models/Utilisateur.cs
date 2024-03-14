using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDotNet.Models
{
    public class Utilisateur
    {
        private string _name;
        private string _lastname;
        private string _cin;
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Utilisateur(string name, string lastname, string cin)
        {
            _name = name;
            _lastname = lastname;
            _cin = cin;
        }

        public Utilisateur(string name, string lastname, string cin, int id) : this(name, lastname, cin)
        {
            _id = id;
        }

        public Utilisateur()
        {
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public string cin
        {
            get { return _cin; }
            set { _cin = value; }
        }

        public override bool Equals(object obj)
        {
            return obj is Utilisateur utilisateur &&
                   name == utilisateur.name &&
                   lastname == utilisateur.lastname &&
                   cin == utilisateur.cin;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, lastname, cin);
        }
    }


}