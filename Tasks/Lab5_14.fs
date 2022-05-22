module Task14

open System

let rec private subGetValueFromDividers number action initValue devider =
    if devider = 0 then initValue
    else
        let initValue = if number % devider = 0 then action initValue devider else initValue
        let devider = devider - 1
        subGetValueFromDividers number action initValue devider

let getValueFromDividers number action initValue =
    subGetValueFromDividers number action initValue number

let startTask =
    printf "Number: "
    let number = Convert.ToInt32(Input.getValue())
    let result = getValueFromDividers number (fun x y -> x * y) 1
    Console.WriteLine("Result: {0}", result)