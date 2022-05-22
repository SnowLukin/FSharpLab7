module Lab7Task28

let private getIndexesOfMaxElements list amountOfMaxElements =
    let rec loop subList amountOfMaxElements indexesOfMaxElements =
        if amountOfMaxElements > 0 then
            let maxElement = List.max subList
            let indexOfMaxElement = List.findIndex (fun element -> element = maxElement) list
            loop (Task8.removeAt indexOfMaxElement subList) (amountOfMaxElements - 1) (indexesOfMaxElements @ [indexOfMaxElement])
        else indexesOfMaxElements
    loop list amountOfMaxElements []

let private getElementBetweenMaxValues list =
    let listOfIndexesOfMaxElements = getIndexesOfMaxElements list 2
    let minIndex = List.min listOfIndexesOfMaxElements
    let maxIndex = List.max listOfIndexesOfMaxElements
    list.[(minIndex + 1)..(maxIndex - 1)]

let startTask =
    let list = [5; 1; 4; 6; 2]
    (getElementBetweenMaxValues list) |> Seq.iter (printf "%d ")