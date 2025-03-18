using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SalarioService
    {
        public decimal CalcularSalarioBase(Profesor profesor)
        {
            decimal salarioBase = 0;
            string categoria = profesor.Categoria != null ? profesor.Categoria.Trim().ToLower() : string.Empty;
            string dedicacion = profesor.Dedicacion != null ? profesor.Dedicacion.Trim().ToLower() : string.Empty;

            if (categoria == "auxiliar")
            {
                salarioBase = dedicacion == "tiempo completo" ? 2.645m : 1.509m;
            }
            else if (categoria == "asistente")
            {
                salarioBase = dedicacion == "tiempo completo" ? 3.125m : 1.749m;
            }
            else if (categoria == "asociado")
            {
                salarioBase = dedicacion == "tiempo completo" ? 3.606m : 1.990m;
            }
            else if (categoria == "titular")
            {
                salarioBase = dedicacion == "tiempo completo" ? 3.918m : 2.146m;
            }
            else
            {
                throw new ArgumentException("Categoría o dedicación no válida.");
            }

            return salarioBase * profesor.SMMLV;
        }

        public decimal CalcularBonificacionPosgrado(string nivelPosgrado, int smmlv)
        {
            decimal bonificacion = 0;

            if (nivelPosgrado != null)
            {
                nivelPosgrado = nivelPosgrado.Trim().ToLower();

                switch (nivelPosgrado)
                {
                    case "especialización":
                        bonificacion = smmlv * 0.10m;
                        break;
                    case "maestría":
                        bonificacion = smmlv * 0.45m;
                        break;
                    case "doctorado":
                        bonificacion = smmlv * 0.90m;
                        break;
                    default:
                        bonificacion = 0;
                        break;
                }
            }

            return bonificacion;
        }

        public decimal CalcularBonificacionInvestigacion(string grupo, int smmlv)
        {
            decimal bonificacion = 0;

            if (grupo != null)
            {
                grupo = grupo.Trim().ToLower();

                switch (grupo)
                {
                    case "a1":
                        bonificacion = smmlv * 0.56m;
                        break;
                    case "a":
                        bonificacion = smmlv * 0.47m;
                        break;
                    case "b":
                        bonificacion = smmlv * 0.42m;
                        break;
                    case "c":
                        bonificacion = smmlv * 0.38m;
                        break;
                    default:
                        bonificacion = 0;
                        break;
                }
            }

            return bonificacion;
        }

        public decimal CalcularSalarioTotal(Profesor profesor)
        {
            var salarioBase = CalcularSalarioBase(profesor);
            var bonificacionPosgrado = CalcularBonificacionPosgrado(profesor.NivelPosgrado, profesor.SMMLV);
            var bonificacionInvestigacion = CalcularBonificacionInvestigacion(profesor.GrupoInvestigacion, profesor.SMMLV);

            return salarioBase + bonificacionPosgrado + bonificacionInvestigacion;
        }
    }

}
