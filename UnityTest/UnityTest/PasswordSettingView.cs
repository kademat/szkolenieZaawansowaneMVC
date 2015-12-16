using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    class PasswordSettingView : IPasswordSetting
    {
        public void Show()
        {
            Console.WriteLine("PasswordSettingView");
        }
    }
}
