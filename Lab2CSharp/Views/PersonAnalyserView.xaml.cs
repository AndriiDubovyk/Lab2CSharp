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
using Lab2CSharp.ViewModels;

namespace Lab2CSharp.Views
{
    /// <summary>
    /// Interaction logic for PersonAnalyserView.xaml
    /// </summary>
    public partial class PersonAnalyserView : UserControl
    {
        private PersonAnalyserViewModel _viewModel;

        public PersonAnalyserView()
        {
            InitializeComponent();
            DataContext = _viewModel = new PersonAnalyserViewModel();
        }
    }
}
