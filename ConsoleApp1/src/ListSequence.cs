namespace ConsoleApp1;

public class ListSequence<T> {
    private LinkedList<T> list;

    public ListSequence() {
        this.list = new LinkedList<T>();
    }

    public ListSequence(params T[] argv) {
        this.list = new LinkedList<T>(argv);
    }


    public void append(T el) {
        this.list.append(el);
    }

    public void prepend(T el) {
        this.list.prepend(el);
    }

    public ListSequence<T> slice(int startIndex, int endIndex) {
        ListSequence<T> res = new ListSequence<T>();
        res.list = this.list.slice(startIndex, endIndex);
        return res;
    }


    public T getFirst() {
        return this.list.getFirst();
    }

    T getLast() {
        return this.list.getLast();
    }

    public T this[int index] {
        get { return this.list[index]; }
        set { this.list[index] = value; }
    }

    public void print() {
        this.list.print();
    }
}