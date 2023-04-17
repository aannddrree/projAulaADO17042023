using projAulaADO17042023.Model;
using projAulaADO17042023.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAulaADO17042023.Controllers
{
    public class AirplaneController
    {
        public bool Insert(Airplane airplane)
        {
            return new AirplaneService().Insert(airplane);
        }
        public List<Airplane> FindAll()
        {
            return new AirplaneService().FindAll();
        }
    }

}
