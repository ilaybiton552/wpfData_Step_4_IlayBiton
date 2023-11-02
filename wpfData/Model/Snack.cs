using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfData_Step_4.Model;

namespace wpfData.Model
{
    public class Snack : BaseEntity
    {
        private string name;
        public string Name { get { return name; } set {  name = value; } }
        private int calories;
        public int Calories { get {  return calories; } set {  calories = value; } }
        private int sugar;
        public int Sugar { get {  return sugar; } set {  sugar = value; } }
        private int grams;
        public int Grams { get { return grams; } set { grams = value; } }
        private string company;
        public string Company { get { return company; } set { company = value; } }
        private int price;
        public int Price { get { return price; } set { price = value; } }
    }

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
