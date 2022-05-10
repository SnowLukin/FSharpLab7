module Task19_17

open System

let startTask =
    let string = "/Users/snowlukin/Desktop/fileName.txt"
    let reversedStringArray = string.ToCharArray()
    Array.Reverse(reversedStringArray)

    let indexOfDot = Array.findIndex (fun e -> e = '.') reversedStringArray
    let indexOfSlash = Array.findIndex (fun e -> e = '/') reversedStringArray

    let result = reversedStringArray.[indexOfDot+1..indexOfSlash-1]
    Array.Reverse(result)

    Console.WriteLine(string)
    Console.WriteLine(result)
