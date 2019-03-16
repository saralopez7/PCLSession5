let isEven x = (x % 2 = 0)
let evenList1 = List.map isEven [0;1;2;3;4];;
// evenList1 = true; false: true; false; true]

let evenList2 = List.filter isEven [0;1;2;3;4]
// evenList 2 = [0; 2; 4]

let closureFun = 
    let multi2 x y = x * y
    let triple = multi2 3 // partial application of multi2
    // triple is a closure that takes one arg
    printfn"%d" (triple 5)

