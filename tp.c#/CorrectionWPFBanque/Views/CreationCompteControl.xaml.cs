using CorrectionWPFBanque.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CorrectionWPFBanque.Views
{
    /// <summary>
    /// Logique d'interaction pour CreationCompteControl.xaml
    /// </summary>
    public partial class CreationCompteControl : UserControl
    {
        public CreationCompteControl()
        {
            InitializeComponent();
            DataContext = new CreationCompteViewModel();
        }
    }
}
