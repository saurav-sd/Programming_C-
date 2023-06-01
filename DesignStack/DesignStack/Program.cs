namespace DesignStack
{
    internal class Program
    {
    //    class Stack<T>
    //    {
    //        private List<T> stack;

    //        public Stack()
    //        {
    //            stack = new List<T>();
    //        }

    //        public void Push(T obj)
    //        {
    //            stack.Add(obj);
    //        }

    //        public T Pop()
    //        {
    //            if (!IsEmpty())
    //            {
    //                int lastIndex = stack.Count - 1;
    //                T obj = stack[lastIndex];
    //                stack.RemoveAt(lastIndex);
    //                return obj;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Stack is empty.");
    //                return default;
    //            }
    //        }

    //        public void Clear()
    //        {
    //            stack.Clear();
    //        }

    //        public bool IsEmpty()
    //        {
    //            return stack.Count == 0;
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Stack<string> myStack = new Stack<string>();
    //        myStack.Push("First");
    //        myStack.Push("Second");
    //        myStack.Push("Third");

    //        Console.WriteLine(myStack.Pop());  // Output: Third
    //        Console.WriteLine(myStack.Pop());  // Output: Second

    //        myStack.Clear();
    //        Console.WriteLine(myStack.IsEmpty());  // Output: True

    //    }

        static void Main(string[] args)
        {
            var stack = new Stack();

            int ini = 0;
            int max = 5;

            for(int i = ini; i<= max; i++)
                stack.Push(i);

            stack.Clear();

            for(int i = ini; i<=max; i++)
                Console.WriteLine(  stack.Pop());

            Console.ReadLine();
            
        }
          
    }

    public class Stack
    {
        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("you cannot add null object to stack.");

            _list.Add(obj);
        }

        public object Pop()
        {
            if(_list.Count == 0)
                throw new InvalidOperationException("There is no element in stack yet.");

            var index = _list.Count - 1;

            var toReturn = _list[index];

            _list.RemoveAt(index);

            return (toReturn);
        }

        public void Clear()
        {
            _list.Clear();
        }

    }
}