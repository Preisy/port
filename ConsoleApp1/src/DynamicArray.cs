using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Xml.Schema;

namespace ConsoleApp1;

public class DynamicArray<T> {
    private T[] arr;
    private int _length;

    public int length {
        get { return this._length; }
    }

    public DynamicArray() {
        this.arr = Array.Empty<T>();
        this._length = 0;
    }

    public DynamicArray(int length) {
        this.arr = new T[length];
        this._length = length;
    }

    public T this[int index] {
        get {
            if (index >= this._length) throw new IndexOutOfRangeException();
            else return this.arr[index];
        }
        set {
            if (index >= this._length) throw new IndexOutOfRangeException();
            else arr[index] = value;
        }
    }

    public void resize(int newLength) {
        T[] bufArr = new T[newLength];
        Array.Copy(this.arr, bufArr, this._length);
        this.arr = bufArr;
        this._length = newLength;
    }

    public void print() {
        for (int i = 0; i < this._length; i++) {
            Console.Write(this.arr[i] + " ");
        }
        Console.WriteLine();
    }
}