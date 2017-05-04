namespace Regions 

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Input

module GeometricFunctions = 
    let IsBetweenLimits (mousePoint: int, inferiorLimit: int, superiorLimit: int) : bool =
        if mousePoint >= inferiorLimit && mousePoint <= superiorLimit then
            true
        else
            false

    let IsInReagion (mouse: Point, rect: Microsoft.Xna.Framework.Rectangle) : bool =
        IsBetweenLimits(mouse.X, rect.Left, rect.Right) && IsBetweenLimits(mouse.Y, rect.Top, rect.Bottom)

