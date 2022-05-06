#ifndef LAB_2_ARRAY_H
#define LAB_2_ARRAY_H

namespace lib {
    template<class T>
    class Array {
    public:
        Array(int len) : len(len) {
            this->arr = new T[len];
        }
        ~Array() {
            delete[] this->arr;
        }

        T & operator[](int index) {
            if (index < this->len)
                return this->arr[index];
            else
                throw std::out_of_range("Index out range");
        };

        const T & operator[](int index) const {
            if (index < this->len)
                return this->arr[index];
            else
                throw std::out_of_range("Index out range");
        };

        int getLength() const { return this->len; };

    private:
        T* arr;
        int len;

    public:
        class RAIterator {
            T* elem;
            int curIndex;
            int arrayLength;
        public:
            explicit RAIterator(T* el, int index, int arrayLength) : elem(el), curIndex(index), arrayLength(arrayLength) {}

            bool isAtStart() {
                return curIndex == 0;
            }

            bool isEnded() {
                return curIndex >= arrayLength;
            }

            RAIterator & operator++() {
                ++elem;
                ++curIndex;
                return *this;
            }

            RAIterator operator++(int) {
                RAIterator retval = *this;
                ++(*this);
                return retval;
            }
            RAIterator & operator--() {
                --elem;
                --curIndex;
                return *this;
            }

            RAIterator operator--(int) {
                RAIterator retval = *this;
                --(*this);
                return retval;
            }

            bool operator==(RAIterator other) const { return (elem == other.elem && curIndex == other.curIndex); }

            bool operator!=(RAIterator other) const { return (elem != other.elem && curIndex != other.curIndex); }

            T & operator*() { return *elem; }
        };

        RAIterator begin() const { return RAIterator(arr, 0, len); }

        RAIterator end() const { return RAIterator(arr + len, len, len); }
    };
}

#endif //LAB_2_ARRAY_H
