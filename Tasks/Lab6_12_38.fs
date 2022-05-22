module Lab6Task38

open System

let private getAmountOfElementsBelongingToSegment list startPoint endPoint =
    let rec loop list counter =
        match list with
        | [] -> counter
        | head :: tail ->
            if head >= startPoint && head <= endPoint then loop tail (counter + 1)
            else loop tail counter
    loop list 0

let startTask =
    let startPoint = 3
    let endPoint = 8
    let list = [12; 1; 5; 3; 8]
    Console.WriteLine(getAmountOfElementsBelongingToSegment list startPoint endPoint)
