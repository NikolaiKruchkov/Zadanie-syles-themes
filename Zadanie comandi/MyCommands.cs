using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Zadanie_comandi
{
    class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand Save { get; set; }
        public static RoutedCommand Open { get; set; }
        public static RoutedCommand newWindow { get; set; }
        public static RoutedCommand inCenter { get; set; }
        public static RoutedCommand showError { get; set; }
        public static RoutedCommand darkThemes { get; set; }
        public static RoutedCommand whiteThemes { get; set; }

        static MyCommands()
        {
            InputGestureCollection input1 = new InputGestureCollection();
            input1.Add(new KeyGesture(Key.X, ModifierKeys.Control, "Ctr+X"));
            InputGestureCollection input2 = new InputGestureCollection();
            input2.Add(new KeyGesture(Key.S, ModifierKeys.Control, "Ctr+S"));
            InputGestureCollection input3 = new InputGestureCollection();
            input3.Add(new KeyGesture(Key.O, ModifierKeys.Control, "Ctr+O"));
            InputGestureCollection input4 = new InputGestureCollection();
            input4.Add(new KeyGesture(Key.W, ModifierKeys.Control, "Ctr+W"));
            InputGestureCollection input5 = new InputGestureCollection();
            input5.Add(new KeyGesture(Key.I, ModifierKeys.Control, "Ctr+I"));
            InputGestureCollection input6 = new InputGestureCollection();
            input6.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctr+E"));
            InputGestureCollection input7 = new InputGestureCollection();
            input7.Add(new KeyGesture(Key.D, ModifierKeys.Control, "Ctr+D"));
            InputGestureCollection input8 = new InputGestureCollection();
            input8.Add(new KeyGesture(Key.G, ModifierKeys.Control, "Ctr+G"));
            Exit = new RoutedUICommand("Выход","Exit",typeof(MyCommands),  input1);
            Save = new RoutedUICommand("Сохранить", "Save", typeof(MyCommands), input2);
            Open = new RoutedUICommand("Открыть", "Open", typeof(MyCommands), input3);
            newWindow = new RoutedUICommand("Новое окно", "New Window", typeof(MyCommands), input4);
            inCenter = new RoutedUICommand("В центр", "In Center", typeof(MyCommands), input5);
            showError = new RoutedUICommand("Показать ошибку", "Show Error", typeof(MyCommands), input6);
            darkThemes = new RoutedUICommand("Темная тема", "Dark themes", typeof(MyCommands), input7);
            whiteThemes = new RoutedUICommand("Светлая тема", "White themes", typeof(MyCommands), input8);
        }
    }
}
