module Lab6Task35

open System

let private getClosestNumberFromList list number =
    let rec loop list difference closestNumber =
        match list with
        | [] -> closestNumber
        | head :: tail ->
            if abs(head - number) < difference then loop tail (abs(head - number)) head
            else loop tail difference closestNumber
    loop list Double.MaxValue 0.0

let startTask =
    let number = 5.6
    let list = [1.0 .. 10.0]
    Console.WriteLine(getClosestNumberFromList list number)