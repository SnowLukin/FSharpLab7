module Lab6Task8

open System

let private findTwoMinValues list =
    let rec loop list firstMin secondMin currentIndex (firstIndex: int) (secondIndex: int) =
        match list with
        | [] -> [firstIndex; secondIndex]
        | head :: tail ->
            if head <= firstMin then
                if head <= secondMin then loop tail firstMin head (currentIndex + 1) firstIndex currentIndex
                else loop tail head secondMin (currentIndex + 1) currentIndex secondIndex
            else loop tail firstMin secondMin (currentIndex + 1) firstIndex secondIndex
    loop list Int32.MaxValue Int32.MaxValue 0 -1 -1


let startTask =
    let list = [7; 4; 0; 2; 8; 1]
    findTwoMinValues list |> Seq.iter (printf "%d ")
