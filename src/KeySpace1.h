#ifndef LAB_3_KEYSPACE1_H
#define LAB_3_KEYSPACE1_H

#include "vector"
#include "algorithm"
#include "Item.h"
#include "lib.h"

template<class Data>
class KeySpace1 {
private:
    lib::LinkedList<lib::LinkedList<Item<Data>>> list = lib::LinkedList<lib::LinkedList<Item<Data>>>();

public:
    KeySpace1() = default;

};

#endif //LAB_3_KEYSPACE1_H
