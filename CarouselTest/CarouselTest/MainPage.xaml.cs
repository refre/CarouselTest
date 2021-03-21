using CarouselTest.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyCarrousel.ItemsSource = new MySourceData().SourceOfData;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var carousel = this.Content.FindByName<CarouselView>("MyCarrousel");
            var listOfControls = carousel.VisibleViews;
            var gridControl = listOfControls[0] as Grid;
            var controlsInsideGrid = gridControl.Children;

            var labelName = controlsInsideGrid[1] as Label;
            var button = controlsInsideGrid[2] as Button;

            button.BackgroundColor = Color.Blue;

            

            await DisplayAlert("Message", $"The displayed color is {labelName.Text}", "Ok");

        }
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    var control = MyCarrousel.FindByName("Btn1");
        //}
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    var control = MyCarrousel.FindByName("MyGrid");
        //}
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    var control = this.Content.FindByName<Button>("Btn1");
        //}
    }
}
