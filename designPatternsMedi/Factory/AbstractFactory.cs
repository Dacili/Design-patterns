using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class AbstractFactory
    {
        public abstract class Creator
        {
            public abstract Laptop createNewLaptop(); // factory method 1
            public abstract Keyboard createNewKeyboard(); // factory method 2
            public void doSomething()
            {
                Laptop laptop = createNewLaptop();
                laptop.turnOn();
                Keyboard keyboard = createNewKeyboard();
                keyboard.writeSomething();
                
            }
        }

        public class CreatorHP : Creator
        {
            public override Laptop createNewLaptop()
            {
                Console.WriteLine("HP laptop created");
                return new LaptopHP();
            }

            public override Keyboard createNewKeyboard()
            {
                Console.WriteLine("HP keyboard created");
                return new KeyboardHP();
            }
        }

        public class CreatorDELL : Creator
        {
            public override Laptop createNewLaptop()
            {
                Console.WriteLine("DELL created");
                return new LaptopDELL();
            }

            public override Keyboard createNewKeyboard()
            {
                Console.WriteLine("DELL keyboard created");
                return new KeyboardDELL();
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

        public interface Keyboard
        {
            void writeSomething();
        }

        public class KeyboardHP: Keyboard
        {
            public void writeSomething()
            {
                Console.WriteLine("HP keyboard writing");
            }
        }

        public class KeyboardDELL : Keyboard
        {
            public void writeSomething()
            {
                Console.WriteLine("DELL keyboard writing");
            }
        }
    }
}
