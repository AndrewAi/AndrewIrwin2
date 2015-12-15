using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AndrewIrwin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double weight = Convert.ToDouble(weightTB.Text);
            double height = Convert.ToDouble(HeigthTB.Text);
            height *= height;
            double bmi = Math.Round((weight / height)*10000);

            bmiResultTB.Text = bmi.ToString("F2");

            if (bmi <= 18.5)
            {
                bmiDescTB.Text = "Considered underweight";
            }
            else if (bmi <= 24.9)
            {
                bmiDescTB.Text = "Considered normal weight";
            }
            else if (bmi <= 29.9)
            {
                bmiDescTB.Text = "Considered overweight";
            }
            else if (bmi >= 30.0)
            {
                bmiDescTB.Text = "Considered obese weight";
            }

        }

       
    }
}
