using System;
namespace Homework12_04
{
    public class Movie
    {
        private readonly string _name;
        private readonly string _director;
        private readonly string _description;

        public Movie(string name, string director, string description)
        {
            _name = name;
            _director = director;
            _description = description;
        }

        public string GetName() => _name;
        public string GetDirector() => _director;
        public string GetDescription() => _description;

    }
}
