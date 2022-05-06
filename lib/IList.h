#ifndef LAB_2_IQUEUE_H
#define LAB_2_IQUEUE_H

namespace lib {
    template<class T>
    class IList {
    public:
        virtual void push(const T & data) = 0;
        virtual void push(T && data) = 0;

        virtual ~IList() = default;
    };
}

#endif //LAB_2_IQUEUE_H
