using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EJ5;

namespace TestingEJ5
{
    [TestClass]
    public class UnitTest1
    {
        private object ordNombre;

        [TestMethod]
        public void Agregar()
        {
            RepositorioUsuario repo = new RepositorioUsuario();
            Usuario us1= new Usuario();
            us1.Codigo = "abc123";
            us1.CorreoElectronico = "us1@gmail.com";
            us1.NombreCompleto = "usuario 1";

            Usuario us2= new Usuario();
            us2.Codigo = "aaa111";
            us2.CorreoElectronico = "us2@gmail.com";
            us2.NombreCompleto = "usuario 2";

            RepositorioUsuario resEsperado = new RepositorioUsuario();

            repo.Agregar(us1);
            repo.Agregar(us2);
            resEsperado.Agregar(us2);
            resEsperado.Agregar(us1);

            CollectionAssert.Equals(repo, resEsperado);
        }

        [TestMethod]
        public void Eliminar()
        {
            RepositorioUsuario repo = new RepositorioUsuario();
            Usuario us1 = new Usuario();
            us1.Codigo = "abc123";
            us1.CorreoElectronico = "us1@gmail.com";
            us1.NombreCompleto = "usuario 1";

            Usuario us2 = new Usuario();
            us2.Codigo = "aaa111";
            us2.CorreoElectronico = "us2@gmail.com";
            us2.NombreCompleto = "usuario 2";

            RepositorioUsuario resEsperado = new RepositorioUsuario();

            repo.Agregar(us1);
            repo.Agregar(us2);
            resEsperado.Agregar(us2);
            resEsperado.Agregar(us1);

            repo.Eliminar(us1);
            resEsperado.Eliminar(us1);

            CollectionAssert.Equals(repo, resEsperado);
        }

        [TestMethod]
        public void Actualizar()
        {
            RepositorioUsuario repo = new RepositorioUsuario();
            Usuario us1 = new Usuario();
            us1.Codigo = "abc123";
            us1.CorreoElectronico = "us1@gmail.com";
            us1.NombreCompleto = "usuario 1";

            Usuario us2 = new Usuario();
            us2.Codigo = "abc123";
            us2.CorreoElectronico = "us2@gmail.com";
            us2.NombreCompleto = "usuario 2";

            RepositorioUsuario resEsperado = new RepositorioUsuario();

            repo.Agregar(us1);
            resEsperado.Agregar(us2);
            repo.Actualizar(us2);


            CollectionAssert.Equals(repo, resEsperado);
        }

        [TestMethod]
        public void ObtenerTodos()
        {
            RepositorioUsuario repo = new RepositorioUsuario();
            Usuario us1 = new Usuario();
            us1.Codigo = "abc123";
            us1.CorreoElectronico = "us1@gmail.com";
            us1.NombreCompleto = "usuario 1";

            Usuario us2 = new Usuario();
            us2.Codigo = "aaa111";
            us2.CorreoElectronico = "us2@gmail.com";
            us2.NombreCompleto = "usuario 2";
            List<Usuario> resEsperado = new List<Usuario>();
            

            repo.Agregar(us1);
            repo.Agregar(us2);
            resEsperado.Add(us2);
            resEsperado.Add(us1);
            IList<Usuario> res = repo.ObtenerTodos();
            CollectionAssert.Equals(res, resEsperado);
        }


        [TestMethod]
        public void ObtenerPorCodigo()
        {
            RepositorioUsuario repo = new RepositorioUsuario();
            Usuario us1 = new Usuario();
            us1.Codigo = "abc123";
            us1.CorreoElectronico = "us1@gmail.com";
            us1.NombreCompleto = "usuario 1";

            repo.Agregar(us1);
            Usuario res = repo.ObtenerPorCodigo(us1.Codigo);
            Usuario resEsperado = us1;

            Assert.AreEqual(res.Codigo,resEsperado.Codigo);
            Assert.AreEqual(res.NombreCompleto, resEsperado.NombreCompleto);
            Assert.AreEqual(res.CorreoElectronico, resEsperado.CorreoElectronico);
        }

        [TestMethod]
        public void ObtenerComparadosPor()
        {
            RepositorioUsuario repo = new RepositorioUsuario();
            Usuario us1 = new Usuario();
            us1.Codigo = "aaa123";
            us1.CorreoElectronico = "us1@gmail.com";
            us1.NombreCompleto = "usuario 1";

            Usuario us2 = new Usuario();
            us2.Codigo = "bbb123";
            us2.CorreoElectronico = "aus2@gmail.com";
            us2.NombreCompleto = "usuario 2";

            Usuario us3 = new Usuario();
            us3.Codigo = "ccc123";
            us3.CorreoElectronico = "bus3@gmail.com";
            us3.NombreCompleto = "usuario 3";

            repo.Agregar(us1);
            repo.Agregar(us2);
            repo.Agregar(us3);
            OrdenarPorNombreAsc ordNombreA = new OrdenarPorNombreAsc();
            IList<Usuario> res = repo.ObtenerComparadosPor(ordNombreA);
            IList<Usuario> resEsperado = new List<Usuario>();
            resEsperado.Add(us3);
            resEsperado.Add(us2);
            resEsperado.Add(us1);

            CollectionAssert.Equals(res, resEsperado);

            OrdenarPorNombreDesc ordNombreD = new OrdenarPorNombreDesc();
            res = repo.ObtenerComparadosPor(ordNombreD);
            resEsperado = new List<Usuario>();
            resEsperado.Add(us1);
            resEsperado.Add(us2);
            resEsperado.Add(us3);

            CollectionAssert.Equals(res, resEsperado);

            OrdenarPorCorreo ordCorreo = new OrdenarPorCorreo();
            res = repo.ObtenerComparadosPor(ordCorreo);
            resEsperado = new List<Usuario>();
            resEsperado.Add(us2);
            resEsperado.Add(us3);
            resEsperado.Add(us1);

            CollectionAssert.Equals(res, resEsperado);
        }

    }
}
