module Lab8_5

open System

type VehicleLicence(id: int, name: string, model: string, category: string, enginePower: int, serialNumber: int, codeNumber: int) =
    member this.id = id
    member this.name = name
    member this.model = model
    member this.category = category
    member this.enginePower = enginePower
    member this.serialNumber = serialNumber
    member this.codeNumber = codeNumber

    member this.print() =
        Console.WriteLine("Id: {0}", this.id)
        Console.WriteLine("Name: {0}", this.name)
        Console.WriteLine("Model: {0}", this.model)
        Console.WriteLine("Category: {0}", this.category)
        Console.WriteLine("EnginePower: {0}", this.enginePower)
        Console.WriteLine("Serial number: {0}", this.serialNumber)
        Console.WriteLine("Code number: {0}", this.codeNumber)

let createVehicleLicence =
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
    printf "Serial number: "
    let serialNumber = Convert.ToInt32(Console.ReadLine())
    printf "Code number: "
    let codeNumber = Convert.ToInt32(Console.ReadLine())

    VehicleLicence(id, name, model, category, enginePower, serialNumber, codeNumber)

let startTask =
    let vehicleLicence = createVehicleLicence
    printfn "Showing results..."
    vehicleLicence.print()