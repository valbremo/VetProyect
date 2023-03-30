﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetProyect
{
    public class Herramientas
    {

        //Regex que permite que el correo cumpla como válido
        const string EmailRegex =
         "@[a-z0-9._%+-]+@[a-z0-9-]+.+.[a-z]{2,4}@";

        //Regex que permite ciertos datos
        const string PassRegex = "^(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{4,10}$";
        //2 numeros, 3 letras, rango de 4 a 5 caracteres



        //valida el email
        public static bool ValidarEmail(string email)
        {
            if (email != null)
            {
                return Regex.IsMatch(email, EmailRegex);
            }
            else
            {
                return false;
            }

        }


        const string FacturaRegex = "^(?=.*[0-9].*[0-9])(?=.*[A-Z])$";
        //valida la factura
        public static bool ValidarFactura(string factura)
        {
            if (factura != null)
            {
                return Regex.IsMatch(factura, FacturaRegex);
            }
            else
            {
                return false;
            }

        }



        //valida la contraseña
        public static bool ValidarPass(string pass)
        {
            if (pass != null)
            {
                return Regex.IsMatch(pass, PassRegex);
            }
            else
            {
                return false;
            }

        }


        private static char g_Gen_DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString());

        //Herramienta que permite letras y numeros
        public static bool CaracteresTexto(System.Windows.Forms.KeyPressEventArgs c, bool Mayusculas = false, bool Minisculas = false)
        {
            bool ret = false;

            if (Mayusculas)
            { c.KeyChar = char.ToUpper(c.KeyChar); }

            if (Minisculas)
            { c.KeyChar = char.ToLower(c.KeyChar); }

            if (!(char.IsLetterOrDigit(c.KeyChar)) & !(char.IsPunctuation(c.KeyChar)) & !(c.KeyChar == Convert.ToChar(Keys.Back)) & !(c.KeyChar == Convert.ToChar(Keys.Space)) & !(c.KeyChar == Convert.ToChar(Keys.Enter)))
                ret = true;
            else
                ret = false;
            return
            ret;

        }

        public static void CaracteresTextoM(KeyPressEventArgs pE)
        {

            if (char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }


        }

        //herramienta que permite numeros
        public static bool CaracteresNumeros(System.Windows.Forms.KeyPressEventArgs c, bool SoloEnteros = true)
        {
            //En el caso que presione enter acepta el valor y devuelve True
            int Asc = (int)Keys.Enter;

            if (c.KeyChar == Asc)
            {
                return true;
            }
            if (SoloEnteros == false)
            {
                if (c.KeyChar.ToString() == (".") | c.KeyChar.ToString() == (","))
                {
                    c.KeyChar = g_Gen_DecimalSeparator;
                    return false;
                }
            }

            if (!(char.IsDigit(c.KeyChar)) & !(c.KeyChar == Convert.ToChar(Keys.Back)) & !(c.KeyChar == Convert.ToChar(Keys.Enter)))
            { return true; }
            else
            { return false; }

        }

        //Formato de fecha
        public static string DateFormat(DateTime pDate, bool ISO_Format = false)
        {
            string s = string.Empty;

            try
            {
                if (ISO_Format)
                {
                    string yyyy;
                    string mm;
                    string dd;
                    int i_mm = pDate.Month;
                    int i_dd = pDate.Day;

                    if (i_mm < 10)
                    {
                        mm = "0" + i_mm.ToString();
                    }
                    else
                    {
                        mm = i_mm.ToString();
                    }

                    if (i_dd < 10)
                    {
                        dd = "0" + i_dd.ToString();
                    }
                    else
                    {
                        dd = i_dd.ToString();
                    }

                    yyyy = pDate.Year.ToString();

                    s = yyyy + mm + dd;
                }
                else
                {
                    s = string.Format("{0:dd/MMMM/yyyy}", pDate.Date);
                }
            }
            catch (Exception e)
            {
                s = e.ToString();
            }

            return s;
        }

        //formato de hora
        public static string FormatoHora(DateTime pDate)
        {
            string h;

            h = pDate.ToLongTimeString();

            return h;
        }

    }

}