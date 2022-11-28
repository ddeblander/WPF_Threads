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
using WPF_Threads.Model;
using WPF_Threads.ViewModele;

namespace WPF_Threads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person p1, p2, p3;
        private Road r1,r2,r3;
        private Magasin m1, m2, m3;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartThreading(object sender, RoutedEventArgs e)
        {
            r1 = new Road("Rue 1", 0, 0);
            r2 = new Road("Rue 2", 5, 5);
            r3 = new Road("Rue 3", 10, 10);

            m1 = new Magasin("InterOne", r1);
            m2 = new Magasin("InterTwo", r2);
            m3 = new Magasin("InterThree", r3);

            p1 = new Person("George",2,r1);
            p2 = new Person("Jean",1,r2);
            p3 = new Person("Roger",5,r3);
            ToTheMove(p1,m2);
            ToTheMove(p2,m3);
            ToTheMove(p3,m1);
        }
        private async Task ToTheMove(Person p,Magasin m)
        {
            threadActif.Items.Add($"{p.Name} : is moving");
            threadActif.Items.Refresh();
            await Task.Delay(MoveToMag.Moving(p,m));
            p.R = m.Road;
            threadActif.Items.Remove($"{p.Name} : is moving");
            threadInactif.Items.Add($"{p.Name} : is shopping at {m.Name}");
            threadActif.Items.Refresh();

            
        }

    }
}
