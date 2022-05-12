module Lab8_5

type VehicleLicence(id: int, name: string, model: string, category: string, yearOfManufacture: int, enginePower: double) =
    member this.id
        with get() = id
    member this.name
        with get() = name
    member this.model
        with get() = model
    member this.category
        with get() = category
    member this.yearOfManufacture
        with get() = yearOfManufacture
    member this.enginePower
        with get() = enginePower
