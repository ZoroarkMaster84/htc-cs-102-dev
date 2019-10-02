﻿using System;
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

namespace ClassesIntro
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

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Name = "Bob";
            dog.Bark();
            dog.SayName();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            string dogName = DogName.Text;

            Dog dog = new Dog("Corgi", 12, dogName);
            dog.SayName();
        }

        private void Jonah_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
