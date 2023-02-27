// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j  + 1])
            {
                var tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            }
        }
    }
}

class StackVal<T>
{
    public T Value { get; set; }
    public StackVal<T>? Previous { get; set; }
}

class Stack<T>
{
    public int Length { get; set; }
    private StackVal<T>? Head
    {
        get;
        set;
    }
    
    public Stack()
    {
        this.Head = null;
        this.Length = 0;
    }

    public void Push(T item)
    {
        var node = new StackVal<T> { Value = item };
        this.Length++;
        if (this.Head is null)
        {
            this.Head = node;
            return;
        }

        node.Previous = this.Head;
        this.Head = node;
    }
    

    public T Pop()
    {
        this.Length = Math.Max(0, this.Length - 1);
        if (this.Length == 0)
        {
            var node = this.Head;
            this.Head = null;
            return node!.Value;
        }

        var head = this.Head;
        this.Head = head!.Previous;
        return head.Value;
    }

    public T Peek()
    {
        return this.Head!.Value;
    }
}

class QueueNode<T>
{
    public T Value { get; set; }
    public QueueNode<T>? Next { get; set; }
}

class Queue<T> 
{
    public int Length { get; set; }
    private QueueNode<T>? Head { get; set; }
    private QueueNode<T>? Tail { get; set; }

    public Queue()
    {
        this.Length++;
        this.Head = this.Tail = null;
        this.Length = 0;
    }
    public void Enqueue(T value)
    {
        QueueNode<T> node = new () { Value = value };
        if (this.Tail is null)
        {
            this.Tail = this.Head = node;
            return;
        }

        this.Tail.Next = node;
        this.Tail = node;
    }

    public T DeQue()
    {
        if (this.Head is not null)
        {
            this.Length--;
            var head = this.Head;
            this.Head = this.Head.Next;
            this.Head.Next = null;
            
            return this.Head.Value;
        }

        if (this.Length == 0)
        {
            this.Tail = null;
        }

        return this.Head.Value;
    }

    public T Peek()
    {
        return this.Head.Value;
    }
}
