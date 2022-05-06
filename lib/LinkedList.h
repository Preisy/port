#ifndef LAB_3_LINKEDLIST_H
#define LAB_3_LINKEDLIST_H
#include <utility>

namespace lib {


    template<class T>
    class LinkedList : public IList<T> {
    private:
        class Node {
        public:
            Node* next = nullptr;
            T data;

        public:
            explicit Node(const T & data) : data(data) {};
            explicit Node(T && data) : data(std::move(data)) {};
        };

    private:
        Node* head;
        Node* tail;
        int len;
    public:
        LinkedList() :
            head(nullptr),
            tail(nullptr),
            len(0) {

        };


        void push(const T & data) override {
            std::cout << "LinkedList::push(const &)" << std::endl;
            Node* tmp = new Node(data);
            if (this->tail == nullptr) {
                this->head = this->tail = tmp;
            } else {
                this->tail->next = tmp;
                this->tail = tmp;
            }
            ++len;
        }

        void push(T && data) override {
            std::cout << "LinkedList::push(&&)" << std::endl;
            Node* tmp = new Node(std::move(data));
            if (this->tail == nullptr) {
                this->head = this->tail = tmp;
            } else {
                this->tail->next = tmp;
                this->tail = tmp;
            }
            ++len;
        }

    };



}

#endif //LAB_3_LINKEDLIST_H
