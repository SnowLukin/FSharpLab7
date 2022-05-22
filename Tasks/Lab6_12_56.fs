module Lab6Task56

open System

let private isPrime number =
    let rec loop currentNumber counter =
        if counter > 2 then counter // already not prime
        else if currentNumber < 1 then counter
        else if number % currentNumber = 0 then loop (currentNumber - 1) (counter + 1)
        else loop (currentNumber - 1) counter
    if (loop number 0) > 2 then false else true

let private getAvarageValueOfPrimes list =
    let rec loop list sum counter =
        match list with
        | [] ->
            if counter = 0 then 0 else (sum / counter)
        | head :: tail ->
            if isPrime head then loop tail (sum + head) (counter + 1)
            else loop tail sum counter
    loop list 0 0

let private getAvrValueOfNumbersGreaterThanValue list number =
    let rec loop list sum counter =
        match list with
        | [] ->
            if counter = 0 then 0 else (sum / counter)
        | head :: tail ->
            if isPrime head = false && head > number then loop tail (sum + head) (counter + 1)
            else loop tail sum counter
    loop list 0 0      

let startTask =
    printf "Number of elements in list: "
    let numberOfElements = Console.ReadLine() |> Convert.ToInt32
    printfn "Input list's elements"
    let list = Task11.readList numberOfElements
    let avrValueOfPrimes = getAvarageValueOfPrimes list
    let result = getAvrValueOfNumbersGreaterThanValue list avrValueOfPrimes
    Console.WriteLine("Result {0}", result)
