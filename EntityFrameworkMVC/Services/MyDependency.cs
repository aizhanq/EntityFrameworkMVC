using System.Diagnostics;

namespace EntityFrameworkMVC.Services
{
    public class MyDependency : IMyDependency
    {
        public void WriteMessage(string message)
        {
            Debug.WriteLine($"MyDependency.WriteMessage Message: {message}");
        }
    }
}
