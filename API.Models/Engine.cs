using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Engine
    {
        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Descrição: " + Description;
        }
        #endregion
    }
}
