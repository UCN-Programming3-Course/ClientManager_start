using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.DataAccessLayer
{
    /// <summary>
    /// Represents a customer
    /// </summary>
    public class Customer
    {
        public int CustomerId { get; internal set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"ID      - {CustomerId}\n" +
                   $"Name    - {Firstname} {Lastname}\n" +
                   $"Address - {Address}\n" +
                   $"          {Zip} {City}\n\n" +
                   $"Phone   - {Phone}\n" +
                   $"Email   - {Email}\n" +
                   $"---\n";
        }
    }
}
