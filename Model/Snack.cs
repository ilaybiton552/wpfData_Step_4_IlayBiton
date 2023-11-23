using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Snack : BaseEntity
    {
        private string name;
        [DataMember]
        public string Name { get { return name; } set {  name = value; } }
        private int calories;
        [DataMember]
        public int Calories { get {  return calories; } set {  calories = value; } }
        private int sugar;
        [DataMember]
        public int Sugar { get {  return sugar; } set {  sugar = value; } }
        private int grams;
        [DataMember]
        public int Grams { get { return grams; } set { grams = value; } }
        private string company;
        [DataMember]
        public string Company { get { return company; } set { company = value; } }
        private int price;
        [DataMember]
        public int Price { get { return price; } set { price = value; } }
    }

    [CollectionDataContract]
    public class SnackList : List<Snack>
    {
        public SnackList() { } //בנאי ברירת מחדל
        public SnackList(IEnumerable<Snack> list) :
            base(list)
        { } //המרה של רשימת קורסים לאוסף של קורסים
        public SnackList(IEnumerable<BaseEntity> list) :
            base(list.Cast<Snack>().ToList())
        { } //המרה כלפי מטה מישות בסיס לרשימת קורסים

    }

}
