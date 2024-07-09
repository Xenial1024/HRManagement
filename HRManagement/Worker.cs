using System;
using System.Security.Permissions;
using System.Xml.Serialization;

namespace HRManagement
{
    public class Worker
    {
        private uint _id;
        private string _firstName;
        private string _lastName;
        private DateTime? _employmentDate = null;
        private DateTime? _dismissalDate = null;
        private uint _earnings;
        private string _comments;
        private bool _isEmployed = true;
        private bool? _isdismissaldateExisting = false;
        //true - istnieje i znana
        //null - istnieje, ale nieznana (już się wydarzyła)
        //false - nie istnieje


        [XmlElement("Id")] //bez tego nie zadziała deserializacja
        public uint Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [XmlElement("FirstName")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        [XmlElement("LastName")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        [XmlElement("EmploymentDate")]
        public DateTime? EmploymentDate
        {
            get { return _employmentDate; }
            set { _employmentDate = value; }
        }

        [XmlElement("DismissalDate")]
        public DateTime? DismissalDate
        {
            get { return _dismissalDate; }
            set { _dismissalDate = value; }
        }

        [XmlElement("Earnings")]
        public uint Earnings
        {
            get { return _earnings; }
            set { _earnings = value; }
        }

        [XmlElement("Comments")]
        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }


        [XmlElement("IsEmployed")]  
        public bool IsEmployed
        {
            get { return _isEmployed; }
            set { _isEmployed = value; }
        }

        
        public bool? IsDismissalDateExisting
        {
            get { return _isdismissaldateExisting; }
            set { _isdismissaldateExisting = value; }
        }
    }
}
