using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview1
{
    public class Student
    {
        //declaring the properties of the class
        String name;
        int id;
        double percentage;
        String[] skills;

        //creating multiple constructors to initialize objects based on either one or combination of these properties.

        public Student(int id)
        {
            this.id = id;
        }

        public Student(String name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public Student(String name, int id, double percentage, String[] skills)
        {
            this.name = name;
            this.id = id;
            this.percentage = percentage;
            this.skills = skills;
        }

        //creating getters
        public String getName()
        {
            return this.name;
        }

        public int getId()
        {
            return this.id;
        }

        public double getPercentage()
        {
            return this.percentage;
        }

        public String[] getSkills()
        {
            return this.skills;
        }

        //creating setters
        public void setName(String name)
        {
            this.name = name;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setPercentage(double percentage)
        {
            this.percentage = percentage;
        }

        public void setSkills(String[] skills)
        {
            this.skills = skills;
        }

        public static void main(String[] args)
        {
           
        }
    }
 }
