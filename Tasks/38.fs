module Task38

open System

let private amountOfElementsInSegment list startPoint endPoint =
    let filteredList = List.filter (fun element -> List.contains(element) [startPoint..endPoint]) list
    filteredList.Length

let startTask =
    let list = [5; 1; 4; 6; 2]
    let startPoint = 3
    let endPoint = 5
    Console.WriteLine(amountOfElementsInSegment list startPoint endPoint)
