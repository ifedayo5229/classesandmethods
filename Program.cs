using System;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student sam = new Student(" sam", " allerdyce", " london" , 08156736898, 016 );
            // sam.printDetails();
            // Student john = new Student(" john", " terry", " Usa" , 08156739898, 010);
            // john.printDetails();
          
          triangle a = new triangle(23,11,45);
            a.perimeter();
            a.area();

        }
    }

     //class


    // public class Student
    public class triangle
    {
        // string _firstname;
        // string _lastname;
        // string _address;
        // double _phonenumber;
        // double _rollnunber;
     
        int _base;
        int _height;
        int _length;
        
        //contructor

       public triangle(int bases , int height, int length)
        // public Student(string firstname, string lastname, string address, double phonenumber, double rollnumber)
        {
        //   _firstname = firstname;
        //  _lastname =lastname;
        //  _address = address;
        //  _phonenumber =phonenumber;
        //  _rollnunber = rollnumber;
         _base =bases;
         _height=height;
         _length=length;

        }

        //methods

    // public void printDetails()
    // {
    //     Console.WriteLine("My name is " +_firstname +  " " +_lastname+ " rollnumber " + _rollnunber+ " and i live in"  + _address+ " my phone number is "+ _phonenumber);
    // }
       public void perimeter()
       {
       Console.WriteLine("The perimeter of the triange is " +  (_base+_height+_length));
       }

         public void area()
       {
           Console.WriteLine("The area of the triange is " +  0.5*( _base*_length));
       }
    }
}


