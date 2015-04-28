//// Learn more about F# at http://fsharp.net
//// See the 'F# Tutorial' project for more help.
//
[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    printfn "add 5 and 3 is %d" (Calculator.add 5 3)
    0 // return an integer exit code
// alternatively module is created by the compiler automatically

// printfn "add 5 and 3 is %d" (Calculator.add 5 3)
