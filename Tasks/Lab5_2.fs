module Task2

// Result Type
type SolveResult =
      None    // No solutions
    | Linear of float   // Linear Equation
    | Quadratic of float*float    // Quadratic Equation

// Count desciminant and return SolveResult
let private getSolutions a b c =
    let descriminant = b * b - 4. * a * c
    if a = 0. then
        if b = 0. then None
        else Linear(-c / b)
    else
        if descriminant < 0. then None
        else Quadratic((-b - sqrt(descriminant)) / (2. * a), (-b + sqrt(descriminant)) / (2. * a))

// Print Result
let private showResult(result: SolveResult) =
    match result with
    None -> printf "No solutions"
    | Linear(x) -> printfn "Linear equation:"
                   printf "x = %f" x
    | Quadratic(x1, x2) when x1 = x2 -> printfn "Quadratic Equation with one solution:"
                                        printfn "x = %f" x1
    | Quadratic(x1, x2) -> printfn "Quadratic Equation:"
                           printfn "x₁₂ = %f" x1
                           printf "x₂ = %f" x2

// Main 
let showSolutionsOfEquation =
    printfn "Equation: ax² + bx + x = 0"

    printf "a = "
    let a = Input.getValue()

    printf "b = "
    let b = Input.getValue()

    printf "c = "
    let c = Input.getValue()

    showResult(getSolutions a b c)