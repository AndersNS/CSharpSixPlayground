using System;
using System.Threading.Tasks;

namespace CSharpSixFeatures
{
    public class TryAwaiter
    {
	    public async Task TryAServiceCall()
        {
            try { await PerformServiceCall(); }
            catch { await AsyncLogging(); }
            finally { await CleanUp(); }
        }

        private async Task PerformServiceCall()
        {
            await Task.Delay(50);
            throw new ArgumentException();
        }

        private async Task AsyncLogging()
        {
            await Task.Delay(500);
        }

        private async Task CleanUp()
        {
            await Task.Delay(500);
        }
    }

    public class Result { }
}