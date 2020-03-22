using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1.Views
{
    public interface IStudent
    {
        string idText_Student { get; set; }
        string imieText { get; set; }
        string nazwiskoText { get; set; }
        string indeksText { get; set; }
    }
}
