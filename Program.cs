using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int Length;
            string LengthStr;
            Console.WriteLine("Enter the number of Student :");
            LengthStr = Console.ReadLine();
            Console.WriteLine("------------------------------------|");

            while (CheckString(LengthStr) !=true )
            {
                Console.WriteLine("Enter Correctly :");
                LengthStr = Console.ReadLine();
                Console.WriteLine("------------------------------------|");

            }
            Length = Convert.ToInt32(LengthStr);

            string GroupName;
            do
            {
                Console.WriteLine("Enter Group Name :");
                GroupName = Console.ReadLine();
                Console.WriteLine("------------------------------------|");

            } while (!CheckValidation(GroupName));


            ClassGroup[] Group = new ClassGroup[Length];

            for (int i = 0; i < Length; i++)
            {
       
                string Name = GetStudentName ($"{i + 1} - Student Name : ", 0, 20);
                string Surname = GetStudentSurname($"{i + 1} - Student  Surname :", 0, 20);
                int Age = GetStudentAge($"{i + 1} - StudentAge", 17,45);

                Group[i] = new ClassGroup(Name, Surname, Age);
       
            }
            for (int i = 0; i < Group.Length; i++)
            {
                Console.WriteLine();
              
                Console.WriteLine($"|------------------------- {i + 1}st Student from {GroupName} Group -------------------------| \n\n");
                Console.WriteLine(Group[i].GetInfo());
            }
        }





        static string GetStudentName(string name, int min, int max)
        {

            string Input;
            do
            {
                Console.WriteLine(name);
                Input = Console.ReadLine();
                Console.WriteLine("------------------------------------|");

            } while (Input.Length < min || max < Input.Length);

            return Input;
        }



        static string GetStudentSurname(string name, int min, int max)
        {

            string Input;
            do
            {
                Console.WriteLine(name);
                Input = Console.ReadLine();
                Console.WriteLine("------------------------------------|");

            } while (Input.Length < min || max < Input.Length);

            return Input;
        }


        static int GetStudentAge(string name, int min, int max)
        {
            int Input;
            string inputStr;

            do
            {
                Console.WriteLine(name);
                inputStr = Console.ReadLine();
                Input = Convert.ToInt32(inputStr);
                Console.WriteLine("------------------------------------|");


            } while (Input < min || max < Input);

            return Input;
        }




        static bool CheckValidation(string name)
        {

            if (!string.IsNullOrWhiteSpace(name) && name.Length < 6 && name.Length > 4)
            {

                if (char.IsUpper(name[0]) && char.IsUpper(name[1]) && char.IsDigit(name[2]) && char.IsDigit(name[3]) && char.IsDigit(name[4]))
                {
                    return true;
                }

            }
            return false;

        }
        static bool CheckString(string count)
        {

            if (!string.IsNullOrWhiteSpace(count) )
            {

                if (count.Length > 0)
                {
                    return true;
                }
               

            }
            return false;

        }






    }
    }


