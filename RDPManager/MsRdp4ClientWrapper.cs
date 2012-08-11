using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDPManager
{
    public class MsRdpClient4 : AxMSTSCLib.AxMsRdpClient4
    {
        public MsRdpClient4()
            : base()
        {
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            //Fix for the missing focus issue on the rdp client component
            if (m.Msg == 0x0021) //WM_MOUSEACTIVATE
                this.Focus();
            base.WndProc(ref m);
        }
    }
}
