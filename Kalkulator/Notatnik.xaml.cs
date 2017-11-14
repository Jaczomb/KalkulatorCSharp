using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Threading;
using System.ComponentModel;


namespace Kalkulator
{
    //https://stackoverflow.com/questions/1207832/wpf-dispatcher-begininvoke-and-ui-background-threads
    /// <summary>
    /// Logika interakcji dla klasy Notatnik.xaml
    /// </summary>
    public partial class Notatnik : Window
    {
        BackgroundWorker bc = new BackgroundWorker();
        public Notatnik()
        {
            InitializeComponent();

        }
        public void Tick()
        {
            lblCzas.Dispatcher.BeginInvoke((Action)(() => { lblCzas.Content = DateTime.Now.ToLongTimeString(); }));
        }
        public void bc_DoWOrk()
        {
            while(true)
            {
                Tick();
                Thread.Sleep(1000);
            }
        }
        public void LiczWGore()
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                lblLiczWGore.Dispatcher.BeginInvoke((Action)(() => { lblLiczWGore.Content = i.ToString(); }));
                Thread.Sleep(1000);
            }
        }
        public void LiczWDol()
        {
            for (int i = 300; i >= int.MinValue; i--)
            {
                txtLiczWDol.Dispatcher.BeginInvoke((Action)(() => { txtLiczWDol.Text = i.ToString(); }));
                Thread.Sleep(1000);
            }
        }

        private void btnPokazCzas_Click(object sender, RoutedEventArgs e)
        {
            new Thread(bc_DoWOrk).Start();
        }

        private void btnLiczWGore_Click(object sender, RoutedEventArgs e)
        {
            new Thread(LiczWGore).Start();
        }

        private void btnLiczWDol_Click(object sender, RoutedEventArgs e)
        {
            new Thread(LiczWDol).Start();

        }
    }
}
