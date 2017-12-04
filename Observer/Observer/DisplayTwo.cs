using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer {
    class DisplayTwo : Observers, Display {
        private Subject data;
        private int a, b, c;

        public DisplayTwo(Subject data) {
            this.data = data;
            data.RegisterObserver(this);
        }
        public void Show() {
            int rs = a + b + c;
            Console.WriteLine("a + b + c = " + rs);
        }

        public void update(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
            Show();
        }
    }
}
