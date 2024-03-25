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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SPage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            signinSp.Visibility = Visibility.Visible;
            loginSp.Visibility = Visibility.Hidden;
            ThicknessAnimationUsingKeyFrames th = new ThicknessAnimationUsingKeyFrames();
            KeyTime keyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            Thickness thickness1 = new Thickness(0, 0, 400, 0);
            KeyTime keyTime2 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.2));
            Thickness thickness2 = new Thickness(400, 0, 0, 0);
            th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness1, keyTime1));
            th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness2, keyTime2));
            bord.BeginAnimation(MarginProperty, th);
        }

        private void Border_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            signinSp.Visibility = Visibility.Hidden;
            loginSp.Visibility = Visibility.Visible;
            ThicknessAnimationUsingKeyFrames th = new ThicknessAnimationUsingKeyFrames();
            KeyTime keyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            Thickness thickness1 = new Thickness(400, 0, 0, 0);
            KeyTime keyTime2 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.2));
            Thickness thickness2 = new Thickness(0, 0, 400, 0);
            th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness1, keyTime1));
            th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness2, keyTime2));
            bord.BeginAnimation(MarginProperty, th);
        }
    }
}
