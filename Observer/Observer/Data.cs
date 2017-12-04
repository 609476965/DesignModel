using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer {
    class Data : Subject {
        int a;
        int b;
        int c;
        List<Observers> obList;
        public Data() {
            obList = new List<Observers>();
        }
        public void NotifyObserver() {
            foreach(var i in obList) {
                i.update(a, b, c);
            }
        }

        public void RegisterObserver(Observers o) {
            obList.Add(o);
        }

        public void RemoveObserver(Observers o) {
            obList.Remove(o);
        }

        public void SetData(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
            DataChange();
        }

        private void DataChange() {
            NotifyObserver();
        }
    }
}
