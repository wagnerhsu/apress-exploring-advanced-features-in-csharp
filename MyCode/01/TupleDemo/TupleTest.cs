using System;

namespace TupleDemo
{
    public class TupleTest
    {
        public void Main()
        {
            GetTupleResult01();
            GetTupleResult02();
            InstanceTupleVariables();
            ComparingTuples();
            DeconstructingTuple();
        }

        // Define other methods and classes here
        void GetTupleResult01()
        {
            var guitar = GetGuitarType();
            Console.WriteLine($"{guitar.GuitarType},{guitar.StringCount}");
        }

        void GetTupleResult02()
        {
            // 名称无所谓，但类型一定要一致
            (string Type, int Count) guitar = GetGuitarType();
            Console.WriteLine($"{guitar.Type},{guitar.Count}");
        }

        public enum InstrumentType { guitar, cello, violin }

        public void InstanceTupleVariables()
        {
            string instrumentType = nameof(InstrumentType.guitar);
            int strings = 12;
            // 先生成一个tuple实例
            (string TypeOfInstrument, int NumberOfStrings) instrument = (instrumentType, strings);
            PlayInstrument(instrument);
        }

        public void PlayInstrument((string instrument, int strings) instrumentToPlay)
        {
            Console.WriteLine($"I am playing a {instrumentToPlay.instrument} with {instrumentToPlay.strings} strings");
        }

        public (string GuitarType, int StringCount) GetGuitarType()
        {
            return ("Les Paul Studio", 6);
        }

        public void ComparingTuples()
        {
            string instrumentType1 = nameof(InstrumentType.guitar);
            int stringsCount1 = 6;
            (string TypeOfInstrument, int NumberOfStrings) instrument1 = (instrumentType1, stringsCount1);

            string instrumentType2 = nameof(InstrumentType.violin);
            int stringsCount2 = 4;
            (string TypeOfInstrument, int NumberOfStrings) instrument2 = (instrumentType2, stringsCount2);

            if (instrument1.NumberOfStrings != instrument2.NumberOfStrings)
            {
                Console.WriteLine($"A {instrument2.TypeOfInstrument} does not have the same number of strings as a {instrument1.TypeOfInstrument}");
            }

            if (!instrument1.Equals(instrument2))
            {
                Console.WriteLine("We are dealing with different instruments here.");
            }


            if (instrument1 != instrument2)
            {
                Console.WriteLine("We are dealing with different instruments here.");
            }

            (string TypeOfInstrument, int NumberOfStrings) instrument3 = (instrumentType1, stringsCount1);
            // Tuple是值意义上的比较
            if (instrument3 == instrument1)
            {
                Console.WriteLine("instrument3 == instrument1");
            }
            else
            {
                Console.WriteLine("instrument3 == instrument1");
            }
        }

        void DeconstructingTuple()
        {
            (string BrandType, int GuitarStringCount) = GetGuitarType();
            Console.WriteLine($"{BrandType}-{GuitarStringCount}");
            (var t, var c) = GetGuitarType();
            Console.WriteLine($"{t}-{c}");
            var (t1, c1) = GetGuitarType();
            Console.WriteLine($"{t1}-{c1}");
        }
    }
}