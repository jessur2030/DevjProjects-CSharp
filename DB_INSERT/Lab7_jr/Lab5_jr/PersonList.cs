using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jessur_lab4._2;
using System.Text.RegularExpressions;

namespace Lab5_jr
{
   public class PersonList
    {
        private List<Person> peoplelist;

        public PersonList()
        {
            peoplelist = new List<Person>();
        }

        public int Count
        {

            get
            {
                return peoplelist.Count;

            }


        }


        public void add(Person p)
        {
            peoplelist.Add(p);

        }

        public Person getbyindex(int i)
        {
            return peoplelist[i];

        }

      
        public Person this[string lname]
        {
            get
            {
                foreach (Person p in peoplelist)
                {
                    if (p.Lname == lname)
                    {
                        return p;
                    }
                  

                }
                return null;
            }
        }



        public static PersonList operator + (PersonList pl, Person p)
        {
            pl.add(p);
            return pl;

        }



    }
}
