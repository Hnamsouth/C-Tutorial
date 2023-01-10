using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.PracticeHome.session4
{
    internal class DemoEvent
    {
        public event PrintString Click;

        public DemoEvent() {
            Click += DelegateDeMo.Alert;
            Click += new DelegateDeMo().ShowMessage;
        }
        public DemoEvent(PrintString functionname)
        {
            Click+= functionname;
        }
        public void ClickAction()
        {
            Click("click here");
        }

    }
}
