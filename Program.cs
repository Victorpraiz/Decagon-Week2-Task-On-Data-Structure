
using Data_Structure;


//Data_Structure.LinkedList<int> myList = new Data_Structure.LinkedList<int>();
//myList.Add(10);
//myList.Add(30);
//myList.Add(56);
//myList.Add(35);
//Console.WriteLine(myList.Remove(56));
//myList.PrintList();
//Console.WriteLine(myList.Count());

Data_Structure.Queue<int> stack = new Data_Structure.Queue<int>();
stack.Enqueue(56);
stack.Enqueue(10);
//stack.Push(1); 
//stack.Push(2);
//stack.Push(3);
//stack.Push(49);
//stack.Pop();
stack.Dequeue();
stack.Dequeue();

//stack.PrintStack();
Console.WriteLine(stack.Size());

