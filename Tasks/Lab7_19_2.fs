module Lab7Task19_2

open System

let isOrderedUp (string: string) =
    let sortedString = string |> Seq.sort |> String.Concat
    String.Equals(string, sortedString)

let startTask =
    let string = "something"
    let secondString = "abc"

    //let string = Console.ReadLine()

    if isOrderedUp string then printfn "Yes" else printfn "No"
    if isOrderedUp secondString then printfn "Yes" else printfn "No" 