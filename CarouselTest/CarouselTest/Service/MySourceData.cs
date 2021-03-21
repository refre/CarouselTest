using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CarouselTest.Service
{
    public class MySourceData
    {
        public List<MySource> SourceOfData { get; set; }
        public MySourceData()
        {
            SourceOfData = new List<MySource>
            {
                new MySource{BoxColor = Color.Green,ColorName="Green"},
                new MySource{BoxColor = Color.Red,ColorName="Red"},
                new MySource{BoxColor = Color.Yellow,ColorName="Yellow"},
            };
        }
    }
}
