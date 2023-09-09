using LinkedList;


//Node temp = new Node();
////temp.Value = 5;
//temp.Next = null;
////temp.Print_Value();

//Node head;


LList linkedList = new LList();
linkedList.InsertAtHead(1);
linkedList.InsertAtHead(2);
linkedList.InsertAtHead(3);
Console.WriteLine(linkedList.GetElementAt(0));
Console.WriteLine(linkedList.GetElementAt(1));
Console.WriteLine(linkedList.GetElementAt(2));
linkedList.RemoveAt(2);



linkedList.PrintList();
