using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_继承练习
{
    class Person
    {
        public Person(string name, int age, string hobby) 
        {
            this.Name = name;
            this.Age = age;
            this.Hobby = hobby;
        }
        private string _name;
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

      
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _hobby;
        public string Hobby 
        {
            get { return _hobby; }
            set { _hobby = value; }
        }
        public Person()
        {
        }
    }
}