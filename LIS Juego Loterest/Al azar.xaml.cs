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
using System.Windows.Shapes;

namespace LIS_Juego_Loterest
{
    /// <summary>
    /// Lógica de interacción para Al_azar.xaml
    /// </summary>
    public partial class Al_azar : Window
    {
        public Al_azar()
        {
            InitializeComponent();
        }

        private void ButtonLoteria_Click(object sender, RoutedEventArgs e)
        {
            Perdiste perdiste = new Perdiste();
            perdiste.Show();
        }
    }
}
