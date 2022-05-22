module Lab6Task6

let private shiftListToTheLeft list shiftCount =
   let rec shift list (acc: int list) counter =
       match list with
       | _ when counter = 0 -> list @ acc
       | head :: tail -> shift tail (acc @ [head]) (counter - 1)
       | [] -> shift acc [] counter
   shift list [] shiftCount

let startTask =
    let list = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
    shiftListToTheLeft list 2 |> Seq.iter (printf "%d ")