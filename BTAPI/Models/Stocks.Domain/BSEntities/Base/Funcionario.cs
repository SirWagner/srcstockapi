using Stocks.Domain.BSEntities.HR;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Stocks.Domain.BSEntities.Base
{
    public class Funcionario : Entity
    {
        [JsonProperty("type")]
        public char Tipo { get; set; } = 'U';

        [JsonProperty("BusinessArea")]
        public Collection<FuncionarioAreaNegocio> AreaNegocio { get; set; }

        //Todo: Properly set the employ Cost Center
        [JsonProperty("bussinesArea")]
        [NotMapped]
        public FuncionarioAreaNegocio _AreaNegocio_Principal {
            get {
                 try
                 {
                    return AreaNegocio.First(p => p.Principal == true);
                 }
                 catch
                 {
                    return new FuncionarioAreaNegocio();
                 }               
            }
        }
    }
}
