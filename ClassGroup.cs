using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ClassGroup
    {
        private string _no;
        private int _studentLimit;
        public string Name;
        public string surname;
        public int age;

        public ClassGroup(string name, string surname, int age)
        {
            this.Name = name;   
            this.surname = surname;
            this.age = age;
        }

        public string GetInfo()
        {
            return $"Student Name : {this.Name}\nStudent Surname : {this.surname}\nStudent Age : {this.age}\n" ;
        }

        public string No
        {
            get => this._no;
            set
            {
                if( CheckValidation(value))
                {
                    this._no = value;
                }
               
            }
        }
        public int StudentLimit
        {
            get => _studentLimit;
            set
            {
                if (value >= 0)
                {
                    this._studentLimit = value;
                }
            }
        }

        static bool CheckValidation(string name)
        {

            if (!string.IsNullOrWhiteSpace(name)&& name.Length < 6 && name.Length>4)
            {   
                
                if (char.IsUpper(name[0]) && char.IsUpper(name[1]) && char.IsDigit(name[2]) && char.IsDigit(name[3]) && char.IsDigit(name[4]))
                {
                    return true;
                }

            }
            return false;
        }


    }
}