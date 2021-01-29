using System;

namespace Factory
{
    public abstract class CreateLaptop 
    {
        public abstract Laptop createNewLaptop(); // factory method

        public void doSomething()
        {
            Laptop laptop = createNewLaptop();
            laptop.turnOn();
        }
    }

    public class CreateLaptopHP : CreateLaptop
    {
        public override Laptop createNewLaptop()
        {
            Console.WriteLine("HP created");
            return new LaptopHP();
        }
    }

    public class CreateLaptopDELL : CreateLaptop
    {
        public override Laptop createNewLaptop()
        {
            Console.WriteLine("DELL created");
            return new LaptopDELL();
        }
    }

    public interface Laptop
    {
        void turnOn();
    }

    public class LaptopHP : Laptop
        {
        public void turnOn()
        {
            Console.WriteLine("HP on");
        }
    }

    public class LaptopDELL : Laptop
    {
        public void turnOn()
        {
            Console.WriteLine("DELL on");
        }
    }

}
