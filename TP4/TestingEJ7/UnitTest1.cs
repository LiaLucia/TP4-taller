using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ7;

namespace TestingEJ7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(CalendarioVacioException))]
        public void listarEventos()
        {
            Calendario Calendario = new Calendario("miCalendario");
            Calendario.ListarEvento();
        }

        [TestMethod]
        [ExpectedException(typeof(CalendarioVacioException))]
        public void FiltrarEventosPorTitulo()
        {
            Calendario Calendario = new Calendario("miCalendario");
            Calendario.FiltrarPor("TituloEvento");
        }

        [TestMethod]
        [ExpectedException(typeof(CalendarioVacioException))]
        public void FiltrarEventosPorFecha()
        {
            Calendario Calendario = new Calendario("miCalendario");
            Calendario.FiltrarPor(new DateTime(2015,07,07), new DateTime(2016,11,11));
        }

        [TestMethod]
        [ExpectedException(typeof(AgendaVaciaException))]
        public void ListarCalendarios()
        {
            Agenda Agenda = new Agenda();
            Agenda.ListarCalendario();
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInicioInvalidaException))]
        public void AgregarEventoFInicio()
        {
            Calendario Calendario = new Calendario("miCalendario");
            Calendario.AgregarEvento("miEvento1", new DateTime(2016,07,07), new DateTime(2016,12,12), TipoFrecuencia.UnaPorAño);
            Calendario.AgregarEvento("miEvento2", new DateTime(2016, 12, 12), new DateTime(2016, 12, 11), TipoFrecuencia.UnaPorAño);

        }

        [TestMethod]
        [ExpectedException(typeof(FechaFinInvalidaException))]
        public void AgregarEventoFFin()
        {
            Calendario Calendario = new Calendario("miCalendario");
            Calendario.AgregarEvento("miEvento1", new DateTime(2016, 12, 11), new DateTime(2016, 10, 12), TipoFrecuencia.UnaPorAño);
        }

        
    }

}
