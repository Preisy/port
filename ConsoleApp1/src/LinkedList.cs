namespace ConsoleApp1;

public class LinkedList<T> {
    private Node<T>? head;
    private Node<T>? tail;
    private int _length;
    public int length {
        get { return this._length; }
    }

    public LinkedList() {
        this.head = null;
        this.tail = null;
        this._length = 0;
    }

    public LinkedList(params T[] argv) {
        this.head = null;
        this.tail = null;
        this._length = 0;
        for (int i = 0; i < argv.Length; i++) {
            append(argv[i]);
        }
    }


    public void append(T el) {
        Node<T> tmp = new Node<T>(el);
        tmp.next = this.head;
        this.head = tmp;
        if (this.tail == null) this.tail = tmp;
        this._length += 1;
    }

    public void prepend(T el) {
        Node<T> tmp = new Node<T>(el);
        tmp.next = null;
        if (this.tail == null) {
            this.head = this.tail = tmp;
            this._length += 1;
            return;
        }

        this.tail.next = tmp;
        this.tail = tmp;
        this._length += 1;
    }

    public LinkedList<T> slice(int startIndex, int endIndex) {
        if (startIndex * endIndex < 0 || startIndex >= this._length || endIndex >= this._length)
            throw new IndexOutOfRangeException();
        LinkedList<T> list = new LinkedList<T>();
        Node<T> it = this.head;
        for (int i = startIndex; i < endIndex; i++, it = it.next) {
            list.prepend(it.data);
        }

        return list;
    }
    
    

    public T getFirst() {
        if (this.head == null) throw new IndexOutOfRangeException();
        else return this.head.data;
    }

    public T getLast() {
        if (this.tail == null) throw new IndexOutOfRangeException();
        else return this.tail.data;
    }

    public T this[int index] {
        get {
            if (index >= this._length) throw new IndexOutOfRangeException();
            Node<T> it = this.head;
            for (int i = 0; i < index; i++, it = it.next) { }

            return it.data;
        }
        set { // потестить
            if (index >= this._length) throw new IndexOutOfRangeException();
            Node<T> it = this.head;
            for (int i = 0; i < index; i++, it = it.next) { }

            it.data = value;
        }
    }

    public void print() {
        if (this.head == null) throw new IndexOutOfRangeException();
        for (Node<T> it = this.head; it != null; it = it.next) {
            Console.Write(it.data + " ");
        }
        Console.WriteLine();
    }
    
}

internal class Node<T> {
    private T _data;
    private Node<T>? _next;

    public Node(T data) {
        this._data = data;
    }

    public T data {
        get { return this._data; }
        set { this._data = value; }
    }

    public Node<T>? next {
        get { return this._next; }
        set { this._next = value; }
    }
}