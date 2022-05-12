module Lab8_5

open System

type VehicleLicence(serialNumber: int, name: string, model: string, category: string, enginePower: int) =
    member this.serialNumber = serialNumber
    member this.name = name
    member this.model = model
    member this.category = category
    member this.enginePower = enginePower

    member this.print() =
        Console.WriteLine("Serial number: {0}", this.serialNumber)
        Console.WriteLine("Name: {0}", this.name)
        Console.WriteLine("Model: {0}", this.model)
        Console.WriteLine("Category: {0}", this.category)
        Console.WriteLine("EnginePower: {0}", this.enginePower)

    interface IComparable<VehicleLicence> with
        member this.CompareTo other =
            compare this.serialNumber other.serialNumber

let createVehicleLicence =
    printfn "Create Vehicle Licence"

    printf "Serial number: "
    let serialNumber = Convert.ToInt32(Console.ReadLine())
    printf "Name: "
    let name = Console.ReadLine()
    printf "Model: "
    let model = Console.ReadLine()
    printf "Category: "
    let category = Console.ReadLine()
    printf "EnginePower: "
    let enginePower = Convert.ToInt32(Console.ReadLine())

    VehicleLicence(serialNumber, name, model, category, enginePower)

let startTask =
    let vehicleLicence = createVehicleLicence
    printfn "Showing results..."
    vehicleLicence.print()