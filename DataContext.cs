namespace Generic_Test
{
    public class DataContext<PL, PA, S>

         where PL : IPlan //P só pode ser do tipo Person e pode ser tanto classe como interface,
         where PA : Payment
         where S : Subscription

    {
        public void Save(PL entity)
        {

        }

        public void Save(PA entity)
        {

        }

        public void Save(S entity)
        {

        }
    }

    public interface IPlan { }
    
}
