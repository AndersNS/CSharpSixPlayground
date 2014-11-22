using System;
using System.Diagnostics.Debug;

namespace CSharpSixFeatures
{
    public class ExceptionFilteringClass
    {
        private void ThisJustThrows() { throw new ArgumentException("oh noes"); }

        public string DoSomething() {
            try { ThisJustThrows(); }
            catch (Exception e) if (e.Message == "oh noes" || Log(e))
            { 
                return "oh noes";
            }
            return "all is fine I guess";
        }

        private bool Log(Exception e) { /** call your logger **/ return false; }
    }
}