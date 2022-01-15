using System.Drawing;

namespace GordGuitar
{
    public class Designer<T> where T: System.Windows.Forms.Button
    {
        private readonly Color StandardColor;
        private readonly Color ChosenColor;
        private readonly Color MutedColor;


        private T[] collection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection">Array of buttons</param>
        public Designer(T[] collection)
        {
            this.collection = collection;

            StandardColor = Color.DarkRed;
            ChosenColor = Color.Black;
            MutedColor = Color.Gray;
        }

        public Designer(T[] collection, Color standardColor, Color chosenColor, Color mutedColor)
        {
            this.collection = collection;

            StandardColor = standardColor;
            ChosenColor = chosenColor;
            MutedColor = mutedColor;
        }

        /// <summary>
        /// Set entire collection to standard state
        /// </summary>
        public void MakeStandardAll()
        {
            for (int i = 0; i < collection.Length; i++)
            {
                collection[i].FlatAppearance.BorderColor = Color.DarkRed;
            }
        }

        /// <summary>
        /// Set button state
        /// </summary>
        /// <param name="index">index of element</param>
        /// <param name="buttonState">Button state</param>
        public void SetState(int index, ButtonState buttonState)
        {
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
        }

        /// <summary>
        /// Switch between standard state of button and second state
        /// </summary>
        /// <param name="index">index of element</param>
        /// <param name="secondState">second state for switch</param>
        public void SwitchBetweenStdand(int index, ButtonState secondState)
        {
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
        }
    }
}
