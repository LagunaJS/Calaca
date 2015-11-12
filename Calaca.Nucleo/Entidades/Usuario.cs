using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calaca.Nucleo.Persistencia;
using NHibernate;


namespace Calaca.Nucleo.Entidades
{
    public class Usuario : Persistent
    {
        public override int Id { get; set;}
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public static IList<Usuario> ObtenerTodos()
        {
            IList<Usuario> usuarios = new List<Usuario>();

            try
            {
                using (ISession session = Persistent.SessionFactory.OpenSession())
                {
                    ICriteria crit = session.CreateCriteria(new Usuario().GetType());
                    usuarios = crit.List<Usuario>();
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return usuarios;
        }

    }
}
