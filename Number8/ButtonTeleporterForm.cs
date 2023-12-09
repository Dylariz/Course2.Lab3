using System.Windows.Forms;

namespace Number8
{
    /// <summary>
    /// Задание:
    /// На форме одна кнопка.
    /// После нажатия на кнопку она начинает хаотически перемещаться по форме, меняя свое местоположение каждые 0,5 с.
    /// </summary>
    public partial class ButtonTeleporterForm : Form
    {
        public ButtonTeleporterForm()
        {
            InitializeComponent();
            jumpButton.StartJumpingAfterClick(); // Добавляем функциональность кнопке
        }
    }
}