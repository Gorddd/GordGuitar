using System.Drawing;

namespace GordGuitar
{
    public class Designer<T> where T: System.Windows.Forms.Button
    {
        private readonly Color StandardColor;
        private readonly Color ChosenColor;
        private readonly Color MutedColor;

        private readonly ColorMode colorMode;


        private T[] collection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection">Array of buttons</param>
        public Designer(T[] collection, ColorMode colorMode)
        {
            this.collection = collection;

            this.colorMode = colorMode;

            StandardColor = Color.DarkRed;
            ChosenColor = Color.Black;
            MutedColor = Color.Gray;
        }

        public Designer(T[] collection, ColorMode colorMode, Color standardColor, Color chosenColor, Color mutedColor)
        {
            this.collection = collection;

            this.colorMode = colorMode;

            StandardColor = standardColor;
            ChosenColor = chosenColor;
            MutedColor = mutedColor;
        }

        /// <summary>
        /// Set entire collection to standard state
        /// </summary>
        public void MakeStandardAll()
        {
            switch (colorMode)
            {
                case ColorMode.Back:
                    for (int i = 0; i < collection.Length; i++)
                    {
                        collection[i].BackColor = StandardColor;
                    }
                    return;
                case ColorMode.Border:
                    for (int i = 0; i < collection.Length; i++)
                    {
                        collection[i].FlatAppearance.BorderColor = StandardColor;
                    }
                    return;
            }
        }

        /// <summary>
        /// Set button state
        /// </summary>
        /// <param name="index">index of element</param>
        /// <param name="buttonState">Button state</param>
        public void SetState(int index, ButtonState buttonState)
        {
            if (index == -1)
                return;

            switch (colorMode)
            {
                case ColorMode.Back:
                    switch (buttonState)
                    {
                        case ButtonState.Standart:
                            collection[index].BackColor = StandardColor;
                            break;
                        case ButtonState.Chosen:
                            collection[index].BackColor = ChosenColor;
                            break;
                        case ButtonState.Muted:
                            collection[index].BackColor = MutedColor;
                            break;
                        default:
                            throw new System.ArgumentException();
                    }
                    return;

                case ColorMode.Border:
                    switch (buttonState)
                    {
                        case ButtonState.Standart:
                            collection[index].FlatAppearance.BorderColor = StandardColor;
                            break;
                        case ButtonState.Chosen:
                            collection[index].FlatAppearance.BorderColor = ChosenColor;
                            break;
                        case ButtonState.Muted:
                            collection[index].FlatAppearance.BorderColor = MutedColor;
                            break;
                        default:
                            throw new System.ArgumentException();
                    }
                    return;
            }
        }

        /// <summary>
        /// Switch between standard state of button and second state
        /// </summary>
        /// <param name="index">index of element</param>
        /// <param name="secondState">second state for switch</param>
        public void SwitchBetweenStdand(int index, ButtonState secondState)
        {
            switch (colorMode)
            {
                case ColorMode.Back:
                    if (collection[index].BackColor == StandardColor)
                        switch (secondState)
                        {
                            case ButtonState.Standart:
                                collection[index].BackColor = StandardColor;
                                break;
                            case ButtonState.Chosen:
                                collection[index].BackColor = ChosenColor;
                                break;
                            case ButtonState.Muted:
                                collection[index].BackColor = MutedColor;
                                break;
                            default:
                                throw new System.ArgumentException();
                        }
                    else
                        collection[index].BackColor = StandardColor;
                    return;

                case ColorMode.Border:
                    if (collection[index].FlatAppearance.BorderColor == StandardColor)
                        switch (secondState)
                        {
                            case ButtonState.Standart:
                                collection[index].FlatAppearance.BorderColor = StandardColor;
                                break;
                            case ButtonState.Chosen:
                                collection[index].FlatAppearance.BorderColor = ChosenColor;
                                break;
                            case ButtonState.Muted:
                                collection[index].FlatAppearance.BorderColor = MutedColor;
                                break;
                            default:
                                throw new System.ArgumentException();
                        }
                    else
                        collection[index].FlatAppearance.BorderColor = StandardColor;
                    return;
            }
        }
    }
}
