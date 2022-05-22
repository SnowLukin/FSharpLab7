module Lab7Task18_8

open System

let startTask =
    let firstArray = List.toArray [ for i in 1 .. (Convert.ToInt32(Console.ReadLine())) -> Convert.ToInt32(Console.ReadLine()) ]
    let secondArray = List.toArray [ for i in 1 .. (Convert.ToInt32(Console.ReadLine())) -> Convert.ToInt32(Console.ReadLine()) ]
    //let firstArray = [| 1; 2; 3; 4; 5; 7 |]
    //let secondArray = [| 1; 3; 5; 6 |]

    let resultArray = Array.append (firstArray |> Array.except secondArray) (secondArray |> Array.except firstArray)
    
    printf "%A" (resultArray)


    // Size of first array: 4
    // 1
    // 2
    // 3
    // 4
    //  Size of second array: 2
    // 1
    // 8
    // Result [|2; 3; 4; 8|]