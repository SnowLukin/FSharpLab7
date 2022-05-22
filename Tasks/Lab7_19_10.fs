module Lab7Task19_10

let startTask =
    let string = "abcaaba"

    let result = string |> String.filter (fun x -> x = 'A' || x = 'a') |> String.length

    printfn "%d" result