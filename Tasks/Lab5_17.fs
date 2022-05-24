module Lab5Task17

open System

let private getValueFromDevidersWithCondition number condition action initValue =
    let checkCondition initialValue tempValue =
        if condition tempValue then action initialValue tempValue
        else initialValue

    Lab5Task14.getValueFromDividers number checkCondition initValue

let private getValueFromCoPrimesWithCondition number condition action initValue =
    let checkCondition initValue tempValue =
        if condition tempValue
        then action initValue tempValue
        else initValue

    Lab5Task1516.getValuesFromCoprimes number checkCondition initValue

let startTask =
    printf "Number: "
    let number = Convert.ToInt32(Input.getValue())

    // Sum Of Dividers that < 10
    let sumOfDividersOfNumber = getValueFromDevidersWithCondition number (fun x -> x < 10) (fun x y -> x + y) 0
    Console.WriteLine("Sum Of Dividers that < 10: {0}", sumOfDividersOfNumber)

    // Sum Of CoPrimes that > 10
    let sumOfCoPrimesOfNumber = getValueFromCoPrimesWithCondition number (fun x -> x > 10) (fun x y -> x + y) 0
    Console.WriteLine("Sum Of CoPrimes that > 10: {0}", sumOfCoPrimesOfNumber)

// 36 -> coprimes: 1, 5, 7, 11, 13, 17, 19, 23, 25, 29, 31, 35
// coprimes > 10: 11, 13, 17, 19, 23, 25, 29, 31, 35
// sum of coprimes > 10: 203