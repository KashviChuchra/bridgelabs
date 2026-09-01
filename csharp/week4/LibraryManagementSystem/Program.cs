using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
namespace LibraryManagementSystem;

class Program
{
    public static void Main(string[] args)
    {
        DateTime checkout = new DateTime(01 / 09 / 2026);
        DateTime due = new DateTime(07 / 09 / 2026);

        Loan loan = new Loan(1,101,checkout,due);

        CirculationManager manager= new CirculationManager();
        manager.ItemOverdue += manager.ItemOverDueNotification;
        manager.ProcessOverdue(loan);
        
        
}

}