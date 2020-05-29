using System;
using System.Collections.Generic;
using System.Text;

namespace Gest_EmpresaAgro
{
    class Cls_Congelados : Cls_Datos_Comun
    {

        public Cls_Congelados(string nom, int cod, int lote, string pais, double temper)
        {
            name_prod_h = nom;
            cod_h = cod;
            lote_h = lote;
            pais_h = pais;
            temper_h = temper;
        }
        public string devol()
        {
            string nom_f = name_prod_h;
            return nom_f;
        }

        public int codd()
        {
            int cod_f = cod_h;
            return cod_f;
        }

        public int lotee()
        {
            int lote_f = lote_h;
            return lote_f;
        }
        public string dev_pais()
        {
            string pais_f = pais_h;
            return pais_h;
        }
        public double temperat()
        {
            double temp_f = temper_h;
            return temp_f;
        }
    }
}
