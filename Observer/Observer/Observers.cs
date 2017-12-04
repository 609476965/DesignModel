using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer {
    public interface Observers {
        void update(int a, int b, int c);
    }
}
