using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace TiendaUno.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new TiendaUno.App(), args);
            host.Run();
        }
    }
}
