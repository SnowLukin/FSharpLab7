module Lab9_OOP

type IPrint = interface
    abstract member Print: unit -> unit
    end

[<AbstractClass>]
type  Figure() =
    abstract member GetArea: unit -> double
    
type Rectangle (width: double, height: double) = 
    inherit Figure()

    let mutable _width = width
    let mutable _height = height

    member this.Width
        with get() = _width
        and set(value) =  _width  <- value

    member this.Height
        with get() = _height
        and set(value) = _height <- value

    override this.GetArea() =  this.Width * this.Height 
    override this.ToString() = 
        (this.Width, this.Height, (this.GetArea()))
        |||> sprintf "Rectangle |width = %f| |height = %f| |area = %f|" 
    
    interface IPrint with
        member this.Print() =
            this.ToString()
            |> printfn "%s"
    member this.Print() = (this :> IPrint).Print()

type Square (side: double) =
    inherit Rectangle(side, side)

    let mutable _side = side
    
    override this.ToString() =
        (this.Width, this.GetArea())
        ||> sprintf "Square |side = %f| |area = %f|" 

type Circle (radius: double) =
    inherit Figure()

    let mutable _radius = radius

    member this.Radius
        with get() = _radius
        and set(value) = _radius <- value

    override this.GetArea() = this.Radius * this.Radius * System.Math.PI

    override this.ToString() =
        (this.Radius, this.GetArea())
        ||> sprintf "Circle |radius = %f| |area = %f|"
    
    interface IPrint with
        member this.Print() =
            this.ToString() |> printfn "%s"
    member this.Print() = (this :> IPrint).Print()

type GeometricalFigure =
    |FRectangle of double * double
    |FSquare of double
    |FCircle of double

let quantifyArea (figure: GeometricalFigure) =
    match figure with
    | FRectangle(width, height) -> width * height
    | FSquare(side) -> side * side
    | FCircle(radius) -> System.Math.PI * radius * radius


let startTask = 
    List.iter (fun (figure:IPrint) -> figure.Print())  [Rectangle(10.0, 5.5); Square(7.77); Circle(3.22)]
    printfn ""
    List.iter (fun (figure:GeometricalFigure) -> printfn "%A | %f" figure  (quantifyArea figure)) [FRectangle(10.0, 5.5); FSquare(7.77); FCircle(3.22)]