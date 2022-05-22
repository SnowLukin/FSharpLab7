module Input

// Safe unwrapping String to Int
let rec getValue() =
    let input = System.Console.ReadLine()
    match System.Double.TryParse input with
    | (true, number) -> number
    | (false, _)     -> printfn "Invalid input. It must be Integer. Try to input again."
                        getValue()  // Start input again