namespace Regions 

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Input

module GeometricFunctions = 
    let IsInReagion (mouse: int, rect: Microsoft.Xna.Framework.Rectangle) : bool =
        if mouse >= rect.Left && mouse <= rect.Right then
            true
        else
            false


