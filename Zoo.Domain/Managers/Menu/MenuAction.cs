using System;
using Zoo.Common;

namespace Zoo.Domain.Managers.Menu
{
    public class MenuAction<TModule> : IMenuItem  where TModule : IRunnable, new()
    {
        public string Name { get; }

        public MenuAction(string name)
        {
            this.Name = name;
        }
            
        public void OnSelect()
        {
            try
            {
                IRunnable menuAction = new TModule();
                menuAction.Run();
            }
            catch (Exception ex)
            {
                ConsoleLogger.WriteError(ex.ToString());
                Console.WriteLine("Hit any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
