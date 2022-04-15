using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThreadsFormTime;


namespace ThreadsFormTime.Implementace {
    public class Clock {
        bool shows=true;
        public void show() {
            this.shows = true;
            Console.WriteLine("Clock will show");
        }
        public void doNotShow() {
            this.shows = false;
            Console.WriteLine("Clock is hidden");
        }
        public void loop() {           
                while (true) {
                    if (this.shows == true) { 
                        Console.WriteLine(DateTime.Now.ToLongTimeString());
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
