using System;
using System.Collections.Generic;
using System.Text;

namespace SD_Class_InvalidOperationException
{
    class Person
    {
        private string _name;
        private int _age;
        private string _gender;
        private int _weight;
        private int _height;
        private string _hairColor;
        private string _eyesColor;
        private string _skinColor;


        public string Name { get => _name;}
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender;}
        public int Weight { get => _weight; set => _weight = value; }
        public int Height { get => _height; set => _height = value; }
        public string HairColor { get => _hairColor; set => _hairColor = value; }
        public string EyesColor { get => _eyesColor;}
        public string SkinColor { get => _skinColor; set => _skinColor = value; }

        public Person(string name, int age, string gender, int weight, int height, string eyesColor, string skinColor)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _weight = weight;
            _height = height;
            _eyesColor = eyesColor;
            _skinColor = skinColor;
        }
    }
}
