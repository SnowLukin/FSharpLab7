module Task3

// Read Data from Input
let private readData dataName =
    printf "%s: " dataName
    Input.getValue()
    

// Circle Aread
let private getCircleArea radius = radius * radius * System.Math.PI

// << Cylinder Volume >> 

// currying
let private getCylinderVolume radius =
    let cylinderVolume length =
        radius * radius * System.Math.PI * length
    cylinderVolume


let private getCylinderVolumeForSuperposition (circleArea: float -> float) radius length = (circleArea radius) * length

let private getCylinderVolumeFormula circleArea length = circleArea * length
let private getCylinderVolumeUsingComposition = getCircleArea >> getCylinderVolumeFormula



let startTask =
    printfn "<< Circle Area and Cylinder Volume >>"

    let radius = readData "Radius"
    let length = readData "Length"

    System.Console.Write("Area of the circle = ")
    System.Console.WriteLine(getCircleArea radius)
    
    System.Console.Write("Volume of Cylinder = ")
    System.Console.WriteLine(getCylinderVolume radius length)
    
    System.Console.Write("Volume of Cylinder = ")
    System.Console.WriteLine(getCylinderVolumeForSuperposition getCircleArea radius length)

    System.Console.Write("Volume of Cylinder = ")
    System.Console.WriteLine(getCylinderVolumeUsingComposition radius length)