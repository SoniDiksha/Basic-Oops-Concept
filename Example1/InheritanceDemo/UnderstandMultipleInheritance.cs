using System;

namespace InheritanceDemo
{
    public class UnderstandMultipleInheritance : PareantClassA, IControllerInterface
    {
        public void interfaceMethodCall()
        {
            Console.WriteLine("This is example of interface implementaion");
        }

        public new void UserName(string FirstName, string LastName)
        {
            Console.WriteLine($"User first and last name as {FirstName} {LastName} came from UnderstandMultipleInheritance");

        }

    }

    public class PareantClassA
    {
        public void UserName(string FirstName, string LastName)
        {
            Console.WriteLine($"User first and last name as {FirstName} {LastName}");

        }
    }

    public class ClassToUnderstandInterface : IControllerInterface
    {
        //each method declared in interface we should give implemenation in class which is implemenating it.
        public void interfaceMethodCall()
        {
            Console.WriteLine("This is example of interface implementaion");
        }
    }

    public interface IControllerInterface
    {
        void interfaceMethodCall();
    }


}

