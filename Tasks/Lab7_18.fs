module Task18

let private getElementsBeforeMin list =
    let minElement = List.min list
    let indexOfMinElement = List.findIndex (fun element -> element = minElement) list
    list.[0..(indexOfMinElement - 1)]

let startTask =
    let list = [5; 4; 1; 6; 2]
    getElementsBeforeMin list |> Seq.iter (printf "%d ")