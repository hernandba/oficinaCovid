using System;
using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class RepositorioSecretario : IRepositorioSecretario
    {
        private readonly AppContext _appContext;

        public RepositorioSecretario(AppContext appContext)
        {
            _appContext = appContext;
        }

        // CRUD
        // Obtiene todos los secretarios
        IEnumerable<SecretarioDespacho> IRepositorioSecretario.GetAll(Gobernacion gobernacion)
        {   
           /* IEnumerable<Oficina> oficinas = _appContext.oficinas.Where(x => x.gobernacion == gobernacion);
            IEnumerable<SecretarioDespacho> secretarios = oficinas.SecretarioDespacho;
            _appContext.secretarios.*/
            /*IEnumerable<SecretarioDespacho> secretariosGobernacion = _appContext.secretarios.GroupJoin(_appContext.oficinas, s => s.id,
            o => o.id, (s,o) => new {s,o}).Where();*/
            IEnumerable<SecretarioDespacho> secretariosEncontrados = (
                                                                        from s in _appContext.secretarios
                                                                        join o in _appContext.oficinas on s equals o.secretario
                                                                        join g in _appContext.gobernaciones on o.gobernacion equals g
                                                                        where o.gobernacion == gobernacion
                                                                        select new SecretarioDespacho{
                                                                            id = s.id,
                                                                            identificacion = s.identificacion,
                                                                            nombres = s.nombres,
                                                                            apellidos = s.apellidos,
                                                                            edad = s.edad,
                                                                            genero = s.genero,
                                                                            gobernacion = s.gobernacion
                                                                        }
                                                                    );

            foreach (var secretario in secretariosEncontrados)
            {
                Console.WriteLine(secretario.nombres);
            }
            return secretariosEncontrados;
        }

        IEnumerable<SecretarioDespacho> IRepositorioSecretario.GetAllSecretarioGobernacion(Gobernacion gobernacion)
        {
            IEnumerable<SecretarioDespacho> secretariosEncontrados = (
                                                                        from s in _appContext.secretarios
                                                                        join o in _appContext.oficinas on s equals o.secretario into seof
                                                                        from o in seof.DefaultIfEmpty()
                                                                        join g in _appContext.gobernaciones on s.gobernacion equals g
                                                                        where g.id == gobernacion.id & o.secretario == null
                                                                        select new SecretarioDespacho{
                                                                            id = s.id,
                                                                            identificacion = s.identificacion,
                                                                            nombres = s.nombres,
                                                                            apellidos = s.apellidos,
                                                                            edad = s.edad,
                                                                            genero = s.genero,
                                                                            gobernacion = s.gobernacion
                                                                        }
                                                                    );
            return secretariosEncontrados;
        }

        SecretarioDespacho IRepositorioSecretario.GetSecretarioOficina(Oficina oficina)
        {
            SecretarioDespacho secretario = (from s in _appContext.secretarios
                                                join o in _appContext.oficinas on s equals o.secretario
                                                where o.id == oficina.id
                                                select new SecretarioDespacho{
                                                    id = s.id,
                                                    identificacion = s.identificacion,
                                                    nombres = s.nombres,
                                                    apellidos = s.apellidos,
                                                    edad = s.edad,
                                                    genero = s.genero,
                                                    gobernacion = s.gobernacion
                                                }
                            ).FirstOrDefault();
            return secretario;
        }
        
        // Obtiene solo uno
        SecretarioDespacho IRepositorioSecretario.GetSecretario(int idSecretario)
        {
            var secretarioEncontrado = _appContext.secretarios.FirstOrDefault(s => s.id == idSecretario);
            return secretarioEncontrado;
        }

        // Guardar en la base de datos
        SecretarioDespacho IRepositorioSecretario.AddSecretario(SecretarioDespacho secretario)
        {
            var secretarioAdicionado = _appContext.secretarios.Add(secretario);
            _appContext.SaveChanges();
            return secretarioAdicionado.Entity;
        }
        // Actualizar
        SecretarioDespacho IRepositorioSecretario.UpdateSecretario(SecretarioDespacho secretario, Gobernacion gobernacion)
        {
            var secretarioEncontrado = _appContext.secretarios.SingleOrDefault(s => s.id == secretario.id);
            if (secretarioEncontrado != null)
            {   
                secretarioEncontrado.identificacion = secretario.identificacion;
                secretarioEncontrado.nombres = secretario.nombres;
                secretarioEncontrado.apellidos = secretario.apellidos;
                secretarioEncontrado.edad = secretario.edad;
                secretarioEncontrado.genero = secretario.genero;
                secretarioEncontrado.gobernacion = gobernacion;

                _appContext.SaveChanges();   
            }
            return secretario;
        }
        // ELiminar
        bool IRepositorioSecretario.DeleteSecretario(int idSecretario)
        {
            var secretarioEncontrado = _appContext.secretarios.FirstOrDefault(s => s.id == idSecretario);
            if (secretarioEncontrado == null)
                return false;
            _appContext.secretarios.Remove(secretarioEncontrado);
            _appContext.SaveChanges();
            return true;
        }
    }    
}