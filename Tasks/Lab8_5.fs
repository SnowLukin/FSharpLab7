module Lab8_5

open System
open System.Text.RegularExpressions

type VehicleLicence(serialNumber: int, name: string, model: string, category: string, enginePower: int) =
    member this.serialNumber
        with get() = serialNumber
        and set(value: int) =
            if Regex.IsMatch (System.Convert.ToString(value), @"[0-9]")
            then this.serialNumber <- value
            else System.Console.WriteLine("Invalid input")
    member this.name
        with get() = name
        and set(value: string) =
            if Regex.IsMatch (value, @"[a-z]")
            then this.name <- value
            else System.Console.WriteLine("Invalid input")
    member this.model
        with get() = model
        and set(value: string) =
            if Regex.IsMatch (value, @"[a-z]")
            then this.model <- value
            else System.Console.WriteLine("Invalid input")
    member this.category
        with get() = category
        and set(value: string) =
            if Regex.IsMatch (value, @"[a-z]")
            then this.category <- value
            else System.Console.WriteLine("Invalid input")
    member this.enginePower
        with get() = enginePower
        and set(value: int) =
            if Regex.IsMatch (System.Convert.ToString(value), @"[0-9]")
            then this.enginePower <- value
            else System.Console.WriteLine("Invalid input")

    member this.print() =
        Console.WriteLine("Serial number: {0}", this.serialNumber)
        Console.WriteLine("Name: {0}", this.name)
        Console.WriteLine("Model: {0}", this.model)
        Console.WriteLine("Category: {0}", this.category)
        Console.WriteLine("EnginePower: {0}", this.enginePower)

    interface IComparable with
        member this.CompareTo(o:obj):int = 
            match o with
            | :? VehicleLicence as other -> if (this.serialNumber = other.serialNumber) then 1 else 0
            |_->0

let compareVehicleLicence v1 v2 =
    if compare v1 v2 = 1 then
        printfn "Identical"
    else printfn "Not identical"
let startTask =
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

    let vehicleLicence = VehicleLicence(serialNumber, name, model, category, enginePower)
    printfn "Showing results..."
    vehicleLicence.print()

    // Comparison 
    let v1 = VehicleLicence(1, "", "", "", 1)
    let v2 = VehicleLicence(2, "", "", "", 1)

    compareVehicleLicence v1 v2