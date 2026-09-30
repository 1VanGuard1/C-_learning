using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMaintainable
{
    DateOnly LastServiceDate { get; protected set; }
    void PerformMaintenance();
}

