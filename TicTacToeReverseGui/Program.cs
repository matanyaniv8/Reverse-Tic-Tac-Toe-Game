using System.Windows.Forms;

namespace TicTacToeReverseGui
{
    internal class Program
    {
        public static void Main()
        {
             runGame();
        }

        private static void runGame()
        {
            Application.EnableVisualStyles();

            GameSettings gameSettingForm = new GameSettings();
            gameSettingForm.ShowDialog();
        }
    }
}
