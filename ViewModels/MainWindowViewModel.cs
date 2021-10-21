using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private Command addCommand;
        public Command AddCommand
        {
            get => addCommand ?? new Command(x =>
            {
                if (!string.IsNullOrWhiteSpace(user.Login) && !string.IsNullOrWhiteSpace(user.Password))
                {
                    
                    user.Id = Users.Last().Id++;
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                    MessageBox.Show("Нет логина или пароля");
            }, f => user?.Id == 0);
        }

        private Command deleteCommamd;
        public Command DeleteCommand
        {
            get => deleteCommamd ?? new Command(a =>
            {
                context.Entry(user).State = EntityState.Deleted;
                context.SaveChanges();
            }, f => user?.Id != 0);
        }

        private Command updateCommand;
        public Command UpdateCommand
        {
            get => updateCommand ?? new Command(a =>
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
            }, f => user?.Id != 0);
        }

        private Command createCommand;
        public Command CreateCommand
        {
            get => createCommand ?? new Command(a =>
            {
                User = new User();
            }, null);
        }

        private DataBaseContext context = new DataBaseContext();
        private ObservableCollection<User> users;
        private User user;

        public User User
        {
            get => user;
            set
            {
                user = value;
                PropertyChanging(nameof(User));
            }
        }
        public ObservableCollection<User> Users
        {
            get => users;
            set
            {
                users = value;
                PropertyChanging(nameof(Users));
            }
        }

        public MainWindowViewModel()
        {
            context.Users.Load();
            Users = context.Users.Local;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void PropertyChanging(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
