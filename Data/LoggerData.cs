using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmericaVirtualChallenge.Models;

namespace AmericaVirtualChallenge.Data
{
    public class LoggerData
    {
        public static void InsertLogger(int idUsuario, string accion)
        {
            Logger logger = new Logger();

            try
            {
                using(ServiciosContext context = new ServiciosContext())
                {
                    logger.IdUsuario = idUsuario;
                    logger.Accion = accion;
                    logger.Fecha = DateTime.Now;

                    context.Logger.Add(logger);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}
