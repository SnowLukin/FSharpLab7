module Lab5Task13

open System

// ------- Recursion BOTTPOM-UP -------

// Multiplication of all digits in a number
let rec private subMultiplicationOfDigits number =
    if number = 0 then 1
    else (number % 10) * subMultiplicationOfDigits(number / 10)

let private multiplicationOfDigits number =
    // If we getting 0 then the answer should be 0... otherwise use recursion
    if number = 0 then 0
    else subMultiplicationOfDigits number

// Min digit in number
let rec private minDigit number =
    if number < 10 then number
    else min (number % 10) (minDigit (number / 10))

// Max digit in number
let rec private maxDigit number =
    if number < 10 then number
    else max (number % 10) (maxDigit(number / 10))



// ------- Recursion TOP-DOWN -------

// Multiplication of all digits in a number
let rec detourDigitsRecDown number current action =
    if number = 0 then current
    else
        let current = action current (number % 10)
        let number = number / 10
        detourDigitsRecDown number current action

let private multiplicationOfDigitsRecDown number =
    if number = 0 then 0
    else detourDigitsRecDown number 1 (fun x y -> x * y)

// Min digit in number
let rec private subMinDigitRecDown number min =
    if number = 0 then min
    else
        let min = if number % 10 < min then number % 10 else min
        let number = number / 10
        subMinDigitRecDown number min

let private minDigitRecDown number =
    subMinDigitRecDown number (number % 10)

// Max digit in number
let rec private subMaxDigitRecDown number max =
    if number = 0 then max
    else
        let max = if number % 10 > max then number % 10 else max
        let number = number / 10
        subMaxDigitRecDown number max

let private maxDigitRecDown number =
    subMaxDigitRecDown number (number % 10)

let private getResults number =
    Console.WriteLine("Multiplication of all the digits in your number(recursion bottom-up): {0}", multiplicationOfDigits number)
    Console.WriteLine("Multiplication of all the digits in your number(recursion top-down): {0}", multiplicationOfDigitsRecDown number)
    Console.WriteLine("Min digit of your number(recursion bottom-up): {0}", minDigit number)
    Console.WriteLine("Min digit of your number(recursion top-down): {0}", minDigitRecDown number)
    Console.WriteLine("Max digit of your number(recursion bottom-up): {0}", maxDigit number)
    Console.WriteLine("Max digit of your number(recursion top-down): {0}", maxDigitRecDown number)

// ------- MAIN -------

let startTask =
    printf "Input a number: "
    let number = Convert.ToInt32(Input.getValue())
    getResults number
