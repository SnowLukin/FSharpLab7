module Lab6Task44

open System

let private isDecimal floatNumber =
    abs(floatNumber % 1.) <= Double.Epsilon * 100.

let rec private ifIntsFollowedByFloats list =
    match list with
    | [] -> true
    | head :: tail ->
        match tail with
        | [] -> true
        | secondHead :: subTail ->
            if isDecimal head <> isDecimal secondHead then ifIntsFollowedByFloats tail
            else false

let startTask =
    let list = [1.2; 2.0; 3.4; 24.0]
    Console.WriteLine(ifIntsFollowedByFloats list)