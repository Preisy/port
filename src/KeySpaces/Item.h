#ifndef LAB_3_ITEM_H
#define LAB_3_ITEM_H

#include <iostream>
#include "lib.h"


template<class Data>
class Item {
private:
    int version;

public:
    Item() = default;

    Item(int version) : version(version) {}


private:
    Item(const Item & node) {
        std::cout << "Node.h copy constructor" << std::endl;
    };
    Item& operator=(const Item & node)  {
        std::cout << "Node.h copy ==" << std::endl;
        return *this;
    };

public:
    Item(Item && node) = default;
    Item& operator=(Item && node) = default;
};


#endif //LAB_3_ITEM_H
