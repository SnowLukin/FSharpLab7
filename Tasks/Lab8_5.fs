module Lab8_5

open System

type VehicleLicence(id: int, name: string, model: string, category: string, enginePower: int) =
    member this.id = id
    member this.name = name
    member this.model = model
    member this.category = category
    member this.enginePower = enginePower

    member this.print() =
        Console.WriteLine("Id: {0}", this.id)
        Console.WriteLine("Name: {0}", this.name)
        Console.WriteLine("Model: {0}", this.model)
        Console.WriteLine("Category: {0}", this.category)
        Console.WriteLine("EnginePower: {0}", enginePower)

let startTask =
    printfn "Create Vehicle Licence"
    printf "Id: "
    let id = Convert.ToInt32(Console.ReadLine())
    printf "Name: "
    let name = Console.ReadLine()
    printf "Model: "
    let model = Console.ReadLine()
    printf "Category: "
    let category = Console.ReadLine()
    printf "EnginePower: "
    let enginePower = Convert.ToInt32(Console.ReadLine())
    printfn "Showing results..."
    let vehicleLicence = VehicleLicence(id, name, model, category, enginePower)
    vehicleLicence.print()