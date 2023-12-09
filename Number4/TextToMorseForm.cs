using System.Windows.Forms;

namespace Number4
{
    public partial class TextToMorseForm : Form
    {
        public TextToMorseForm()
        {
            InitializeComponent();
            sourceTextBox.ToMorse(outputTextBox);
        }
    }
}