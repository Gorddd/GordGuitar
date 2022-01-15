using System.Drawing;

namespace GordGuitar
{
    public class Designer<T> where T: System.Windows.Forms.Button
    {
        private T[] collection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection">Array of buttons</param>
        public Designer(T[] collection)
        {
            this.collection = collection;
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
                    collection[index].FlatAppearance.BorderColor = Color.DarkRed;
                    break;
                case ButtonState.Chosen:
                    collection[index].FlatAppearance.BorderColor = Color.Black;
                    break;
                case ButtonState.Muted:
                    collection[index].FlatAppearance.BorderColor = Color.Gray;
                    break;
                default:
                    throw new System.ArgumentException();
            }
        }
    }
}
