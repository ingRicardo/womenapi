namespace WebWomen.Models
{
    public class Dog
    {

        // Instance Variables
        String name;
        String breed;
        int age;
        String color;

        // Constructor Declaration of Class same name as class
        public Dog(String name, String breed, int age, String color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        public String GetName()
        {
            return name;
        }

        public String GetBreed()
        {
            return breed;
        }

        public int GetAge()
        {
            return age;
        }

        public String GetColor()
        {
            return color;
        }

        public override String ToString()
        {
            return "my name is: " + name +
                   "\nmy breed is: " + breed +
                   "\nmy age is: " + age;
        }


    }
}
