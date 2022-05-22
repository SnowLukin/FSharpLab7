module Task58

open System

let private sumOfTuple (a, b) = a + b

let private allPairs list =
    let rec loop list resultList =
        match list with
        | [] -> resultList
        | head :: tail ->
            let updatedResultList = resultList @ List.allPairs [head] tail
            loop tail (updatedResultList)
    loop list []

let private getListOfSum list =
    let rec loop list resultList =
        match list with
        | [] -> resultList
        | head :: tail ->
            loop tail (resultList @ [sumOfTuple head])
    loop list []

let private getAmountOfMatchedElements mainList subList =
    let rec loop list counter =
        match list with
        | [] -> counter
        | head :: tail ->
            if List.contains(head) subList then loop tail (counter + 1)
            else loop tail counter
    loop mainList 0

let startTask =
    //printf "Number of elements in list: "
    //let listSize = Console.ReadLine() |> Convert.ToInt32
    //printfn "Input elements"
    //let list = readList listSize
    let list = [1..10]
    list |> Seq.iter (printf "%d ")
    printfn ""
    let allPairsList = allPairs list
    //allPairsList |> Seq.iter (printf "%d ")
    let listOfSums = getListOfSum allPairsList
    listOfSums |> Seq.iter (printfn "%d ")
    Console.WriteLine(getAmountOfMatchedElements list listOfSums)

    // 3, 4, 5, 6, 7, 8, 9, 10 = 8
