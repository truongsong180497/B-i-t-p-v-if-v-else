using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collecton
{
    public class Student
    {
        string s_code;
        string s_name;
        int s_age;
        float s_mark;         
        public Student(string s_code,string s_name,int s_age,float s_mark)
        {
            this.s_code = s_code;
            this.s_name = s_name;
            this.s_age = s_age;
            this.s_mark = s_mark;
        }
        public void input_student()
        {
           
        }
        public void output_student()
        {
            Console.WriteLine("s_code:"+s_code);
            Console.WriteLine("s_name:"+s_name);
            Console.WriteLine("s_age:"+s_age);
            Console.WriteLine("s_mark:"+s_mark);
            Console.WriteLine("--------------");
        }
        public bool check_scholarship()
        {
            return true;
        }
        public string get_name()
        {
            return s_name;
        }
        public string get_code()
        {
            return s_code;
        }
        public float get_mark()
        {
            return s_mark;
        }
        public void set_mark(float new_mark)
        {
            this.s_mark = new_mark;
        }

    }
 
}

