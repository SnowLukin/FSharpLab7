module Task20

open System

// convert to ASCII
let charToInt char = int char - int '0'

let getAsciiAverage (string: string) = 
    Array.average (Array.map (fun x -> Convert.ToDouble (charToInt x)) (Seq.toArray string))

let private task1 =
    Console.Write("Word: ")
    let string = Console.ReadLine()
    // sort by ascii code value to average ascii value in string
    let temp = (Seq.toArray string) |> Array.sortBy (fun x -> (getAsciiAverage string) - (Convert.ToDouble(charToInt x)))
    // converting char array to string
    let result = temp |> Array.map (fun x -> Convert.ToString x) |> String.concat ""
    Console.WriteLine(result)

let startTask =
    task1