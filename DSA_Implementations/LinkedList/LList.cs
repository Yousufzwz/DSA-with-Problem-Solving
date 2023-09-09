using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList;

public class LList
{
    private Node head;

    public LList()
    {
        head = new Node();  //initialized dummy node
    }

    public void InsertAtTail(int value)
    {
        Node copyHead = head;
        while (copyHead.Next != null)
        {
            copyHead = copyHead.Next;
        }

        copyHead.Next = new Node(value);
    }

    public void InsertAtHead(int value)
    {
        Node nextNode = head.Next;
        head.Next = new Node(value);
        head.Next.Next = nextNode;
    }

    public int GetElementAt(int position)
    {
        Node curr = head.Next;
        for (int i = 0; i < position; i++)
        {
            curr = curr.Next;
        }
        return curr.Value;
    }

    public void RemoveAt(int position)
    {
        Node curr = head;
        for (int i = 0; i < position; i++)
        {
            curr = curr.Next;
        }
        Node nextNode = curr.Next.Next;
        curr.Next = nextNode;
    }

    public void PrintList()
    {
        Node current = head.Next;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

}