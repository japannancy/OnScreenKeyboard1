using System;

namespace OnScreenKeyboard1
{
    public class InterfaceInput
    {
        public static InterfaceInput UP = new InterfaceInput("UP", keyboard => keyboard.MoveCursor(new Position(0, 1)));
        public static InterfaceInput DOWN = new InterfaceInput("DOWN", keyboard => keyboard.MoveCursor(new Position(0, -1)));
        public static InterfaceInput LEFT = new InterfaceInput("LEFT", keyboard => keyboard.MoveCursor(new Position(-1, 0)));
        public static InterfaceInput RIGHT = new InterfaceInput("RIGHT", keyboard => keyboard.MoveCursor(new Position(1, 0)));
        public static InterfaceInput SPACE = new InterfaceInput("SPACE", keyboard => keyboard.AddSpace());
        public static InterfaceInput SELECT = new InterfaceInput("SELECT", keyboard => keyboard.AddKeyAtCursor());
        
        
        private String name;
        private Action<Keyboard> keyboardAction;

        public void InterfaceInput(String name, Action<Keyboard> keyboardAction)
        {
            this.name = name;
            this.keyboardAction = keyboardAction;
        }

        public void Trigger(Keyboard keyboard)
        {
            keyboardAction(keyboard);
        }
    }
}
