module Task8

let removeAt index list =
    list |> List.indexed |> List.filter (fun (i, _) -> i <> index) |> List.map snd

let private getIndexesOfMinElements list amountOfMinElements =
    let rec loop subList amountOfMinElements indexesOfMinElements =
        if amountOfMinElements > 0 then
            let minElement = List.min subList
            let indexOfMinElement = List.findIndex (fun element -> element = minElement) list
            loop (removeAt indexOfMinElement subList) (amountOfMinElements - 1) (indexesOfMinElements @ [indexOfMinElement])
        else indexesOfMinElements
    loop list amountOfMinElements []

let startTask =
    let list = [5; 1; 4; 6; 2]
    getIndexesOfMinElements list 2 |> Seq.iter (printf "%d ")