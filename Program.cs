
using Data_Structure;

//Linkedlist Methods
var newLinkedList = new Data_Structure.LinkedList<int>();
newLinkedList.Add(80);
newLinkedList.Add(34);
newLinkedList.Add(32);
newLinkedList.Remove(32);
newLinkedList.Check(34);
newLinkedList.Index(80);


//Stack Methods
var newStack = new Data_Structure.Stack<int>();
newStack.Push(23);
newStack.Push(18);
newStack.Pop();
newStack.Peek();
newStack.IsEmpty();
newStack.Size();


//Queue Methods
var newQueue = new Data_Structure.Queue<int>();
newQueue.Enqueue(30);
newQueue.Enqueue(43);
newQueue.Dequeue();
newQueue.isEmpty();
newQueue.Size();



