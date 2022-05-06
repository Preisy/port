cmake_minimum_required(VERSION 3.16)
project(lab_3)

set(CMAKE_CXX_STANDARD 17)

include_directories(src)
include_directories(lib)

add_executable(lab_3
        main.cpp
        src/KeySpaces/KeySpace1/KeySpace1.h
        src/KeySpaces/Item.h
        )

add_executable(iterator1 iterators/iterator1.cpp)
add_executable(iterator2 iterators/iterator2.cpp)