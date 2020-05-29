using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacc_Cuenta
{
    class Cls_Transacciones
    {
        public int valor_usu { get; set; }
        public int saldo = 0;

        
        public int met_deposito()
        {
            
            saldo = saldo + valor_usu;
            return saldo;
        }
        public int met_retiro()
        {
            int tot = saldo - valor_usu;
            return tot;
        }
        public string mensj_main()
        {
            string dev = "NO SE PUDO REALIZAR LA TRANSACCIÓN...";
            return dev;
        }
    }
}
