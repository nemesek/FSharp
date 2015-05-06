﻿// Listing 1.10
//let message = "Hello World"
//printfn "%s" message
//
//
//let sayHello name = 
//    let str = "Hello " + name + "!"
//    printfn "%s" str
open System.Drawing
open System.Windows.Forms

type HelloWindow() = 
    let frm = new Form(Width = 400, Height = 140)
    let fnt = new Font("Times New Roman", 28.0f)
    let lbl = new Label(Dock = DockStyle.Fill, Font = fnt, TextAlign = ContentAlignment.MiddleCenter)

    do frm.Controls.Add(lbl)

    member x.SayHello(name) = 
        let msg = "Hello " + name + "!"
        lbl.Text <- msg

    member x.Run() =
        Application.Run(frm)

let hello = new HelloWindow()
hello.SayHello("Dan")
hello.Run();