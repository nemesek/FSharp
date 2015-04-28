let x = 100 // think of them as values not variables, immutable

let strVal = "hi there"

let boolVal = true

let floatVal = 12.3

let decimalVal = 47.99m

let square(x) = x * x
let square2 x = x * x

printfn "square 5 is %d" (square 5)

let add x y =
    x + y

let add' x y =
    let result = 
        x + y
    result

let add5and3 = add 5 3

// let result = add(square(12), 7) // not valid f#
// let result = add square 12 7 // not valid either
let result = add (square 12) 7

