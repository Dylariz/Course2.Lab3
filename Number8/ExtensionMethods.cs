using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number8
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Добавляет функциональность кнопке, которая позволяет ей прыгать по форме после нажатия на нее
        /// </summary>
        public static void StartJumpingAfterClick(this Button buttonToJump)
        {
            var window = (Form)buttonToJump.Parent; // Получаем форму, на которой находится кнопка
            var random = new Random();
            
            int minX = 0;
            int minY = 0;
            bool shouldJump = false; // Флаг, указывающий, должна ли кнопка прыгать

            // Добавляем обработчик события Click для кнопки,
            // представляет из себя инструкцию, которая будет выполнена при нажатии на кнопку
            buttonToJump.Click += (sender, args) =>
            {
                shouldJump = !shouldJump; 

                // Запускаем новую задачу в отдельном потоке, это позволяет не блокировать основной поток
                Task.Run(() =>
                {
                    while (shouldJump)
                    {
                        // Вычисляем максимальные координаты для перемещения кнопки
                        int maxX = window.ClientSize.Width - buttonToJump.Width;
                        int maxY = window.ClientSize.Height - buttonToJump.Height;

                        // Используем Invoke для выполнения кода в основном потоке,
                        // поскольку все операции с пользовательским интерфейсом должны выполняться в основном потоке,
                        // он принимает делегат MethodInvoker 
                        window.Invoke((MethodInvoker)delegate
                        {
                            // Перемещаем кнопку в случайное место в пределах формы
                            buttonToJump.Location = new Point(random.Next(minX, maxX), random.Next(minY, maxY));
                        });
                        
                        Thread.Sleep(500); // Приостанавливаем поток на 0,5 секунды
                    }
                });
            };
        }
    }
}