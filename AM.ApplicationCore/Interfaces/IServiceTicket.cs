using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
   public interface IServiceTicket: IService<Ticket>
    {
        public IEnumerable<Ticket> GetTicketByPrice(string prix);
        public IEnumerable<Ticket> GetTicketBySiege(string siege);
        public IEnumerable<Ticket> GetTicketByPriceAndSiege(string prix, string siege);
    }
}
