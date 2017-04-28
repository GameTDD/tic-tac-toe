namespace Handlers 

open Microsoft.Xna.Framework.Input

module Input =
    let IsMousePressed (mouseState: MouseState) : bool =
        if mouseState.LeftButton = ButtonState.Pressed then
            true
        else
            false
     
    let IsMouseClick (mouseState: MouseState, mousePrevState: MouseState) : bool =
         false

