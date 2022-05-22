module Lab6Task18

open System

let private getMinElementIndex list =
    let rec loop list minValue currentIndex minIndex =
        match list with
        | [] -> minIndex
        | head :: tail ->
            if head <= minValue then loop tail head (currentIndex + 1) currentIndex
            else loop tail minValue (currentIndex + 1) minIndex
    loop list Int32.MaxValue 0 0

let private getElementsBeforeMin list =
    let rec loop list resultList currentIndex minValueIndex =
        match list with
        | [] -> resultList // shouldnt come here but leave it just to be secure
        | _ when currentIndex = minValueIndex -> resultList
        | head :: tail -> loop tail (resultList @ [head]) (currentIndex + 1) minValueIndex
    loop list [] 0 (getMinElementIndex list)

let startTask =
    let list = [5; 9; 23; 13; 1; 2; 3; 4]
    getElementsBeforeMin list |> Seq.iter (printf "%d ")