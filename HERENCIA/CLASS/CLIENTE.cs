using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
   public class CLIENTE : PERSONA
    {
        public string CEDULA1;

        //ATRIBUTOS
        private String CATEGORIA;
        private String CODIGODEPEDIDO;
        private String CEDULA;

        //PROPIEDADES

        public string CATEGORIA1
        { 
            get => CATEGORIA; 
            set => CATEGORIA = value;
        }
        public string CODIGODEPEDIDO1 
        { 
            get => CODIGODEPEDIDO;
            set => CODIGODEPEDIDO = value;
        }
        public string CEDULA2 
        { 
            get => CEDULA; 
            set => CEDULA = value; 
        }

        //PROCEDIMIENTOS, OPERACIONES, METODOS 
        public void GENERARCODIGOPEDIDO()
        {
            this.CODIGODEPEDIDO1 = "C" + this.APPATERNO1.Substring(0, 3);
            this.CEDULA1 = this.CEDULA1.Substring(0, 10);
        }

    }
}
