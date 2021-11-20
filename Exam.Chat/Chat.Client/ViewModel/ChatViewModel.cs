using ChatClient.Infrastructure;
using MyChatModelsLibrary.Models;
using System;
using System.Collections.Generic;
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

        private Visibility usernameTakenLabelIsEnable;
        public Visibility UsernameTakenLabelIsEnable
        {
            set
            {
                usernameTakenLabelIsEnable = value;
                Notify();
            }
            get => usernameTakenLabelIsEnable;
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




        public void SendMessage(ClientMessage msg)
        {

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
