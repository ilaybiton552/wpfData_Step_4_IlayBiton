using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class City : BaseEntity
    {
        //id->BaseEntity
        private string cityName;

        [DataMember]
        public string CityName 
        {
            get { return cityName; }
            set { cityName = value; } 
        }

    }


    [CollectionDataContract]
    public class CityList : List<City>
    {
        public CityList() { } //בנאי ברירת מחדל
        public CityList(IEnumerable<City> list) :
            base(list)
        { } //המרה של רשימת קורסים לאוסף של קורסים
        public CityList(IEnumerable<BaseEntity> list) :
            base(list.Cast<City>().ToList())
        { } //המרה כלפי מטה מישות בסיס לרשימת קורסים

    }
}
