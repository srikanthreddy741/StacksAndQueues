using StackAndQueues;

namespace StacksAndQueues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pushing values to Stack");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.push(70);//1st in and last in stack
            linkedListStack.push(30);
            linkedListStack.push(56);//last in and on top of stack(UC1 requirement)
            linkedListStack.Display();
        }
    }
}