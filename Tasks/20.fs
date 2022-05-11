module Task20

open System

// convert to ASCII
let private charToInt char = int char - int '0'

let private getAsciiAverage (string: string) = 
    Array.average (Array.map (fun x -> Convert.ToDouble (charToInt x)) (Seq.toArray string))

let private task1 string =
    // sort by ascii code value to average ascii value in string
    let temp = (Seq.toArray string) |> Array.sortBy (fun x -> (getAsciiAverage string) - (Convert.ToDouble(charToInt x)))
    // converting char array to string
    let result = temp |> Array.map (fun x -> Convert.ToString x) |> String.concat ""
    result

let startTask =
    printf "Task number: "
    match Console.ReadLine() |> Convert.ToInt32 with
    | 1 ->
        printf "Word: "
        let string = Console.ReadLine()
        printf "Result: "
        Console.WriteLine(task1 string)
    | 2 -> Console.WriteLine("Under contruction")
    | _ -> Console.WriteLine("Invalid task number")