using System;

namespace Homework12_01
{
    public class Flashcard
    {
        // instance variables
        private readonly string _term;
        private readonly string _definition;

        // Full-arg Constructor
        public Flashcard(string term, string definition)
        {
            _term = term;
            _definition = definition;
        }

        // Getters
        public string GetTerm() => _term;
        public string GetDefinition() => _definition;
    }
}
