using System.Security.Cryptography.X509Certificates;

namespace GC
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
           
            // how to say to GC to collect sth manually 

            try
            {
                // DB Context 
            }
            finally
            {
                // dispose 
            }

            // instead of finally : using dispose after the end of block, not remove from heeap, but disconnect the rrealtion to be ready to GC
            // fielstream for exmaple with using compiled to the try finally block 

            //using (FileStream)
            //{

            //}

            // it was hard with {} and nested udings so invented using;

            // not root: in stack doesnt hace reference 
            // not root in heap
            // gc in the clr ( different in os) isnt schedule, and no one tell it! it watched the heap, allocation of heap, tracehold with algorithm

            //explixit:
            //gc.collect(int generation);

            // works of GC: 1. Mark 2.Collect 3.Defrag

            // when a object ahs a relation or has finalizer it goes from gen 0 to gen 1 

            //try
            //{

            //}
            //catch ()
            //{

            //    GC.ReRegisterForFinalization()
            //}

        }


        // when a object ahs a relation or has finalizer it goes from gen 0 to gen 1 
        public class User
        { 
            // when want to delete from memory this line of code run: lock, or delete a file
            ~User() 
            {
                //File.Delete();  if we hadnt access to delete this file, or have an exception we have object resurection
            } 
        }


    }

    // mark: no root in another obj in heap or stack / collect: if had finalizer cant delete it in gen0 and move to gen1. => so goes to queue
    // and finalozers bjectare in queue 
}
