module Lab6Task20

open System

let private getMissingNumbers list =
    let rec loop list resultList =
        match list with
        | [] -> resultList
        | head :: tail ->
            match tail with
            | [] -> resultList
            | secondHead :: subTail ->
                if secondHead - head = 1 then loop tail resultList
                else loop tail (resultList @ [head + 1..secondHead - 1])
    loop list []
                
let startTask =
    let list = List.sort [12; 1; 5; 3; 8]
    getMissingNumbers list |> Seq.iter (printf "%d ")
    