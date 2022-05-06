#ifndef LAB_3_KEYSPACE1_H
#define LAB_3_KEYSPACE1_H

#include "vector"
#include "algorithm"
#include "KeySpaces/IKeySpace.h"
#include "KeySpaces/Item.h"
#include "lib.h"

template<class Data>
class KeySpace1 : public IKeySpace<Data> {
private:
    lib::LinkedList<lib::LinkedList<Item<Data>>> list = lib::LinkedList<lib::LinkedList<Item<Data>>>();

public:
    KeySpace1() = default;

};

#endif //LAB_3_KEYSPACE1_H
