using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace IIS_Costumes
{
    class Controller
    {
        public static Form ShowForm(Form form, bool showDialog = false)
        {
            if (form.IsDisposed)
            {
                form = (Form)Activator.CreateInstance(form.GetType());
                //var constructorInfo = form.GetType().GetConstructor(new Type[] { });
                //form = (Form)constructorInfo.Invoke(new object[] { });
            }
            if (showDialog) form.ShowDialog();
            else form.Show();
            form.Activate();
            return form;
        }
    }
}
