using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    class PlayingCard
    {
        public int Rank { get; set; }
        public string Suit { get; set; }
    }

    public class Class1
    {

        public void Foo()
        {
            List<int> myIntList = new List<int>();

            myIntList.Add(7);
            //myIntList.Add(7.0f);


            List<float> myFloatList = new List<float>();

            myFloatList.Add(7.0f);

            List<String> myStringList = new List<string>();

            myStringList.Add("First");

            List<PlayingCard> myCardList = new List<PlayingCard>();
            //myCardList.Add(7);
            //myCardList.Add(7.0f);
            //myCardList.Add("seven");

        }
    }
}
