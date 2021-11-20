using ChatClient.Infrastructure;
using MyChatModelsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChatClient.ViewModel
{
    class ChatViewModel:Notifier
    {
        #region UI
        private Visibility connectIsVisible;
        public Visibility ConnectIsVisible
        {
            set
            {
                connectIsVisible = value;
                Notify();
            }
            get => connectIsVisible;
        }

        private Visibility warningVisibility;
        public Visibility WarningVisibility
        {
            set
            {
                warningVisibility = value;
                Notify();
            }
            get => warningVisibility;
        }

        private bool sendIsEnable;
        public bool SendIsEnable
        {
            set
            {
                sendIsEnable = value;
                Notify();
            }
            get => sendIsEnable;
        }

        private Visibility nickNameTakenLabelIsEnable;
        public Visibility NickNameTakenLabelIsEnable
        {
            set
            {
                nickNameTakenLabelIsEnable = value;
                Notify();
            }
            get => nickNameTakenLabelIsEnable;
        }

        private string textMessage;
        public string TextMessage
        {
            set
            {
                textMessage = value;
                Notify();
            }
            get => textMessage;
        }

        private string receiver;
        public string Receiver
        {
            set
            {
                receiver = value;
                Notify();
            }
            get => receiver;
        }

        #endregion

        #region Commands
        public ICommand ConnectCommand { set; get; }
        public ICommand SendCommand { set; get; }
        public ICommand SendEmailCommand { set; get; }
        #endregion

        #region Data

        private static Client client;
        private string selectedNick;
        private string nickName;

        #endregion

        public string NickName
        {
            set
            {
                nickName = value;
                Notify();
            }
            get => nickName;
        }
        public string SelectedNick
        {
            set
            {
                selectedNick = value;
                if (value == ClientsNick.ElementAt(0))
                    Receiver = ClientsNick.ElementAt(0).ToLower();
                else
                    Receiver = $"only {value}";

                Notify();
            }
            get => selectedNick;
        }
        public ObservableCollection<string> ClientsNick { get; set; }
        public ObservableCollection<MessageUI> MessagessItems { set; get; }
        public ChatViewModel()
        {
            client = new Client();
            ClientsNick = new ObservableCollection<string>();
            ClientsNick.Add("Everyone");
            SelectedNick = ClientsNick.ElementAt(0);

            ConnectIsVisible = Visibility.Visible;
            WarningVisibility = NickNameTakenLabelIsEnable = Visibility.Hidden;
            MessagessItems = new ObservableCollection<MessageUI>();
            InitCommands();

            Application.Current.MainWindow.Closing += new CancelEventHandler(ChatWindow_Closing);
        }



        private void InitCommands()
        {
            ConnectCommand = new RelayCommand(x => Task.Run(() =>
            {
               
            }));

            SendCommand = new RelayCommand(x => Task.Run(() =>
            {
               if(!Connect())
                {
                    NickNameTakenLabelIsEnable = Visibility.Visible;
                }
                ConnectIsVisible = NickNameTakenLabelIsEnable = Visibility.Hidden;
                WarningVisibility = Visibility.Visible;
                SendIsEnable = true;
                client.NickName = NickName;

                ReceiveMessage();
            }
            ));
        }

        public bool Connect()
        {
            return true;
        }

        static byte[] ReceiveMessage()
        {
            const int BUFF_SIZE = 255;
            byte[] buff = new byte[BUFF_SIZE];

            client.clientSocket.Receive(buff);

            return buff;
        }

        public void SendMessage(ClientMessage msg)
        {
            

        }
        static byte[] ConvertStringToBytes(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        static string ConvertBytesToString(byte[] data)
        {
            return Encoding.UTF8.GetString(data, 0, data.Length);
        }
        static void StartListening()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    byte[] buff = ReceiveMessage();
                    string message = ConvertBytesToString(buff);

                    Console.WriteLine($"Receive message from the server - {message}");
                }
            });
        }

        void ChatWindow_Closing(object sender, CancelEventArgs e )
        {
            try
            {
                
            }
            catch
            {

            }
        }
    }
}
