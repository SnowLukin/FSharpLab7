module Lab5Task12

open System

let startTask =

    // Superposition
    printfn "Whats your favorite programming language? (Testing Superposition)"
    (Console.ReadLine>>Task11.getAnswer>>Console.WriteLine)()

    // Currying
    printfn "Whats your favorite programming language? (Testing Currying)"
    let curringFunction input (output: string -> unit) text = output(text(input()))
    curringFunction Console.ReadLine Console.WriteLine Task11.getAnswer