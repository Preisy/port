#ifndef LAB_3_TABLE_H
#define LAB_3_TABLE_H

#include "iostream"
#include "lib.h"
#include "KeySpaces/IKeySpace.h"
#include "KeySpaces/KeySpace1/KeySpace1.h"

template<class Data>
class Table {
private:
    lib::Array<IKeySpace<Data>*> keySpaces{1};

public:
    Table() {
        keySpaces[0] = new KeySpace1<Data>();
    };
};


#endif //LAB_3_TABLE_H
