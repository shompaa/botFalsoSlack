using SlackAPI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;


namespace BotFalsoSlack
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private static async Task EnviarMensajeAlBot(string mensaje)
        {
            const string TOKEN = "xoxb-1078280749793-1064282359525-XpjVVS9IT2btexCd4nYZLC87";  // token from last step in section above
            var slackClient = new SlackTaskClient(TOKEN);
            
            var response = await slackClient.PostMessageAsync("#botfalso", mensaje);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await EnviarMensajeAlBot(textBox.Text.ToString());

        }
    }
}
