using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1.Models;

namespace zadanie1.Views
{
    interface IKurs
    {
        string idText { get; set; }
        string nameText { get; set; }
        List<string> students { get; set; }
    }
}
