module Lab7Task48

open System

let private getElement (index, _) = index

let private tupleListToIntList list =
    let rec loop list resultList =
        match list with
        | [] -> resultList
        | (index, element) :: tail ->
            loop tail (resultList @ [index])
    loop list []



let private getMostFrequentElement list =
    let newList = list |> List.countBy id
    getElement (List.maxBy(fun (_, amount) -> amount) newList)
    
let private getListOfIndexesOfMostFrequentElement list =
    let mostFrequentElement = getMostFrequentElement list
    let indexedList = List.indexed list
    let filteredList = List.filter (fun (_, element) -> element = mostFrequentElement) indexedList
    tupleListToIntList filteredList


let rec readList numberOfElements =
    if numberOfElements = 0 then []
    else
        let head = Console.ReadLine() |> Convert.ToInt32
        let tail = readList (numberOfElements - 1)
        head :: tail

let startTask =
    //printf "Number of elements in list: "
    //let listSize = Console.ReadLine() |> Convert.ToInt32
    //printfn "Input elements"
    //let list = readList listSize
    let list = [1; 2; 3; 1; 5; 3; 3]
    getListOfIndexesOfMostFrequentElement list |> Seq.iter (printf "%d ")
