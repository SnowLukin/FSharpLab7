module Lab5Task181920

open System

// V-8

// First subtask
let private firstTask number =
    printfn "1) Amount of coprimes to number."
    Task1516.eulerFunc number 0 1

// Second subtask
let private secondTask number =
    printfn "2) Sum of digits multiple of 3."
    Task13.detourDigitsRecDown number 0 (fun x y -> x + y)

// Thid subtask
let rec private getAmountOfDigitsCoprimeToNumber number initualNumber counter =
    if initualNumber = 0 then counter
    else
        if Task1516.greatestCommonDivisor initualNumber number = 1 then
            getAmountOfDigitsCoprimeToNumber number (initualNumber / 10) (counter + 1)
        else getAmountOfDigitsCoprimeToNumber number (initualNumber / 10) counter

let private hasMoreCoprimes number firstDevider secondDevider =
    let firstValue = getAmountOfDigitsCoprimeToNumber firstDevider number 0
    let secondValue = getAmountOfDigitsCoprimeToNumber secondDevider number 0
    firstValue < secondValue


let rec private getDividerWithMaxAmountOfCoprimes number resultDevider currentDevider =
    if currentDevider = 0 then resultDevider
    else
        if number % currentDevider = 0 || hasMoreCoprimes number resultDevider currentDevider then
            getDividerWithMaxAmountOfCoprimes number currentDevider (currentDevider - 1)
        else getDividerWithMaxAmountOfCoprimes number resultDevider (currentDevider - 1)

let private thirdTask number =
    getDividerWithMaxAmountOfCoprimes number 1 number

// Choose Task
let rec private startChosenTask taskNumber value =
    match taskNumber with
    | 1 -> firstTask value
    | 2 -> secondTask value
    | other -> thirdTask value

// Main
let startTask =
    printfn "Input task number and your value."
    // Superposition
    let data = ((Console.ReadLine >> Int32.Parse)(), (Console.ReadLine >> Int32.Parse)())
    // Curring
    //let data = (Console.ReadLine() |> Int32.Parse, Console.ReadLine() |> Int32.Parse)
    let result = startChosenTask (fst data) (snd data)
    Console.WriteLine("Result: {0}", result)

// 36 ->
// 1) 12 (Euler function)
// 2) 3 + 6 = 9
// 3) Obviously the answer is 1, cuz has biggest amount of coprimes.