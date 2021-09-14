obj_count = {}
function increment(name) {
    if (obj_count[`${name}`] == undefined) {
        obj_count[`${name}`] = 1
    } else {
        obj_count[`${name}`]++
    }
}

uls = document.body.querySelectorAll("ul:not(ul ul)")
for (var i = 3; i < 60; i++) {
    var lis = uls[i].children
    for (var j = 0; j < lis.length; j++) {
        try {    
            name = lis[j].querySelector("a").innerText
            increment(name)
        } catch {
//             my job here is done
        }
        
    }
}

arr_count = []
for (var key in obj_count) {
    arr_count.push([key, obj_count[key]])
}
arr_count.sort((a, b) => a[1] > b[1] ? -1 : 1)

output = ``
for (var i = 0; i < 20; i++) {
    output += `${arr_count[i][0]}: ${arr_count[i][1]}\n`
}
console.log(output)