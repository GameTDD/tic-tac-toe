namespace Handlers 

open Microsoft.Xna.Framework.Input

module Input =
    let IsMousePressed (mouseState: MouseState, prevState: MouseState) : bool =
        if mouseState.LeftButton = ButtonState.Pressed && prevState.LeftButton = ButtonState.Pressed then
            true
        else
            false
     
    let IsMouseClick (mouseState: MouseState, mousePrevState: MouseState) : bool =
         if mouseState.LeftButton = ButtonState.Pressed && mousePrevState.LeftButton = ButtonState.Released then
             true
         else
             false

