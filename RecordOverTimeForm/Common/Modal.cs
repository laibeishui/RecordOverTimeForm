using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordOverTimeForm.Common
{
    public class Modal
    {
        public void ErrorInfo(Form form, string title, string msg)
        {
            AntdUI.Modal.open(new AntdUI.Modal.Config(form, title, msg, AntdUI.TType.Error)
            {
                OnButtonStyle = (id, btn) =>
                {
                    btn.BackExtend = "135, #6253E1, #04BEFE";
                },
                CancelText = null,
                OkText = "知道了"
            });
        }

        public void SuccessInfo(Form form, string title, string msg)
        {
            AntdUI.Modal.open(new AntdUI.Modal.Config(form, title, msg, AntdUI.TType.Success)
            {
                OnButtonStyle = (id, btn) =>
                {
                    btn.BackExtend = "135, #6253E1, #04BEFE";
                },
                CancelText = null,
                OkText = "知道了"
            });
        }
    }
}
