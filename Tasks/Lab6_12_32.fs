module Lab6Task32

open System

let private getAmountOfLocalMax list =
    let rec loop list counter previousValue =
        match list with
        | [] -> counter
        | head :: tail ->
            match tail with
            | [] ->
                if head > previousValue then counter + 1
                else counter
            | secondHead :: subTail ->
                if head > secondHead && head > previousValue then loop tail (counter + 1) head
                else loop tail counter head
    loop list 0 Int32.MinValue

let startTask =
    let list = [12; 1; 5; 3; 8]
    Console.WriteLine(getAmountOfLocalMax list)
