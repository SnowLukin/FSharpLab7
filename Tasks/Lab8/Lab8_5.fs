module Lab8_5

type VehicleLicence(id: int, name: string, model: string, category: string, yearOfManufacture: int, enginePower: double) =
    member this.id = id
    member this.name = name
    member this.model = model
    member this.category = category
    member this.yearOfManufacture = yearOfManufacture
    member this.enginePower = enginePower
