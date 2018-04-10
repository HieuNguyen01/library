using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDTNC04
{
    public class ButtonGroupEventArgs : EventArgs
    {
        #region Khai báo biến
        #endregion
        #region Các hàm tạo
        #endregion
        #region Các đặc trưng
        #endregion
        #region Các phương thức
        #endregion
    }
    #region Các ủy quyền biến cố
    public delegate void ButtonGroupEventHandler(object sender, ButtonGroupEventArgs e);
    public delegate bool ButtonGroupCanDoDelegate(object sender, ButtonGroupEventArgs e);
    #endregion
}
