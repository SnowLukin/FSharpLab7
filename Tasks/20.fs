module Task20

open System

let private task1 =
    Console.Write("Word: ")
    let string = Console.ReadLine()

    let bytearray : byte[] = Text.Encoding.ASCII.GetBytes(string)
    let sortedByteArray = Array.sort bytearray
    let resultString = Text.Encoding.ASCII.GetString(sortedByteArray)

    Console.WriteLine(resultString)

let startTask =
    task1