using System;
using System.Windows.Forms;
    public class MsgBox
    {
        /// <summary>
        /// Enumerador para Seleccionar El tipo de Boton del MsgBox
        /// </summary>
        public enum EnumTipoBoton :int
        {
            Aceptar      = 1,
            OKCancel     = 2,                  
            SiNo         = 3,
            SiNoCancelar = 4
        }

        /// <summary>
        /// Enumerador para Seleccionar el Tipo de Icono del MsgBox
        /// </summary>

        public enum EnumTipoIcono : int
        {
            Error       = 1,
            Exclamacion = 2,                    
            Informacion = 3,
            Advertencia = 4
        }

        /// <summary>
        /// Funcion que Genera un Mensaje de texto
        /// </summary>
        /// <param name="strMessage">Mensaje a Mostrar</param>
        /// <param name="strTitle">Titulo del Mensaje de Texto</param>
        /// <param name="boton">Tipo de Boton</param>
        /// <param name="icono">Icono a Mostrar en el Boton</param>
        public static void ShowMessageBox(string strMessage, 
                                          string strTitle,
                                          EnumTipoBoton boton = EnumTipoBoton.Aceptar,
                                          EnumTipoIcono icono = EnumTipoIcono.Advertencia)
           {
               MessageBoxButtons msgbtn= MessageBoxButtons.OK;
               MessageBoxIcon msgicon = MessageBoxIcon.Warning;
               if (boton == EnumTipoBoton.Aceptar)
               {
                    msgbtn = MessageBoxButtons.OK;
               }
               
               if (boton == EnumTipoBoton.OKCancel)
               {
                    msgbtn = MessageBoxButtons.OKCancel;
               }
               else if (boton == EnumTipoBoton.SiNo)
               {
                    msgbtn = MessageBoxButtons.YesNo;
               }
               else if (boton == EnumTipoBoton.SiNoCancelar)
               {
                    msgbtn = MessageBoxButtons.YesNoCancel;
               }

               if(icono == EnumTipoIcono.Advertencia)
               {
                    msgicon = MessageBoxIcon.Warning;
               }
               if (icono == EnumTipoIcono.Error)
               {
                   msgicon = MessageBoxIcon.Error;
               }
               if (icono == EnumTipoIcono.Exclamacion)
               {
                   msgicon = MessageBoxIcon.Exclamation;
               }
               if (icono == EnumTipoIcono.Informacion)
               {
                   msgicon = MessageBoxIcon.Information;
               }

               MessageBox.Show(strMessage, strTitle, msgbtn, msgicon);

           } 
               
    }

