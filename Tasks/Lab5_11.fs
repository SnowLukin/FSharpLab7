module Task11

open System

let getAnswer language = 
    match language with
        | "F#" | "Prolog" -> "Kiss-ass 🤭"
        | "Swift" -> "My respect. Man of culture."
        | "Python" -> "Why do coding yourself when others have already done that?"
        | "С++" -> "You prob either a student or mathematician."
        | "Ruby" -> "You like things to be hard, dont you?"
        | "С#" -> "Unity?"
        | "PHP" -> "Sounds ancient"
        | other -> "Wow, really? Idc..."

let startTask =
    printfn "Whats your favorite programming language?"
    let usersLanguage = Console.ReadLine()
    let answer = getAnswer usersLanguage
    Console.WriteLine(answer)