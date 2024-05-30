using NaychnaKonferencia.Aplicationdata;
using System;
using System.Collections.Generic;
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

namespace NaychnaKonferencia.MainPage
{
    /// <summary>
    /// Логика взаимодействия для Avtorizacia.xaml
    /// </summary>
    public partial class Avtorizacia : Page
    {
        public Avtorizacia()
        {
            InitializeComponent();
        }
        ///Авторизация///
        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    var userObj = NAychnaKonferenciaEntities.GetContext().user.FirstOrDefault(x => x.login == Login.Text && x.password == Password.Text);
                    if (userObj == null)
                    {
                        MessageBox.Show("Такого пользователя нет!", "Ошибка авторизации!", MessageBoxButton.OK, MessageBoxImage.Error);

                    }

                    else
                    {
                        switch (userObj.userid)
                        {
                            case 1:
                                MessageBox.Show("Здраствуйте,Организатор " + userObj.lastname + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                AppFrame.FrameMain.Navigate(new Organization());
                                break;

                            case 2:
                                MessageBox.Show("Здраствуйте, Техник " + userObj.lastname + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                AppFrame.FrameMain.Navigate(new Texnic());
                                break;

                            case 3:
                                MessageBox.Show("Здраствуйте, Заведующий подразделением " + userObj.lastname + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                AppFrame.FrameMain.Navigate(new ZavedyushiOtdelenia());
                                break;
                            default:
                                MessageBox.Show("Данные не обнаружены!");
                                break;
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая ошибка", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
               
            }
        }
    }
}
