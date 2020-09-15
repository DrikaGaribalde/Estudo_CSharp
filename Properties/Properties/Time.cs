using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Properties {
    public class Time {
        private int _hour;
        private int _minute;
        private int _second;
        //
        public Time() {
            SetTime(0,0,0);
        }
        public Time(int hour) {
            SetTime(hour, 0, 0);
        }
        public Time(int hour, int minute) {
            SetTime(hour, minute, 0);
        }
        public Time(int hour, int minute, int second) {
            SetTime(hour, minute, second);
        }
        public Time(Time time) {
            SetTime(time.Hour,time.Minute, time.Second);
        }
        //
        public void SetTime(int hourValue, int minuteValue, int secondValue) {
            Hour = hourValue;
            Minute = minuteValue;
            Second = secondValue;
        }

        public int Hour {
            get { return _hour; }
            set { _hour = ((value >= 0 && value < 24) ? value : 0); }
        }
        public int Minute {
            get { return _minute; }
            set { _minute = ((value >= 0 && value < 60) ? value : 0); }
        }
        public int Second {
            get { return _second; }
            set { _second = ((value >= 0 && value < 60) ? value : 0); }
        }
        //
        public string ToUniversalString() {
            return String.Format("{0:D2} : {1:D2} : {2:D2}", Hour, Minute,Second);
        }
        public string ToStandardString() {
            return String.Format("{0} : {1:D2} : {2:D2} : {3}", 
                ((Hour == 12 || Hour == 0) ? 12 : Hour % 12),
                Minute, Second,(Hour < 12 ? "AM" : "PM"));
        }
        public override string ToString() {
            return 
                     "Hour: " + Hour +
                     " Minute: " + Minute +
                     " Second: " + Second + "\n" +
                     "Standard time: " +
                      ToStandardString() + " \nUniversal time: " +
                      ToStandardString();
        }
        public void AddSecond(){
            Second = (Second + 1) % 60;
            if (Second == 0 ) {
                Minute = (Minute + 1) % 60;
                if (Minute == 0 ) {
                    Hour = (Hour + 1) % 60;
                }
            }
        }
    }
}
