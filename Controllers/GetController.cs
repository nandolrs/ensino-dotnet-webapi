using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ensino_dotnet_webapi.Controllers
{

    public class GetController : Controller
    {

        [HttpGet]
        [Route("acordar")]
        public String Acordar()
        {
            return "acordando";
        }

        [HttpGet]
        [Route("tomarcafe")]
        public String TomarCafe()
        {
            return "tomando cafe";
        }

        [HttpGet]
        [Route("almocar")]
        public String Almocar()
        {
            return "almocando";
        }


        [HttpGet]
        [Route("tomarcafedatarde")]
        public String CafeTarde()
        {
            return "tomando cafe da tarde";
        }


        [HttpGet]
        [Route("jantar")]
        public String Jantar()
        {
            return "jantando";
        }


        [HttpGet]
        [Route("dormindo")]
        public String Dormir()
        {
            return "dormindo";
        }

        [HttpGet]
        [Route("falar")]
        public Frase Falar()
        {
            Frase retorno =  new Frase();

            return retorno;
        }

        public class Frase
        {

            public String adjetivo
            {
                get { return "bonito"; }
            }
            public String substantivo
            {
                get { return "fernando"; }
            }

            public String frase
            {
                get { return "fernando é bonito"; }
            }


        }
    }
}
