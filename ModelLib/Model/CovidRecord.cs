using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class CovidRecord
    {
        private int _id;
        private string _city;
        private int _household;
        private int _tested;
        private int _sick;

        public CovidRecord()
        {
        }

        public CovidRecord(int id, string city, int household, int tested, int sick)
        {
            _id = id;
            _city = city;
            _household = household;
            _tested = tested;
            _sick = sick;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string City // min 2 tegn
        {
            get => _city;
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length < 2) throw new ArgumentException();
                _city = value;
            }
        }

        public int Household // >= 1
        {
            get => _household;
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException();
                _household = value;
            }
        }

        public int Tested // >= 0
        {
            get => _tested;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _tested = value;
            }
        }

        public int Sick // >= 0
        {
            get => _sick;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _sick = value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(_city)}: {_city}, {nameof(_household)}: {_household}, {nameof(_tested)}: {_tested}, {nameof(_sick)}: {_sick}";
        }
    }
}
