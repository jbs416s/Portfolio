using CalendarLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLibrary.Factories;

public class CalendarFactory
{
    public Calendar Create() { return new Calendar(); }
}
