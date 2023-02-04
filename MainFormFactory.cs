using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.Interfaces;

namespace demo
{
    public class MainFormFactory : IMainForm
    {
        private MainForm _form;


        public MainForm Create()
        {
            return _form;
        }
    }
}
