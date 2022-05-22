module Lab7Task17_8

let getDigitsOfNumber number =
    let rec loop number result =
        match number with
        | 0 -> result
        | _ -> loop (number / 10) (result |> List.append [number % 10])
    loop number []

let getListOfDigits list =
    list |> List.collect (fun x -> getDigitsOfNumber x)

let getRepeatAmount list number =
    list |> List.filter (fun x -> number = x) |> List.length

let isRepeatingMoreThanHalf list number =
    let elementRepeatAmount = getRepeatAmount list number
    let checkList = [0..9]
    let rec loop subList counter =
        match subList with
        | [] -> counter
        | head::tail ->
            if getRepeatAmount list head < elementRepeatAmount then loop tail (counter + 1)
            else loop tail counter
    let amountOfElementRepeatedMoreThanGiven = loop checkList 0
    // 10 - all digits
    // 5 - half of em
    if amountOfElementRepeatedMoreThanGiven > 5 then true else false

let solve list =
    let listOfDigits = getListOfDigits list
    list |> List.collect (fun x -> getDigitsOfNumber x |> List.filter (fun y -> isRepeatingMoreThanHalf listOfDigits y))

let startTask =
    //printf "Number of elements in list: "
    //let listSize = Console.ReadLine() |> Convert.ToInt32
    //printfn "Input elements"
    //let list = Task48.readList listSize
    let list = [1..10]
    let listOfDigits = getListOfDigits list
    list |> List.collect (fun x -> getDigitsOfNumber x |> List.filter (fun y -> isRepeatingMoreThanHalf listOfDigits y)) |> Seq.iter (printf "%d ")
    