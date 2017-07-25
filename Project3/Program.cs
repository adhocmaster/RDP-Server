using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePc
{
     class Program
    {       
         static void Main()
         {
             Console.WriteLine("hello");

             SharePC pc1 = new SharePC();             
             
             pc1.shareControl();
             String controlInvitation1 = pc1.getInvitationString(5); //the max no of client 
             Console.WriteLine("for control:\n"+controlInvitation1);

             //pc1.disconnect();
             
             pc1.shareControl();
             String controlInvitation = pc1.getInvitationString( ( int ) 2 );
             Console.WriteLine("for control222:\n"+controlInvitation);

             Console.WriteLine("\nHELLO:\n" + pc1.GetControlString(5));
             pc1.destroy();

             Console.WriteLine("\nHELLO3333333:\n" + pc1.GetControlString(5));
            

             String a = Console.ReadLine();

             System.Diagnostics.Debug.Print( controlInvitation );

             
         }
        
    }
}
