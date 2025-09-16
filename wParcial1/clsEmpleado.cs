using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wParcial1
{
    internal class clsEmpleado
    {
        public int Documento{get;set;}
        public string Nombre{get;set;}
        public string Cargo{get;set;}
        public double Salario{get;set;}
        public int Horas_extras{get;set;}
        public int Porcentaje{get;set;}
        public double Salario_neto{get;set;}

        public clsEmpleado(int documento, string nombre, string cargo, double salario, int horas_extras, int porcentaje)
        {
            Documento = documento;
            Nombre = nombre;
            Cargo = cargo;
            Salario = salario;
            Horas_extras = horas_extras;
            Porcentaje = porcentaje;

            double valor_hora = (Salario/160);
            double valor_hora_extra = (valor_hora*1.5*horas_extras);
            double  total_deduciones = salario*((float)Porcentaje/100);
            Salario_neto = Salario + valor_hora_extra - total_deduciones;
        }

        public string Validar()
        {
            if (Documento < 10000)
            {
                return "El documento debe tener minimo 5 digitos.";
            }
            if (String.IsNullOrEmpty(Nombre))
            {
                return "El nombre no puede estar vacio.";
            }
            if (Nombre.Length < 3)
            {
                return "El nombre debe contener 3 o mas caracteres.";
            }
            foreach (char c in Nombre)
            {
                if (!char.IsLetter(c))
                {
                    return "El nombre no puede contener numeros o caracteres especiales.";
                }
            }
            if (String.IsNullOrEmpty(Cargo))
            {
                return "Debe escoger un cargo.";
            }
            if(Salario <= 0 || Salario > 100000)
            {
                return "El salario debe ser mayor a 0 y menor o igual a 100000.";
            }
            if(Horas_extras < 0 ||Horas_extras > 100)
            {
                return "Las horas extras deben ser entre 0 y 100.";
            }
            if(Porcentaje< 0 || Porcentaje > 100)
            {
                return "El porcentaje debe ser entre 0 y 100.";
            }
            return"OK";
        }

        public override string ToString()
        {
            return $"documento:{Documento}, Nombre: {Nombre}, Cargo: {Cargo}, Salario:${Salario}\n, Horas extras: {Horas_extras}, Porcentaje: {Porcentaje}, Salario neto:${Salario_neto}";;
        }
    }
}
