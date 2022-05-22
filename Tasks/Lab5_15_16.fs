module Lab5Task1516

open System

let rec greatestCommonDivisor firstValue secondValue =
    if secondValue = 0 then firstValue
    else greatestCommonDivisor secondValue (firstValue % secondValue)

let getValuesFromCoprimes number action initualValue =
    let rec subGetValuesFromCoprimes number action initualValue primeValue =
        if primeValue = number then initualValue
        else if greatestCommonDivisor number primeValue = 1
        then subGetValuesFromCoprimes number action (action initualValue primeValue) (primeValue + 1)
        else subGetValuesFromCoprimes number action initualValue (primeValue + 1)
    subGetValuesFromCoprimes number action initualValue 1

let rec eulerFunc number initualValue primeValue =
    if primeValue = number then initualValue
    else if greatestCommonDivisor number primeValue = 1 then eulerFunc number (initualValue + 1) (primeValue + 1)
    else eulerFunc number initualValue (primeValue + 1)

let startTask =
    printf "Number: "
    let number = Convert.ToInt32(Input.getValue())
    Console.WriteLine(number)
    Console.WriteLine("Sum of coprimes: {0}", (getValuesFromCoprimes number (fun x y -> x + y) 0))
    Console.WriteLine("The result of Euler's totient function: {0}", (eulerFunc number 0 1))
    let first = 256
    let second = 0
    Console.WriteLine(greatestCommonDivisor first second)

// 36 -> coprimes: 1, 5, 7, 11, 13, 17, 19, 23, 25, 29, 31, 35
// euler(36) = 12
// sum of coprimes: 216
