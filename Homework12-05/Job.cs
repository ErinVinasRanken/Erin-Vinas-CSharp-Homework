using System;

namespace Homework12_05
{
    public class Job
    {
        // instance variables
        private string _description;
        private float _hoursToComplete;
        private float _hourlyFee;
        private float _totalFee;

        // Full-arg constructor
        public Job(string description, float hoursToComplete, float hourlyFee, float totalFee)
        {
            _description = description;
            _hoursToComplete = hoursToComplete;
            _hourlyFee = hourlyFee;
            _totalFee = totalFee;
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                CalculateTotalFee();
            }
        }

        public float HoursToComplete
        {
            get { return _hoursToComplete; }
            set
            {
                _hoursToComplete = value;
                CalculateTotalFee();
            }
        }

        public float HourlyFee
        {
            get { return _hourlyFee; }
            set
            {
                _hourlyFee = value;
                CalculateTotalFee();
            }
        }

        public float TotalFee
        {
            get { return _totalFee; }
            private set 
            { 
                _totalFee = value; 
            }
        }

        public Job()
        {
            TotalFee = 0;
        }

        private void CalculateTotalFee()
        {
            _totalFee = _hoursToComplete * _hourlyFee + 35;
        }
    }
}
