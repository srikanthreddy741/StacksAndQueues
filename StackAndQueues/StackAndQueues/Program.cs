using StackAndQueues;

namespace StacksAndQueues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Pushing values to Stack");
            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.push(70);//1st in and last in stack
            //linkedListStack.push(30);
            //linkedListStack.push(56);//last in and on top of stack(UC1 requirement)
            //linkedListStack.Display();


            //Console.WriteLine("Using Peek and Pop Till Stack is Empty");
            //linkedListStack.Peek();//shows top element of stack
            //linkedListStack.Pop();//deletes top element of stack
            //linkedListStack.IsEmpty();
            //linkedListStack.Display();

            LinkedListQueue linkedListQueues = new LinkedListQueue();
            linkedListQueues.Enqueue(56);//1ST in 1st out
            linkedListQueues.Enqueue(30);
            linkedListQueues.Enqueue(70);
            linkedListQueues.Display();

        }
    }
}