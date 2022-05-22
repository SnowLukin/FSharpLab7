module Lab6Task11

open System

let rec readList numberOfElements = 
    if numberOfElements = 0 then []
    else
        let head = Console.ReadLine() |> Convert.ToInt32
        let tail = readList (numberOfElements - 1)
        head::tail

let rec printList = function
    | [] -> ()
    | head::tail ->
        printfn "%O" head
        printList tail

let private solve list func =
    let rec getNewElementAsSumOfThree list func currentList =
        match list with
        | [] -> currentList
        | firstElement::t ->
            let secondElement = if t <> [] then t.Head else 1
            let thirdElement = if t <> [] then (if t.Tail <> [] then t.Tail.Head else 1) else 1
            let newElement = func firstElement secondElement thirdElement
            // create new list by adding newElement to currentList
            let newList = currentList @ [newElement]
            // Shift list
            // two to the right
            let shiftedList = if t <> [] then (if t.Tail <> [] then t.Tail.Tail else []) else []
            getNewElementAsSumOfThree shiftedList func newList
    getNewElementAsSumOfThree list func []

let startTask =
    printf "Number of elements in list: "
    let numberOfElements = Console.ReadLine() |> Convert.ToInt32
    printfn "Input list's elements"
    let list = readList numberOfElements
    let newList = solve list (fun firstElement secondElement thirdElement -> firstElement + secondElement + thirdElement)
    printfn "Result:"
    printList newList

(*
     EXAMPLE

     Values:
     6
     1
     2
     3
     4
     5
     6

     Result:
     6
     15
*)