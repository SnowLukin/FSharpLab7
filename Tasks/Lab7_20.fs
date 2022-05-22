module Lab7Task20

open System

// convert to ASCII
let private charToInt char = int char - int '0'

// ASCII avarage value of a string 
let private getAsciiAverage (string: string) = 
    Array.average (Array.map (fun x -> Convert.ToDouble (charToInt x)) (Seq.toArray string))

let private getAsciiAverageByThreeChars (string: string) =
    let rec loop (newString: string) (resultArray: double list) =
        match newString with
        | "" -> resultArray
        | _ when newString.Length < 3 -> resultArray
        | _ ->
            // Sum of three first chars in string
            let newValue = Convert.ToDouble((charToInt newString.[0]) + (charToInt newString.[1]) + (charToInt newString.[2]))
            if newString.Length = 3 then loop "" resultArray @ [newValue]
            else loop newString.[3..newString.Length-1] resultArray @ [newValue]
    List.average (loop string [])

// standard deviation
let getStandardDeviation  string char =
    let asciiAvrValue = (getAsciiAverage string) - (Convert.ToDouble(charToInt char))
    let avrByThreeChars = getAsciiAverageByThreeChars string
    let subResult = asciiAvrValue - avrByThreeChars
    pown subResult 2

let private task1 string =
    // sort by ascii code value to average ascii value in string
    let temp = (Seq.toArray string) |> Array.sortBy (fun x -> (getAsciiAverage string) - (Convert.ToDouble(charToInt x)))
    // converting char array to string
    temp |> Array.map (fun x -> Convert.ToString x) |> String.concat ""

let private task2 (string: string) =
    let charArray = string.ToCharArray()
    // sorted list of chars
    let list = List.sortBy (fun x -> getStandardDeviation string x) (Array.toList charArray)
    // converting list of chars to string
    list |> Array.ofList |> String
2
let startTask =
    printf "Task number: "
    match Console.ReadLine() |> Convert.ToInt32 with
    | 1 ->
        printf "Word: "
        let string = Console.ReadLine()
        printf "Result: "
        Console.WriteLine(task1 string)
    | 2 ->
        printf "Word: "
        let string = Console.ReadLine()
        printf "Result: "
        Console.WriteLine(task2 string)
    | _ -> Console.WriteLine("Invalid task number")