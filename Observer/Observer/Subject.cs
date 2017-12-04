using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer {
    interface Subject {
        void RegisterObserver(Observers o);
        void RemoveObserver(Observers o);
        void NotifyObserver();
    }
}
