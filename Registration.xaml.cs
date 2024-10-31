using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void UsernameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text == "введите имя пользователя")
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }
        private void UsernameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                UsernameTextBox.Text = "введите имя пользователя";
                UsernameTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }
        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailTextBox.Text == "exam@yandex.ru")
            {
                EmailTextBox.Text = "";
                EmailTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }
        private void EmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                EmailTextBox.Text = "exam@yandex.ru";
                EmailTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }
        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text == "введите пароль")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }
        private void PasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                PasswordTextBox.Text = "введите пароль";
                PasswordTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }
        private void ConfirmPasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ConfirmPasswordTextBox.Text == "повторите пароль")
            {
                ConfirmPasswordTextBox.Text = "";
                ConfirmPasswordTextBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }
        
        private void ConfirmPasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
            {
                ConfirmPasswordTextBox.Text = "повторите пароль";
                ConfirmPasswordTextBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        } 
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Валидация имени пользователя
            if (UsernameTextBox.Text == "введите имя пользователя" || string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя.");
                return;
            }

            // Валидация адреса электронной почты if (EmailTextBox.Text == "exam@yandex.ru" || string.IsNullOrWhiteSpace(EmailTextBox.Text) || !IsValidEmail(EmailTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите корректный адрес электронной почты.");
                return;
            }
        }
        private bool IsValidEmail(string email)
        {
            // Простейшая валидация email с использованием регулярных выражений
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        } 

        private void ConfirmPasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
