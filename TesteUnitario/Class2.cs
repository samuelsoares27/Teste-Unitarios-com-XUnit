using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TesteUnitario
{
    public class Class2
    {
        public DateTime DataHora()
        {
            return DateTime.Now;
        }

        public PingOptions PingOptions()
        {
            return new PingOptions(){
                DontFragment = true,
                Ttl = 1
            };
        }

        public IEnumerable<PingOptions> ListPingOptions()
        {
            return new[] {

                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },

                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },

                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },
            };
            
        }
    }
}
