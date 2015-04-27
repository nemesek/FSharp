//// Learn more about F# at http://fsharp.net
//// See the 'F# Tutorial' project for more help.
//
//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0 // return an integer exit code

printfn "Hello World!"

printfn "How are you today?"

let response = System.Console.ReadLine()

printfn "Great to hear you're %s" response
printfn "Goodbye cruel world."