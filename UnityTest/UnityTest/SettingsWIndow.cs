using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    class SettingsWIndow
    {
        private IEnumerable<ISettingView> _views;

        public SettingsWIndow(IEnumerable<ISettingView> views)
        {
            _views = views;
        }

        public void Show()
        {
            foreach (var view in _views)
            {
                view.Show();
            }
        }
    }

}
