using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class User:BaseEntity
    {
        private string firstName;
        private string lastName;
        private string phone;
        private City city;
        private string userName;
        private string password;
        private bool isAdmin;

        [DataMember]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        [DataMember]

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        [DataMember]

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        [DataMember]
        public City City
        {
            get { return city; }
            set { city = value; }
        }
        [DataMember]
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        public bool IsAdmin 
        { 
            get { return isAdmin; } 
            set {  isAdmin = value; } }

        private SnackList snacks;
        [DataMember]
        public SnackList Snacks 
        { 
            get { return snacks; } 
            set { snacks = value; } 
        }

    }

    [CollectionDataContract]
    public class UserList : List<User>
    {
        public UserList() { } //בנאי ברירת מחדל
        public UserList(IEnumerable<User> list) :
            base(list)
        { } //המרה של רשימת קורסים לאוסף של קורסים
        public UserList(IEnumerable<BaseEntity> list) :
            base(list.Cast<User>().ToList())
        { } //המרה כלפי מטה מישות בסיס לרשימת קורסים

    }
}
