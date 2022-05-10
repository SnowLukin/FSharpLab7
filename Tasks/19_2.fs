module Task19_2

open System

let isOrderedUp string =
    let rec loop string result previousChar =
        match string with
        | "" -> result
        | _ ->
            if string.[0] >= previousChar then loop string.[1..(string.Length-2)] result (string.[0])
            else loop "" false string.[0]
    loop string true (string.[0])

let startTask =
    let string = "something"
    let secondString = "abc"

    //let string = Console.ReadLine()

    if isOrderedUp string then printfn "Yes" else printfn "No"
    if isOrderedUp secondString then printfn "Yes" else printfn "No" 