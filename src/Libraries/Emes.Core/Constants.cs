using System;
using System.Collections.Generic;
using System.Text;

namespace Emes.Core
{
    public static class Constants
    {
        #region 长度限制

        public static int XS => 50;
        public static int S => 100;
        public static int M => 200;
        public static int L => 400;
        public static int XL => 500;
        public static int XXL => 1000;

        #endregion

        #region 校验提示
        public static string MaxLenMsg => "{0}超过最大长度{1}";

        public static string MinLenMsg => "{0}小于最小长度{1}";

        public static string RequestMsg => "{0}是必填项";
        #endregion


    }
}
