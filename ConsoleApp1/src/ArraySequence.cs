namespace ConsoleApp1;

public class ArraySequence<T> {
    private DynamicArray<T> arr;
    private int _length;
    public int length {
        get { return this._length; }
    }
    private int stepLength = 2;

    public ArraySequence() {
        this.arr = new DynamicArray<T>();
        this._length = 0;
    }

    public ArraySequence(params T[] argv) {
        this.arr = new DynamicArray<T>(argv.Length);
        for (int i = 0; i < argv.Length; i++) {
            this.arr[i] = argv[i];
        }

        this._length = argv.Length;
    }


    public T getFirst() {
        return this.arr[0];
    }

    public T getLast() {
        return this.arr[this._length - 1];
    }

    public ArraySequence<T> slice(int startIndex, int endIndex) {
        if (startIndex * endIndex < 0 || startIndex >= this._length || endIndex >= this._length)
            throw new IndexOutOfRangeException();
        ArraySequence<T> res = new ArraySequence<T>();
        for (int i = startIndex; i < endIndex; i++) {
            res.append(this.arr[i]);
        }

        return res;
    }

    public T this[int index] {
        get { return this.arr[index]; }
        set { this.arr[index] = value; }
    }


    public void append(T el) {
        if (this.arr.length <= this._length) {
            if (this.arr.length == 0) this.arr.resize(stepLength);
            else this.arr.resize(this.arr.length * stepLength);
        }

        this.arr[this._length] = el;
        this._length += 1;
    }

    public void prepend(T el) {
        if (this.arr.length <= this._length) {
            this.arr.resize(this.arr.length * stepLength);
        }

        for (int i = 0; i < this._length; i++) {
            this.arr[i + 1] = this.arr[i];
        }

        this.arr[0] = el;
        this._length += 1;
    }

    public void print() {
        this.arr.print();
    }
}