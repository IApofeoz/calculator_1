using System.Net;

namespace calculator
{
    internal class Internet_checker
    {
        
        public static bool OK()
        {
            try
            {
                Dns.GetHostEntry("yandex.ru");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
